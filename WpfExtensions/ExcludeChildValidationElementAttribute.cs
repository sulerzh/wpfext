using Semantic.WpfCommon;

namespace Semantic.WpfExtensions
{
  public sealed class ExcludeChildValidationElementAttribute : PropertyValidationAttribute
  {
    public ExcludeChildValidationElementAttribute()
      : base((ITypeChecker) new TypeChecker<IValidationElement>())
    {
    }

    protected override bool ValidateInternal(object toValidate, object context)
    {
      return true;
    }
  }
}
