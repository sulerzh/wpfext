using System.Windows;
using System.Windows.Data;

namespace Semantic.WpfExtensions
{
  [ValueConversion(typeof (object), typeof (Visibility))]
  public class ReferenceNullToVisibilityConverter : ReferenceNullToValueConverter<Visibility>
  {
  }
}
