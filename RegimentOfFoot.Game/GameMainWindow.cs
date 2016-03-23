using System;
using Xwt;

namespace RegimentOfFoot.Game
{
    public class GameMainWindow : Window
    {
        #region Private Control Members

        private Frame windowFrame;

        #endregion

        public GameMainWindow()
            : base()
        {
            Padding = 5;
            Title = "Regiment of Foot";
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            windowFrame = new Frame()
            {
                BackgroundColor = new Xwt.Drawing.Color(.886, .886, .886)
            };
            Content = windowFrame;

        }

        protected override bool OnCloseRequested()
        {
            
            return MessageDialog.AskQuestion("Are you sure you want to exit?", 
                Command.Yes, Command.No) == Command.Yes;
        }

        protected override void OnClosed()
        {
            Xwt.Application.Exit();
        }
    }
}

