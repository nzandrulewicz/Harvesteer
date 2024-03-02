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
using FlatRedBall.Gui;
using System.Diagnostics;
using FlatRedBall.Math;

namespace Harvesteer.Entities
{
    public partial class Player
    {
        private void CustomInitialize()
        {
        }

        private void CustomActivity()
        {
            if (InputManager.Mouse.ButtonPushed(Mouse.MouseButtons.LeftButton))
            {
                useSword();
            }
        }

        private void CustomDestroy()
        {


        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }

        void useSword()
        {
            //Debug.WriteLine("MOUSE BUTTON CLICKED");
            //this.SwordCollision.RelativeRotationZVelocity = -10;

            var differenceVector = GuiManager.Cursor.WorldPosition.ToVector3() - this.Position;
            var angleInDegrees = differenceVector.AngleDegreesOrZero();
            var angleRoundedTo90Degrees = MathFunctions.RoundFloat(angleInDegrees, 90);
            var startSwingAngle = angleRoundedTo90Degrees + 45;
            var angleRoundedBackInRadians = MathHelper.ToRadians(startSwingAngle);

            SwordCollision.RelativeRotationZ = angleRoundedBackInRadians;
        }
    }
}
