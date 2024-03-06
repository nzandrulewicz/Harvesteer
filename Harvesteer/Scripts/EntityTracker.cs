using FlatRedBall.Input;
using Harvesteer.Entities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvesteer.Scripts
{
    /// <summary>
    /// EntityTracker is a "spoof" controller using in game entities to determine movement.
    /// </summary>
    internal class EntityTracker : I2DInput
    {
        Vector2 vEntitySource;
        Vector2 vEntityTarget;

        public EntityTracker(Vector2 pvEntitySource, Vector2 pvEntityTarget)
        {
            this.vEntitySource = pvEntitySource;
            this.vEntityTarget = pvEntityTarget;
        }

        /// <summary>
        /// Returns a vector that points from the point represented by <paramref name="from"/>
        /// to the point represented by <paramref name="to"/>
        /// </summary>
        public static Vector2 GetVectorTo(Vector2 from, Vector2 to)
        {
            return to - from;
        }

        public float X
        {
            get
            {
                return vEntityTarget.X;
            }
        }

        public float Y
        {
            get
            {
                return vEntityTarget.Y;
            }
        }

        public float XVelocity => throw new NotImplementedException();

        public float YVelocity => throw new NotImplementedException();

        public float Magnitude => throw new NotImplementedException();
    }
}
