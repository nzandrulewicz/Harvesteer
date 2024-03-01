using System.Linq;
namespace Harvesteer.GumRuntimes.Elements
{
    public partial class PercentBarRuntime : Harvesteer.GumRuntimes.ContainerRuntime
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
        public enum BarDecorCategory
        {
            None,
            CautionLines,
            VerticalLines
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        BarDecorCategory? mCurrentBarDecorCategoryState;
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
                        Bar.Parent = this.GetGraphicalUiElementByName("BarContainer") ?? this;
                        CautionLinesInstance.Parent = this.GetGraphicalUiElementByName("Bar") ?? this;
                        VerticalLinesInstance.Parent = this.GetGraphicalUiElementByName("Bar") ?? this;
                        Background.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                        Background.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                        BarContainer.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
                        BarContainer.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                        Bar.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                        Bar.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                        CautionLinesInstance.LineColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
                        VerticalLinesInstance.LineColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
                        Height = 16f;
                        Width = 128f;
                        BarContainer.Height = -4f;
                        BarContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        BarContainer.Width = -4f;
                        BarContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        BarContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        BarContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        BarContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        BarContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        Bar.Width = 25f;
                        Bar.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                        Bar.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        Bar.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        CautionLinesInstance.Height = 0f;
                        CautionLinesInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        CautionLinesInstance.LineAlpha = 50;
                        CautionLinesInstance.Visible = false;
                        CautionLinesInstance.Width = 0f;
                        CautionLinesInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        VerticalLinesInstance.Height = 0f;
                        VerticalLinesInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        VerticalLinesInstance.LineAlpha = 50;
                        VerticalLinesInstance.Visible = false;
                        VerticalLinesInstance.Width = 0f;
                        VerticalLinesInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        break;
                }
            }
        }
        public BarDecorCategory? CurrentBarDecorCategoryState
        {
            get
            {
                return mCurrentBarDecorCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentBarDecorCategoryState = value;
                    switch(mCurrentBarDecorCategoryState)
                    {
                        case  BarDecorCategory.None:
                            CautionLinesInstance.Visible = false;
                            VerticalLinesInstance.Visible = false;
                            break;
                        case  BarDecorCategory.CautionLines:
                            CautionLinesInstance.Visible = true;
                            VerticalLinesInstance.Visible = false;
                            break;
                        case  BarDecorCategory.VerticalLines:
                            CautionLinesInstance.Visible = false;
                            VerticalLinesInstance.Visible = true;
                            break;
                    }
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
            bool setBackgroundCurrentColorCategoryStateFirstValue = false;
            bool setBackgroundCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory BackgroundCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory BackgroundCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setBackgroundCurrentStyleCategoryStateFirstValue = false;
            bool setBackgroundCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setBarCurrentColorCategoryStateFirstValue = false;
            bool setBarCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory BarCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory BarCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setBarCurrentStyleCategoryStateFirstValue = false;
            bool setBarCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory BarCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory BarCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setBarWidthFirstValue = false;
            bool setBarWidthSecondValue = false;
            float BarWidthFirstValue= 0;
            float BarWidthSecondValue= 0;
            bool setBarContainerCurrentColorCategoryStateFirstValue = false;
            bool setBarContainerCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory BarContainerCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory BarContainerCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setBarContainerHeightFirstValue = false;
            bool setBarContainerHeightSecondValue = false;
            float BarContainerHeightFirstValue= 0;
            float BarContainerHeightSecondValue= 0;
            bool setBarContainerCurrentStyleCategoryStateFirstValue = false;
            bool setBarContainerCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory BarContainerCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory BarContainerCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setBarContainerWidthFirstValue = false;
            bool setBarContainerWidthSecondValue = false;
            float BarContainerWidthFirstValue= 0;
            float BarContainerWidthSecondValue= 0;
            bool setCautionLinesInstanceHeightFirstValue = false;
            bool setCautionLinesInstanceHeightSecondValue = false;
            float CautionLinesInstanceHeightFirstValue= 0;
            float CautionLinesInstanceHeightSecondValue= 0;
            bool setCautionLinesInstanceLineAlphaFirstValue = false;
            bool setCautionLinesInstanceLineAlphaSecondValue = false;
            int CautionLinesInstanceLineAlphaFirstValue= 0;
            int CautionLinesInstanceLineAlphaSecondValue= 0;
            bool setCautionLinesInstanceWidthFirstValue = false;
            bool setCautionLinesInstanceWidthSecondValue = false;
            float CautionLinesInstanceWidthFirstValue= 0;
            float CautionLinesInstanceWidthSecondValue= 0;
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setVerticalLinesInstanceHeightFirstValue = false;
            bool setVerticalLinesInstanceHeightSecondValue = false;
            float VerticalLinesInstanceHeightFirstValue= 0;
            float VerticalLinesInstanceHeightSecondValue= 0;
            bool setVerticalLinesInstanceLineAlphaFirstValue = false;
            bool setVerticalLinesInstanceLineAlphaSecondValue = false;
            int VerticalLinesInstanceLineAlphaFirstValue= 0;
            int VerticalLinesInstanceLineAlphaSecondValue= 0;
            bool setVerticalLinesInstanceWidthFirstValue = false;
            bool setVerticalLinesInstanceWidthSecondValue = false;
            float VerticalLinesInstanceWidthFirstValue= 0;
            float VerticalLinesInstanceWidthSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setBackgroundCurrentStyleCategoryStateFirstValue = true;
                    BackgroundCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setBarCurrentColorCategoryStateFirstValue = true;
                    BarCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue < 1)
                    {
                        this.Bar.Parent = this.GetGraphicalUiElementByName("BarContainer") ?? this;
                    }
                    setBarCurrentStyleCategoryStateFirstValue = true;
                    BarCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                    setBarWidthFirstValue = true;
                    BarWidthFirstValue = 25f;
                    if (interpolationValue < 1)
                    {
                        this.Bar.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Bar.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Bar.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setBarContainerCurrentColorCategoryStateFirstValue = true;
                    BarContainerCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
                    setBarContainerHeightFirstValue = true;
                    BarContainerHeightFirstValue = -4f;
                    if (interpolationValue < 1)
                    {
                        this.BarContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setBarContainerCurrentStyleCategoryStateFirstValue = true;
                    BarContainerCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                    setBarContainerWidthFirstValue = true;
                    BarContainerWidthFirstValue = -4f;
                    if (interpolationValue < 1)
                    {
                        this.BarContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.BarContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.BarContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.BarContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.BarContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setCautionLinesInstanceHeightFirstValue = true;
                    CautionLinesInstanceHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.CautionLinesInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setCautionLinesInstanceLineAlphaFirstValue = true;
                    CautionLinesInstanceLineAlphaFirstValue = 50;
                    if (interpolationValue < 1)
                    {
                        this.CautionLinesInstance.LineColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
                    }
                    if (interpolationValue < 1)
                    {
                        this.CautionLinesInstance.Parent = this.GetGraphicalUiElementByName("Bar") ?? this;
                    }
                    if (interpolationValue < 1)
                    {
                        this.CautionLinesInstance.Visible = false;
                    }
                    setCautionLinesInstanceWidthFirstValue = true;
                    CautionLinesInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.CautionLinesInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 16f;
                    setVerticalLinesInstanceHeightFirstValue = true;
                    VerticalLinesInstanceHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.VerticalLinesInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setVerticalLinesInstanceLineAlphaFirstValue = true;
                    VerticalLinesInstanceLineAlphaFirstValue = 50;
                    if (interpolationValue < 1)
                    {
                        this.VerticalLinesInstance.LineColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalLinesInstance.Parent = this.GetGraphicalUiElementByName("Bar") ?? this;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalLinesInstance.Visible = false;
                    }
                    setVerticalLinesInstanceWidthFirstValue = true;
                    VerticalLinesInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.VerticalLinesInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 128f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setBackgroundCurrentStyleCategoryStateSecondValue = true;
                    BackgroundCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setBarCurrentColorCategoryStateSecondValue = true;
                    BarCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue >= 1)
                    {
                        this.Bar.Parent = this.GetGraphicalUiElementByName("BarContainer") ?? this;
                    }
                    setBarCurrentStyleCategoryStateSecondValue = true;
                    BarCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                    setBarWidthSecondValue = true;
                    BarWidthSecondValue = 25f;
                    if (interpolationValue >= 1)
                    {
                        this.Bar.WidthUnits = Gum.DataTypes.DimensionUnitType.Percentage;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Bar.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Bar.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setBarContainerCurrentColorCategoryStateSecondValue = true;
                    BarContainerCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
                    setBarContainerHeightSecondValue = true;
                    BarContainerHeightSecondValue = -4f;
                    if (interpolationValue >= 1)
                    {
                        this.BarContainer.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setBarContainerCurrentStyleCategoryStateSecondValue = true;
                    BarContainerCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                    setBarContainerWidthSecondValue = true;
                    BarContainerWidthSecondValue = -4f;
                    if (interpolationValue >= 1)
                    {
                        this.BarContainer.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.BarContainer.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.BarContainer.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.BarContainer.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.BarContainer.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setCautionLinesInstanceHeightSecondValue = true;
                    CautionLinesInstanceHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.CautionLinesInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setCautionLinesInstanceLineAlphaSecondValue = true;
                    CautionLinesInstanceLineAlphaSecondValue = 50;
                    if (interpolationValue >= 1)
                    {
                        this.CautionLinesInstance.LineColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.CautionLinesInstance.Parent = this.GetGraphicalUiElementByName("Bar") ?? this;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.CautionLinesInstance.Visible = false;
                    }
                    setCautionLinesInstanceWidthSecondValue = true;
                    CautionLinesInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.CautionLinesInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 16f;
                    setVerticalLinesInstanceHeightSecondValue = true;
                    VerticalLinesInstanceHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.VerticalLinesInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setVerticalLinesInstanceLineAlphaSecondValue = true;
                    VerticalLinesInstanceLineAlphaSecondValue = 50;
                    if (interpolationValue >= 1)
                    {
                        this.VerticalLinesInstance.LineColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalLinesInstance.Parent = this.GetGraphicalUiElementByName("Bar") ?? this;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalLinesInstance.Visible = false;
                    }
                    setVerticalLinesInstanceWidthSecondValue = true;
                    VerticalLinesInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.VerticalLinesInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
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
            if (setBackgroundCurrentColorCategoryStateFirstValue && setBackgroundCurrentColorCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentColorCategoryStateFirstValue, BackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setBackgroundCurrentStyleCategoryStateFirstValue && setBackgroundCurrentStyleCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentStyleCategoryStateFirstValue, BackgroundCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setBarCurrentColorCategoryStateFirstValue && setBarCurrentColorCategoryStateSecondValue)
            {
                Bar.InterpolateBetween(BarCurrentColorCategoryStateFirstValue, BarCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setBarCurrentStyleCategoryStateFirstValue && setBarCurrentStyleCategoryStateSecondValue)
            {
                Bar.InterpolateBetween(BarCurrentStyleCategoryStateFirstValue, BarCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setBarWidthFirstValue && setBarWidthSecondValue)
            {
                Bar.Width = BarWidthFirstValue * (1 - interpolationValue) + BarWidthSecondValue * interpolationValue;
            }
            if (setBarContainerCurrentColorCategoryStateFirstValue && setBarContainerCurrentColorCategoryStateSecondValue)
            {
                BarContainer.InterpolateBetween(BarContainerCurrentColorCategoryStateFirstValue, BarContainerCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setBarContainerHeightFirstValue && setBarContainerHeightSecondValue)
            {
                BarContainer.Height = BarContainerHeightFirstValue * (1 - interpolationValue) + BarContainerHeightSecondValue * interpolationValue;
            }
            if (setBarContainerCurrentStyleCategoryStateFirstValue && setBarContainerCurrentStyleCategoryStateSecondValue)
            {
                BarContainer.InterpolateBetween(BarContainerCurrentStyleCategoryStateFirstValue, BarContainerCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setBarContainerWidthFirstValue && setBarContainerWidthSecondValue)
            {
                BarContainer.Width = BarContainerWidthFirstValue * (1 - interpolationValue) + BarContainerWidthSecondValue * interpolationValue;
            }
            if (setCautionLinesInstanceHeightFirstValue && setCautionLinesInstanceHeightSecondValue)
            {
                CautionLinesInstance.Height = CautionLinesInstanceHeightFirstValue * (1 - interpolationValue) + CautionLinesInstanceHeightSecondValue * interpolationValue;
            }
            if (setCautionLinesInstanceLineAlphaFirstValue && setCautionLinesInstanceLineAlphaSecondValue)
            {
                CautionLinesInstance.LineAlpha = FlatRedBall.Math.MathFunctions.RoundToInt(CautionLinesInstanceLineAlphaFirstValue* (1 - interpolationValue) + CautionLinesInstanceLineAlphaSecondValue * interpolationValue);
            }
            if (setCautionLinesInstanceWidthFirstValue && setCautionLinesInstanceWidthSecondValue)
            {
                CautionLinesInstance.Width = CautionLinesInstanceWidthFirstValue * (1 - interpolationValue) + CautionLinesInstanceWidthSecondValue * interpolationValue;
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setVerticalLinesInstanceHeightFirstValue && setVerticalLinesInstanceHeightSecondValue)
            {
                VerticalLinesInstance.Height = VerticalLinesInstanceHeightFirstValue * (1 - interpolationValue) + VerticalLinesInstanceHeightSecondValue * interpolationValue;
            }
            if (setVerticalLinesInstanceLineAlphaFirstValue && setVerticalLinesInstanceLineAlphaSecondValue)
            {
                VerticalLinesInstance.LineAlpha = FlatRedBall.Math.MathFunctions.RoundToInt(VerticalLinesInstanceLineAlphaFirstValue* (1 - interpolationValue) + VerticalLinesInstanceLineAlphaSecondValue * interpolationValue);
            }
            if (setVerticalLinesInstanceWidthFirstValue && setVerticalLinesInstanceWidthSecondValue)
            {
                VerticalLinesInstance.Width = VerticalLinesInstanceWidthFirstValue * (1 - interpolationValue) + VerticalLinesInstanceWidthSecondValue * interpolationValue;
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
        public void InterpolateBetween (BarDecorCategory firstState, BarDecorCategory secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            switch(firstState)
            {
                case  BarDecorCategory.None:
                    if (interpolationValue < 1)
                    {
                        this.CautionLinesInstance.Visible = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalLinesInstance.Visible = false;
                    }
                    break;
                case  BarDecorCategory.CautionLines:
                    if (interpolationValue < 1)
                    {
                        this.CautionLinesInstance.Visible = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalLinesInstance.Visible = false;
                    }
                    break;
                case  BarDecorCategory.VerticalLines:
                    if (interpolationValue < 1)
                    {
                        this.CautionLinesInstance.Visible = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalLinesInstance.Visible = true;
                    }
                    break;
            }
            switch(secondState)
            {
                case  BarDecorCategory.None:
                    if (interpolationValue >= 1)
                    {
                        this.CautionLinesInstance.Visible = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalLinesInstance.Visible = false;
                    }
                    break;
                case  BarDecorCategory.CautionLines:
                    if (interpolationValue >= 1)
                    {
                        this.CautionLinesInstance.Visible = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalLinesInstance.Visible = false;
                    }
                    break;
                case  BarDecorCategory.VerticalLines:
                    if (interpolationValue >= 1)
                    {
                        this.CautionLinesInstance.Visible = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalLinesInstance.Visible = true;
                    }
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            // all values assigned in this state do not require recursive updates:
            suspendRecursively = false;
            var isSafeToInterpolateWithoutSuppression = true;
            isSafeToInterpolateWithoutSuppression &= CautionLinesInstance.Parent as Gum.Wireframe.GraphicalUiElement == null && CautionLinesInstance.XUnits == Gum.Converters.GeneralUnitType.PixelsFromSmall && CautionLinesInstance.XOrigin == RenderingLibrary.Graphics.HorizontalAlignment.Left;
            isSafeToInterpolateWithoutSuppression &= VerticalLinesInstance.Parent as Gum.Wireframe.GraphicalUiElement == null && VerticalLinesInstance.XUnits == Gum.Converters.GeneralUnitType.PixelsFromSmall && VerticalLinesInstance.XOrigin == RenderingLibrary.Graphics.HorizontalAlignment.Left;
            if(isSafeToInterpolateWithoutSuppression) shouldSuspend = false;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (interpolationValue < 1)
            {
                mCurrentBarDecorCategoryState = firstState;
            }
            else
            {
                mCurrentBarDecorCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Elements.PercentBarRuntime.VariableState fromState,Harvesteer.GumRuntimes.Elements.PercentBarRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Elements.PercentBarRuntime.BarDecorCategory fromState,Harvesteer.GumRuntimes.Elements.PercentBarRuntime.BarDecorCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (BarDecorCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "BarDecorCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentBarDecorCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (BarDecorCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentBarDecorCategoryState = toState;
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
            CautionLinesInstance.StopAnimations();
            VerticalLinesInstance.StopAnimations();
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
                        Name = "Background.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Background.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = Background.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = BarContainer.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.Height",
                        Type = "float",
                        Value = BarContainer.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.Height Units",
                        Type = "DimensionUnitType",
                        Value = BarContainer.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = BarContainer.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.Width",
                        Type = "float",
                        Value = BarContainer.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.Width Units",
                        Type = "DimensionUnitType",
                        Value = BarContainer.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.X Origin",
                        Type = "HorizontalAlignment",
                        Value = BarContainer.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.X Units",
                        Type = "PositionUnitType",
                        Value = BarContainer.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.Y Origin",
                        Type = "VerticalAlignment",
                        Value = BarContainer.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.Y Units",
                        Type = "PositionUnitType",
                        Value = BarContainer.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Bar.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.Parent",
                        Type = "string",
                        Value = Bar.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = Bar.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.Width",
                        Type = "float",
                        Value = Bar.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.Width Units",
                        Type = "DimensionUnitType",
                        Value = Bar.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.X Origin",
                        Type = "HorizontalAlignment",
                        Value = Bar.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.X Units",
                        Type = "PositionUnitType",
                        Value = Bar.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Height",
                        Type = "float",
                        Value = CautionLinesInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = CautionLinesInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.LineAlpha",
                        Type = "int",
                        Value = CautionLinesInstance.LineAlpha
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.LineColor",
                        Type = "ColorCategory",
                        Value = CautionLinesInstance.LineColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Parent",
                        Type = "string",
                        Value = CautionLinesInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Visible",
                        Type = "bool",
                        Value = CautionLinesInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Width",
                        Type = "float",
                        Value = CautionLinesInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = CautionLinesInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Height",
                        Type = "float",
                        Value = VerticalLinesInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = VerticalLinesInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.LineAlpha",
                        Type = "int",
                        Value = VerticalLinesInstance.LineAlpha
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.LineColor",
                        Type = "ColorCategory",
                        Value = VerticalLinesInstance.LineColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Parent",
                        Type = "string",
                        Value = VerticalLinesInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Visible",
                        Type = "bool",
                        Value = VerticalLinesInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Width",
                        Type = "float",
                        Value = VerticalLinesInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = VerticalLinesInstance.WidthUnits
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
                        Name = "Background.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Background.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = Background.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = BarContainer.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.Height",
                        Type = "float",
                        Value = BarContainer.Height + -4f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.Height Units",
                        Type = "DimensionUnitType",
                        Value = BarContainer.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = BarContainer.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.Width",
                        Type = "float",
                        Value = BarContainer.Width + -4f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.Width Units",
                        Type = "DimensionUnitType",
                        Value = BarContainer.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.X Origin",
                        Type = "HorizontalAlignment",
                        Value = BarContainer.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.X Units",
                        Type = "PositionUnitType",
                        Value = BarContainer.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.Y Origin",
                        Type = "VerticalAlignment",
                        Value = BarContainer.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "BarContainer.Y Units",
                        Type = "PositionUnitType",
                        Value = BarContainer.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Bar.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.Parent",
                        Type = "string",
                        Value = Bar.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = Bar.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.Width",
                        Type = "float",
                        Value = Bar.Width + 25f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.Width Units",
                        Type = "DimensionUnitType",
                        Value = Bar.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.X Origin",
                        Type = "HorizontalAlignment",
                        Value = Bar.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Bar.X Units",
                        Type = "PositionUnitType",
                        Value = Bar.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Height",
                        Type = "float",
                        Value = CautionLinesInstance.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = CautionLinesInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.LineAlpha",
                        Type = "int",
                        Value = CautionLinesInstance.LineAlpha + 50
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.LineColor",
                        Type = "ColorCategory",
                        Value = CautionLinesInstance.LineColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Parent",
                        Type = "string",
                        Value = CautionLinesInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Visible",
                        Type = "bool",
                        Value = CautionLinesInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Width",
                        Type = "float",
                        Value = CautionLinesInstance.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = CautionLinesInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Height",
                        Type = "float",
                        Value = VerticalLinesInstance.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = VerticalLinesInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.LineAlpha",
                        Type = "int",
                        Value = VerticalLinesInstance.LineAlpha + 50
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.LineColor",
                        Type = "ColorCategory",
                        Value = VerticalLinesInstance.LineColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Parent",
                        Type = "string",
                        Value = VerticalLinesInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Visible",
                        Type = "bool",
                        Value = VerticalLinesInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Width",
                        Type = "float",
                        Value = VerticalLinesInstance.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = VerticalLinesInstance.WidthUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (BarDecorCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  BarDecorCategory.None:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Visible",
                        Type = "bool",
                        Value = CautionLinesInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Visible",
                        Type = "bool",
                        Value = VerticalLinesInstance.Visible
                    }
                    );
                    break;
                case  BarDecorCategory.CautionLines:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Visible",
                        Type = "bool",
                        Value = CautionLinesInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Visible",
                        Type = "bool",
                        Value = VerticalLinesInstance.Visible
                    }
                    );
                    break;
                case  BarDecorCategory.VerticalLines:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Visible",
                        Type = "bool",
                        Value = CautionLinesInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Visible",
                        Type = "bool",
                        Value = VerticalLinesInstance.Visible
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (BarDecorCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  BarDecorCategory.None:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Visible",
                        Type = "bool",
                        Value = CautionLinesInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Visible",
                        Type = "bool",
                        Value = VerticalLinesInstance.Visible
                    }
                    );
                    break;
                case  BarDecorCategory.CautionLines:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Visible",
                        Type = "bool",
                        Value = CautionLinesInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Visible",
                        Type = "bool",
                        Value = VerticalLinesInstance.Visible
                    }
                    );
                    break;
                case  BarDecorCategory.VerticalLines:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CautionLinesInstance.Visible",
                        Type = "bool",
                        Value = CautionLinesInstance.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalLinesInstance.Visible",
                        Type = "bool",
                        Value = VerticalLinesInstance.Visible
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
                else if (category.Name == "BarDecorCategory")
                {
                    if(state.Name == "None") this.mCurrentBarDecorCategoryState = BarDecorCategory.None;
                    if(state.Name == "CautionLines") this.mCurrentBarDecorCategoryState = BarDecorCategory.CautionLines;
                    if(state.Name == "VerticalLines") this.mCurrentBarDecorCategoryState = BarDecorCategory.VerticalLines;
                }
            }
            base.ApplyState(state);
        }
        public Harvesteer.GumRuntimes.NineSliceRuntime Background { get; set; }
        public Harvesteer.GumRuntimes.NineSliceRuntime BarContainer { get; set; }
        public Harvesteer.GumRuntimes.NineSliceRuntime Bar { get; set; }
        public Harvesteer.GumRuntimes.Elements.CautionLinesRuntime CautionLinesInstance { get; set; }
        public Harvesteer.GumRuntimes.Elements.VerticalLinesRuntime VerticalLinesInstance { get; set; }
        public NineSliceRuntime.ColorCategory? BarColor
        {
            get
            {
                return Bar.CurrentColorCategoryState;
            }
            set
            {
                if (Bar.CurrentColorCategoryState != value)
                {
                    Bar.CurrentColorCategoryState = value;
                    BarColorChanged?.Invoke(this, null);
                }
            }
        }
        public float BarPercent
        {
            get
            {
                return Bar.Width;
            }
            set
            {
                if (Bar.Width != value)
                {
                    Bar.Width = value;
                    BarPercentChanged?.Invoke(this, null);
                }
            }
        }
        public event FlatRedBall.Gui.WindowEvent CautionLinesInstanceClick;
        public event FlatRedBall.Gui.WindowEvent VerticalLinesInstanceClick;
        public event System.EventHandler BarColorChanged;
        public event System.EventHandler BarPercentChanged;
        public PercentBarRuntime () 
        	: this(true, true)
        {
        }
        public PercentBarRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Elements/PercentBar");
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
            Background = this.GetGraphicalUiElementByName("Background") as Harvesteer.GumRuntimes.NineSliceRuntime;
            BarContainer = this.GetGraphicalUiElementByName("BarContainer") as Harvesteer.GumRuntimes.NineSliceRuntime;
            Bar = this.GetGraphicalUiElementByName("Bar") as Harvesteer.GumRuntimes.NineSliceRuntime;
            CautionLinesInstance = this.GetGraphicalUiElementByName("CautionLinesInstance") as Harvesteer.GumRuntimes.Elements.CautionLinesRuntime;
            VerticalLinesInstance = this.GetGraphicalUiElementByName("VerticalLinesInstance") as Harvesteer.GumRuntimes.Elements.VerticalLinesRuntime;
            CautionLinesInstance.Click += (unused) => CautionLinesInstanceClick?.Invoke(this);
            VerticalLinesInstance.Click += (unused) => VerticalLinesInstanceClick?.Invoke(this);
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
    }
}
