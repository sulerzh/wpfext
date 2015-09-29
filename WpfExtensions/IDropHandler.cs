namespace Semantic.WpfExtensions
{
  public interface IDropHandler
  {
    bool CanDropItem(object item);

    string ValidateDropItem(object item);

    void AddDroppableType<T>(ValidateDropItemDelegate<T> validationCallback);
  }
}
