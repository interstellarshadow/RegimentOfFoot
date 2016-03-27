using System;
using Xwt;
using System.Collections;

namespace RegimentOfFoot.Game
{
    public class NewGameScreen : Frame
    {
        #region GUI Controls

        private Button characterCreationButton = new Button()
        {
            Label = "Create/Select Character"
            //ButtonPressed = CharacterCreationButtonPressed
        };
        private Button gameOptionsButton = new Button()
        {
            Label = "Game Options"
            //ButtonPressed = GameOptionsPressed
        };
        private Button backButton = new Button()
        {
            Label = "Back"
            //ButtonPressed = BackButtonPressed
        };
        private Button nextButton = new Button()
        {
            Label = "Next"
        };
        private TextEntry gameNameBox = new TextEntry()
        {
            Text = "New Game"
        };

        private VBox stack = new VBox()
        {
            HorizontalPlacement = WidgetPlacement.Center,
            VerticalPlacement = WidgetPlacement.Center
        };
        
        private HBox backNextArea = new HBox();

        #endregion

        public NewGameScreen()
        {
            InitializeComponents();
        }

        void InitializeComponents()
        {
            characterCreationButton.ButtonPressed += CharacterCreationButtonPressed;
            gameOptionsButton.ButtonPressed += GameOptionsPressed;
            backButton.ButtonPressed += BackButtonPressed;

            backNextArea.PackStart(backButton);
            backNextArea.PackStart(nextButton);
            backNextArea.ExpandHorizontal = true;

            stack.PackEnd(backNextArea);
            stack.PackEnd(gameOptionsButton);
            stack.PackEnd(characterCreationButton);
            stack.PackEnd(gameNameBox);
            Content = stack;
        }

        void GameOptionsPressed(object sender, ButtonEventArgs e)
        {
            var gameOptionsScreen = new GameOptionsScreen();
            FrameSwitcher.SwitchFrame("GameOptionsScreen", gameOptionsScreen);
        }

        void CharacterCreationButtonPressed(object sender, ButtonEventArgs e)
        {
            var characterCreationScreen = new CharacterCreationScreen();
            FrameSwitcher.SwitchFrame("CharacterCreationScreen",
                characterCreationScreen);
        }

        void BackButtonPressed(object sender, ButtonEventArgs e)
        {
            FrameSwitcher.GoBack(1);
        }
    }
}

