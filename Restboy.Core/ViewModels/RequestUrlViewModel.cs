using System;
namespace Restboy.Core
{
	public class RequestUrlViewModel : BaseViewModel
	{
		private string _url;
		public string Url
		{
			get
			{
				return _url;
			}
			set
			{
				_url = value;
				OnPropertyChanged();
			}
		}
	}
}
