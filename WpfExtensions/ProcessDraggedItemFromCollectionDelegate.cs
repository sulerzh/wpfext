using System.Windows;

namespace Semantic.WpfExtensions
{
  public delegate int ProcessDraggedItemFromCollectionDelegate<T>(T item, DragDropEffects effects);
}
