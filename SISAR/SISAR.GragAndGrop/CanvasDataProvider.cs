using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace SISAR.GragAndGrop
{
    public class CanvasDataProvider<TContainer, TObject> : DataProviderBase<TContainer, TObject>, IDataProvider
        where TContainer : Canvas
        where TObject : UIElement
    {

        public CanvasDataProvider(string dataFormatString) :
            base(dataFormatString)
        {
        }

        /// <summary>
        /// Return true so an addorner is added when an item is dragged
        /// </summary>
        public override bool AddAdorner { get { return true; } }

        public override DragDropEffects AllowedEffects
        {
            get
            {
                return
                    //DragDropEffects.Copy |
                    //DragDropEffects.Scroll |
                    DragDropEffects.Move |
                    DragDropEffects.Link |  // Indicates a ToolBar "insert"

                    DragDropEffects.None;
            }
        }

        public override DataProviderActions DataProviderActions
        {
            get
            {
                return
                    //DragDropDataProviderActions.QueryContinueDrag |
                    DataProviderActions.GiveFeedback |
                    //DragDropDataProviderActions.DoDragDrop_Done |

                    DataProviderActions.None;
            }
        }

        public override bool IsSupportedContainerAndObject(bool initFlag, object dragSourceContainer, object dragSourceObject, object dragOriginalSourceObject)
        {
            TObject sourceObject = dragSourceObject as TObject;
            // When an image button is clicked,
            // most of the time the image is the <code>e.Source</code>.
            // So when _SourceObject is null, search for a TObject parent.
            if (sourceObject == null)
            {
                // Image buttons can return the image as the source, so look for the button
                sourceObject = Utilities.FindParentControlExcludingMe<TObject>(dragSourceObject as DependencyObject);
            }

            if (initFlag)
            {
                // Init DataProvider variables
                this.Init();
                this.SourceContainer = dragSourceContainer;
                this.SourceObject = sourceObject;
                this.OriginalSourceObject = dragOriginalSourceObject;
            }

            return
                (dragSourceContainer is TContainer) &&
                (sourceObject != null)
                ;
        }

        /// <summary>
        /// Not only add the DataProvider class, also add a string
        /// </summary>
        public override void SetData(ref DataObject data)
        {
            // Set default data
            System.Diagnostics.Debug.Assert(data.GetDataPresent(this.SourceDataFormat) == false, "Shouldn't set data more than once");
            data.SetData(this.SourceDataFormat, this);

            // Look for a System.String
            string textString = null;

            if (this.SourceObject is Image)
            {
                Image ima = (Image)this.SourceObject;
                if (ima.Source != null)
                    textString = ima.Source.ToString();
            }

            if (textString != null)
                data.SetData(textString);
        }

        public override void DragSource_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (e.Effects == DragDropEffects.Move)
            {
                e.UseDefaultCursors = true;
                e.Handled = true;
            }
        }

        public override void Unparent()
        {
            TObject item = this.SourceObject as TObject;
            TContainer panel = this.SourceContainer as TContainer;

            Debug.Assert(item != null, "Unparent expects a non-null item");
            Debug.Assert(panel != null, "Unparent expects a non-null panel");

            if ((panel != null) && (item != null))
                if (!string.IsNullOrEmpty(panel.Name))
                    panel.Children.Remove(item);

        }
    }

}
