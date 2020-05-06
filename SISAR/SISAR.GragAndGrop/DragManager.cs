using System;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace SISAR.GragAndGrop
{
    public class DragManager
    {
        private UIElement _dragSource;
        private IDataProvider[] _dragDropObjects;

        private IDataProvider _dragDropObject;
        private Point _startPosition;
        private bool _dragInProgress;

        /// <summary>
        /// Manage dragging data object from <code>dragSource</code> FrameworkElement.
        /// Hook various PreviewMouse* events in order to determine when a drag starts.
        /// </summary>
        /// <param name="dragSource">The FrameworkElement which contains objects to be dragged</param>
        /// <param name="dragDropObject">Object to be dragged, implementing IDataProvider</param>
        public DragManager(FrameworkElement dragSource, IDataProvider dragDropObject)
            : this(dragSource, new IDataProvider[] { dragDropObject })
        {
        }

        /// <summary>
        /// Manage dragging data object from <code>dragSource</code> FrameworkElement.
        /// Hook various PreviewMouse* events in order to determine when a drag starts.
        /// </summary>
        /// <param name="dragSource">The FrameworkElement which contains objects to be dragged</param>
        /// <param name="dragDropObjects">Array of objects to be dragged, implementing IDataProvider</param>
        public DragManager(FrameworkElement dragSource, IDataProvider[] dragDropObjects)
        {
            this._dragSource = dragSource;
            Debug.Assert(dragSource != null, "dragSource cannot be null");
            this._dragDropObjects = dragDropObjects;

            this._dragSource.PreviewMouseLeftButtonDown += new MouseButtonEventHandler(DragSource_PreviewMouseLeftButtonDown);
            this._dragSource.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(DragSource_PreviewMouseMove);
            this._dragSource.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(DragSource_PreviewMouseLeftButtonUp);
        }

        /// <summary>
        /// Check for a supported SourceContainer/SourceObject.
        /// If found, get ready for a possible drag operation.
        /// </summary>
        private void DragSource_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            foreach (IDataProvider dragDropObject in this._dragDropObjects)
            {
                if (dragDropObject.IsSupportedContainerAndObject(true, sender, e.Source, e.OriginalSource))
                {
                    Debug.Assert(sender.Equals(this._dragSource));

                    this._dragDropObject = dragDropObject;

                    this._startPosition = e.GetPosition(sender as IInputElement);

                    this._dragDropObject.StartPosition = e.GetPosition(e.Source as IInputElement);

                    if (this._dragDropObject.NeedsCaptureMouse)
                        this._dragSource.CaptureMouse();

                    break;
                }
            }
        }

        /// <summary>
        /// If the mouse is moved (dragged) a minimum distance
        /// over a supported SourceContainer/SourceObject,
        /// initiate a drag operation.
        /// </summary>
        private void DragSource_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if ((this._dragDropObject != null) && !this._dragInProgress && this._dragDropObject.IsSupportedContainerAndObject(false, sender, e.Source, e.OriginalSource))
            {
                Point currentPosition = e.GetPosition(sender as IInputElement);
                if (((Math.Abs(currentPosition.X - this._startPosition.X) > SystemParameters.MinimumHorizontalDragDistance) ||
                    (Math.Abs(currentPosition.Y - this._startPosition.Y) > SystemParameters.MinimumVerticalDragDistance)))
                {

                    // NOTE:
                    //      While dragging a ListBoxItem, another one can be selected
                    //      This doesn't seem to happen with TreeView or TabControl
                    if (sender is ListBox)
                        this._dragDropObject.SourceObject = e.Source;

                    this._dragInProgress = true;

                    if (this._dragDropObject.AddAdorner)
                    {
                        this._dragDropObject.DragAdorner = new DefaultAdorner(
                            (UIElement)Application.Current.MainWindow.Content,
                            (UIElement)this._dragDropObject.SourceObject,
                            this._dragDropObject.StartPosition);
                        System.Windows.Media.Visual visual = Application.Current.MainWindow.Content as Visual;
                        AdornerLayer.GetAdornerLayer(visual).Add(this._dragDropObject.DragAdorner);
                    }

                    DragDropEffects resultEffects = DoDragDrop_Start(e);

                    if (this._dragDropObject.NeedsCaptureMouse)
                        this._dragSource.ReleaseMouseCapture();

                    this.DoDragDrop_Done(resultEffects);

                    if (this._dragDropObject.AddAdorner)
                    {
                        AdornerLayer.GetAdornerLayer((Visual)Application.Current.MainWindow.Content).Remove(this._dragDropObject.DragAdorner);
                    }

                    Mouse.OverrideCursor = null;

                    this._dragDropObject = null;
                    this._dragInProgress = false;
                }
            }
        }

        /// <summary>
        /// When MouseLeftButtonUp event occurs, abandon
        /// any drag operation that may be in progress
        /// </summary>
        private void DragSource_PreviewMouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this._dragDropObject != null)
            {
                if (this._dragDropObject.NeedsCaptureMouse)
                    this._dragSource.ReleaseMouseCapture();
                this._dragDropObject = null;
                this._dragInProgress = false;
            }
        }

        /// <summary>
        /// Gather keyboard key state information
        /// and optionally abort a drag operation
        /// </summary>
        private void DragSource_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
#if PRINT2BUFFER
            //Epsilower//((Window1)Application.Current.MainWindow).buf0.Append('q');
#endif

            if ((this._dragDropObject.DataProviderActions & DataProviderActions.QueryContinueDrag) != 0)
                this._dragDropObject.DragSource_QueryContinueDrag(sender, e);

#if PRINT2OUTPUT
            Debug.WriteLine(
                "q handled=" + e.Handled.ToString()
                + " action=" + e.Action.ToString()
                + " sender=" + sender.GetType().ToString()
                + " Source=" + e.Source.GetType().ToString()
                + " OriginalSource=" + e.OriginalSource.GetType().ToString()
                + " KeyStates=" + e.KeyStates.ToString()
                );
#endif

#if PRINT2BUFFER
            //Epsilower//((Window1)Application.Current.MainWindow).buf1.Append('q');
#endif
        }

        /// <summary>
        /// Display the appropriate drag cursor based on
        /// DragDropEffects returned within the DropManager
        /// </summary>
        private void DragSource_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
#if PRINT2BUFFER
            //Epsilower//((Window1)Application.Current.MainWindow).buf0.Append('g');
#endif

            if (this._dragDropObject.AddAdorner)
            {
                Point point = Utilities.Win32GetCursorPos();
                DefaultAdorner dragAdorner = this._dragDropObject.DragAdorner;
                dragAdorner.SetMousePosition(dragAdorner.AdornedElement.PointFromScreen(point));
            }

            if ((this._dragDropObject.DataProviderActions & DataProviderActions.GiveFeedback) != 0)
                this._dragDropObject.DragSource_GiveFeedback(sender, e);

#if PRINT2OUTPUT
            Debug.WriteLine(
                "g handled=" + e.Handled.ToString()
                + " sender=" + sender.GetType().ToString()
                + " Source=" + e.Source.GetType().ToString()
                + " OriginalSource=" + e.OriginalSource.GetType().ToString()
                + " Effects=" + e.Effects.ToString()
                );
#endif

#if PRINT2BUFFER
            //Epsilower//((Window1)Application.Current.MainWindow).buf1.Append('g');
#endif
        }

        /// <summary>
        /// Prepare for and begin a drag operation.
        /// Hook the events needed by the data provider.
        /// </summary>
        private DragDropEffects DoDragDrop_Start(MouseEventArgs e)
        {
            DragDropEffects resultEffects = DragDropEffects.None;

            DataObject data = new DataObject();
            this._dragDropObject.SetData(ref data);

            bool hookQueryContinueDrag = false;
            bool hookGiveFeedback = false;

            if ((this._dragDropObject.DataProviderActions & DataProviderActions.QueryContinueDrag) != 0)
                hookQueryContinueDrag = true;

            if ((this._dragDropObject.DataProviderActions & DataProviderActions.GiveFeedback) != 0)
                hookGiveFeedback = true;

            if (this._dragDropObject.AddAdorner)
                hookGiveFeedback = true;

            QueryContinueDragEventHandler queryContinueDrag = null;
            GiveFeedbackEventHandler giveFeedback = null;

            if (hookQueryContinueDrag)
            {
                queryContinueDrag = new QueryContinueDragEventHandler(DragSource_QueryContinueDrag);
                this._dragSource.QueryContinueDrag += queryContinueDrag;
            }
            if (hookGiveFeedback)
            {
                giveFeedback = new GiveFeedbackEventHandler(DragSource_GiveFeedback);
                this._dragSource.GiveFeedback += giveFeedback;
            }

            try
            {
                // NOTE:  Set 'dragSource' to desired value (dragSource or item being dragged)
                //		  'dragSource' is passed to QueryContinueDrag as Source and OriginalSource
                DependencyObject dragSource;
                dragSource = this._dragSource;
                //dragSource = this._dragDropObject.Item;
                resultEffects = DragDrop.DoDragDrop(dragSource, data, this._dragDropObject.AllowedEffects);
            }
            catch
            {
                Debug.WriteLine("DragDrop.DoDragDrop threw an exception");
            }

            if (queryContinueDrag != null)
                this._dragSource.QueryContinueDrag -= queryContinueDrag;
            if (giveFeedback != null)
                this._dragSource.GiveFeedback -= giveFeedback;

            return resultEffects;
        }

        /// <summary>
        /// Called after DragDrop.DoDragDrop() returns.
        /// Typically during a file move, for example, the file is deleted here.
        /// However, when moving a TabItem from one TabControl to another the
        /// source TabItem must be unparented from the source TabControl
        /// before it can be added to the destination TabControl.
        /// So most of the time when moving items between item controls,
        /// this method isn't used.
        /// </summary>
        /// <param name="resultEffects">The drop operation that was performed</param>
        private void DoDragDrop_Done(DragDropEffects resultEffects)
        {
            if ((this._dragDropObject.DataProviderActions & DataProviderActions.DoDragDrop_Done) != 0)
                this._dragDropObject.DoDragDrop_Done(resultEffects);

#if PRINT2BUFFER
            //Epsilower//Debug.WriteLine("buf0: " + ((Window1)Application.Current.MainWindow).buf0.ToString());
            //Epsilower//Debug.WriteLine("buf1: " + ((Window1)Application.Current.MainWindow).buf1.ToString());
            //Epsilower// bool buffersSame = (((Window1)Application.Current.MainWindow).buf0.ToString().CompareTo(((Window1)Application.Current.MainWindow).buf1.ToString()) == 0);
            //Epsilower//if(buffersSame)
            //Epsilower//    Debug.WriteLine("buf0 and buf1 are the same");
            //Epsilower//Debug.Assert(buffersSame, "Possible reentrancy issue(s) -- make sure event code is short");
            //Epsilower//((Window1)Application.Current.MainWindow).buf0 = new StringBuilder("");
            //Epsilower//((Window1)Application.Current.MainWindow).buf1 = new StringBuilder("");
#endif
        }
    }

    [Flags]
    public enum DataProviderActions
    {
        QueryContinueDrag = 0x01,   // Call IDataProvider.DragSource_QueryContinueDrag
        GiveFeedback = 0x02,   // Call IDataProvider.DragSource_GiveFeedback
        DoDragDrop_Done = 0x04,   // Call IDataProvider.DoDragDrop_Done

        None = 0x00,
    }
}
