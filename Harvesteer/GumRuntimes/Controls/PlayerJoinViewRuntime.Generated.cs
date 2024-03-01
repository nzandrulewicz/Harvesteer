using System.Linq;
namespace Harvesteer.GumRuntimes.Controls
{
    public partial class PlayerJoinViewRuntime : Harvesteer.GumRuntimes.ContainerRuntime, Harvesteer.GumRuntimes.IPlayerJoinViewBehavior
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
                        PlayerJoinViewItem1.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                        PlayerJoinViewItem2.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                        PlayerJoinViewItem3.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                        PlayerJoinViewItem4.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                        Height = 463f;
                        Width = 144f;
                        InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        InnerPanelInstance.Height = 0f;
                        InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        InnerPanelInstance.StackSpacing = 32f;
                        InnerPanelInstance.Width = 0f;
                        InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        InnerPanelInstance.X = 0f;
                        InnerPanelInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        InnerPanelInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        InnerPanelInstance.Y = 0f;
                        InnerPanelInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        InnerPanelInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setInnerPanelInstanceHeightFirstValue = false;
            bool setInnerPanelInstanceHeightSecondValue = false;
            float InnerPanelInstanceHeightFirstValue= 0;
            float InnerPanelInstanceHeightSecondValue= 0;
            bool setInnerPanelInstanceStackSpacingFirstValue = false;
            bool setInnerPanelInstanceStackSpacingSecondValue = false;
            float InnerPanelInstanceStackSpacingFirstValue= 0;
            float InnerPanelInstanceStackSpacingSecondValue= 0;
            bool setInnerPanelInstanceWidthFirstValue = false;
            bool setInnerPanelInstanceWidthSecondValue = false;
            float InnerPanelInstanceWidthFirstValue= 0;
            float InnerPanelInstanceWidthSecondValue= 0;
            bool setInnerPanelInstanceXFirstValue = false;
            bool setInnerPanelInstanceXSecondValue = false;
            float InnerPanelInstanceXFirstValue= 0;
            float InnerPanelInstanceXSecondValue= 0;
            bool setInnerPanelInstanceYFirstValue = false;
            bool setInnerPanelInstanceYSecondValue = false;
            float InnerPanelInstanceYFirstValue= 0;
            float InnerPanelInstanceYSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setHeightFirstValue = true;
                    HeightFirstValue = 463f;
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                    }
                    setInnerPanelInstanceHeightFirstValue = true;
                    InnerPanelInstanceHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setInnerPanelInstanceStackSpacingFirstValue = true;
                    InnerPanelInstanceStackSpacingFirstValue = 32f;
                    setInnerPanelInstanceWidthFirstValue = true;
                    InnerPanelInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setInnerPanelInstanceXFirstValue = true;
                    InnerPanelInstanceXFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setInnerPanelInstanceYFirstValue = true;
                    InnerPanelInstanceYFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.PlayerJoinViewItem1.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                    }
                    if (interpolationValue < 1)
                    {
                        this.PlayerJoinViewItem2.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                    }
                    if (interpolationValue < 1)
                    {
                        this.PlayerJoinViewItem3.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                    }
                    if (interpolationValue < 1)
                    {
                        this.PlayerJoinViewItem4.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 144f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setHeightSecondValue = true;
                    HeightSecondValue = 463f;
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                    }
                    setInnerPanelInstanceHeightSecondValue = true;
                    InnerPanelInstanceHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setInnerPanelInstanceStackSpacingSecondValue = true;
                    InnerPanelInstanceStackSpacingSecondValue = 32f;
                    setInnerPanelInstanceWidthSecondValue = true;
                    InnerPanelInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setInnerPanelInstanceXSecondValue = true;
                    InnerPanelInstanceXSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setInnerPanelInstanceYSecondValue = true;
                    InnerPanelInstanceYSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.PlayerJoinViewItem1.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.PlayerJoinViewItem2.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.PlayerJoinViewItem3.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.PlayerJoinViewItem4.Parent = this.GetGraphicalUiElementByName("InnerPanelInstance") ?? this;
                    }
                    setWidthSecondValue = true;
                    WidthSecondValue = 144f;
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setInnerPanelInstanceHeightFirstValue && setInnerPanelInstanceHeightSecondValue)
            {
                InnerPanelInstance.Height = InnerPanelInstanceHeightFirstValue * (1 - interpolationValue) + InnerPanelInstanceHeightSecondValue * interpolationValue;
            }
            if (setInnerPanelInstanceStackSpacingFirstValue && setInnerPanelInstanceStackSpacingSecondValue)
            {
                InnerPanelInstance.StackSpacing = InnerPanelInstanceStackSpacingFirstValue * (1 - interpolationValue) + InnerPanelInstanceStackSpacingSecondValue * interpolationValue;
            }
            if (setInnerPanelInstanceWidthFirstValue && setInnerPanelInstanceWidthSecondValue)
            {
                InnerPanelInstance.Width = InnerPanelInstanceWidthFirstValue * (1 - interpolationValue) + InnerPanelInstanceWidthSecondValue * interpolationValue;
            }
            if (setInnerPanelInstanceXFirstValue && setInnerPanelInstanceXSecondValue)
            {
                InnerPanelInstance.X = InnerPanelInstanceXFirstValue * (1 - interpolationValue) + InnerPanelInstanceXSecondValue * interpolationValue;
            }
            if (setInnerPanelInstanceYFirstValue && setInnerPanelInstanceYSecondValue)
            {
                InnerPanelInstance.Y = InnerPanelInstanceYFirstValue * (1 - interpolationValue) + InnerPanelInstanceYSecondValue * interpolationValue;
            }
            if (setWidthFirstValue && setWidthSecondValue)
            {
                Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.PlayerJoinViewRuntime.VariableState fromState,Harvesteer.GumRuntimes.Controls.PlayerJoinViewRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            PlayerJoinViewItem1.StopAnimations();
            PlayerJoinViewItem2.StopAnimations();
            PlayerJoinViewItem3.StopAnimations();
            PlayerJoinViewItem4.StopAnimations();
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
                        Name = "InnerPanelInstance.Children Layout",
                        Type = "ChildrenLayout",
                        Value = InnerPanelInstance.ChildrenLayout
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Height",
                        Type = "float",
                        Value = InnerPanelInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = InnerPanelInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.StackSpacing",
                        Type = "float",
                        Value = InnerPanelInstance.StackSpacing
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Width",
                        Type = "float",
                        Value = InnerPanelInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = InnerPanelInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.X",
                        Type = "float",
                        Value = InnerPanelInstance.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = InnerPanelInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.X Units",
                        Type = "PositionUnitType",
                        Value = InnerPanelInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Y",
                        Type = "float",
                        Value = InnerPanelInstance.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = InnerPanelInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = InnerPanelInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlayerJoinViewItem1.Parent",
                        Type = "string",
                        Value = PlayerJoinViewItem1.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlayerJoinViewItem2.Parent",
                        Type = "string",
                        Value = PlayerJoinViewItem2.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlayerJoinViewItem3.Parent",
                        Type = "string",
                        Value = PlayerJoinViewItem3.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlayerJoinViewItem4.Parent",
                        Type = "string",
                        Value = PlayerJoinViewItem4.Parent
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
                        Value = Height + 463f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width + 144f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Children Layout",
                        Type = "ChildrenLayout",
                        Value = InnerPanelInstance.ChildrenLayout
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Height",
                        Type = "float",
                        Value = InnerPanelInstance.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = InnerPanelInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.StackSpacing",
                        Type = "float",
                        Value = InnerPanelInstance.StackSpacing + 32f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Width",
                        Type = "float",
                        Value = InnerPanelInstance.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = InnerPanelInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.X",
                        Type = "float",
                        Value = InnerPanelInstance.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = InnerPanelInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.X Units",
                        Type = "PositionUnitType",
                        Value = InnerPanelInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Y",
                        Type = "float",
                        Value = InnerPanelInstance.Y + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = InnerPanelInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = InnerPanelInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlayerJoinViewItem1.Parent",
                        Type = "string",
                        Value = PlayerJoinViewItem1.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlayerJoinViewItem2.Parent",
                        Type = "string",
                        Value = PlayerJoinViewItem2.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlayerJoinViewItem3.Parent",
                        Type = "string",
                        Value = PlayerJoinViewItem3.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlayerJoinViewItem4.Parent",
                        Type = "string",
                        Value = PlayerJoinViewItem4.Parent
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
        public Harvesteer.GumRuntimes.ContainerRuntime InnerPanelInstance { get; set; }
        public Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime PlayerJoinViewItem1 { get; set; }
        public Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime PlayerJoinViewItem2 { get; set; }
        public Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime PlayerJoinViewItem3 { get; set; }
        public Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime PlayerJoinViewItem4 { get; set; }
        public event FlatRedBall.Gui.WindowEvent PlayerJoinViewItem1Click;
        public event FlatRedBall.Gui.WindowEvent PlayerJoinViewItem2Click;
        public event FlatRedBall.Gui.WindowEvent PlayerJoinViewItem3Click;
        public event FlatRedBall.Gui.WindowEvent PlayerJoinViewItem4Click;
        public PlayerJoinViewRuntime () 
        	: this(true, true)
        {
        }
        public PlayerJoinViewRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/PlayerJoinView");
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
            InnerPanelInstance = this.GetGraphicalUiElementByName("InnerPanelInstance") as Harvesteer.GumRuntimes.ContainerRuntime;
            PlayerJoinViewItem1 = this.GetGraphicalUiElementByName("PlayerJoinViewItem1") as Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime;
            PlayerJoinViewItem2 = this.GetGraphicalUiElementByName("PlayerJoinViewItem2") as Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime;
            PlayerJoinViewItem3 = this.GetGraphicalUiElementByName("PlayerJoinViewItem3") as Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime;
            PlayerJoinViewItem4 = this.GetGraphicalUiElementByName("PlayerJoinViewItem4") as Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime;
            PlayerJoinViewItem1.Click += (unused) => PlayerJoinViewItem1Click?.Invoke(this);
            PlayerJoinViewItem2.Click += (unused) => PlayerJoinViewItem2Click?.Invoke(this);
            PlayerJoinViewItem3.Click += (unused) => PlayerJoinViewItem3Click?.Invoke(this);
            PlayerJoinViewItem4.Click += (unused) => PlayerJoinViewItem4Click?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.Games.PlayerJoinView(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.Games.PlayerJoinView FormsControl {get => (FlatRedBall.Forms.Controls.Games.PlayerJoinView) FormsControlAsObject;}
    }
}
