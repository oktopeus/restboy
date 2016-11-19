using System;
namespace Restboy.Core
{
	public class TextParameterViewModel : BaseViewModel
	{
		private string _text;
		public string Text
		{
			get
			{
				return _text;
			}
			set
			{
				if (!Validate(value))
				{
					return;
				}
				_text = value;
				OnPropertyChanged();
			}
		}

		protected virtual bool Validate(string value)
		{
			return true;
		}
	}
}
