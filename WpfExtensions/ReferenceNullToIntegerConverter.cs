using System.Windows.Data;

namespace Semantic.WpfExtensions
{
  [ValueConversion(typeof (object), typeof (int))]
  public class ReferenceNullToIntegerConverter : ReferenceNullToValueConverter<int>
  {
  }
}
