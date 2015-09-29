using System.Windows;

namespace Semantic.WpfExtensions
{
    public interface IDragItemHandler : IDragHandler
    {
        void ProcessDraggedItem(object item, DragDropEffects effects);
    }

    public interface IDragItemHandler<T> : IDragItemHandler, IDragHandler
    {
        void ProcessDraggedItem(T item, DragDropEffects effects);
    }
}
