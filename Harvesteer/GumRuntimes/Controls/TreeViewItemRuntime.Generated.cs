using System.Linq;
namespace Harvesteer.GumRuntimes.Controls
{
    public partial class TreeViewItemRuntime : Harvesteer.GumRuntimes.ContainerRuntime, Harvesteer.GumRuntimes.ITreeViewItemBehavior
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
                        Height = 0f;
                        HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        Width = 0f;
                        WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        ListBoxItemInstance.Height = 24f;
                        ListBoxItemInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        ListBoxItemInstance.Width = -24f;
                        ListBoxItemInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        ListBoxItemInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        InnerPanelInstance.Height = 0f;
                        InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        InnerPanelInstance.Width = -24f;
                        InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        InnerPanelInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        InnerPanelInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        InnerPanelInstance.Y = 24f;
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
            bool setInnerPanelInstanceWidthFirstValue = false;
            bool setInnerPanelInstanceWidthSecondValue = false;
            float InnerPanelInstanceWidthFirstValue= 0;
            float InnerPanelInstanceWidthSecondValue= 0;
            bool setInnerPanelInstanceYFirstValue = false;
            bool setInnerPanelInstanceYSecondValue = false;
            float InnerPanelInstanceYFirstValue= 0;
            float InnerPanelInstanceYSecondValue= 0;
            bool setListBoxItemInstanceHeightFirstValue = false;
            bool setListBoxItemInstanceHeightSecondValue = false;
            float ListBoxItemInstanceHeightFirstValue= 0;
            float ListBoxItemInstanceHeightSecondValue= 0;
            bool setListBoxItemInstanceWidthFirstValue = false;
            bool setListBoxItemInstanceWidthSecondValue = false;
            float ListBoxItemInstanceWidthFirstValue= 0;
            float ListBoxItemInstanceWidthSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setHeightFirstValue = true;
                    HeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                    }
                    setInnerPanelInstanceHeightFirstValue = true;
                    InnerPanelInstanceHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setInnerPanelInstanceWidthFirstValue = true;
                    InnerPanelInstanceWidthFirstValue = -24f;
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setInnerPanelInstanceYFirstValue = true;
                    InnerPanelInstanceYFirstValue = 24f;
                    setListBoxItemInstanceHeightFirstValue = true;
                    ListBoxItemInstanceHeightFirstValue = 24f;
                    if (interpolationValue < 1)
                    {
                        this.ListBoxItemInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setListBoxItemInstanceWidthFirstValue = true;
                    ListBoxItemInstanceWidthFirstValue = -24f;
                    if (interpolationValue < 1)
                    {
                        this.ListBoxItemInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ListBoxItemInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setHeightSecondValue = true;
                    HeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                    }
                    setInnerPanelInstanceHeightSecondValue = true;
                    InnerPanelInstanceHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setInnerPanelInstanceWidthSecondValue = true;
                    InnerPanelInstanceWidthSecondValue = -24f;
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setInnerPanelInstanceYSecondValue = true;
                    InnerPanelInstanceYSecondValue = 24f;
                    setListBoxItemInstanceHeightSecondValue = true;
                    ListBoxItemInstanceHeightSecondValue = 24f;
                    if (interpolationValue >= 1)
                    {
                        this.ListBoxItemInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setListBoxItemInstanceWidthSecondValue = true;
                    ListBoxItemInstanceWidthSecondValue = -24f;
                    if (interpolationValue >= 1)
                    {
                        this.ListBoxItemInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ListBoxItemInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setWidthSecondValue = true;
                    WidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
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
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setInnerPanelInstanceHeightFirstValue && setInnerPanelInstanceHeightSecondValue)
            {
                InnerPanelInstance.Height = InnerPanelInstanceHeightFirstValue * (1 - interpolationValue) + InnerPanelInstanceHeightSecondValue * interpolationValue;
            }
            if (setInnerPanelInstanceWidthFirstValue && setInnerPanelInstanceWidthSecondValue)
            {
                InnerPanelInstance.Width = InnerPanelInstanceWidthFirstValue * (1 - interpolationValue) + InnerPanelInstanceWidthSecondValue * interpolationValue;
            }
            if (setInnerPanelInstanceYFirstValue && setInnerPanelInstanceYSecondValue)
            {
                InnerPanelInstance.Y = InnerPanelInstanceYFirstValue * (1 - interpolationValue) + InnerPanelInstanceYSecondValue * interpolationValue;
            }
            if (setListBoxItemInstanceHeightFirstValue && setListBoxItemInstanceHeightSecondValue)
            {
                ListBoxItemInstance.Height = ListBoxItemInstanceHeightFirstValue * (1 - interpolationValue) + ListBoxItemInstanceHeightSecondValue * interpolationValue;
            }
            if (setListBoxItemInstanceWidthFirstValue && setListBoxItemInstanceWidthSecondValue)
            {
                ListBoxItemInstance.Width = ListBoxItemInstanceWidthFirstValue * (1 - interpolationValue) + ListBoxItemInstanceWidthSecondValue * interpolationValue;
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.TreeViewItemRuntime.VariableState fromState,Harvesteer.GumRuntimes.Controls.TreeViewItemRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
            ToggleButtonInstance.StopAnimations();
            ListBoxItemInstance.StopAnimations();
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
                        Name = "Height Units",
                        Type = "DimensionUnitType",
                        Value = HeightUnits
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
                        Name = "Width Units",
                        Type = "DimensionUnitType",
                        Value = WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.Height",
                        Type = "float",
                        Value = ListBoxItemInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = ListBoxItemInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.Width",
                        Type = "float",
                        Value = ListBoxItemInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = ListBoxItemInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.X Units",
                        Type = "PositionUnitType",
                        Value = ListBoxItemInstance.XUnits
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
                        Value = Height + 0f
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
                        Name = "Width",
                        Type = "float",
                        Value = Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width Units",
                        Type = "DimensionUnitType",
                        Value = WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.Height",
                        Type = "float",
                        Value = ListBoxItemInstance.Height + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = ListBoxItemInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.Width",
                        Type = "float",
                        Value = ListBoxItemInstance.Width + -24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = ListBoxItemInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ListBoxItemInstance.X Units",
                        Type = "PositionUnitType",
                        Value = ListBoxItemInstance.XUnits
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
                        Name = "InnerPanelInstance.Width",
                        Type = "float",
                        Value = InnerPanelInstance.Width + -24f
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
                        Value = InnerPanelInstance.Y + 24f
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
        public Harvesteer.GumRuntimes.Controls.TreeViewToggleRuntime ToggleButtonInstance { get; set; }
        public Harvesteer.GumRuntimes.Controls.ListBoxItemRuntime ListBoxItemInstance { get; set; }
        public Harvesteer.GumRuntimes.ContainerRuntime InnerPanelInstance { get; set; }
        public event FlatRedBall.Gui.WindowEvent ToggleButtonInstanceClick;
        public event FlatRedBall.Gui.WindowEvent ListBoxItemInstanceClick;
        public TreeViewItemRuntime () 
        	: this(true, true)
        {
        }
        public TreeViewItemRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/TreeViewItem");
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
            ToggleButtonInstance = this.GetGraphicalUiElementByName("ToggleButtonInstance") as Harvesteer.GumRuntimes.Controls.TreeViewToggleRuntime;
            ListBoxItemInstance = this.GetGraphicalUiElementByName("ListBoxItemInstance") as Harvesteer.GumRuntimes.Controls.ListBoxItemRuntime;
            InnerPanelInstance = this.GetGraphicalUiElementByName("InnerPanelInstance") as Harvesteer.GumRuntimes.ContainerRuntime;
            ToggleButtonInstance.Click += (unused) => ToggleButtonInstanceClick?.Invoke(this);
            ListBoxItemInstance.Click += (unused) => ListBoxItemInstanceClick?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.TreeViewItem(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.TreeViewItem FormsControl {get => (FlatRedBall.Forms.Controls.TreeViewItem) FormsControlAsObject;}
    }
}
