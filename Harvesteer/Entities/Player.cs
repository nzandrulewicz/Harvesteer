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
        double LastTimeAttackStarted;

        public bool CanAttack => TimeManager.SecondsSince(LastTimeAttackStarted) > AttackCooldown;

        public bool IsAttackActive => TimeManager.SecondsSince(LastTimeAttackStarted) < AttackDamageDuration;

        private void CustomInitialize()
        {

        }

        private void CustomActivity()
        {
            // If left mouse button pushed AND CanAttack is true...
            if (InputManager.Mouse.ButtonPushed(Mouse.MouseButtons.LeftButton) && CanAttack)
            {
                // Use sword
                useSword();
            }

            // If not attacking, disable SwordCollision
            SwordCollision.Visible = IsAttackActive;

            if (IsAttackActive)
            {
                // Stop player movement
                this.CurrentMovement = TopDownValues[DataTypes.TopDownValues.SwingingSword];
            }
            else
            {
                // Enable player movement
                this.CurrentMovement = TopDownValues[DataTypes.TopDownValues.Default];
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
            // Check when the last attack started
            LastTimeAttackStarted = TimeManager.CurrentScreenTime;

            // Get the current position of the mouse
            var differenceVector = GuiManager.Cursor.WorldPosition.ToVector3() - this.Position;
            // Get the angle of where the mouse is relative to the player
            var angleInDegrees = differenceVector.AngleDegreesOrZero();
            // Adjust the angle to the nearest axis
            var angleRoundedTo90Degrees = MathFunctions.RoundFloat(angleInDegrees, 90);
            // Get the adjusted degree in Radians
            var angleRoundedBackInRadians = MathHelper.ToRadians(angleRoundedTo90Degrees);

            // Set the SwordCollision to the adjusted angled position
            this.SwordCollision.RelativeRotationZ = angleRoundedBackInRadians;
        }
    }
}
