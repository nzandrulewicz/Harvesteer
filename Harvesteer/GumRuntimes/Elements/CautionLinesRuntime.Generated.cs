using System.Linq;
namespace Harvesteer.GumRuntimes.Elements
{
    public partial class CautionLinesRuntime : Harvesteer.GumRuntimes.ContainerRuntime
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
                        ClipsChildren = true;
                        Height = 16f;
                        Width = 128f;
                        SetProperty("LinesSprite.SourceFile", "UISpriteSheet.png");
                        LinesSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        LinesSprite.TextureHeight = 32;
                        LinesSprite.TextureLeft = 0;
                        LinesSprite.TextureTop = 992;
                        LinesSprite.TextureWidth = 1024;
                        LinesSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        LinesSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        LinesSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
            bool setLinesSpriteTextureHeightFirstValue = false;
            bool setLinesSpriteTextureHeightSecondValue = false;
            int LinesSpriteTextureHeightFirstValue= 0;
            int LinesSpriteTextureHeightSecondValue= 0;
            bool setLinesSpriteTextureLeftFirstValue = false;
            bool setLinesSpriteTextureLeftSecondValue = false;
            int LinesSpriteTextureLeftFirstValue= 0;
            int LinesSpriteTextureLeftSecondValue= 0;
            bool setLinesSpriteTextureTopFirstValue = false;
            bool setLinesSpriteTextureTopSecondValue = false;
            int LinesSpriteTextureTopFirstValue= 0;
            int LinesSpriteTextureTopSecondValue= 0;
            bool setLinesSpriteTextureWidthFirstValue = false;
            bool setLinesSpriteTextureWidthSecondValue = false;
            int LinesSpriteTextureWidthFirstValue= 0;
            int LinesSpriteTextureWidthSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    if (interpolationValue < 1)
                    {
                        this.ClipsChildren = true;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 16f;
                    if (interpolationValue < 1)
                    {
                        SetProperty("LinesSprite.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue < 1)
                    {
                        this.LinesSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setLinesSpriteTextureHeightFirstValue = true;
                    LinesSpriteTextureHeightFirstValue = 32;
                    setLinesSpriteTextureLeftFirstValue = true;
                    LinesSpriteTextureLeftFirstValue = 0;
                    setLinesSpriteTextureTopFirstValue = true;
                    LinesSpriteTextureTopFirstValue = 992;
                    setLinesSpriteTextureWidthFirstValue = true;
                    LinesSpriteTextureWidthFirstValue = 1024;
                    if (interpolationValue < 1)
                    {
                        this.LinesSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.LinesSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.LinesSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 128f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    if (interpolationValue >= 1)
                    {
                        this.ClipsChildren = true;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 16f;
                    if (interpolationValue >= 1)
                    {
                        SetProperty("LinesSprite.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue >= 1)
                    {
                        this.LinesSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setLinesSpriteTextureHeightSecondValue = true;
                    LinesSpriteTextureHeightSecondValue = 32;
                    setLinesSpriteTextureLeftSecondValue = true;
                    LinesSpriteTextureLeftSecondValue = 0;
                    setLinesSpriteTextureTopSecondValue = true;
                    LinesSpriteTextureTopSecondValue = 992;
                    setLinesSpriteTextureWidthSecondValue = true;
                    LinesSpriteTextureWidthSecondValue = 1024;
                    if (interpolationValue >= 1)
                    {
                        this.LinesSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.LinesSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.LinesSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthSecondValue = true;
                    WidthSecondValue = 128f;
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
            if (setLinesSpriteTextureHeightFirstValue && setLinesSpriteTextureHeightSecondValue)
            {
                LinesSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(LinesSpriteTextureHeightFirstValue* (1 - interpolationValue) + LinesSpriteTextureHeightSecondValue * interpolationValue);
            }
            if (setLinesSpriteTextureLeftFirstValue && setLinesSpriteTextureLeftSecondValue)
            {
                LinesSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(LinesSpriteTextureLeftFirstValue* (1 - interpolationValue) + LinesSpriteTextureLeftSecondValue * interpolationValue);
            }
            if (setLinesSpriteTextureTopFirstValue && setLinesSpriteTextureTopSecondValue)
            {
                LinesSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(LinesSpriteTextureTopFirstValue* (1 - interpolationValue) + LinesSpriteTextureTopSecondValue * interpolationValue);
            }
            if (setLinesSpriteTextureWidthFirstValue && setLinesSpriteTextureWidthSecondValue)
            {
                LinesSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(LinesSpriteTextureWidthFirstValue* (1 - interpolationValue) + LinesSpriteTextureWidthSecondValue * interpolationValue);
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Elements.CautionLinesRuntime.VariableState fromState,Harvesteer.GumRuntimes.Elements.CautionLinesRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                        Name = "Clips Children",
                        Type = "bool",
                        Value = ClipsChildren
                    }
                    );
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
                        Name = "LinesSprite.SourceFile",
                        Type = "string",
                        Value = LinesSprite.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Texture Address",
                        Type = "TextureAddress",
                        Value = LinesSprite.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Texture Height",
                        Type = "int",
                        Value = LinesSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Texture Left",
                        Type = "int",
                        Value = LinesSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Texture Top",
                        Type = "int",
                        Value = LinesSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Texture Width",
                        Type = "int",
                        Value = LinesSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.X Origin",
                        Type = "HorizontalAlignment",
                        Value = LinesSprite.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Y Origin",
                        Type = "VerticalAlignment",
                        Value = LinesSprite.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Y Units",
                        Type = "PositionUnitType",
                        Value = LinesSprite.YUnits
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
                        Name = "Clips Children",
                        Type = "bool",
                        Value = ClipsChildren
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height",
                        Type = "float",
                        Value = Height + 16f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width + 128f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.SourceFile",
                        Type = "string",
                        Value = LinesSprite.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Texture Address",
                        Type = "TextureAddress",
                        Value = LinesSprite.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Texture Height",
                        Type = "int",
                        Value = LinesSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Texture Left",
                        Type = "int",
                        Value = LinesSprite.TextureLeft + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Texture Top",
                        Type = "int",
                        Value = LinesSprite.TextureTop + 992
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Texture Width",
                        Type = "int",
                        Value = LinesSprite.TextureWidth + 1024
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.X Origin",
                        Type = "HorizontalAlignment",
                        Value = LinesSprite.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Y Origin",
                        Type = "VerticalAlignment",
                        Value = LinesSprite.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LinesSprite.Y Units",
                        Type = "PositionUnitType",
                        Value = LinesSprite.YUnits
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
        public Harvesteer.GumRuntimes.SpriteRuntime LinesSprite { get; set; }
        public int LineAlpha
        {
            get
            {
                return LinesSprite.Alpha;
            }
            set
            {
                if (LinesSprite.Alpha != value)
                {
                    LinesSprite.Alpha = value;
                    LineAlphaChanged?.Invoke(this, null);
                }
            }
        }
        public SpriteRuntime.ColorCategory? LineColor
        {
            get
            {
                return LinesSprite.CurrentColorCategoryState;
            }
            set
            {
                if (LinesSprite.CurrentColorCategoryState != value)
                {
                    LinesSprite.CurrentColorCategoryState = value;
                    LineColorChanged?.Invoke(this, null);
                }
            }
        }
        public event System.EventHandler LineAlphaChanged;
        public event System.EventHandler LineColorChanged;
        public CautionLinesRuntime () 
        	: this(true, true)
        {
        }
        public CautionLinesRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Elements/CautionLines");
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
            LinesSprite = this.GetGraphicalUiElementByName("LinesSprite") as Harvesteer.GumRuntimes.SpriteRuntime;
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
    }
}
