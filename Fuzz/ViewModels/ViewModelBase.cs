using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq.Expressions;

namespace Fuzz.ViewModels
{
    public abstract class ViewModelBase<TDerivedViewModel> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged<TProperty>(Expression<Func<TDerivedViewModel, TProperty>> property)
        {
            MemberExpression me = property.Body as MemberExpression;
            if (me == null || me.Expression != property.Parameters[0] || me.Member.MemberType != MemberTypes.Property)
            {
                throw new InvalidOperationException("Now tell me about the property");
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(me.Member.Name));
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
