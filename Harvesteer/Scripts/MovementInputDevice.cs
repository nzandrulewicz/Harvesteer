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
    internal class MovementInputDevice : IInputDevice
    {
        Vector2 vEntitySource;
        Vector2 vEntityTarget;

        public MovementInputDevice(Vector2 pvEntitySource, Vector2 pvEntityTarget)
        {
            this.vEntitySource = pvEntitySource;
            this.vEntityTarget = pvEntityTarget;
        }

        // I2DInput represents 2D inputs such as Joysticks, AWSD, and DPads
        // Default2DInput provides input for the movement of an instance of an entity on a 2D plain
        public I2DInput Default2DInput
        {
            get
            {
                EntityTracker input = new EntityTracker(vEntitySource, vEntityTarget);

                return input;
            }
        }

        public IRepeatPressableInput DefaultUpPressable => throw new NotImplementedException();

        public IRepeatPressableInput DefaultDownPressable => throw new NotImplementedException();

        public IRepeatPressableInput DefaultLeftPressable => throw new NotImplementedException();

        public IRepeatPressableInput DefaultRightPressable => throw new NotImplementedException();

        public I1DInput DefaultHorizontalInput => throw new NotImplementedException();

        public I1DInput DefaultVerticalInput => throw new NotImplementedException();

        public IPressableInput DefaultPrimaryActionInput => throw new NotImplementedException();

        public IPressableInput DefaultSecondaryActionInput => throw new NotImplementedException();

        public IPressableInput DefaultConfirmInput => throw new NotImplementedException();

        public IPressableInput DefaultJoinInput => throw new NotImplementedException();

        public IPressableInput DefaultPauseInput => throw new NotImplementedException();

        public IPressableInput DefaultBackInput => throw new NotImplementedException();

        public IPressableInput DefaultCancelInput => throw new NotImplementedException();
    }
}
