using System.Linq;
namespace Harvesteer.GumRuntimes.Controls
{
    public partial class SliderRuntime : Harvesteer.GumRuntimes.ContainerRuntime, Harvesteer.GumRuntimes.ISliderBehavior
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
        public enum SliderCategory
        {
            Enabled,
            Focused,
            Highlighted,
            HighlightedFocused
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        SliderCategory? mCurrentSliderCategoryState;
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
                        NineSliceInstance.Parent = this.GetGraphicalUiElementByName("TrackInstance") ?? this;
                        ThumbInstance.Parent = this.GetGraphicalUiElementByName("TrackInstance") ?? this;
                        NineSliceInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                        NineSliceInstance.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                        FocusedIndicator.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Warning;
                        FocusedIndicator.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                        Height = 24f;
                        Width = 128f;
                        TrackInstance.Height = 0f;
                        TrackInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        TrackInstance.Width = -32f;
                        TrackInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        TrackInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        TrackInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        TrackInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TrackInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        NineSliceInstance.Height = 8f;
                        NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        NineSliceInstance.Width = 0f;
                        ThumbInstance.ButtonDisplayText = "";
                        ThumbInstance.Height = 24f;
                        ThumbInstance.Width = 32f;
                        ThumbInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        ThumbInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                        ThumbInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        ThumbInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        FocusedIndicator.Height = 2f;
                        FocusedIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        FocusedIndicator.Visible = false;
                        FocusedIndicator.Y = 2f;
                        FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        break;
                }
            }
        }
        public SliderCategory? CurrentSliderCategoryState
        {
            get
            {
                return mCurrentSliderCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentSliderCategoryState = value;
                    switch(mCurrentSliderCategoryState)
                    {
                        case  SliderCategory.Enabled:
                            ThumbInstance.CurrentButtonCategoryState = Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Enabled;
                            FocusedIndicator.Visible = false;
                            break;
                        case  SliderCategory.Focused:
                            ThumbInstance.CurrentButtonCategoryState = Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Enabled;
                            FocusedIndicator.Visible = true;
                            break;
                        case  SliderCategory.Highlighted:
                            ThumbInstance.CurrentButtonCategoryState = Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Highlighted;
                            FocusedIndicator.Visible = false;
                            break;
                        case  SliderCategory.HighlightedFocused:
                            ThumbInstance.CurrentButtonCategoryState = Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Highlighted;
                            FocusedIndicator.Visible = true;
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
            bool setFocusedIndicatorCurrentColorCategoryStateFirstValue = false;
            bool setFocusedIndicatorCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory FocusedIndicatorCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory FocusedIndicatorCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setFocusedIndicatorHeightFirstValue = false;
            bool setFocusedIndicatorHeightSecondValue = false;
            float FocusedIndicatorHeightFirstValue= 0;
            float FocusedIndicatorHeightSecondValue= 0;
            bool setFocusedIndicatorCurrentStyleCategoryStateFirstValue = false;
            bool setFocusedIndicatorCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory FocusedIndicatorCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory FocusedIndicatorCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setFocusedIndicatorYFirstValue = false;
            bool setFocusedIndicatorYSecondValue = false;
            float FocusedIndicatorYFirstValue= 0;
            float FocusedIndicatorYSecondValue= 0;
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setNineSliceInstanceCurrentColorCategoryStateFirstValue = false;
            bool setNineSliceInstanceCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setNineSliceInstanceHeightFirstValue = false;
            bool setNineSliceInstanceHeightSecondValue = false;
            float NineSliceInstanceHeightFirstValue= 0;
            float NineSliceInstanceHeightSecondValue= 0;
            bool setNineSliceInstanceCurrentStyleCategoryStateFirstValue = false;
            bool setNineSliceInstanceCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory NineSliceInstanceCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory NineSliceInstanceCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setNineSliceInstanceWidthFirstValue = false;
            bool setNineSliceInstanceWidthSecondValue = false;
            float NineSliceInstanceWidthFirstValue= 0;
            float NineSliceInstanceWidthSecondValue= 0;
            bool setThumbInstanceHeightFirstValue = false;
            bool setThumbInstanceHeightSecondValue = false;
            float ThumbInstanceHeightFirstValue= 0;
            float ThumbInstanceHeightSecondValue= 0;
            bool setThumbInstanceWidthFirstValue = false;
            bool setThumbInstanceWidthSecondValue = false;
            float ThumbInstanceWidthFirstValue= 0;
            float ThumbInstanceWidthSecondValue= 0;
            bool setTrackInstanceHeightFirstValue = false;
            bool setTrackInstanceHeightSecondValue = false;
            float TrackInstanceHeightFirstValue= 0;
            float TrackInstanceHeightSecondValue= 0;
            bool setTrackInstanceWidthFirstValue = false;
            bool setTrackInstanceWidthSecondValue = false;
            float TrackInstanceWidthFirstValue= 0;
            float TrackInstanceWidthSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setFocusedIndicatorCurrentColorCategoryStateFirstValue = true;
                    FocusedIndicatorCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Warning;
                    setFocusedIndicatorHeightFirstValue = true;
                    FocusedIndicatorHeightFirstValue = 2f;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setFocusedIndicatorCurrentStyleCategoryStateFirstValue = true;
                    FocusedIndicatorCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setFocusedIndicatorYFirstValue = true;
                    FocusedIndicatorYFirstValue = 2f;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 24f;
                    setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                    NineSliceInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setNineSliceInstanceHeightFirstValue = true;
                    NineSliceInstanceHeightFirstValue = 8f;
                    if (interpolationValue < 1)
                    {
                        this.NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    if (interpolationValue < 1)
                    {
                        this.NineSliceInstance.Parent = this.GetGraphicalUiElementByName("TrackInstance") ?? this;
                    }
                    setNineSliceInstanceCurrentStyleCategoryStateFirstValue = true;
                    NineSliceInstanceCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setNineSliceInstanceWidthFirstValue = true;
                    NineSliceInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.ButtonDisplayText = "";
                    }
                    setThumbInstanceHeightFirstValue = true;
                    ThumbInstanceHeightFirstValue = 24f;
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.Parent = this.GetGraphicalUiElementByName("TrackInstance") ?? this;
                    }
                    setThumbInstanceWidthFirstValue = true;
                    ThumbInstanceWidthFirstValue = 32f;
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ThumbInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setTrackInstanceHeightFirstValue = true;
                    TrackInstanceHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TrackInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setTrackInstanceWidthFirstValue = true;
                    TrackInstanceWidthFirstValue = -32f;
                    if (interpolationValue < 1)
                    {
                        this.TrackInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TrackInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TrackInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TrackInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TrackInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 128f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setFocusedIndicatorCurrentColorCategoryStateSecondValue = true;
                    FocusedIndicatorCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Warning;
                    setFocusedIndicatorHeightSecondValue = true;
                    FocusedIndicatorHeightSecondValue = 2f;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setFocusedIndicatorCurrentStyleCategoryStateSecondValue = true;
                    FocusedIndicatorCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setFocusedIndicatorYSecondValue = true;
                    FocusedIndicatorYSecondValue = 2f;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 24f;
                    setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                    NineSliceInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setNineSliceInstanceHeightSecondValue = true;
                    NineSliceInstanceHeightSecondValue = 8f;
                    if (interpolationValue >= 1)
                    {
                        this.NineSliceInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.NineSliceInstance.Parent = this.GetGraphicalUiElementByName("TrackInstance") ?? this;
                    }
                    setNineSliceInstanceCurrentStyleCategoryStateSecondValue = true;
                    NineSliceInstanceCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setNineSliceInstanceWidthSecondValue = true;
                    NineSliceInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.ButtonDisplayText = "";
                    }
                    setThumbInstanceHeightSecondValue = true;
                    ThumbInstanceHeightSecondValue = 24f;
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.Parent = this.GetGraphicalUiElementByName("TrackInstance") ?? this;
                    }
                    setThumbInstanceWidthSecondValue = true;
                    ThumbInstanceWidthSecondValue = 32f;
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.XUnits = Gum.Converters.GeneralUnitType.Percentage;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ThumbInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setTrackInstanceHeightSecondValue = true;
                    TrackInstanceHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TrackInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setTrackInstanceWidthSecondValue = true;
                    TrackInstanceWidthSecondValue = -32f;
                    if (interpolationValue >= 1)
                    {
                        this.TrackInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TrackInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TrackInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TrackInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TrackInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
            if (setFocusedIndicatorCurrentColorCategoryStateFirstValue && setFocusedIndicatorCurrentColorCategoryStateSecondValue)
            {
                FocusedIndicator.InterpolateBetween(FocusedIndicatorCurrentColorCategoryStateFirstValue, FocusedIndicatorCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setFocusedIndicatorHeightFirstValue && setFocusedIndicatorHeightSecondValue)
            {
                FocusedIndicator.Height = FocusedIndicatorHeightFirstValue * (1 - interpolationValue) + FocusedIndicatorHeightSecondValue * interpolationValue;
            }
            if (setFocusedIndicatorCurrentStyleCategoryStateFirstValue && setFocusedIndicatorCurrentStyleCategoryStateSecondValue)
            {
                FocusedIndicator.InterpolateBetween(FocusedIndicatorCurrentStyleCategoryStateFirstValue, FocusedIndicatorCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setFocusedIndicatorYFirstValue && setFocusedIndicatorYSecondValue)
            {
                FocusedIndicator.Y = FocusedIndicatorYFirstValue * (1 - interpolationValue) + FocusedIndicatorYSecondValue * interpolationValue;
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setNineSliceInstanceCurrentColorCategoryStateFirstValue && setNineSliceInstanceCurrentColorCategoryStateSecondValue)
            {
                NineSliceInstance.InterpolateBetween(NineSliceInstanceCurrentColorCategoryStateFirstValue, NineSliceInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setNineSliceInstanceHeightFirstValue && setNineSliceInstanceHeightSecondValue)
            {
                NineSliceInstance.Height = NineSliceInstanceHeightFirstValue * (1 - interpolationValue) + NineSliceInstanceHeightSecondValue * interpolationValue;
            }
            if (setNineSliceInstanceCurrentStyleCategoryStateFirstValue && setNineSliceInstanceCurrentStyleCategoryStateSecondValue)
            {
                NineSliceInstance.InterpolateBetween(NineSliceInstanceCurrentStyleCategoryStateFirstValue, NineSliceInstanceCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setNineSliceInstanceWidthFirstValue && setNineSliceInstanceWidthSecondValue)
            {
                NineSliceInstance.Width = NineSliceInstanceWidthFirstValue * (1 - interpolationValue) + NineSliceInstanceWidthSecondValue * interpolationValue;
            }
            if (setThumbInstanceHeightFirstValue && setThumbInstanceHeightSecondValue)
            {
                ThumbInstance.Height = ThumbInstanceHeightFirstValue * (1 - interpolationValue) + ThumbInstanceHeightSecondValue * interpolationValue;
            }
            if (setThumbInstanceWidthFirstValue && setThumbInstanceWidthSecondValue)
            {
                ThumbInstance.Width = ThumbInstanceWidthFirstValue * (1 - interpolationValue) + ThumbInstanceWidthSecondValue * interpolationValue;
            }
            if (setTrackInstanceHeightFirstValue && setTrackInstanceHeightSecondValue)
            {
                TrackInstance.Height = TrackInstanceHeightFirstValue * (1 - interpolationValue) + TrackInstanceHeightSecondValue * interpolationValue;
            }
            if (setTrackInstanceWidthFirstValue && setTrackInstanceWidthSecondValue)
            {
                TrackInstance.Width = TrackInstanceWidthFirstValue * (1 - interpolationValue) + TrackInstanceWidthSecondValue * interpolationValue;
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
        public void InterpolateBetween (SliderCategory firstState, SliderCategory secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setThumbInstanceCurrentButtonCategoryStateFirstValue = false;
            bool setThumbInstanceCurrentButtonCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory ThumbInstanceCurrentButtonCategoryStateFirstValue= Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Enabled;
            Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory ThumbInstanceCurrentButtonCategoryStateSecondValue= Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Enabled;
            switch(firstState)
            {
                case  SliderCategory.Enabled:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setThumbInstanceCurrentButtonCategoryStateFirstValue = true;
                    ThumbInstanceCurrentButtonCategoryStateFirstValue = Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Enabled;
                    break;
                case  SliderCategory.Focused:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setThumbInstanceCurrentButtonCategoryStateFirstValue = true;
                    ThumbInstanceCurrentButtonCategoryStateFirstValue = Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Enabled;
                    break;
                case  SliderCategory.Highlighted:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setThumbInstanceCurrentButtonCategoryStateFirstValue = true;
                    ThumbInstanceCurrentButtonCategoryStateFirstValue = Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Highlighted;
                    break;
                case  SliderCategory.HighlightedFocused:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setThumbInstanceCurrentButtonCategoryStateFirstValue = true;
                    ThumbInstanceCurrentButtonCategoryStateFirstValue = Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Highlighted;
                    break;
            }
            switch(secondState)
            {
                case  SliderCategory.Enabled:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setThumbInstanceCurrentButtonCategoryStateSecondValue = true;
                    ThumbInstanceCurrentButtonCategoryStateSecondValue = Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Enabled;
                    break;
                case  SliderCategory.Focused:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setThumbInstanceCurrentButtonCategoryStateSecondValue = true;
                    ThumbInstanceCurrentButtonCategoryStateSecondValue = Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Enabled;
                    break;
                case  SliderCategory.Highlighted:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setThumbInstanceCurrentButtonCategoryStateSecondValue = true;
                    ThumbInstanceCurrentButtonCategoryStateSecondValue = Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Highlighted;
                    break;
                case  SliderCategory.HighlightedFocused:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setThumbInstanceCurrentButtonCategoryStateSecondValue = true;
                    ThumbInstanceCurrentButtonCategoryStateSecondValue = Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime.ButtonCategory.Highlighted;
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setThumbInstanceCurrentButtonCategoryStateFirstValue && setThumbInstanceCurrentButtonCategoryStateSecondValue)
            {
                ThumbInstance.InterpolateBetween(ThumbInstanceCurrentButtonCategoryStateFirstValue, ThumbInstanceCurrentButtonCategoryStateSecondValue, interpolationValue);
            }
            if (interpolationValue < 1)
            {
                mCurrentSliderCategoryState = firstState;
            }
            else
            {
                mCurrentSliderCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.SliderRuntime.VariableState fromState,Harvesteer.GumRuntimes.Controls.SliderRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.SliderRuntime.SliderCategory fromState,Harvesteer.GumRuntimes.Controls.SliderRuntime.SliderCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (SliderCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "SliderCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentSliderCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (SliderCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentSliderCategoryState = toState;
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
            ThumbInstance.StopAnimations();
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
                        Name = "TrackInstance.Height",
                        Type = "float",
                        Value = TrackInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = TrackInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.Width",
                        Type = "float",
                        Value = TrackInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = TrackInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = TrackInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.X Units",
                        Type = "PositionUnitType",
                        Value = TrackInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = TrackInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = TrackInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.Height",
                        Type = "float",
                        Value = NineSliceInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = NineSliceInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.Parent",
                        Type = "string",
                        Value = NineSliceInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = NineSliceInstance.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.Width",
                        Type = "float",
                        Value = NineSliceInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.ButtonDisplayText",
                        Type = "string",
                        Value = ThumbInstance.ButtonDisplayText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Height",
                        Type = "float",
                        Value = ThumbInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Parent",
                        Type = "string",
                        Value = ThumbInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Width",
                        Type = "float",
                        Value = ThumbInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = ThumbInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.X Units",
                        Type = "PositionUnitType",
                        Value = ThumbInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = ThumbInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = ThumbInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = FocusedIndicator.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Height",
                        Type = "float",
                        Value = FocusedIndicator.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Height Units",
                        Type = "DimensionUnitType",
                        Value = FocusedIndicator.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = FocusedIndicator.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y",
                        Type = "float",
                        Value = FocusedIndicator.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y Origin",
                        Type = "VerticalAlignment",
                        Value = FocusedIndicator.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y Units",
                        Type = "PositionUnitType",
                        Value = FocusedIndicator.YUnits
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
                        Value = Height + 24f
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
                        Name = "TrackInstance.Height",
                        Type = "float",
                        Value = TrackInstance.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = TrackInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.Width",
                        Type = "float",
                        Value = TrackInstance.Width + -32f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = TrackInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = TrackInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.X Units",
                        Type = "PositionUnitType",
                        Value = TrackInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = TrackInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TrackInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = TrackInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.Height",
                        Type = "float",
                        Value = NineSliceInstance.Height + 8f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = NineSliceInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.Parent",
                        Type = "string",
                        Value = NineSliceInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = NineSliceInstance.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.Width",
                        Type = "float",
                        Value = NineSliceInstance.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.ButtonDisplayText",
                        Type = "string",
                        Value = ThumbInstance.ButtonDisplayText
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Height",
                        Type = "float",
                        Value = ThumbInstance.Height + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Parent",
                        Type = "string",
                        Value = ThumbInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Width",
                        Type = "float",
                        Value = ThumbInstance.Width + 32f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = ThumbInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.X Units",
                        Type = "PositionUnitType",
                        Value = ThumbInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = ThumbInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = ThumbInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = FocusedIndicator.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Height",
                        Type = "float",
                        Value = FocusedIndicator.Height + 2f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Height Units",
                        Type = "DimensionUnitType",
                        Value = FocusedIndicator.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = FocusedIndicator.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y",
                        Type = "float",
                        Value = FocusedIndicator.Y + 2f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y Origin",
                        Type = "VerticalAlignment",
                        Value = FocusedIndicator.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y Units",
                        Type = "PositionUnitType",
                        Value = FocusedIndicator.YUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (SliderCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  SliderCategory.Enabled:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.ButtonCategoryState",
                        Type = "ButtonCategory",
                        Value = ThumbInstance.CurrentButtonCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  SliderCategory.Focused:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.ButtonCategoryState",
                        Type = "ButtonCategory",
                        Value = ThumbInstance.CurrentButtonCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  SliderCategory.Highlighted:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.ButtonCategoryState",
                        Type = "string",
                        Value = ThumbInstance.CurrentButtonCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  SliderCategory.HighlightedFocused:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.ButtonCategoryState",
                        Type = "ButtonCategory",
                        Value = ThumbInstance.CurrentButtonCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (SliderCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  SliderCategory.Enabled:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.ButtonCategoryState",
                        Type = "ButtonCategory",
                        Value = ThumbInstance.CurrentButtonCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  SliderCategory.Focused:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.ButtonCategoryState",
                        Type = "ButtonCategory",
                        Value = ThumbInstance.CurrentButtonCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  SliderCategory.Highlighted:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.ButtonCategoryState",
                        Type = "string",
                        Value = ThumbInstance.CurrentButtonCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    break;
                case  SliderCategory.HighlightedFocused:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ThumbInstance.ButtonCategoryState",
                        Type = "ButtonCategory",
                        Value = ThumbInstance.CurrentButtonCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
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
                else if (category.Name == "SliderCategory")
                {
                    if(state.Name == "Enabled") this.mCurrentSliderCategoryState = SliderCategory.Enabled;
                    if(state.Name == "Focused") this.mCurrentSliderCategoryState = SliderCategory.Focused;
                    if(state.Name == "Highlighted") this.mCurrentSliderCategoryState = SliderCategory.Highlighted;
                    if(state.Name == "HighlightedFocused") this.mCurrentSliderCategoryState = SliderCategory.HighlightedFocused;
                }
            }
            base.ApplyState(state);
        }
        Harvesteer.GumRuntimes.ISliderBehavior.SliderCategory Harvesteer.GumRuntimes.ISliderBehavior.CurrentSliderCategoryState
        {
            set
            {
                switch(value)
                {
                    case  Harvesteer.GumRuntimes.ISliderBehavior.SliderCategory.Enabled:
                        this.CurrentSliderCategoryState = SliderCategory.Enabled;
                        break;
                    case  Harvesteer.GumRuntimes.ISliderBehavior.SliderCategory.Focused:
                        this.CurrentSliderCategoryState = SliderCategory.Focused;
                        break;
                    case  Harvesteer.GumRuntimes.ISliderBehavior.SliderCategory.Highlighted:
                        this.CurrentSliderCategoryState = SliderCategory.Highlighted;
                        break;
                    case  Harvesteer.GumRuntimes.ISliderBehavior.SliderCategory.HighlightedFocused:
                        this.CurrentSliderCategoryState = SliderCategory.HighlightedFocused;
                        break;
                }
            }
        }
        private bool tryCreateFormsObject;
        public Harvesteer.GumRuntimes.ContainerRuntime TrackInstance { get; set; }
        public Harvesteer.GumRuntimes.NineSliceRuntime NineSliceInstance { get; set; }
        public Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime ThumbInstance { get; set; }
        public Harvesteer.GumRuntimes.NineSliceRuntime FocusedIndicator { get; set; }
        public float SliderPercent
        {
            get
            {
                return ThumbInstance.X;
            }
            set
            {
                if (ThumbInstance.X != value)
                {
                    ThumbInstance.X = value;
                    SliderPercentChanged?.Invoke(this, null);
                }
            }
        }
        public event FlatRedBall.Gui.WindowEvent ThumbInstanceClick;
        public event System.EventHandler SliderPercentChanged;
        public SliderRuntime () 
        	: this(true, true)
        {
        }
        public SliderRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/Slider");
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
            TrackInstance = this.GetGraphicalUiElementByName("TrackInstance") as Harvesteer.GumRuntimes.ContainerRuntime;
            NineSliceInstance = this.GetGraphicalUiElementByName("NineSliceInstance") as Harvesteer.GumRuntimes.NineSliceRuntime;
            ThumbInstance = this.GetGraphicalUiElementByName("ThumbInstance") as Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime;
            FocusedIndicator = this.GetGraphicalUiElementByName("FocusedIndicator") as Harvesteer.GumRuntimes.NineSliceRuntime;
            ThumbInstance.Click += (unused) => ThumbInstanceClick?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.Slider(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.Slider FormsControl {get => (FlatRedBall.Forms.Controls.Slider) FormsControlAsObject;}
    }
}
