using System;
using Xwt;
using System.Collections.Generic;
using System.Collections;

namespace RegimentOfFoot.Game
{
    public static class FrameSwitcher
    {
        public static Window Window{ get; set; }

        public static Dictionary<string, Frame> Frames{ get; private set; }

        private static string current;

        private static Stack<string> history{ get; set; }

        private static Stack<string> future{ get; set; }

        private static bool initialized = false;

        public static void InitializeFrames()
        {
            
            Frames = new Dictionary<string, Frame>();
            history = new Stack<string>();
            future = new Stack<string>();
            initialized = true;
        }

        public static void SwitchFrame(string key, Frame frame, bool fwd_back_nav = false)
        {
            if (!initialized)
            {
                throw new NullReferenceException("Switcher not initialized");
            }
            if (frame != null)
            {
                Frames.Add(key, frame);
            }
            Window.Content = Frames[key];
            Window.Size = frame.Size;
            //Xwt.Application.Invoke(() => Window.Content = Frames[key]);
            if (!fwd_back_nav)
                history.Push(current);
            current = key;
        }

        public static void SwitchFrame(string key, bool fwd_back_nav = false)
        {
            SwitchFrame(key, null, fwd_back_nav);
        }

        public static void GoBack(int times)
        {
            if (!initialized)
            {
                throw new NullReferenceException("Switcher not initialized");
            }
            string temp_curr = current;
            while (history.Count > 0 && times > 0)
            {
                string temp = history.Pop();
                future.Push(temp_curr);
                temp_curr = temp;
                times--;
            }
            SwitchFrame(temp_curr, true);
        }

        public static void GoForward(int times)
        {
            if (!initialized)
            {
                throw new NullReferenceException("Switcher not initialized");
            }
            string temp_curr = current;
            while (future.Count > 0 && times > 0)
            {
                string temp = future.Pop();
                history.Push(temp_curr);
                temp_curr = temp;
                times--;
            }
            SwitchFrame(temp_curr, true);
            
        }
    }
}

