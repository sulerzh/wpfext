namespace Semantic.WpfCommon
{
  public interface IUndoManager
  {
    void Undo();

    void Redo();

    void Push(UndoItem item);

    void ResetRedo();
  }
}
