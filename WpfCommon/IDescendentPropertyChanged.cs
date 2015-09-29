using System.ComponentModel;

namespace Semantic.WpfCommon
{
  public interface IDescendentPropertyChanged
  {
    event PropertyChangedEventHandler DescendentPropertyChanged;
  }
}
