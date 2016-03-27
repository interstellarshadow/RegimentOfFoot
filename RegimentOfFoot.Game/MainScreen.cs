using System;
using Xwt;
using Xwt.Drawing;
using System.Security.Cryptography;

namespace RegimentOfFoot.Game
{
    public class MainScreen : Frame
    {
        #region Private Component Fields

        private Button startGameButton = new Button()
        {
            Label = "Start New Game"
        };
        private Button continueGameButton = new Button()
        {
            Label = "Continue"
        };
        private Button loadGameButton = new Button()
        {
            Label = "Load Game"
        };
        private Button characterPoolButton = new Button()
        {
            Label = "Character Pool"
        };
        private Button settingsButton = new Button()
        {
            Label = "Settings"
        };
        private Button exitButton = new Button()
        {
            Label = "Exit",
            BackgroundColor = Colors.SkyBlue
        };

        private VBox container = new VBox()
        {
            HorizontalPlacement = WidgetPlacement.Center,
            VerticalPlacement = WidgetPlacement.Center
        };

        #endregion

        public MainScreen()
            : base()
        {
            Xwt.Application.Invoke(InitializeComponents);
        }

        private void InitializeComponents()
        {
            HeightRequest = 300;
            WidthRequest = 400;
            Content = container;
            container.PackEnd(exitButton);
            container.PackEnd(characterPoolButton);
            container.PackEnd(settingsButton);
            container.PackEnd(loadGameButton);
            container.PackEnd(startGameButton);

            exitButton.ButtonPressed += ExitPressed;
            characterPoolButton.ButtonPressed += CharacterPoolButton_ButtonPressed;
            settingsButton.ButtonPressed += SettingsButton_ButtonPressed;
            startGameButton.ButtonPressed += StartGameButton_ButtonPressed;


            if (false) //If a game is ready to continue
            {
                container.PackStart(continueGameButton);
            }

        }

        void StartGameButton_ButtonPressed(object sender, ButtonEventArgs e)
        {
            NewGameScreen screen = new NewGameScreen();
            FrameSwitcher.SwitchFrame(screen.GetType().ToString(), screen);
        }

        void CharacterPoolButton_ButtonPressed(object sender, ButtonEventArgs e)
        {
            CharacterPoolScreen screen = new CharacterPoolScreen();
            FrameSwitcher.SwitchFrame(screen.GetType().ToString(), screen);
        }

        void SettingsButton_ButtonPressed(object sender, ButtonEventArgs e)
        {
            SettingsScreen screen = new SettingsScreen();
            FrameSwitcher.SwitchFrame(screen.GetType().ToString(), screen);
        }

        void ExitPressed(object sender, ButtonEventArgs e)
        {
            FrameSwitcher.Window.Close();
        }
    }
}

