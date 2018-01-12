using System;

namespace Editor
{
	public class Page
	{
		// Page number
		private int count;

		public int Count
		{
			get { return count; }
			set { count = value; }
		}

		// Actual lines of text
		private string[] line;

		public string[] Line
		{
			get { return line; }
			set { line = value; }

		}

		// Constructor
		public Page(int number)
		{
			Line = new string[Init.WIDTH - 1];
			Count = number;
		}
	}
}

