using System;

namespace Semantic.WpfExtensions
{
  public interface IDropItemHandler : IDropHandler
  {
    void DropItem(object item);

    void AddDroppableTypeOnDrop<T>(Action<T> onDropCallback);

    void AddDroppableTypeHandlers<T>(Action<T> onDropCallback, ValidateDropItemDelegate<T> validateCallback);
  }
}
