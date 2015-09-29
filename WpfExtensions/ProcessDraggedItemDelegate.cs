using System.Windows;

namespace Semantic.WpfExtensions
{
  public delegate void ProcessDraggedItemDelegate<T>(T item, DragDropEffects effects);
}
