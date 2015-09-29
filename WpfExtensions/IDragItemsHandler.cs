using System.Windows;

namespace Semantic.WpfExtensions
{
    public interface IDragItemsHandler : IDragHandler
    {
        int ProcessDraggedItem(object item, DragDropEffects effects);
    }

    public interface IDragItemsHandler<T> : IDragItemsHandler, IDragHandler
    {
        int ProcessDraggedItem(T item, DragDropEffects effects);
    }
}
