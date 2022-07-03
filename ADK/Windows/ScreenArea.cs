﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADK.Windows
{
    public static class ScreenArea
    {
        /// <summary>
        /// Gets the least "x" coordinate of all screens on the system
        /// </summary>
        /// <returns>The smallest visible "x" screen coordinate</returns>
        public static int LeftMostBound
        {
            get
            {
                int leftBound = int.MaxValue;

                // Return the left-most "x" screen coordinate
                foreach (Screen display in Screen.AllScreens)
                {
                    if (leftBound > display.Bounds.X)
                    {
                        leftBound = display.Bounds.X;
                    }
                }

                return leftBound;
            }
        }

        /// <summary>
        /// Gets the greatest "x" coordinate of all screens on the system
        /// </summary>
        /// <returns>The largest visible "x" screen coordinate</returns>
        public static int RightMostBound
        {
            get
            {
                int rightBound = int.MinValue;

                // Return the right-most "x" screen coordinate
                foreach (Screen display in Screen.AllScreens)
                {
                    if (rightBound < display.Bounds.X + display.Bounds.Width)
                    {
                        rightBound = 
                            display.Bounds.X + display.Bounds.Width;
                    }
                }

                return rightBound;
            }
        }

        /// <summary>
        /// Gets the least "y" coordinate of all screens on the system
        /// </summary>
        /// <returns>The smallest visible "y" screen coordinate</returns>
        public static int TopMostBound
        {
            get
            {
                int topBound = int.MaxValue;

                // Return the top-most "y" screen coordinate
                foreach (Screen display in Screen.AllScreens)
                {
                    if (topBound > display.Bounds.Y)
                    {
                        topBound = display.Bounds.Y;
                    }
                }

                return topBound;
            }
        }

        /// <summary>
        /// Gets the greatest "y" coordinate of all screens on the system
        /// </summary>
        /// <returns>The largest visible "y" screen coordinate</returns>
        public static int BottomMostBound
        {
            get
            {
                int bottomBound = int.MinValue;

                // Return the bottom-most "y" screen coordinate
                foreach (Screen display in Screen.AllScreens)
                {
                    if (bottomBound < display.Bounds.Y + display.Bounds.Height)
                    {
                        bottomBound = 
                            display.Bounds.Y + display.Bounds.Height;
                    }
                }

                return bottomBound;
            }
        }

        /// <summary>
        /// Gets the width of the screen with the highest resolution.
        /// </summary>
        /// <returns>The width of the screen with the highest resolution.</returns>
        public static int MaximumWidth
        {
            get
            {
                int maxWidth = int.MinValue;

                // In this case we just get the largest screen height
                foreach (Screen display in Screen.AllScreens)
                {
                    if (maxWidth < display.Bounds.Width)
                    {
                        maxWidth = display.Bounds.Width;
                    }
                }

                return maxWidth;
            }
        }

        /// <summary>
        /// Gets the width of the screen with the lowest resolution.
        /// </summary>
        /// <returns>The width of the screen with the lowest resolution.</returns>
        public static int MinimumWidth
        {
            get
            {
                int minWidth = int.MaxValue;

                // In this case we just get the smallest screen height
                foreach (Screen display in Screen.AllScreens)
                {
                    if (minWidth > display.Bounds.Width)
                    {
                        minWidth = display.Bounds.Width;
                    }
                }

                return minWidth;
            }
        }

        /// <summary>
        /// Gets the height of the screen with the highest resolution.
        /// </summary>
        /// <returns>The height of the screen with the highest resolution.</returns>
        public static int MaximumHeight
        {
            get
            {
                int maxHeight = int.MinValue;

                // In this case we just get the largest screen height
                foreach (Screen display in Screen.AllScreens)
                {
                    if (maxHeight < display.Bounds.Height)
                    {
                        maxHeight = display.Bounds.Height;
                    }
                }

                return maxHeight;
            }
        }

        /// <summary>
        /// Gets the height of the screen with the lowest resolution.
        /// </summary>
        /// <returns>The height of the screen with the lowest resolution.</returns>
        public static int MinimumHeight
        {
            get
            {
                int minHeight = int.MaxValue;

                // In this case we just get the smallest screen height
                foreach (Screen display in Screen.AllScreens)
                {
                    if (minHeight > display.Bounds.Height)
                    {
                        minHeight = display.Bounds.Height;
                    }
                }

                return minHeight;
            }
        }

        /// <summary>
        /// Gets the total width of all the screens relative to their arrangement.
        /// </summary>
        /// <returns>The total width of all the screens relative to their arrangement.</returns>
        public static int TotalWidth
        {
            get
            {
                return RightMostBound - LeftMostBound;
            }
        }

        /// <summary>
        /// Gets the total height of all the screens relative to their arrangement.
        /// </summary>
        /// <returns>The total height of all the screens relative to their arrangement.</returns>
        public static int TotalHeight
        {
            get
            {
                return BottomMostBound - TopMostBound;
            }
        }
    }
}
