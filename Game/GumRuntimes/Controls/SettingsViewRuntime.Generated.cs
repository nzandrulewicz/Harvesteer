using System.Linq;
namespace Harvesteer.GumRuntimes.Controls
{
    public partial class SettingsViewRuntime : Harvesteer.GumRuntimes.ContainerRuntime, Harvesteer.GumRuntimes.ISettingsViewBehavior
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
                        ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        FullscreenCheckboxInstance.CheckboxDisplayText = "Fullscreen";
                        FullscreenCheckboxInstance.Width = 0f;
                        FullscreenCheckboxInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        FullscreenCheckboxInstance.Y = 0f;
                        MusicVolumeLabel.LabelText = "Music Volume";
                        MusicVolumeLabel.Width = 0f;
                        MusicVolumeLabel.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        MusicVolumeLabel.Y = 12f;
                        MusicSliderInstance.Width = 0f;
                        MusicSliderInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        SoundVolumeLabel.LabelText = "Sound Effect Volume";
                        SoundVolumeLabel.Width = 0f;
                        SoundVolumeLabel.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        SoundVolumeLabel.Y = 12f;
                        SoundSliderInstance.Width = 0f;
                        SoundSliderInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
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
            bool setFullscreenCheckboxInstanceWidthFirstValue = false;
            bool setFullscreenCheckboxInstanceWidthSecondValue = false;
            float FullscreenCheckboxInstanceWidthFirstValue= 0;
            float FullscreenCheckboxInstanceWidthSecondValue= 0;
            bool setFullscreenCheckboxInstanceYFirstValue = false;
            bool setFullscreenCheckboxInstanceYSecondValue = false;
            float FullscreenCheckboxInstanceYFirstValue= 0;
            float FullscreenCheckboxInstanceYSecondValue= 0;
            bool setMusicSliderInstanceWidthFirstValue = false;
            bool setMusicSliderInstanceWidthSecondValue = false;
            float MusicSliderInstanceWidthFirstValue= 0;
            float MusicSliderInstanceWidthSecondValue= 0;
            bool setMusicVolumeLabelWidthFirstValue = false;
            bool setMusicVolumeLabelWidthSecondValue = false;
            float MusicVolumeLabelWidthFirstValue= 0;
            float MusicVolumeLabelWidthSecondValue= 0;
            bool setMusicVolumeLabelYFirstValue = false;
            bool setMusicVolumeLabelYSecondValue = false;
            float MusicVolumeLabelYFirstValue= 0;
            float MusicVolumeLabelYSecondValue= 0;
            bool setSoundSliderInstanceWidthFirstValue = false;
            bool setSoundSliderInstanceWidthSecondValue = false;
            float SoundSliderInstanceWidthFirstValue= 0;
            float SoundSliderInstanceWidthSecondValue= 0;
            bool setSoundVolumeLabelWidthFirstValue = false;
            bool setSoundVolumeLabelWidthSecondValue = false;
            float SoundVolumeLabelWidthFirstValue= 0;
            float SoundVolumeLabelWidthSecondValue= 0;
            bool setSoundVolumeLabelYFirstValue = false;
            bool setSoundVolumeLabelYSecondValue = false;
            float SoundVolumeLabelYFirstValue= 0;
            float SoundVolumeLabelYSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    if (interpolationValue < 1)
                    {
                        this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                    }
                    if (interpolationValue < 1)
                    {
                        this.FullscreenCheckboxInstance.CheckboxDisplayText = "Fullscreen";
                    }
                    setFullscreenCheckboxInstanceWidthFirstValue = true;
                    FullscreenCheckboxInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.FullscreenCheckboxInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setFullscreenCheckboxInstanceYFirstValue = true;
                    FullscreenCheckboxInstanceYFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setMusicSliderInstanceWidthFirstValue = true;
                    MusicSliderInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.MusicSliderInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.MusicVolumeLabel.LabelText = "Music Volume";
                    }
                    setMusicVolumeLabelWidthFirstValue = true;
                    MusicVolumeLabelWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.MusicVolumeLabel.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setMusicVolumeLabelYFirstValue = true;
                    MusicVolumeLabelYFirstValue = 12f;
                    setSoundSliderInstanceWidthFirstValue = true;
                    SoundSliderInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.SoundSliderInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.SoundVolumeLabel.LabelText = "Sound Effect Volume";
                    }
                    setSoundVolumeLabelWidthFirstValue = true;
                    SoundVolumeLabelWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.SoundVolumeLabel.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setSoundVolumeLabelYFirstValue = true;
                    SoundVolumeLabelYFirstValue = 12f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    if (interpolationValue >= 1)
                    {
                        this.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.FullscreenCheckboxInstance.CheckboxDisplayText = "Fullscreen";
                    }
                    setFullscreenCheckboxInstanceWidthSecondValue = true;
                    FullscreenCheckboxInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.FullscreenCheckboxInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setFullscreenCheckboxInstanceYSecondValue = true;
                    FullscreenCheckboxInstanceYSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setMusicSliderInstanceWidthSecondValue = true;
                    MusicSliderInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.MusicSliderInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.MusicVolumeLabel.LabelText = "Music Volume";
                    }
                    setMusicVolumeLabelWidthSecondValue = true;
                    MusicVolumeLabelWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.MusicVolumeLabel.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setMusicVolumeLabelYSecondValue = true;
                    MusicVolumeLabelYSecondValue = 12f;
                    setSoundSliderInstanceWidthSecondValue = true;
                    SoundSliderInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.SoundSliderInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.SoundVolumeLabel.LabelText = "Sound Effect Volume";
                    }
                    setSoundVolumeLabelWidthSecondValue = true;
                    SoundVolumeLabelWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.SoundVolumeLabel.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setSoundVolumeLabelYSecondValue = true;
                    SoundVolumeLabelYSecondValue = 12f;
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setFullscreenCheckboxInstanceWidthFirstValue && setFullscreenCheckboxInstanceWidthSecondValue)
            {
                FullscreenCheckboxInstance.Width = FullscreenCheckboxInstanceWidthFirstValue * (1 - interpolationValue) + FullscreenCheckboxInstanceWidthSecondValue * interpolationValue;
            }
            if (setFullscreenCheckboxInstanceYFirstValue && setFullscreenCheckboxInstanceYSecondValue)
            {
                FullscreenCheckboxInstance.Y = FullscreenCheckboxInstanceYFirstValue * (1 - interpolationValue) + FullscreenCheckboxInstanceYSecondValue * interpolationValue;
            }
            if (setMusicSliderInstanceWidthFirstValue && setMusicSliderInstanceWidthSecondValue)
            {
                MusicSliderInstance.Width = MusicSliderInstanceWidthFirstValue * (1 - interpolationValue) + MusicSliderInstanceWidthSecondValue * interpolationValue;
            }
            if (setMusicVolumeLabelWidthFirstValue && setMusicVolumeLabelWidthSecondValue)
            {
                MusicVolumeLabel.Width = MusicVolumeLabelWidthFirstValue * (1 - interpolationValue) + MusicVolumeLabelWidthSecondValue * interpolationValue;
            }
            if (setMusicVolumeLabelYFirstValue && setMusicVolumeLabelYSecondValue)
            {
                MusicVolumeLabel.Y = MusicVolumeLabelYFirstValue * (1 - interpolationValue) + MusicVolumeLabelYSecondValue * interpolationValue;
            }
            if (setSoundSliderInstanceWidthFirstValue && setSoundSliderInstanceWidthSecondValue)
            {
                SoundSliderInstance.Width = SoundSliderInstanceWidthFirstValue * (1 - interpolationValue) + SoundSliderInstanceWidthSecondValue * interpolationValue;
            }
            if (setSoundVolumeLabelWidthFirstValue && setSoundVolumeLabelWidthSecondValue)
            {
                SoundVolumeLabel.Width = SoundVolumeLabelWidthFirstValue * (1 - interpolationValue) + SoundVolumeLabelWidthSecondValue * interpolationValue;
            }
            if (setSoundVolumeLabelYFirstValue && setSoundVolumeLabelYSecondValue)
            {
                SoundVolumeLabel.Y = SoundVolumeLabelYFirstValue * (1 - interpolationValue) + SoundVolumeLabelYSecondValue * interpolationValue;
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.SettingsViewRuntime.VariableState fromState,Harvesteer.GumRuntimes.Controls.SettingsViewRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            FullscreenCheckboxInstance.StopAnimations();
            MusicVolumeLabel.StopAnimations();
            MusicSliderInstance.StopAnimations();
            SoundVolumeLabel.StopAnimations();
            SoundSliderInstance.StopAnimations();
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
                        Name = "Children Layout",
                        Type = "ChildrenLayout",
                        Value = ChildrenLayout
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height Units",
                        Type = "DimensionUnitType",
                        Value = HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FullscreenCheckboxInstance.CheckboxDisplayText",
                        Type = "string",
                        Value = FullscreenCheckboxInstance.CheckboxDisplayText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FullscreenCheckboxInstance.Width",
                        Type = "float",
                        Value = FullscreenCheckboxInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FullscreenCheckboxInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = FullscreenCheckboxInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FullscreenCheckboxInstance.Y",
                        Type = "float",
                        Value = FullscreenCheckboxInstance.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "MusicVolumeLabel.LabelText",
                        Type = "string",
                        Value = MusicVolumeLabel.LabelText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "MusicVolumeLabel.Width",
                        Type = "float",
                        Value = MusicVolumeLabel.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "MusicVolumeLabel.Width Units",
                        Type = "DimensionUnitType",
                        Value = MusicVolumeLabel.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "MusicVolumeLabel.Y",
                        Type = "float",
                        Value = MusicVolumeLabel.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "MusicSliderInstance.Width",
                        Type = "float",
                        Value = MusicSliderInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "MusicSliderInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = MusicSliderInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SoundVolumeLabel.LabelText",
                        Type = "string",
                        Value = SoundVolumeLabel.LabelText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SoundVolumeLabel.Width",
                        Type = "float",
                        Value = SoundVolumeLabel.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SoundVolumeLabel.Width Units",
                        Type = "DimensionUnitType",
                        Value = SoundVolumeLabel.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SoundVolumeLabel.Y",
                        Type = "float",
                        Value = SoundVolumeLabel.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SoundSliderInstance.Width",
                        Type = "float",
                        Value = SoundSliderInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SoundSliderInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = SoundSliderInstance.WidthUnits
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
                        Name = "Children Layout",
                        Type = "ChildrenLayout",
                        Value = ChildrenLayout
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height Units",
                        Type = "DimensionUnitType",
                        Value = HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FullscreenCheckboxInstance.CheckboxDisplayText",
                        Type = "string",
                        Value = FullscreenCheckboxInstance.CheckboxDisplayText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FullscreenCheckboxInstance.Width",
                        Type = "float",
                        Value = FullscreenCheckboxInstance.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FullscreenCheckboxInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = FullscreenCheckboxInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FullscreenCheckboxInstance.Y",
                        Type = "float",
                        Value = FullscreenCheckboxInstance.Y + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "MusicVolumeLabel.LabelText",
                        Type = "string",
                        Value = MusicVolumeLabel.LabelText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "MusicVolumeLabel.Width",
                        Type = "float",
                        Value = MusicVolumeLabel.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "MusicVolumeLabel.Width Units",
                        Type = "DimensionUnitType",
                        Value = MusicVolumeLabel.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "MusicVolumeLabel.Y",
                        Type = "float",
                        Value = MusicVolumeLabel.Y + 12f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "MusicSliderInstance.Width",
                        Type = "float",
                        Value = MusicSliderInstance.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "MusicSliderInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = MusicSliderInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SoundVolumeLabel.LabelText",
                        Type = "string",
                        Value = SoundVolumeLabel.LabelText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SoundVolumeLabel.Width",
                        Type = "float",
                        Value = SoundVolumeLabel.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SoundVolumeLabel.Width Units",
                        Type = "DimensionUnitType",
                        Value = SoundVolumeLabel.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SoundVolumeLabel.Y",
                        Type = "float",
                        Value = SoundVolumeLabel.Y + 12f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SoundSliderInstance.Width",
                        Type = "float",
                        Value = SoundSliderInstance.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SoundSliderInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = SoundSliderInstance.WidthUnits
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
        private bool tryCreateFormsObject;
        public Harvesteer.GumRuntimes.Controls.CheckBoxRuntime FullscreenCheckboxInstance { get; set; }
        public Harvesteer.GumRuntimes.Elements.LabelRuntime MusicVolumeLabel { get; set; }
        public Harvesteer.GumRuntimes.Controls.SliderRuntime MusicSliderInstance { get; set; }
        public Harvesteer.GumRuntimes.Elements.LabelRuntime SoundVolumeLabel { get; set; }
        public Harvesteer.GumRuntimes.Controls.SliderRuntime SoundSliderInstance { get; set; }
        public event FlatRedBall.Gui.WindowEvent FullscreenCheckboxInstanceClick;
        public event FlatRedBall.Gui.WindowEvent MusicVolumeLabelClick;
        public event FlatRedBall.Gui.WindowEvent MusicSliderInstanceClick;
        public event FlatRedBall.Gui.WindowEvent SoundVolumeLabelClick;
        public event FlatRedBall.Gui.WindowEvent SoundSliderInstanceClick;
        public SettingsViewRuntime () 
        	: this(true, true)
        {
        }
        public SettingsViewRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/SettingsView");
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
            FullscreenCheckboxInstance = this.GetGraphicalUiElementByName("FullscreenCheckboxInstance") as Harvesteer.GumRuntimes.Controls.CheckBoxRuntime;
            MusicVolumeLabel = this.GetGraphicalUiElementByName("MusicVolumeLabel") as Harvesteer.GumRuntimes.Elements.LabelRuntime;
            MusicSliderInstance = this.GetGraphicalUiElementByName("MusicSliderInstance") as Harvesteer.GumRuntimes.Controls.SliderRuntime;
            SoundVolumeLabel = this.GetGraphicalUiElementByName("SoundVolumeLabel") as Harvesteer.GumRuntimes.Elements.LabelRuntime;
            SoundSliderInstance = this.GetGraphicalUiElementByName("SoundSliderInstance") as Harvesteer.GumRuntimes.Controls.SliderRuntime;
            FullscreenCheckboxInstance.Click += (unused) => FullscreenCheckboxInstanceClick?.Invoke(this);
            MusicVolumeLabel.Click += (unused) => MusicVolumeLabelClick?.Invoke(this);
            MusicSliderInstance.Click += (unused) => MusicSliderInstanceClick?.Invoke(this);
            SoundVolumeLabel.Click += (unused) => SoundVolumeLabelClick?.Invoke(this);
            SoundSliderInstance.Click += (unused) => SoundSliderInstanceClick?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.Games.SettingsView(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.Games.SettingsView FormsControl {get => (FlatRedBall.Forms.Controls.Games.SettingsView) FormsControlAsObject;}
    }
}
