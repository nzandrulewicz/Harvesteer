using System.Linq;
namespace Harvesteer.GumRuntimes.Controls
{
    public partial class RadioButtonRuntime : Harvesteer.GumRuntimes.ContainerRuntime, Harvesteer.GumRuntimes.IRadioButtonBehavior
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
        public enum RadioButtonCategory
        {
            EnabledOn,
            EnabledOff,
            DisabledOn,
            DisabledOff,
            HighlightedOn,
            HighlightedOff,
            PushedOn,
            PushedOff,
            FocusedOn,
            FocusedOff,
            HighlightedFocusedOn,
            HighlightedFocusedOff,
            DisabledFocusedOn,
            DisabledFocusedOff
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        RadioButtonCategory? mCurrentRadioButtonCategoryState;
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
                        Radio.Parent = this.GetGraphicalUiElementByName("RadioBackground") ?? this;
                        RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                        RadioBackground.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                        Radio.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.Circle2;
                        Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                        TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                        TextInstance.CurrentStyleCategoryState = Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Normal;
                        FocusedIndicator.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Warning;
                        FocusedIndicator.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                        Height = 24f;
                        Width = 128f;
                        RadioBackground.Height = 24f;
                        RadioBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        RadioBackground.Width = 24f;
                        RadioBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        RadioBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        RadioBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        RadioBackground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        RadioBackground.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        Radio.Height = 0f;
                        Radio.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        Radio.Width = 0f;
                        Radio.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        TextInstance.Text = "Radio Label";
                        TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TextInstance.Width = -28f;
                        TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
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
        public RadioButtonCategory? CurrentRadioButtonCategoryState
        {
            get
            {
                return mCurrentRadioButtonCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentRadioButtonCategoryState = value;
                    switch(mCurrentRadioButtonCategoryState)
                    {
                        case  RadioButtonCategory.EnabledOn:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                            Radio.Visible = true;
                            FocusedIndicator.Visible = false;
                            break;
                        case  RadioButtonCategory.EnabledOff:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                            Radio.Visible = false;
                            FocusedIndicator.Visible = false;
                            break;
                        case  RadioButtonCategory.DisabledOn:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            Radio.Visible = true;
                            FocusedIndicator.Visible = false;
                            break;
                        case  RadioButtonCategory.DisabledOff:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            Radio.Visible = false;
                            FocusedIndicator.Visible = false;
                            break;
                        case  RadioButtonCategory.HighlightedOn:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                            Radio.Visible = true;
                            FocusedIndicator.Visible = false;
                            break;
                        case  RadioButtonCategory.HighlightedOff:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                            Radio.Visible = false;
                            FocusedIndicator.Visible = false;
                            break;
                        case  RadioButtonCategory.PushedOn:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                            Radio.Visible = true;
                            FocusedIndicator.Visible = false;
                            break;
                        case  RadioButtonCategory.PushedOff:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                            Radio.Visible = false;
                            FocusedIndicator.Visible = false;
                            break;
                        case  RadioButtonCategory.FocusedOn:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                            Radio.Visible = true;
                            FocusedIndicator.Visible = true;
                            break;
                        case  RadioButtonCategory.FocusedOff:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                            Radio.Visible = false;
                            FocusedIndicator.Visible = true;
                            break;
                        case  RadioButtonCategory.HighlightedFocusedOn:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                            Radio.Visible = true;
                            FocusedIndicator.Visible = true;
                            break;
                        case  RadioButtonCategory.HighlightedFocusedOff:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                            Radio.Visible = false;
                            FocusedIndicator.Visible = true;
                            break;
                        case  RadioButtonCategory.DisabledFocusedOn:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            Radio.Visible = true;
                            FocusedIndicator.Visible = true;
                            break;
                        case  RadioButtonCategory.DisabledFocusedOff:
                            RadioBackground.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                            TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            Radio.Visible = false;
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
            bool setRadioHeightFirstValue = false;
            bool setRadioHeightSecondValue = false;
            float RadioHeightFirstValue= 0;
            float RadioHeightSecondValue= 0;
            bool setRadioCurrentIconCategoryStateFirstValue = false;
            bool setRadioCurrentIconCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory RadioCurrentIconCategoryStateFirstValue= Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory RadioCurrentIconCategoryStateSecondValue= Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            bool setRadioWidthFirstValue = false;
            bool setRadioWidthSecondValue = false;
            float RadioWidthFirstValue= 0;
            float RadioWidthSecondValue= 0;
            bool setRadioBackgroundCurrentColorCategoryStateFirstValue = false;
            bool setRadioBackgroundCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory RadioBackgroundCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory RadioBackgroundCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setRadioBackgroundHeightFirstValue = false;
            bool setRadioBackgroundHeightSecondValue = false;
            float RadioBackgroundHeightFirstValue= 0;
            float RadioBackgroundHeightSecondValue= 0;
            bool setRadioBackgroundCurrentStyleCategoryStateFirstValue = false;
            bool setRadioBackgroundCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory RadioBackgroundCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory RadioBackgroundCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setRadioBackgroundWidthFirstValue = false;
            bool setRadioBackgroundWidthSecondValue = false;
            float RadioBackgroundWidthFirstValue= 0;
            float RadioBackgroundWidthSecondValue= 0;
            bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
            bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Black;
            bool setTextInstanceCurrentStyleCategoryStateFirstValue = false;
            bool setTextInstanceCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.TextRuntime.StyleCategory TextInstanceCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Tiny;
            Harvesteer.GumRuntimes.TextRuntime.StyleCategory TextInstanceCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Tiny;
            bool setTextInstanceWidthFirstValue = false;
            bool setTextInstanceWidthSecondValue = false;
            float TextInstanceWidthFirstValue= 0;
            float TextInstanceWidthSecondValue= 0;
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
                    setRadioHeightFirstValue = true;
                    RadioHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Radio.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setRadioCurrentIconCategoryStateFirstValue = true;
                    RadioCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.Circle2;
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Parent = this.GetGraphicalUiElementByName("RadioBackground") ?? this;
                    }
                    setRadioWidthFirstValue = true;
                    RadioWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Radio.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setRadioBackgroundHeightFirstValue = true;
                    RadioBackgroundHeightFirstValue = 24f;
                    if (interpolationValue < 1)
                    {
                        this.RadioBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setRadioBackgroundCurrentStyleCategoryStateFirstValue = true;
                    RadioBackgroundCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setRadioBackgroundWidthFirstValue = true;
                    RadioBackgroundWidthFirstValue = 24f;
                    if (interpolationValue < 1)
                    {
                        this.RadioBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    if (interpolationValue < 1)
                    {
                        this.RadioBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.RadioBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    if (interpolationValue < 1)
                    {
                        this.RadioBackground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.RadioBackground.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setTextInstanceCurrentStyleCategoryStateFirstValue = true;
                    TextInstanceCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Normal;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.Text = "Radio Label";
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setTextInstanceWidthFirstValue = true;
                    TextInstanceWidthFirstValue = -28f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
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
                    setRadioHeightSecondValue = true;
                    RadioHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Radio.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setRadioCurrentIconCategoryStateSecondValue = true;
                    RadioCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.Circle2;
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Parent = this.GetGraphicalUiElementByName("RadioBackground") ?? this;
                    }
                    setRadioWidthSecondValue = true;
                    RadioWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Radio.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setRadioBackgroundHeightSecondValue = true;
                    RadioBackgroundHeightSecondValue = 24f;
                    if (interpolationValue >= 1)
                    {
                        this.RadioBackground.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setRadioBackgroundCurrentStyleCategoryStateSecondValue = true;
                    RadioBackgroundCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setRadioBackgroundWidthSecondValue = true;
                    RadioBackgroundWidthSecondValue = 24f;
                    if (interpolationValue >= 1)
                    {
                        this.RadioBackground.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.RadioBackground.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.RadioBackground.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.RadioBackground.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.RadioBackground.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setTextInstanceCurrentStyleCategoryStateSecondValue = true;
                    TextInstanceCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Normal;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.Text = "Radio Label";
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setTextInstanceWidthSecondValue = true;
                    TextInstanceWidthSecondValue = -28f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
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
            if (setRadioHeightFirstValue && setRadioHeightSecondValue)
            {
                Radio.Height = RadioHeightFirstValue * (1 - interpolationValue) + RadioHeightSecondValue * interpolationValue;
            }
            if (setRadioCurrentIconCategoryStateFirstValue && setRadioCurrentIconCategoryStateSecondValue)
            {
                Radio.InterpolateBetween(RadioCurrentIconCategoryStateFirstValue, RadioCurrentIconCategoryStateSecondValue, interpolationValue);
            }
            if (setRadioWidthFirstValue && setRadioWidthSecondValue)
            {
                Radio.Width = RadioWidthFirstValue * (1 - interpolationValue) + RadioWidthSecondValue * interpolationValue;
            }
            if (setRadioBackgroundCurrentColorCategoryStateFirstValue && setRadioBackgroundCurrentColorCategoryStateSecondValue)
            {
                RadioBackground.InterpolateBetween(RadioBackgroundCurrentColorCategoryStateFirstValue, RadioBackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setRadioBackgroundHeightFirstValue && setRadioBackgroundHeightSecondValue)
            {
                RadioBackground.Height = RadioBackgroundHeightFirstValue * (1 - interpolationValue) + RadioBackgroundHeightSecondValue * interpolationValue;
            }
            if (setRadioBackgroundCurrentStyleCategoryStateFirstValue && setRadioBackgroundCurrentStyleCategoryStateSecondValue)
            {
                RadioBackground.InterpolateBetween(RadioBackgroundCurrentStyleCategoryStateFirstValue, RadioBackgroundCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setRadioBackgroundWidthFirstValue && setRadioBackgroundWidthSecondValue)
            {
                RadioBackground.Width = RadioBackgroundWidthFirstValue * (1 - interpolationValue) + RadioBackgroundWidthSecondValue * interpolationValue;
            }
            if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
            {
                TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstanceCurrentStyleCategoryStateFirstValue && setTextInstanceCurrentStyleCategoryStateSecondValue)
            {
                TextInstance.InterpolateBetween(TextInstanceCurrentStyleCategoryStateFirstValue, TextInstanceCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
            {
                TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
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
        public void InterpolateBetween (RadioButtonCategory firstState, RadioButtonCategory secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setRadioBackgroundCurrentColorCategoryStateFirstValue = false;
            bool setRadioBackgroundCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory RadioBackgroundCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory RadioBackgroundCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
            bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Black;
            switch(firstState)
            {
                case  RadioButtonCategory.EnabledOn:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.EnabledOff:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.DisabledOn:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  RadioButtonCategory.DisabledOff:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  RadioButtonCategory.HighlightedOn:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.HighlightedOff:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.PushedOn:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.PushedOff:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.FocusedOn:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.FocusedOff:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.HighlightedFocusedOn:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.HighlightedFocusedOff:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.DisabledFocusedOn:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  RadioButtonCategory.DisabledFocusedOff:
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateFirstValue = true;
                    RadioBackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
            }
            switch(secondState)
            {
                case  RadioButtonCategory.EnabledOn:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.EnabledOff:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.DisabledOn:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  RadioButtonCategory.DisabledOff:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  RadioButtonCategory.HighlightedOn:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.HighlightedOff:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.PushedOn:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.PushedOff:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.FocusedOn:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.FocusedOff:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.HighlightedFocusedOn:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.HighlightedFocusedOff:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    break;
                case  RadioButtonCategory.DisabledFocusedOn:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = true;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  RadioButtonCategory.DisabledFocusedOff:
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Radio.Visible = false;
                    }
                    setRadioBackgroundCurrentColorCategoryStateSecondValue = true;
                    RadioBackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setRadioBackgroundCurrentColorCategoryStateFirstValue && setRadioBackgroundCurrentColorCategoryStateSecondValue)
            {
                RadioBackground.InterpolateBetween(RadioBackgroundCurrentColorCategoryStateFirstValue, RadioBackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
            {
                TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (interpolationValue < 1)
            {
                mCurrentRadioButtonCategoryState = firstState;
            }
            else
            {
                mCurrentRadioButtonCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.RadioButtonRuntime.VariableState fromState,Harvesteer.GumRuntimes.Controls.RadioButtonRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.RadioButtonRuntime.RadioButtonCategory fromState,Harvesteer.GumRuntimes.Controls.RadioButtonRuntime.RadioButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (RadioButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "RadioButtonCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentRadioButtonCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (RadioButtonCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentRadioButtonCategoryState = toState;
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
            Radio.StopAnimations();
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
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.Height",
                        Type = "float",
                        Value = RadioBackground.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.Height Units",
                        Type = "DimensionUnitType",
                        Value = RadioBackground.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = RadioBackground.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.Width",
                        Type = "float",
                        Value = RadioBackground.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.Width Units",
                        Type = "DimensionUnitType",
                        Value = RadioBackground.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.X Origin",
                        Type = "HorizontalAlignment",
                        Value = RadioBackground.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.X Units",
                        Type = "PositionUnitType",
                        Value = RadioBackground.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.Y Origin",
                        Type = "VerticalAlignment",
                        Value = RadioBackground.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.Y Units",
                        Type = "PositionUnitType",
                        Value = RadioBackground.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Height",
                        Type = "float",
                        Value = Radio.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Height Units",
                        Type = "DimensionUnitType",
                        Value = Radio.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconCategoryState",
                        Type = "IconCategory",
                        Value = Radio.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Parent",
                        Type = "string",
                        Value = Radio.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Width",
                        Type = "float",
                        Value = Radio.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Width Units",
                        Type = "DimensionUnitType",
                        Value = Radio.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = TextInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = TextInstance.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Text",
                        Type = "string",
                        Value = TextInstance.Text
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.VerticalAlignment",
                        Type = "VerticalAlignment",
                        Value = TextInstance.VerticalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Width",
                        Type = "float",
                        Value = TextInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = TextInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = TextInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.X Units",
                        Type = "PositionUnitType",
                        Value = TextInstance.XUnits
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
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.Height",
                        Type = "float",
                        Value = RadioBackground.Height + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.Height Units",
                        Type = "DimensionUnitType",
                        Value = RadioBackground.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = RadioBackground.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.Width",
                        Type = "float",
                        Value = RadioBackground.Width + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.Width Units",
                        Type = "DimensionUnitType",
                        Value = RadioBackground.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.X Origin",
                        Type = "HorizontalAlignment",
                        Value = RadioBackground.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.X Units",
                        Type = "PositionUnitType",
                        Value = RadioBackground.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.Y Origin",
                        Type = "VerticalAlignment",
                        Value = RadioBackground.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.Y Units",
                        Type = "PositionUnitType",
                        Value = RadioBackground.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Height",
                        Type = "float",
                        Value = Radio.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Height Units",
                        Type = "DimensionUnitType",
                        Value = Radio.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconCategoryState",
                        Type = "IconCategory",
                        Value = Radio.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Parent",
                        Type = "string",
                        Value = Radio.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Width",
                        Type = "float",
                        Value = Radio.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Width Units",
                        Type = "DimensionUnitType",
                        Value = Radio.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = TextInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = TextInstance.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Text",
                        Type = "string",
                        Value = TextInstance.Text
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.VerticalAlignment",
                        Type = "VerticalAlignment",
                        Value = TextInstance.VerticalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Width",
                        Type = "float",
                        Value = TextInstance.Width + -28f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = TextInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = TextInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.X Units",
                        Type = "PositionUnitType",
                        Value = TextInstance.XUnits
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
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (RadioButtonCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  RadioButtonCategory.EnabledOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.EnabledOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.DisabledOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.DisabledOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.HighlightedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.HighlightedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.PushedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.PushedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.FocusedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.FocusedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.HighlightedFocusedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.HighlightedFocusedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.DisabledFocusedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.DisabledFocusedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (RadioButtonCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  RadioButtonCategory.EnabledOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.EnabledOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.DisabledOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.DisabledOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.HighlightedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.HighlightedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.PushedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.PushedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.FocusedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.FocusedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.HighlightedFocusedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.HighlightedFocusedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.DisabledFocusedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                case  RadioButtonCategory.DisabledFocusedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "RadioBackground.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = RadioBackground.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.IconColor",
                        Type = "ColorCategory",
                        Value = Radio.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Radio.Visible",
                        Type = "bool",
                        Value = Radio.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = TextInstance.CurrentColorCategoryState
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
                else if (category.Name == "RadioButtonCategory")
                {
                    if(state.Name == "EnabledOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.EnabledOn;
                    if(state.Name == "EnabledOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.EnabledOff;
                    if(state.Name == "DisabledOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.DisabledOn;
                    if(state.Name == "DisabledOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.DisabledOff;
                    if(state.Name == "HighlightedOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.HighlightedOn;
                    if(state.Name == "HighlightedOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.HighlightedOff;
                    if(state.Name == "PushedOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.PushedOn;
                    if(state.Name == "PushedOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.PushedOff;
                    if(state.Name == "FocusedOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.FocusedOn;
                    if(state.Name == "FocusedOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.FocusedOff;
                    if(state.Name == "HighlightedFocusedOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.HighlightedFocusedOn;
                    if(state.Name == "HighlightedFocusedOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.HighlightedFocusedOff;
                    if(state.Name == "DisabledFocusedOn") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.DisabledFocusedOn;
                    if(state.Name == "DisabledFocusedOff") this.mCurrentRadioButtonCategoryState = RadioButtonCategory.DisabledFocusedOff;
                }
            }
            base.ApplyState(state);
        }
        Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory Harvesteer.GumRuntimes.IRadioButtonBehavior.CurrentRadioButtonCategoryState
        {
            set
            {
                switch(value)
                {
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.EnabledOn:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.EnabledOn;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.EnabledOff:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.EnabledOff;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.DisabledOn:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.DisabledOn;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.DisabledOff:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.DisabledOff;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.HighlightedOn:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.HighlightedOn;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.HighlightedOff:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.HighlightedOff;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.PushedOn:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.PushedOn;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.PushedOff:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.PushedOff;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.FocusedOn:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.FocusedOn;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.FocusedOff:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.FocusedOff;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.HighlightedFocusedOn:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.HighlightedFocusedOn;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.HighlightedFocusedOff:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.HighlightedFocusedOff;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.DisabledFocusedOn:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.DisabledFocusedOn;
                        break;
                    case  Harvesteer.GumRuntimes.IRadioButtonBehavior.RadioButtonCategory.DisabledFocusedOff:
                        this.CurrentRadioButtonCategoryState = RadioButtonCategory.DisabledFocusedOff;
                        break;
                }
            }
        }
        private bool tryCreateFormsObject;
        public Harvesteer.GumRuntimes.NineSliceRuntime RadioBackground { get; set; }
        public Harvesteer.GumRuntimes.Elements.IconRuntime Radio { get; set; }
        public Harvesteer.GumRuntimes.TextRuntime TextInstance { get; set; }
        public Harvesteer.GumRuntimes.NineSliceRuntime FocusedIndicator { get; set; }
        public string RadioDisplayText
        {
            get
            {
                return TextInstance.Text;
            }
            set
            {
                if (TextInstance.Text != value)
                {
                    TextInstance.Text = value;
                    RadioDisplayTextChanged?.Invoke(this, null);
                }
            }
        }
        public event FlatRedBall.Gui.WindowEvent RadioClick;
        public event System.EventHandler RadioDisplayTextChanged;
        public RadioButtonRuntime () 
        	: this(true, true)
        {
        }
        public RadioButtonRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/RadioButton");
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
            RadioBackground = this.GetGraphicalUiElementByName("RadioBackground") as Harvesteer.GumRuntimes.NineSliceRuntime;
            Radio = this.GetGraphicalUiElementByName("Radio") as Harvesteer.GumRuntimes.Elements.IconRuntime;
            TextInstance = this.GetGraphicalUiElementByName("TextInstance") as Harvesteer.GumRuntimes.TextRuntime;
            FocusedIndicator = this.GetGraphicalUiElementByName("FocusedIndicator") as Harvesteer.GumRuntimes.NineSliceRuntime;
            Radio.Click += (unused) => RadioClick?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.RadioButton(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.RadioButton FormsControl {get => (FlatRedBall.Forms.Controls.RadioButton) FormsControlAsObject;}
    }
}
