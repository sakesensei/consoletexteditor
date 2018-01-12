using System;

namespace consoletexteditor
{
	public static class Clear
	{
		public static void All(char c)
		{
			int _width = Console.LargestWindowWidth;
			int _height = Console.LargestWindowHeight;

			for (int j = 0; j < _height; j++)
			{
				for (int i = 0; i < _width; i++)
				{
					Console.SetCursorPosition(i, j);
					Console.Write(c);
				}
			}

		}
	}
}

