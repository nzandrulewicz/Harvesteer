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
using Harvesteer.Scripts;

namespace Harvesteer.Entities
{
    public partial class Enemy
    {
        public Vector2 vPlayerPosition;

        private void CustomInitialize()
        {
            var input = new MovementInputDevice(this.Position.ToVector2(), vPlayerPosition);

            InitializeTopDownInput(input);
        }

        private void CustomActivity()
        {

        }

        private void CustomDestroy()
        {


        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {


        }
    }
}
