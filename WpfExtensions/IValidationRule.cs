namespace Semantic.WpfExtensions
{
  public interface IValidationRule
  {
    bool IsValid(object param, object context);
  }
}
