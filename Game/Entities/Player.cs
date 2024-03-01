using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;

namespace Harvesteer.Entities
{
    public partial class Player
    {
        int iHealth;

        public int Health
        {
            get
            {
                return iHealth;
            }
            set
            {
                iHealth = value;

                // Determine the percentage of health the player has left.
                HealthBarRuntimeInstance.PercentFull = 100 * Health / (float)StartingHealth;

                // If iHealth is less than or equal to 0
                if (iHealth <= 0)
                {
                    // Run the Destory function
                    Destroy();
                }
            }
        }

        private void CustomInitialize()
        {
            Health = StartingHealth;
        }

        private void CustomActivity()
        {
            getMousePosition();

        }

        private void CustomDestroy()
        {


        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }

        void getMousePosition()
        {
            FlatRedBall.Gui.Cursor cursor = FlatRedBall.Gui.GuiManager.Cursor;

            FlatRedBall.Debugging.Debugger.Write($"{cursor.ScreenX}, {cursor.ScreenY}");
        }

    }
}
