using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Restboy.Core
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged<T>(Expression<Func<T>> property)
		{
			var propertyInfo = ((MemberExpression)property.Body).Member as PropertyInfo;
			if (propertyInfo == null)
			{
				throw new ArgumentNullException(nameof(property), "Argument is not a valid Property");
			}
			OnPropertyChanged(propertyInfo.Name);
		}

		protected void OnPropertyChanged([CallerMemberName]string propertyName = "")
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
