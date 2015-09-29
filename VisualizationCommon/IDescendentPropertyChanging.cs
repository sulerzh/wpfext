using System.ComponentModel;

namespace Semantic.WpfCommon
{
  public interface IDescendentPropertyChanging
  {
    event PropertyChangingEventHandler DescendentPropertyChanging;
  }
}
