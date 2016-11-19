using System;
namespace Restboy.Core
{
	public class KeyTextParameterViewModel : TextParameterViewModel
	{
		protected override bool Validate(string value)
		{
			return !string.IsNullOrWhiteSpace(value) && base.Validate(value);
		}
	}
}
