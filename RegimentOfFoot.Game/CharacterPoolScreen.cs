using System;
using Xwt;

namespace RegimentOfFoot.Game
{
    public class CharacterPoolScreen : Frame
    {
        private HPaned pane = new HPaned()
        {
            
        };
        private VBox leftChild = new VBox();
        private VBox rightContainer = new VBox()
        {
            VerticalPlacement = WidgetPlacement.End 
        };
        private ScrollView leftContainer = new ScrollView();
        private Button backButton = new Button("Back");

        public CharacterPoolScreen()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Content = pane;
            leftContainer.Content = leftChild;
            pane.Panel1.Content = leftContainer;
            pane.Panel2.Content = rightContainer;
            rightContainer.PackEnd(backButton);
            leftChild.PackEnd(new Label("Character Pool Not Supported Yet"));
            backButton.ButtonPressed += BackButton_ButtonPressed;
            pane.Position = 200;
        }

        void BackButton_ButtonPressed(object sender, ButtonEventArgs e)
        {
            FrameSwitcher.GoBack(1);
        }
    }
}