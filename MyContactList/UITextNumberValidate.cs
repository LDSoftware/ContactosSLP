using System;
using UIKit;

namespace MyContactList
{
	public class UITextNumberValidate : UITextFieldDelegate
	{
		public UITextNumberValidate()
		{
		}

		public override bool ShouldChangeCharacters(UITextField textField, Foundation.NSRange range, string replacementString)
		{
			return NumberValidator.ValidateNumbers(replacementString, NumberValidator.ValidationType.Numbers);
		}
	}
}
