using Semantic.WpfCommon;
using System.ComponentModel;

namespace Semantic.WpfExtensions
{
  public interface IViewModel : ICompositeProperty, INotifyPropertyChanged, INotifyPropertyChanging, IDescendentPropertyChanged, IDescendentPropertyChanging, IValidationElement
  {
  }
}
