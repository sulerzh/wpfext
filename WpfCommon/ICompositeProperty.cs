using System.ComponentModel;

namespace Semantic.WpfCommon
{
  public interface ICompositeProperty : INotifyPropertyChanged, INotifyPropertyChanging, IDescendentPropertyChanged, IDescendentPropertyChanging
  {
  }
}
