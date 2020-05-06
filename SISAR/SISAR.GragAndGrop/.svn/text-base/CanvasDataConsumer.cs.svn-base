using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace SISAR.GragAndGrop
{
    public class CanvasDataConsumer<TContainer, TObject> : DataConsumerBase, IDataConsumer
        where TContainer : Canvas
        where TObject : UIElement
    {

        public CanvasDataConsumer(string[] dataFormats)
            : base(dataFormats)
        {
        }

        public override DataConsumerActions DataConsumerActions
        {
            get
            {
                return
                    DataConsumerActions.DragEnter |
                    DataConsumerActions.DragOver |
                    DataConsumerActions.Drop |
                    //DragDropDataConsumerActions.DragLeave |

                    DataConsumerActions.None;
            }
        }

        public override void DropTarget_DragEnter(object sender, DragEventArgs e)
        {
            this.DragOverOrDrop(false, sender, e);
        }

        public override void DropTarget_DragOver(object sender, DragEventArgs e)
        {
            this.DragOverOrDrop(false, sender, e);
        }

        public override void DropTarget_Drop(object sender, DragEventArgs e)
        {
            this.DragOverOrDrop(true, sender, e);
        }

        /// <summary>
        /// First determine whether the drag data is supported.
        /// Second determine what operation to do (copy, move, link).
        /// And finally handle the actual drop when <code>bDrop</code> is true.
        /// </summary>
        /// <param name="bDrop">True to perform an actual drop, otherwise just return e.Effects</param>
        /// <param name="sender">DragDrop event <code>sender</code></param>
        /// <param name="e">DragDrop event arguments</param>
        private void DragOverOrDrop(bool bDrop, object sender, DragEventArgs e)
        {
            CanvasDataProvider<TContainer, TObject> dataProvider = this.GetData(e) as CanvasDataProvider<TContainer, TObject>;
            if (dataProvider != null)
            {
                TObject dragSourceObject = dataProvider.SourceObject as TObject;
                Debug.Assert(dragSourceObject != null);
                TContainer dropContainer = sender as TContainer;


                if (dropContainer != null)
                {
                    if (bDrop)
                    {
                        //dataProvider.Unparent();
                        Image nuevo = new Image();
                        nuevo.Source = (dragSourceObject as Image).Source;
                        nuevo.Width = (dragSourceObject as Image).Width;
                        nuevo.Height = (dragSourceObject as Image).Height;
                        nuevo.Name = (dragSourceObject as Image).Name;
                        //dragSourceObject = nuevo as TObject;
                        if (!(dropContainer.Name=="canvas"))
                        {
                            //dropContainer.Children.Add(dragSourceObject);
                            if (dropContainer.Name == "trash")
                                dataProvider.Unparent();
                            else
                            {
                                dropContainer.Children.Add(nuevo);
                                Point dropPosition = e.GetPosition(dropContainer);
                                Point objectOrigin = dataProvider.StartPosition;
                                //Canvas.SetLeft(dragSourceObject, dropPosition.X - objectOrigin.X);
                                //Canvas.SetTop(dragSourceObject, dropPosition.Y - objectOrigin.Y);
                                Canvas.SetLeft(nuevo, dropPosition.X - objectOrigin.X);
                                Canvas.SetTop(nuevo, dropPosition.Y - objectOrigin.Y);
                                if (IsCorrect(dragSourceObject as Image, nuevo, dropContainer as Canvas)) 
                                        dropContainer.Children.Remove(dragSourceObject);
                                else
                                    dropContainer.Children.Remove(nuevo);
                            }
                        }

                    }
                    e.Effects = DragDropEffects.Move;
                    e.Handled = true;
                }
                else
                {
                    e.Effects = DragDropEffects.None;
                    e.Handled = true;
                }
            }
        }
        internal bool IsCorrect(Image antiguo, Image nuevo, Canvas panel)
        {
            foreach (UIElement elem in panel.Children)
                if (elem is Image)
                    if ((nuevo != elem) && (antiguo != elem))
                        if (Chocan(nuevo, elem as Image))
                            return false;
                        else
                            if (Chocan(elem as Image, nuevo))
                                return false;
            return true;
        }

        private bool Chocan(Image item, Image elem)
        {
            Point pointElem = new Point(Canvas.GetLeft(elem), Canvas.GetTop(elem));
            Point nuevo = new Point(Canvas.GetLeft(item), Canvas.GetTop(item));

            if ((pointElem.X == nuevo.X) && (pointElem.Y == nuevo.Y))
                return true;
            if (isOut(nuevo, elem, pointElem))
                if (isOut(new Point(nuevo.X + item.Width, nuevo.Y), elem, pointElem))
                    if (isOut(new Point(nuevo.X, nuevo.Y + item.Height), elem, pointElem))
                        if (isOut(new Point(nuevo.X + item.Width, nuevo.Y + item.Height), elem, pointElem))
                            return false;
            return true;
        }

        private bool isOut(Point item, Image rec, Point pointElem)
        {
            if (item.X > pointElem.X && item.X < pointElem.X + rec.Width)
                if (item.Y > pointElem.Y && item.Y < pointElem.Y + rec.Height)
                    return false;
            return true;
        }
    }
}
