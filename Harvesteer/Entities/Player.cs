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
        double LastTimeAttackStarted = -999;
        double AttackDamageDuration = .25;
        double AttackCooldown = .5;

        public bool CanAttack => TimeManager.SecondsSince(LastTimeAttackStarted) > AttackCooldown;
        public bool IsAttackActive => TimeManager.SecondsSince(LastTimeAttackStarted) < AttackDamageDuration;

        private void CustomInitialize()
        {

        }

        private void CustomActivity()
        {
            if (InputManager.Mouse.ButtonPushed(Mouse.MouseButtons.LeftButton) && CanAttack)
            {
                useSword();
            }

            SwordCollision.Visible = IsAttackActive;
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
            LastTimeAttackStarted = TimeManager.CurrentScreenTime;

            var differenceVector = GuiManager.Cursor.WorldPosition.ToVector3() - this.Position;
            var angleInDegrees = differenceVector.AngleDegreesOrZero();
            var angleRoundedTo90Degrees = MathFunctions.RoundFloat(angleInDegrees, 90);
            var startSwingAngleDegrees = angleRoundedTo90Degrees;
            var angleRoundedBackInRadians = MathHelper.ToRadians(startSwingAngleDegrees);

            this.SwordCollision.RelativeRotationZ = angleRoundedBackInRadians;

        }
    }
}
