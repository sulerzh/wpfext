using System.Windows.Data;

namespace Semantic.WpfExtensions
{
  [ValueConversion(typeof (object), typeof (bool))]
  public class ReferenceNullToBooleanConverter : ReferenceNullToValueConverter<bool>
  {
  }
}
