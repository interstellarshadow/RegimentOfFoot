using System;
using Xwt;
using System.Collections.Generic;

namespace RegimentOfFoot.Game
{
    public static class FrameSwitcher
    {
        public static Window Window{ get; set; }

        public static Dictionary<string, Frame> Frames{ get; private set; }

        private static Stack<string> history{ get; set; }

        private static Stack<string> future{ get; set; }

        private static bool initialized = false;

        public static void InitializeFrames()
        {
            initialized = true;
        }

        public static void SwitchFrame(String key)
        {
            if (!initialized)
            {
                throw new NullReferenceException("Switcher not initialized");
            }
        }

        public static void GoBack(int times)
        {
            if (!initialized)
            {
                throw new NullReferenceException("Switcher not initialized");
            }
            //while()
        }

        public static void GoForward(int times)
        {
            if (!initialized)
            {
                throw new NullReferenceException("Switcher not initialized");
            }

            
        }
    }
}

