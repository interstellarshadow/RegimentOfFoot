using System;
using Xwt;

namespace RegimentOfFoot.Game
{
	public class Application
	{
		static void Main()
		{
			Xwt.Application.Initialize();
			var mainWindow = new GameMainWindow()
			{
				Title = "Xwt Demo Application",
				Width = 500,
				Height = 400
			};
			//mainWindow.
			mainWindow.Show();
			Xwt.Application.Run();
			mainWindow.Dispose();
			Xwt.Application.Exit();
			return;
		}
	}
}

