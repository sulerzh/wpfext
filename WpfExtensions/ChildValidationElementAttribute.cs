using Semantic.WpfCommon;

namespace Semantic.WpfExtensions
{
  public class ChildValidationElementAttribute : PropertyValidationAttribute
  {
    public ChildValidationElementAttribute()
      : base((ITypeChecker) new TypeChecker<IValidationElement>())
    {
    }

    protected override bool ValidateInternal(object toValidate, object context)
    {
      IValidationElement validationElement = toValidate as IValidationElement;
      if (validationElement != null)
        return validationElement.IsContentValid();
      else
        return true;
    }
  }
}
