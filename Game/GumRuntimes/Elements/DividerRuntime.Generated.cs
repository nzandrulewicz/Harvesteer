using System.Linq;
namespace Harvesteer.GumRuntimes.Elements
{
    public partial class DividerRuntime : Harvesteer.GumRuntimes.ContainerRuntime
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
                        AccentLeft.CurrentColorCategoryState = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                        Line.CurrentColorCategoryState = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                        AccentRight.CurrentColorCategoryState = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                        Height = 0f;
                        HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        Width = 128f;
                        AccentLeft.Height = 100f;
                        AccentLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                        SetProperty("AccentLeft.SourceFile", "UISpriteSheet.png");
                        AccentLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        AccentLeft.TextureHeight = 3;
                        AccentLeft.TextureLeft = 281;
                        AccentLeft.TextureTop = 0;
                        AccentLeft.TextureWidth = 3;
                        AccentLeft.Width = 100f;
                        Line.Height = 100f;
                        Line.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                        SetProperty("Line.SourceFile", "UISpriteSheet.png");
                        Line.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        Line.TextureHeight = 1;
                        Line.TextureLeft = 281;
                        Line.TextureTop = 1;
                        Line.TextureWidth = 3;
                        Line.Width = -10f;
                        Line.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        Line.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        Line.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        Line.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        Line.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        AccentRight.Height = 100f;
                        AccentRight.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                        SetProperty("AccentRight.SourceFile", "UISpriteSheet.png");
                        AccentRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        AccentRight.TextureHeight = 3;
                        AccentRight.TextureLeft = 281;
                        AccentRight.TextureTop = 0;
                        AccentRight.TextureWidth = 3;
                        AccentRight.Width = 100f;
                        AccentRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        AccentRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
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
            bool setAccentLeftCurrentColorCategoryStateFirstValue = false;
            bool setAccentLeftCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory AccentLeftCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory AccentLeftCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            bool setAccentLeftHeightFirstValue = false;
            bool setAccentLeftHeightSecondValue = false;
            float AccentLeftHeightFirstValue= 0;
            float AccentLeftHeightSecondValue= 0;
            bool setAccentLeftTextureHeightFirstValue = false;
            bool setAccentLeftTextureHeightSecondValue = false;
            int AccentLeftTextureHeightFirstValue= 0;
            int AccentLeftTextureHeightSecondValue= 0;
            bool setAccentLeftTextureLeftFirstValue = false;
            bool setAccentLeftTextureLeftSecondValue = false;
            int AccentLeftTextureLeftFirstValue= 0;
            int AccentLeftTextureLeftSecondValue= 0;
            bool setAccentLeftTextureTopFirstValue = false;
            bool setAccentLeftTextureTopSecondValue = false;
            int AccentLeftTextureTopFirstValue= 0;
            int AccentLeftTextureTopSecondValue= 0;
            bool setAccentLeftTextureWidthFirstValue = false;
            bool setAccentLeftTextureWidthSecondValue = false;
            int AccentLeftTextureWidthFirstValue= 0;
            int AccentLeftTextureWidthSecondValue= 0;
            bool setAccentLeftWidthFirstValue = false;
            bool setAccentLeftWidthSecondValue = false;
            float AccentLeftWidthFirstValue= 0;
            float AccentLeftWidthSecondValue= 0;
            bool setAccentRightCurrentColorCategoryStateFirstValue = false;
            bool setAccentRightCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory AccentRightCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory AccentRightCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            bool setAccentRightHeightFirstValue = false;
            bool setAccentRightHeightSecondValue = false;
            float AccentRightHeightFirstValue= 0;
            float AccentRightHeightSecondValue= 0;
            bool setAccentRightTextureHeightFirstValue = false;
            bool setAccentRightTextureHeightSecondValue = false;
            int AccentRightTextureHeightFirstValue= 0;
            int AccentRightTextureHeightSecondValue= 0;
            bool setAccentRightTextureLeftFirstValue = false;
            bool setAccentRightTextureLeftSecondValue = false;
            int AccentRightTextureLeftFirstValue= 0;
            int AccentRightTextureLeftSecondValue= 0;
            bool setAccentRightTextureTopFirstValue = false;
            bool setAccentRightTextureTopSecondValue = false;
            int AccentRightTextureTopFirstValue= 0;
            int AccentRightTextureTopSecondValue= 0;
            bool setAccentRightTextureWidthFirstValue = false;
            bool setAccentRightTextureWidthSecondValue = false;
            int AccentRightTextureWidthFirstValue= 0;
            int AccentRightTextureWidthSecondValue= 0;
            bool setAccentRightWidthFirstValue = false;
            bool setAccentRightWidthSecondValue = false;
            float AccentRightWidthFirstValue= 0;
            float AccentRightWidthSecondValue= 0;
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setLineCurrentColorCategoryStateFirstValue = false;
            bool setLineCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory LineCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory LineCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            bool setLineHeightFirstValue = false;
            bool setLineHeightSecondValue = false;
            float LineHeightFirstValue= 0;
            float LineHeightSecondValue= 0;
            bool setLineTextureHeightFirstValue = false;
            bool setLineTextureHeightSecondValue = false;
            int LineTextureHeightFirstValue= 0;
            int LineTextureHeightSecondValue= 0;
            bool setLineTextureLeftFirstValue = false;
            bool setLineTextureLeftSecondValue = false;
            int LineTextureLeftFirstValue= 0;
            int LineTextureLeftSecondValue= 0;
            bool setLineTextureTopFirstValue = false;
            bool setLineTextureTopSecondValue = false;
            int LineTextureTopFirstValue= 0;
            int LineTextureTopSecondValue= 0;
            bool setLineTextureWidthFirstValue = false;
            bool setLineTextureWidthSecondValue = false;
            int LineTextureWidthFirstValue= 0;
            int LineTextureWidthSecondValue= 0;
            bool setLineWidthFirstValue = false;
            bool setLineWidthSecondValue = false;
            float LineWidthFirstValue= 0;
            float LineWidthSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setAccentLeftCurrentColorCategoryStateFirstValue = true;
                    AccentLeftCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    setAccentLeftHeightFirstValue = true;
                    AccentLeftHeightFirstValue = 100f;
                    if (interpolationValue < 1)
                    {
                        this.AccentLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                    }
                    if (interpolationValue < 1)
                    {
                        SetProperty("AccentLeft.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue < 1)
                    {
                        this.AccentLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setAccentLeftTextureHeightFirstValue = true;
                    AccentLeftTextureHeightFirstValue = 3;
                    setAccentLeftTextureLeftFirstValue = true;
                    AccentLeftTextureLeftFirstValue = 281;
                    setAccentLeftTextureTopFirstValue = true;
                    AccentLeftTextureTopFirstValue = 0;
                    setAccentLeftTextureWidthFirstValue = true;
                    AccentLeftTextureWidthFirstValue = 3;
                    setAccentLeftWidthFirstValue = true;
                    AccentLeftWidthFirstValue = 100f;
                    setAccentRightCurrentColorCategoryStateFirstValue = true;
                    AccentRightCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    setAccentRightHeightFirstValue = true;
                    AccentRightHeightFirstValue = 100f;
                    if (interpolationValue < 1)
                    {
                        this.AccentRight.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                    }
                    if (interpolationValue < 1)
                    {
                        SetProperty("AccentRight.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue < 1)
                    {
                        this.AccentRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setAccentRightTextureHeightFirstValue = true;
                    AccentRightTextureHeightFirstValue = 3;
                    setAccentRightTextureLeftFirstValue = true;
                    AccentRightTextureLeftFirstValue = 281;
                    setAccentRightTextureTopFirstValue = true;
                    AccentRightTextureTopFirstValue = 0;
                    setAccentRightTextureWidthFirstValue = true;
                    AccentRightTextureWidthFirstValue = 3;
                    setAccentRightWidthFirstValue = true;
                    AccentRightWidthFirstValue = 100f;
                    if (interpolationValue < 1)
                    {
                        this.AccentRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue < 1)
                    {
                        this.AccentRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setLineCurrentColorCategoryStateFirstValue = true;
                    LineCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    setLineHeightFirstValue = true;
                    LineHeightFirstValue = 100f;
                    if (interpolationValue < 1)
                    {
                        this.Line.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                    }
                    if (interpolationValue < 1)
                    {
                        SetProperty("Line.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue < 1)
                    {
                        this.Line.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setLineTextureHeightFirstValue = true;
                    LineTextureHeightFirstValue = 1;
                    setLineTextureLeftFirstValue = true;
                    LineTextureLeftFirstValue = 281;
                    setLineTextureTopFirstValue = true;
                    LineTextureTopFirstValue = 1;
                    setLineTextureWidthFirstValue = true;
                    LineTextureWidthFirstValue = 3;
                    setLineWidthFirstValue = true;
                    LineWidthFirstValue = -10f;
                    if (interpolationValue < 1)
                    {
                        this.Line.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Line.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Line.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Line.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Line.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 128f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setAccentLeftCurrentColorCategoryStateSecondValue = true;
                    AccentLeftCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    setAccentLeftHeightSecondValue = true;
                    AccentLeftHeightSecondValue = 100f;
                    if (interpolationValue >= 1)
                    {
                        this.AccentLeft.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                    }
                    if (interpolationValue >= 1)
                    {
                        SetProperty("AccentLeft.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue >= 1)
                    {
                        this.AccentLeft.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setAccentLeftTextureHeightSecondValue = true;
                    AccentLeftTextureHeightSecondValue = 3;
                    setAccentLeftTextureLeftSecondValue = true;
                    AccentLeftTextureLeftSecondValue = 281;
                    setAccentLeftTextureTopSecondValue = true;
                    AccentLeftTextureTopSecondValue = 0;
                    setAccentLeftTextureWidthSecondValue = true;
                    AccentLeftTextureWidthSecondValue = 3;
                    setAccentLeftWidthSecondValue = true;
                    AccentLeftWidthSecondValue = 100f;
                    setAccentRightCurrentColorCategoryStateSecondValue = true;
                    AccentRightCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    setAccentRightHeightSecondValue = true;
                    AccentRightHeightSecondValue = 100f;
                    if (interpolationValue >= 1)
                    {
                        this.AccentRight.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                    }
                    if (interpolationValue >= 1)
                    {
                        SetProperty("AccentRight.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue >= 1)
                    {
                        this.AccentRight.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setAccentRightTextureHeightSecondValue = true;
                    AccentRightTextureHeightSecondValue = 3;
                    setAccentRightTextureLeftSecondValue = true;
                    AccentRightTextureLeftSecondValue = 281;
                    setAccentRightTextureTopSecondValue = true;
                    AccentRightTextureTopSecondValue = 0;
                    setAccentRightTextureWidthSecondValue = true;
                    AccentRightTextureWidthSecondValue = 3;
                    setAccentRightWidthSecondValue = true;
                    AccentRightWidthSecondValue = 100f;
                    if (interpolationValue >= 1)
                    {
                        this.AccentRight.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.AccentRight.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setLineCurrentColorCategoryStateSecondValue = true;
                    LineCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    setLineHeightSecondValue = true;
                    LineHeightSecondValue = 100f;
                    if (interpolationValue >= 1)
                    {
                        this.Line.HeightUnits = Gum.DataTypes.DimensionUnitType.PercentageOfSourceFile;
                    }
                    if (interpolationValue >= 1)
                    {
                        SetProperty("Line.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Line.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setLineTextureHeightSecondValue = true;
                    LineTextureHeightSecondValue = 1;
                    setLineTextureLeftSecondValue = true;
                    LineTextureLeftSecondValue = 281;
                    setLineTextureTopSecondValue = true;
                    LineTextureTopSecondValue = 1;
                    setLineTextureWidthSecondValue = true;
                    LineTextureWidthSecondValue = 3;
                    setLineWidthSecondValue = true;
                    LineWidthSecondValue = -10f;
                    if (interpolationValue >= 1)
                    {
                        this.Line.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Line.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Line.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Line.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Line.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
            if (setAccentLeftCurrentColorCategoryStateFirstValue && setAccentLeftCurrentColorCategoryStateSecondValue)
            {
                AccentLeft.InterpolateBetween(AccentLeftCurrentColorCategoryStateFirstValue, AccentLeftCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setAccentLeftHeightFirstValue && setAccentLeftHeightSecondValue)
            {
                AccentLeft.Height = AccentLeftHeightFirstValue * (1 - interpolationValue) + AccentLeftHeightSecondValue * interpolationValue;
            }
            if (setAccentLeftTextureHeightFirstValue && setAccentLeftTextureHeightSecondValue)
            {
                AccentLeft.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(AccentLeftTextureHeightFirstValue* (1 - interpolationValue) + AccentLeftTextureHeightSecondValue * interpolationValue);
            }
            if (setAccentLeftTextureLeftFirstValue && setAccentLeftTextureLeftSecondValue)
            {
                AccentLeft.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(AccentLeftTextureLeftFirstValue* (1 - interpolationValue) + AccentLeftTextureLeftSecondValue * interpolationValue);
            }
            if (setAccentLeftTextureTopFirstValue && setAccentLeftTextureTopSecondValue)
            {
                AccentLeft.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(AccentLeftTextureTopFirstValue* (1 - interpolationValue) + AccentLeftTextureTopSecondValue * interpolationValue);
            }
            if (setAccentLeftTextureWidthFirstValue && setAccentLeftTextureWidthSecondValue)
            {
                AccentLeft.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(AccentLeftTextureWidthFirstValue* (1 - interpolationValue) + AccentLeftTextureWidthSecondValue * interpolationValue);
            }
            if (setAccentLeftWidthFirstValue && setAccentLeftWidthSecondValue)
            {
                AccentLeft.Width = AccentLeftWidthFirstValue * (1 - interpolationValue) + AccentLeftWidthSecondValue * interpolationValue;
            }
            if (setAccentRightCurrentColorCategoryStateFirstValue && setAccentRightCurrentColorCategoryStateSecondValue)
            {
                AccentRight.InterpolateBetween(AccentRightCurrentColorCategoryStateFirstValue, AccentRightCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setAccentRightHeightFirstValue && setAccentRightHeightSecondValue)
            {
                AccentRight.Height = AccentRightHeightFirstValue * (1 - interpolationValue) + AccentRightHeightSecondValue * interpolationValue;
            }
            if (setAccentRightTextureHeightFirstValue && setAccentRightTextureHeightSecondValue)
            {
                AccentRight.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(AccentRightTextureHeightFirstValue* (1 - interpolationValue) + AccentRightTextureHeightSecondValue * interpolationValue);
            }
            if (setAccentRightTextureLeftFirstValue && setAccentRightTextureLeftSecondValue)
            {
                AccentRight.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(AccentRightTextureLeftFirstValue* (1 - interpolationValue) + AccentRightTextureLeftSecondValue * interpolationValue);
            }
            if (setAccentRightTextureTopFirstValue && setAccentRightTextureTopSecondValue)
            {
                AccentRight.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(AccentRightTextureTopFirstValue* (1 - interpolationValue) + AccentRightTextureTopSecondValue * interpolationValue);
            }
            if (setAccentRightTextureWidthFirstValue && setAccentRightTextureWidthSecondValue)
            {
                AccentRight.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(AccentRightTextureWidthFirstValue* (1 - interpolationValue) + AccentRightTextureWidthSecondValue * interpolationValue);
            }
            if (setAccentRightWidthFirstValue && setAccentRightWidthSecondValue)
            {
                AccentRight.Width = AccentRightWidthFirstValue * (1 - interpolationValue) + AccentRightWidthSecondValue * interpolationValue;
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setLineCurrentColorCategoryStateFirstValue && setLineCurrentColorCategoryStateSecondValue)
            {
                Line.InterpolateBetween(LineCurrentColorCategoryStateFirstValue, LineCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setLineHeightFirstValue && setLineHeightSecondValue)
            {
                Line.Height = LineHeightFirstValue * (1 - interpolationValue) + LineHeightSecondValue * interpolationValue;
            }
            if (setLineTextureHeightFirstValue && setLineTextureHeightSecondValue)
            {
                Line.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(LineTextureHeightFirstValue* (1 - interpolationValue) + LineTextureHeightSecondValue * interpolationValue);
            }
            if (setLineTextureLeftFirstValue && setLineTextureLeftSecondValue)
            {
                Line.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(LineTextureLeftFirstValue* (1 - interpolationValue) + LineTextureLeftSecondValue * interpolationValue);
            }
            if (setLineTextureTopFirstValue && setLineTextureTopSecondValue)
            {
                Line.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(LineTextureTopFirstValue* (1 - interpolationValue) + LineTextureTopSecondValue * interpolationValue);
            }
            if (setLineTextureWidthFirstValue && setLineTextureWidthSecondValue)
            {
                Line.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(LineTextureWidthFirstValue* (1 - interpolationValue) + LineTextureWidthSecondValue * interpolationValue);
            }
            if (setLineWidthFirstValue && setLineWidthSecondValue)
            {
                Line.Width = LineWidthFirstValue * (1 - interpolationValue) + LineWidthSecondValue * interpolationValue;
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Elements.DividerRuntime.VariableState fromState,Harvesteer.GumRuntimes.Elements.DividerRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                        Name = "AccentLeft.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = AccentLeft.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Height",
                        Type = "float",
                        Value = AccentLeft.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Height Units",
                        Type = "DimensionUnitType",
                        Value = AccentLeft.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.SourceFile",
                        Type = "string",
                        Value = AccentLeft.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Texture Address",
                        Type = "TextureAddress",
                        Value = AccentLeft.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Texture Height",
                        Type = "int",
                        Value = AccentLeft.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Texture Left",
                        Type = "int",
                        Value = AccentLeft.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Texture Top",
                        Type = "int",
                        Value = AccentLeft.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Texture Width",
                        Type = "int",
                        Value = AccentLeft.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Width",
                        Type = "float",
                        Value = AccentLeft.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Line.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Height",
                        Type = "float",
                        Value = Line.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Height Units",
                        Type = "DimensionUnitType",
                        Value = Line.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.SourceFile",
                        Type = "string",
                        Value = Line.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Texture Address",
                        Type = "TextureAddress",
                        Value = Line.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Texture Height",
                        Type = "int",
                        Value = Line.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Texture Left",
                        Type = "int",
                        Value = Line.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Texture Top",
                        Type = "int",
                        Value = Line.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Texture Width",
                        Type = "int",
                        Value = Line.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Width",
                        Type = "float",
                        Value = Line.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Width Units",
                        Type = "DimensionUnitType",
                        Value = Line.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.X Origin",
                        Type = "HorizontalAlignment",
                        Value = Line.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.X Units",
                        Type = "PositionUnitType",
                        Value = Line.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Y Origin",
                        Type = "VerticalAlignment",
                        Value = Line.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Y Units",
                        Type = "PositionUnitType",
                        Value = Line.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = AccentRight.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Height",
                        Type = "float",
                        Value = AccentRight.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Height Units",
                        Type = "DimensionUnitType",
                        Value = AccentRight.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.SourceFile",
                        Type = "string",
                        Value = AccentRight.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Texture Address",
                        Type = "TextureAddress",
                        Value = AccentRight.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Texture Height",
                        Type = "int",
                        Value = AccentRight.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Texture Left",
                        Type = "int",
                        Value = AccentRight.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Texture Top",
                        Type = "int",
                        Value = AccentRight.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Texture Width",
                        Type = "int",
                        Value = AccentRight.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Width",
                        Type = "float",
                        Value = AccentRight.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.X Origin",
                        Type = "HorizontalAlignment",
                        Value = AccentRight.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.X Units",
                        Type = "PositionUnitType",
                        Value = AccentRight.XUnits
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
                        Value = Width + 128f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = AccentLeft.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Height",
                        Type = "float",
                        Value = AccentLeft.Height + 100f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Height Units",
                        Type = "DimensionUnitType",
                        Value = AccentLeft.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.SourceFile",
                        Type = "string",
                        Value = AccentLeft.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Texture Address",
                        Type = "TextureAddress",
                        Value = AccentLeft.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Texture Height",
                        Type = "int",
                        Value = AccentLeft.TextureHeight + 3
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Texture Left",
                        Type = "int",
                        Value = AccentLeft.TextureLeft + 281
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Texture Top",
                        Type = "int",
                        Value = AccentLeft.TextureTop + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Texture Width",
                        Type = "int",
                        Value = AccentLeft.TextureWidth + 3
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentLeft.Width",
                        Type = "float",
                        Value = AccentLeft.Width + 100f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Line.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Height",
                        Type = "float",
                        Value = Line.Height + 100f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Height Units",
                        Type = "DimensionUnitType",
                        Value = Line.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.SourceFile",
                        Type = "string",
                        Value = Line.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Texture Address",
                        Type = "TextureAddress",
                        Value = Line.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Texture Height",
                        Type = "int",
                        Value = Line.TextureHeight + 1
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Texture Left",
                        Type = "int",
                        Value = Line.TextureLeft + 281
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Texture Top",
                        Type = "int",
                        Value = Line.TextureTop + 1
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Texture Width",
                        Type = "int",
                        Value = Line.TextureWidth + 3
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Width",
                        Type = "float",
                        Value = Line.Width + -10f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Width Units",
                        Type = "DimensionUnitType",
                        Value = Line.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.X Origin",
                        Type = "HorizontalAlignment",
                        Value = Line.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.X Units",
                        Type = "PositionUnitType",
                        Value = Line.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Y Origin",
                        Type = "VerticalAlignment",
                        Value = Line.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Line.Y Units",
                        Type = "PositionUnitType",
                        Value = Line.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = AccentRight.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Height",
                        Type = "float",
                        Value = AccentRight.Height + 100f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Height Units",
                        Type = "DimensionUnitType",
                        Value = AccentRight.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.SourceFile",
                        Type = "string",
                        Value = AccentRight.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Texture Address",
                        Type = "TextureAddress",
                        Value = AccentRight.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Texture Height",
                        Type = "int",
                        Value = AccentRight.TextureHeight + 3
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Texture Left",
                        Type = "int",
                        Value = AccentRight.TextureLeft + 281
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Texture Top",
                        Type = "int",
                        Value = AccentRight.TextureTop + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Texture Width",
                        Type = "int",
                        Value = AccentRight.TextureWidth + 3
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.Width",
                        Type = "float",
                        Value = AccentRight.Width + 100f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.X Origin",
                        Type = "HorizontalAlignment",
                        Value = AccentRight.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "AccentRight.X Units",
                        Type = "PositionUnitType",
                        Value = AccentRight.XUnits
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
        public Harvesteer.GumRuntimes.SpriteRuntime AccentLeft { get; set; }
        public Harvesteer.GumRuntimes.SpriteRuntime Line { get; set; }
        public Harvesteer.GumRuntimes.SpriteRuntime AccentRight { get; set; }
        public DividerRuntime () 
        	: this(true, true)
        {
        }
        public DividerRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Elements/Divider");
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
            AccentLeft = this.GetGraphicalUiElementByName("AccentLeft") as Harvesteer.GumRuntimes.SpriteRuntime;
            Line = this.GetGraphicalUiElementByName("Line") as Harvesteer.GumRuntimes.SpriteRuntime;
            AccentRight = this.GetGraphicalUiElementByName("AccentRight") as Harvesteer.GumRuntimes.SpriteRuntime;
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
    }
}
