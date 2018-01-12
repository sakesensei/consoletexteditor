using System;

namespace Editor
{
	public static class Init
	{
		public const int WIDTH = 100;
		public const int HEIGHT = 32;

		public static void Display()
		{
			Console.SetWindowSize(WIDTH, HEIGHT);
		}
	}
}

