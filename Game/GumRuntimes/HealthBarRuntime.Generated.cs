using System.Linq;
namespace Harvesteer.GumRuntimes
{
    public partial class HealthBarRuntime : Harvesteer.GumRuntimes.ContainerRuntime
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        #endregion
        #region State Properties
        public VariableState CurrentVariableState
        {
            get
            {
                return mCurrentVariableState;
            }
            set
            {
                mCurrentVariableState = value;
                switch(mCurrentVariableState)
                {
                    case  VariableState.Default:
                        Height = 8f;
                        Width = 40f;
                        X = 0f;
                        XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        Y = -20f;
                        YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        Background.Blue = 53;
                        Background.Green = 49;
                        Background.Height = 0f;
                        Background.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        Background.Red = 255;
                        Background.Width = 0f;
                        Background.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        Background.X = 0f;
                        Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        Background.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        Background.Y = 0f;
                        Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        Foreground.Alpha = 255;
                        Foreground.Blue = 0;
                        Foreground.Green = 255;
                        Foreground.HasEvents = false;
                        Foreground.Height = 0f;
                        Foreground.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        Foreground.Red = 124;
                        Foreground.Width = 100f;
                        Foreground.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        Foreground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        Foreground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        Foreground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        Foreground.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        break;
                }
            }
        }
        #endregion
        #region State Interpolation
        public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setBackgroundBlueFirstValue = false;
            bool setBackgroundBlueSecondValue = false;
            int BackgroundBlueFirstValue= 0;
            int BackgroundBlueSecondValue= 0;
            bool setBackgroundGreenFirstValue = false;
            bool setBackgroundGreenSecondValue = false;
            int BackgroundGreenFirstValue= 0;
            int BackgroundGreenSecondValue= 0;
            bool setBackgroundHeightFirstValue = false;
            bool setBackgroundHeightSecondValue = false;
            float BackgroundHeightFirstValue= 0;
            float BackgroundHeightSecondValue= 0;
            bool setBackgroundRedFirstValue = false;
            bool setBackgroundRedSecondValue = false;
            int BackgroundRedFirstValue= 0;
            int BackgroundRedSecondValue= 0;
            bool setBackgroundWidthFirstValue = false;
            bool setBackgroundWidthSecondValue = false;
            float BackgroundWidthFirstValue= 0;
            float BackgroundWidthSecondValue= 0;
            bool setBackgroundXFirstValue = false;
            bool setBackgroundXSecondValue = false;
            float BackgroundXFirstValue= 0;
            float BackgroundXSecondValue= 0;
            bool setBackgroundYFirstValue = false;
            bool setBackgroundYSecondValue = false;
            float BackgroundYFirstValue= 0;
            float BackgroundYSecondValue= 0;
            bool setForegroundAlphaFirstValue = false;
            bool setForegroundAlphaSecondValue = false;
            int ForegroundAlphaFirstValue= 0;
            int ForegroundAlphaSecondValue= 0;
            bool setForegroundBlueFirstValue = false;
            bool setForegroundBlueSecondValue = false;
            int ForegroundBlueFirstValue= 0;
            int ForegroundBlueSecondValue= 0;
            bool setForegroundGreenFirstValue = false;
            bool setForegroundGreenSecondValue = false;
            int ForegroundGreenFirstValue= 0;
            int ForegroundGreenSecondValue= 0;
            bool setForegroundHeightFirstValue = false;
            bool setForegroundHeightSecondValue = false;
            float ForegroundHeightFirstValue= 0;
            float ForegroundHeightSecondValue= 0;
            bool setForegroundRedFirstValue = false;
            bool setForegroundRedSecondValue = false;
            int ForegroundRedFirstValue= 0;
            int ForegroundRedSecondValue= 0;
            bool setForegroundWidthFirstValue = false;
            bool setForegroundWidthSecondValue = false;
            float ForegroundWidthFirstValue= 0;
            float ForegroundWidthSecondValue= 0;
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            bool setXFirstValue = false;
            bool setXSecondValue = false;
            float XFirstValue= 0;
            float XSecondValue= 0;
            bool setYFirstValue = false;
            bool setYSecondValue = false;
            float YFirstValue= 0;
            float YSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setBackgroundBlueFirstValue = true;
                    BackgroundBlueFirstValue = 53;
                    setBackgroundGreenFirstValue = true;
                    BackgroundGreenFirstValue = 49;
                    setBackgroundHeightFirstValue = true;
                    BackgroundHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setBackgroundRedFirstValue = true;
                    BackgroundRedFirstValue = 255;
                    setBackgroundWidthFirstValue = true;
                    BackgroundWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setBackgroundXFirstValue = true;
                    BackgroundXFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Background.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setBackgroundYFirstValue = true;
                    BackgroundYFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setForegroundAlphaFirstValue = true;
                    ForegroundAlphaFirstValue = 255;
                    setForegroundBlueFirstValue = true;
                    ForegroundBlueFirstValue = 0;
                    setForegroundGreenFirstValue = true;
                    ForegroundGreenFirstValue = 255;
                    if (interpolationValue < 1)
                    {
                        this.Foreground.HasEvents = false;
                    }
                    setForegroundHeightFirstValue = true;
                    ForegroundHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Foreground.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setForegroundRedFirstValue = true;
                    ForegroundRedFirstValue = 124;
                    setForegroundWidthFirstValue = true;
                    ForegroundWidthFirstValue = 100f;
                    if (interpolationValue < 1)
                    {
                        this.Foreground.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Foreground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Foreground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Foreground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Foreground.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 8f;
                    setWidthFirstValue = true;
                    WidthFirstValue = 40f;
                    setXFirstValue = true;
                    XFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    setYFirstValue = true;
                    YFirstValue = -20f;
                    if (interpolationValue < 1)
                    {
                        this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setBackgroundBlueSecondValue = true;
                    BackgroundBlueSecondValue = 53;
                    setBackgroundGreenSecondValue = true;
                    BackgroundGreenSecondValue = 49;
                    setBackgroundHeightSecondValue = true;
                    BackgroundHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setBackgroundRedSecondValue = true;
                    BackgroundRedSecondValue = 255;
                    setBackgroundWidthSecondValue = true;
                    BackgroundWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setBackgroundXSecondValue = true;
                    BackgroundXSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Background.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setBackgroundYSecondValue = true;
                    BackgroundYSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setForegroundAlphaSecondValue = true;
                    ForegroundAlphaSecondValue = 255;
                    setForegroundBlueSecondValue = true;
                    ForegroundBlueSecondValue = 0;
                    setForegroundGreenSecondValue = true;
                    ForegroundGreenSecondValue = 255;
                    if (interpolationValue >= 1)
                    {
                        this.Foreground.HasEvents = false;
                    }
                    setForegroundHeightSecondValue = true;
                    ForegroundHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Foreground.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setForegroundRedSecondValue = true;
                    ForegroundRedSecondValue = 124;
                    setForegroundWidthSecondValue = true;
                    ForegroundWidthSecondValue = 100f;
                    if (interpolationValue >= 1)
                    {
                        this.Foreground.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Foreground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Foreground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Foreground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Foreground.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 8f;
                    setWidthSecondValue = true;
                    WidthSecondValue = 40f;
                    setXSecondValue = true;
                    XSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    setYSecondValue = true;
                    YSecondValue = -20f;
                    if (interpolationValue >= 1)
                    {
                        this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setBackgroundBlueFirstValue && setBackgroundBlueSecondValue)
            {
                Background.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundBlueFirstValue* (1 - interpolationValue) + BackgroundBlueSecondValue * interpolationValue);
            }
            if (setBackgroundGreenFirstValue && setBackgroundGreenSecondValue)
            {
                Background.Green = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundGreenFirstValue* (1 - interpolationValue) + BackgroundGreenSecondValue * interpolationValue);
            }
            if (setBackgroundHeightFirstValue && setBackgroundHeightSecondValue)
            {
                Background.Height = BackgroundHeightFirstValue * (1 - interpolationValue) + BackgroundHeightSecondValue * interpolationValue;
            }
            if (setBackgroundRedFirstValue && setBackgroundRedSecondValue)
            {
                Background.Red = FlatRedBall.Math.MathFunctions.RoundToInt(BackgroundRedFirstValue* (1 - interpolationValue) + BackgroundRedSecondValue * interpolationValue);
            }
            if (setBackgroundWidthFirstValue && setBackgroundWidthSecondValue)
            {
                Background.Width = BackgroundWidthFirstValue * (1 - interpolationValue) + BackgroundWidthSecondValue * interpolationValue;
            }
            if (setBackgroundXFirstValue && setBackgroundXSecondValue)
            {
                Background.X = BackgroundXFirstValue * (1 - interpolationValue) + BackgroundXSecondValue * interpolationValue;
            }
            if (setBackgroundYFirstValue && setBackgroundYSecondValue)
            {
                Background.Y = BackgroundYFirstValue * (1 - interpolationValue) + BackgroundYSecondValue * interpolationValue;
            }
            if (setForegroundAlphaFirstValue && setForegroundAlphaSecondValue)
            {
                Foreground.Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundAlphaFirstValue* (1 - interpolationValue) + ForegroundAlphaSecondValue * interpolationValue);
            }
            if (setForegroundBlueFirstValue && setForegroundBlueSecondValue)
            {
                Foreground.Blue = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundBlueFirstValue* (1 - interpolationValue) + ForegroundBlueSecondValue * interpolationValue);
            }
            if (setForegroundGreenFirstValue && setForegroundGreenSecondValue)
            {
                Foreground.Green = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundGreenFirstValue* (1 - interpolationValue) + ForegroundGreenSecondValue * interpolationValue);
            }
            if (setForegroundHeightFirstValue && setForegroundHeightSecondValue)
            {
                Foreground.Height = ForegroundHeightFirstValue * (1 - interpolationValue) + ForegroundHeightSecondValue * interpolationValue;
            }
            if (setForegroundRedFirstValue && setForegroundRedSecondValue)
            {
                Foreground.Red = FlatRedBall.Math.MathFunctions.RoundToInt(ForegroundRedFirstValue* (1 - interpolationValue) + ForegroundRedSecondValue * interpolationValue);
            }
            if (setForegroundWidthFirstValue && setForegroundWidthSecondValue)
            {
                Foreground.Width = ForegroundWidthFirstValue * (1 - interpolationValue) + ForegroundWidthSecondValue * interpolationValue;
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setWidthFirstValue && setWidthSecondValue)
            {
                Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
            }
            if (setXFirstValue && setXSecondValue)
            {
                X = XFirstValue * (1 - interpolationValue) + XSecondValue * interpolationValue;
            }
            if (setYFirstValue && setYSecondValue)
            {
                Y = YFirstValue * (1 - interpolationValue) + YSecondValue * interpolationValue;
            }
            if (interpolationValue < 1)
            {
                mCurrentVariableState = firstState;
            }
            else
            {
                mCurrentVariableState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.HealthBarRuntime.VariableState fromState,Harvesteer.GumRuntimes.HealthBarRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
        {
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.States.First(item => item.Name == toState.ToString());
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
            tweener.Ended += ()=> this.CurrentVariableState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
            tweener.Ended += ()=> this.CurrentVariableState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        #endregion
        #region State Animations
        #endregion
        public override void StopAnimations () 
        {
            base.StopAnimations();
        }
        public override FlatRedBall.Gum.Animation.GumAnimation GetAnimation (string animationName) 
        {
            return base.GetAnimation(animationName);
        }
        #region Get Current Values on State
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  VariableState.Default:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height",
                        Type = "float",
                        Value = Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "X",
                        Type = "float",
                        Value = X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "X Origin",
                        Type = "HorizontalAlignment",
                        Value = XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Y",
                        Type = "float",
                        Value = Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Y Origin",
                        Type = "VerticalAlignment",
                        Value = YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Blue",
                        Type = "int",
                        Value = Background.Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Green",
                        Type = "int",
                        Value = Background.Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height",
                        Type = "float",
                        Value = Background.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height Units",
                        Type = "DimensionUnitType",
                        Value = Background.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Red",
                        Type = "int",
                        Value = Background.Red
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Width",
                        Type = "float",
                        Value = Background.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Width Units",
                        Type = "DimensionUnitType",
                        Value = Background.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X",
                        Type = "float",
                        Value = Background.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X Origin",
                        Type = "HorizontalAlignment",
                        Value = Background.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X Units",
                        Type = "PositionUnitType",
                        Value = Background.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y",
                        Type = "float",
                        Value = Background.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y Origin",
                        Type = "VerticalAlignment",
                        Value = Background.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y Units",
                        Type = "PositionUnitType",
                        Value = Background.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Alpha",
                        Type = "int",
                        Value = Foreground.Alpha
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Blue",
                        Type = "int",
                        Value = Foreground.Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Green",
                        Type = "int",
                        Value = Foreground.Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.HasEvents",
                        Type = "bool",
                        Value = Foreground.HasEvents
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Height",
                        Type = "float",
                        Value = Foreground.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Height Units",
                        Type = "DimensionUnitType",
                        Value = Foreground.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Red",
                        Type = "int",
                        Value = Foreground.Red
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Width",
                        Type = "float",
                        Value = Foreground.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Width Units",
                        Type = "DimensionUnitType",
                        Value = Foreground.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.X Origin",
                        Type = "HorizontalAlignment",
                        Value = Foreground.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.X Units",
                        Type = "PositionUnitType",
                        Value = Foreground.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Y Origin",
                        Type = "VerticalAlignment",
                        Value = Foreground.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Y Units",
                        Type = "PositionUnitType",
                        Value = Foreground.YUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  VariableState.Default:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height",
                        Type = "float",
                        Value = Height + 8f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width + 40f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "X",
                        Type = "float",
                        Value = X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "X Origin",
                        Type = "HorizontalAlignment",
                        Value = XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Y",
                        Type = "float",
                        Value = Y + -20f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Y Origin",
                        Type = "VerticalAlignment",
                        Value = YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Blue",
                        Type = "int",
                        Value = Background.Blue + 53
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Green",
                        Type = "int",
                        Value = Background.Green + 49
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height",
                        Type = "float",
                        Value = Background.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height Units",
                        Type = "DimensionUnitType",
                        Value = Background.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Red",
                        Type = "int",
                        Value = Background.Red + 255
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Width",
                        Type = "float",
                        Value = Background.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Width Units",
                        Type = "DimensionUnitType",
                        Value = Background.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X",
                        Type = "float",
                        Value = Background.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X Origin",
                        Type = "HorizontalAlignment",
                        Value = Background.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X Units",
                        Type = "PositionUnitType",
                        Value = Background.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y",
                        Type = "float",
                        Value = Background.Y + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y Origin",
                        Type = "VerticalAlignment",
                        Value = Background.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y Units",
                        Type = "PositionUnitType",
                        Value = Background.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Alpha",
                        Type = "int",
                        Value = Foreground.Alpha + 255
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Blue",
                        Type = "int",
                        Value = Foreground.Blue + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Green",
                        Type = "int",
                        Value = Foreground.Green + 255
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.HasEvents",
                        Type = "bool",
                        Value = Foreground.HasEvents
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Height",
                        Type = "float",
                        Value = Foreground.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Height Units",
                        Type = "DimensionUnitType",
                        Value = Foreground.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Red",
                        Type = "int",
                        Value = Foreground.Red + 124
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Width",
                        Type = "float",
                        Value = Foreground.Width + 100f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Width Units",
                        Type = "DimensionUnitType",
                        Value = Foreground.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.X Origin",
                        Type = "HorizontalAlignment",
                        Value = Foreground.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.X Units",
                        Type = "PositionUnitType",
                        Value = Foreground.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Y Origin",
                        Type = "VerticalAlignment",
                        Value = Foreground.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Foreground.Y Units",
                        Type = "PositionUnitType",
                        Value = Foreground.YUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        #endregion
        public override void ApplyState (Gum.DataTypes.Variables.StateSave state) 
        {
            bool matches = this.ElementSave.AllStates.Contains(state);
            if (matches)
            {
                var category = this.ElementSave.Categories.FirstOrDefault(item => item.States.Contains(state));
                if (category == null)
                {
                    if (state.Name == "Default") this.mCurrentVariableState = VariableState.Default;
                }
            }
            base.ApplyState(state);
        }
        public Harvesteer.GumRuntimes.ColoredRectangleRuntime Background { get; set; }
        public Harvesteer.GumRuntimes.ColoredRectangleRuntime Foreground { get; set; }
        public float PercentFull
        {
            get
            {
                return Foreground.Width;
            }
            set
            {
                if (Foreground.Width != value)
                {
                    Foreground.Width = value;
                    PercentFullChanged?.Invoke(this, null);
                }
            }
        }
        public event System.EventHandler PercentFullChanged;
        public HealthBarRuntime () 
        	: this(true, true)
        {
        }
        public HealthBarRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "HealthBar");
                this.ElementSave = elementSave;
                string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
            }
        }
        public override void SetInitialState () 
        {
            var wasSuppressed = this.IsLayoutSuspended;
            if(!wasSuppressed) this.SuspendLayout();
            base.SetInitialState();
            this.CurrentVariableState = VariableState.Default;
            if(!wasSuppressed) this.ResumeLayout();
            CallCustomInitialize();
        }
        public override void CreateChildrenRecursively (Gum.DataTypes.ElementSave elementSave, RenderingLibrary.ISystemManagers systemManagers) 
        {
            base.CreateChildrenRecursively(elementSave, systemManagers);
            this.AssignInternalReferences();
        }
        private void AssignInternalReferences () 
        {
            Background = this.GetGraphicalUiElementByName("Background") as Harvesteer.GumRuntimes.ColoredRectangleRuntime;
            Foreground = this.GetGraphicalUiElementByName("Foreground") as Harvesteer.GumRuntimes.ColoredRectangleRuntime;
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
    }
}
