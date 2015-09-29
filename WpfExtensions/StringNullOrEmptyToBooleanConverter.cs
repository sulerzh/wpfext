using System.Windows.Data;

namespace Semantic.WpfExtensions
{
  [ValueConversion(typeof (object), typeof (bool))]
  public class StringNullOrEmptyToBooleanConverter : StringNullOrEmptyToValueConverter<bool>
  {
  }
}
