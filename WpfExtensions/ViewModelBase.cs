using Semantic.WpfCommon;
using System.ComponentModel;
using System.Reflection;

namespace Semantic.WpfExtensions
{
    public abstract class ViewModelBase : ValidationElement, IViewModel, ICompositeProperty, INotifyPropertyChanged, INotifyPropertyChanging, IDescendentPropertyChanged, IDescendentPropertyChanging, IValidationElement
    {
        protected void ReValidate()
        {
            foreach (MemberInfo memberInfo in this.ValidationEntries.Keys)
                this.RaisePropertyChanged(memberInfo.Name);
        }

        protected bool SetProperty<T>(string propertyName, ref T property, T newValue, bool reValidate = false)
        {
            bool flag = base.SetProperty<T>(propertyName, ref property, newValue);
            if (!flag)
                return flag;
            if (reValidate)
                this.ReValidate();
            return true;
        }
    }
}
