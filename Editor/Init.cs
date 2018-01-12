using System;

namespace Editor
{
	public static class Init
	{
		public const int WIDTH = 24;
		public const int HEIGHT = 80;

		public static void Display()
		{
			Console.SetWindowSize(WIDTH, HEIGHT);
		}
	}
}

