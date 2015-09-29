namespace Semantic.WpfExtensions
{
  public interface IPropertyValidationAttribute : IResourceString, IValidationRule
  {
    string Condition { get; set; }

    string ErrorMessage { get; }

    bool IsConditionMet(object instance);
  }
}
