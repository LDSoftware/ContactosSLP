using System;
using System.Linq;

namespace MyContactList
{
	public class NumberValidator
	{
		public enum ValidationType
		{
			Letters = 1,
			Numbers = 2
		}

		const string _letters = "abcdefghijklmnopqrstvwxyz";
		const string _numbers = "0123456789";


		public static bool ValidateNumbers(string text, ValidationType validationType)
		{
			bool result = false;

			switch (validationType)
			{
				case ValidationType.Letters:
					result = text.ToLower().All(c => _letters.Contains(c));
				break;
				case ValidationType.Numbers:
					result = text.ToLower().All(c => _numbers.Contains(c));
					break;
				default:
					break;
			}

			return result;
		}



	}
}
