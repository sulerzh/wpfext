namespace Semantic.WpfExtensions
{
  public class InvertBoolConverter : BoolToValueConverter<bool>
  {
    public InvertBoolConverter()
    {
      this.TrueValue = false;
      this.FalseValue = true;
    }
  }
}
