using System.Linq;
namespace Harvesteer.GumRuntimes.Controls
{
    public partial class PasswordBoxRuntime : Harvesteer.GumRuntimes.ContainerRuntime, Harvesteer.GumRuntimes.IPasswordBoxBehavior
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
        public enum PasswordBoxCategory
        {
            Enabled,
            Disabled,
            Highlighted,
            Selected
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        PasswordBoxCategory? mCurrentPasswordBoxCategoryState;
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
                        Background.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                        Background.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                        SelectionInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Accent;
                        TextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                        TextInstance.CurrentStyleCategoryState = Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Normal;
                        PlaceholderTextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                        FocusedIndicator.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Warning;
                        FocusedIndicator.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                        CaretInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Primary;
                        Height = 24f;
                        Width = 256f;
                        SelectionInstance.Height = -4f;
                        SelectionInstance.Width = 7f;
                        SelectionInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        SelectionInstance.X = 15f;
                        SelectionInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        SelectionInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        SelectionInstance.Y = 0f;
                        TextInstance.Height = -4f;
                        TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        TextInstance.Text = "";
                        TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TextInstance.Width = 0f;
                        TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        TextInstance.X = 4f;
                        TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        TextInstance.Y = 0f;
                        TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        PlaceholderTextInstance.Height = -4f;
                        PlaceholderTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        PlaceholderTextInstance.Text = "Password";
                        PlaceholderTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        PlaceholderTextInstance.Width = -8f;
                        PlaceholderTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        PlaceholderTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        PlaceholderTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        PlaceholderTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        PlaceholderTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        FocusedIndicator.Height = 2f;
                        FocusedIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        FocusedIndicator.Visible = false;
                        FocusedIndicator.Y = 2f;
                        FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        CaretInstance.Height = 14f;
                        CaretInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        SetProperty("CaretInstance.SourceFile", "UISpriteSheet.png");
                        CaretInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        CaretInstance.TextureHeight = 24;
                        CaretInstance.TextureLeft = 0;
                        CaretInstance.TextureTop = 48;
                        CaretInstance.TextureWidth = 24;
                        CaretInstance.Width = 1f;
                        CaretInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        CaretInstance.X = 4f;
                        CaretInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        CaretInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        CaretInstance.Y = 0f;
                        CaretInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        CaretInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        break;
                }
            }
        }
        public PasswordBoxCategory? CurrentPasswordBoxCategoryState
        {
            get
            {
                return mCurrentPasswordBoxCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentPasswordBoxCategoryState = value;
                    switch(mCurrentPasswordBoxCategoryState)
                    {
                        case  PasswordBoxCategory.Enabled:
                            Background.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            PlaceholderTextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            FocusedIndicator.Visible = false;
                            break;
                        case  PasswordBoxCategory.Disabled:
                            Background.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            PlaceholderTextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                            FocusedIndicator.Visible = false;
                            break;
                        case  PasswordBoxCategory.Highlighted:
                            Background.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Gray;
                            PlaceholderTextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.DarkGray;
                            FocusedIndicator.Visible = false;
                            break;
                        case  PasswordBoxCategory.Selected:
                            Background.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            PlaceholderTextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
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
            bool setBackgroundCurrentColorCategoryStateFirstValue = false;
            bool setBackgroundCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory BackgroundCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory BackgroundCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setBackgroundCurrentStyleCategoryStateFirstValue = false;
            bool setBackgroundCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setCaretInstanceCurrentColorCategoryStateFirstValue = false;
            bool setCaretInstanceCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory CaretInstanceCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory CaretInstanceCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            bool setCaretInstanceHeightFirstValue = false;
            bool setCaretInstanceHeightSecondValue = false;
            float CaretInstanceHeightFirstValue= 0;
            float CaretInstanceHeightSecondValue= 0;
            bool setCaretInstanceTextureHeightFirstValue = false;
            bool setCaretInstanceTextureHeightSecondValue = false;
            int CaretInstanceTextureHeightFirstValue= 0;
            int CaretInstanceTextureHeightSecondValue= 0;
            bool setCaretInstanceTextureLeftFirstValue = false;
            bool setCaretInstanceTextureLeftSecondValue = false;
            int CaretInstanceTextureLeftFirstValue= 0;
            int CaretInstanceTextureLeftSecondValue= 0;
            bool setCaretInstanceTextureTopFirstValue = false;
            bool setCaretInstanceTextureTopSecondValue = false;
            int CaretInstanceTextureTopFirstValue= 0;
            int CaretInstanceTextureTopSecondValue= 0;
            bool setCaretInstanceTextureWidthFirstValue = false;
            bool setCaretInstanceTextureWidthSecondValue = false;
            int CaretInstanceTextureWidthFirstValue= 0;
            int CaretInstanceTextureWidthSecondValue= 0;
            bool setCaretInstanceWidthFirstValue = false;
            bool setCaretInstanceWidthSecondValue = false;
            float CaretInstanceWidthFirstValue= 0;
            float CaretInstanceWidthSecondValue= 0;
            bool setCaretInstanceXFirstValue = false;
            bool setCaretInstanceXSecondValue = false;
            float CaretInstanceXFirstValue= 0;
            float CaretInstanceXSecondValue= 0;
            bool setCaretInstanceYFirstValue = false;
            bool setCaretInstanceYSecondValue = false;
            float CaretInstanceYFirstValue= 0;
            float CaretInstanceYSecondValue= 0;
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
            bool setPlaceholderTextInstanceCurrentColorCategoryStateFirstValue = false;
            bool setPlaceholderTextInstanceCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.TextRuntime.ColorCategory PlaceholderTextInstanceCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.TextRuntime.ColorCategory PlaceholderTextInstanceCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Black;
            bool setPlaceholderTextInstanceHeightFirstValue = false;
            bool setPlaceholderTextInstanceHeightSecondValue = false;
            float PlaceholderTextInstanceHeightFirstValue= 0;
            float PlaceholderTextInstanceHeightSecondValue= 0;
            bool setPlaceholderTextInstanceWidthFirstValue = false;
            bool setPlaceholderTextInstanceWidthSecondValue = false;
            float PlaceholderTextInstanceWidthFirstValue= 0;
            float PlaceholderTextInstanceWidthSecondValue= 0;
            bool setSelectionInstanceCurrentColorCategoryStateFirstValue = false;
            bool setSelectionInstanceCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory SelectionInstanceCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory SelectionInstanceCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setSelectionInstanceHeightFirstValue = false;
            bool setSelectionInstanceHeightSecondValue = false;
            float SelectionInstanceHeightFirstValue= 0;
            float SelectionInstanceHeightSecondValue= 0;
            bool setSelectionInstanceWidthFirstValue = false;
            bool setSelectionInstanceWidthSecondValue = false;
            float SelectionInstanceWidthFirstValue= 0;
            float SelectionInstanceWidthSecondValue= 0;
            bool setSelectionInstanceXFirstValue = false;
            bool setSelectionInstanceXSecondValue = false;
            float SelectionInstanceXFirstValue= 0;
            float SelectionInstanceXSecondValue= 0;
            bool setSelectionInstanceYFirstValue = false;
            bool setSelectionInstanceYSecondValue = false;
            float SelectionInstanceYFirstValue= 0;
            float SelectionInstanceYSecondValue= 0;
            bool setTextInstanceCurrentColorCategoryStateFirstValue = false;
            bool setTextInstanceCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.TextRuntime.ColorCategory TextInstanceCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Black;
            bool setTextInstanceHeightFirstValue = false;
            bool setTextInstanceHeightSecondValue = false;
            float TextInstanceHeightFirstValue= 0;
            float TextInstanceHeightSecondValue= 0;
            bool setTextInstanceCurrentStyleCategoryStateFirstValue = false;
            bool setTextInstanceCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.TextRuntime.StyleCategory TextInstanceCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Tiny;
            Harvesteer.GumRuntimes.TextRuntime.StyleCategory TextInstanceCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Tiny;
            bool setTextInstanceWidthFirstValue = false;
            bool setTextInstanceWidthSecondValue = false;
            float TextInstanceWidthFirstValue= 0;
            float TextInstanceWidthSecondValue= 0;
            bool setTextInstanceXFirstValue = false;
            bool setTextInstanceXSecondValue = false;
            float TextInstanceXFirstValue= 0;
            float TextInstanceXSecondValue= 0;
            bool setTextInstanceYFirstValue = false;
            bool setTextInstanceYSecondValue = false;
            float TextInstanceYFirstValue= 0;
            float TextInstanceYSecondValue= 0;
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
                    setCaretInstanceCurrentColorCategoryStateFirstValue = true;
                    CaretInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Primary;
                    setCaretInstanceHeightFirstValue = true;
                    CaretInstanceHeightFirstValue = 14f;
                    if (interpolationValue < 1)
                    {
                        this.CaretInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    if (interpolationValue < 1)
                    {
                        SetProperty("CaretInstance.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue < 1)
                    {
                        this.CaretInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setCaretInstanceTextureHeightFirstValue = true;
                    CaretInstanceTextureHeightFirstValue = 24;
                    setCaretInstanceTextureLeftFirstValue = true;
                    CaretInstanceTextureLeftFirstValue = 0;
                    setCaretInstanceTextureTopFirstValue = true;
                    CaretInstanceTextureTopFirstValue = 48;
                    setCaretInstanceTextureWidthFirstValue = true;
                    CaretInstanceTextureWidthFirstValue = 24;
                    setCaretInstanceWidthFirstValue = true;
                    CaretInstanceWidthFirstValue = 1f;
                    if (interpolationValue < 1)
                    {
                        this.CaretInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setCaretInstanceXFirstValue = true;
                    CaretInstanceXFirstValue = 4f;
                    if (interpolationValue < 1)
                    {
                        this.CaretInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.CaretInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setCaretInstanceYFirstValue = true;
                    CaretInstanceYFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.CaretInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.CaretInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
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
                    setPlaceholderTextInstanceCurrentColorCategoryStateFirstValue = true;
                    PlaceholderTextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    setPlaceholderTextInstanceHeightFirstValue = true;
                    PlaceholderTextInstanceHeightFirstValue = -4f;
                    if (interpolationValue < 1)
                    {
                        this.PlaceholderTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.PlaceholderTextInstance.Text = "Password";
                    }
                    if (interpolationValue < 1)
                    {
                        this.PlaceholderTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setPlaceholderTextInstanceWidthFirstValue = true;
                    PlaceholderTextInstanceWidthFirstValue = -8f;
                    if (interpolationValue < 1)
                    {
                        this.PlaceholderTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.PlaceholderTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.PlaceholderTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.PlaceholderTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.PlaceholderTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setSelectionInstanceCurrentColorCategoryStateFirstValue = true;
                    SelectionInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Accent;
                    setSelectionInstanceHeightFirstValue = true;
                    SelectionInstanceHeightFirstValue = -4f;
                    setSelectionInstanceWidthFirstValue = true;
                    SelectionInstanceWidthFirstValue = 7f;
                    if (interpolationValue < 1)
                    {
                        this.SelectionInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setSelectionInstanceXFirstValue = true;
                    SelectionInstanceXFirstValue = 15f;
                    if (interpolationValue < 1)
                    {
                        this.SelectionInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.SelectionInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setSelectionInstanceYFirstValue = true;
                    SelectionInstanceYFirstValue = 0f;
                    setTextInstanceCurrentColorCategoryStateFirstValue = true;
                    TextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    setTextInstanceHeightFirstValue = true;
                    TextInstanceHeightFirstValue = -4f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    setTextInstanceCurrentStyleCategoryStateFirstValue = true;
                    TextInstanceCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Normal;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.Text = "";
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setTextInstanceWidthFirstValue = true;
                    TextInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setTextInstanceXFirstValue = true;
                    TextInstanceXFirstValue = 4f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setTextInstanceYFirstValue = true;
                    TextInstanceYFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 256f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setBackgroundCurrentStyleCategoryStateSecondValue = true;
                    BackgroundCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setCaretInstanceCurrentColorCategoryStateSecondValue = true;
                    CaretInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Primary;
                    setCaretInstanceHeightSecondValue = true;
                    CaretInstanceHeightSecondValue = 14f;
                    if (interpolationValue >= 1)
                    {
                        this.CaretInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    if (interpolationValue >= 1)
                    {
                        SetProperty("CaretInstance.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue >= 1)
                    {
                        this.CaretInstance.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setCaretInstanceTextureHeightSecondValue = true;
                    CaretInstanceTextureHeightSecondValue = 24;
                    setCaretInstanceTextureLeftSecondValue = true;
                    CaretInstanceTextureLeftSecondValue = 0;
                    setCaretInstanceTextureTopSecondValue = true;
                    CaretInstanceTextureTopSecondValue = 48;
                    setCaretInstanceTextureWidthSecondValue = true;
                    CaretInstanceTextureWidthSecondValue = 24;
                    setCaretInstanceWidthSecondValue = true;
                    CaretInstanceWidthSecondValue = 1f;
                    if (interpolationValue >= 1)
                    {
                        this.CaretInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setCaretInstanceXSecondValue = true;
                    CaretInstanceXSecondValue = 4f;
                    if (interpolationValue >= 1)
                    {
                        this.CaretInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.CaretInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setCaretInstanceYSecondValue = true;
                    CaretInstanceYSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.CaretInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.CaretInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
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
                    setPlaceholderTextInstanceCurrentColorCategoryStateSecondValue = true;
                    PlaceholderTextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    setPlaceholderTextInstanceHeightSecondValue = true;
                    PlaceholderTextInstanceHeightSecondValue = -4f;
                    if (interpolationValue >= 1)
                    {
                        this.PlaceholderTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.PlaceholderTextInstance.Text = "Password";
                    }
                    if (interpolationValue >= 1)
                    {
                        this.PlaceholderTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setPlaceholderTextInstanceWidthSecondValue = true;
                    PlaceholderTextInstanceWidthSecondValue = -8f;
                    if (interpolationValue >= 1)
                    {
                        this.PlaceholderTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.PlaceholderTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.PlaceholderTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.PlaceholderTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.PlaceholderTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setSelectionInstanceCurrentColorCategoryStateSecondValue = true;
                    SelectionInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Accent;
                    setSelectionInstanceHeightSecondValue = true;
                    SelectionInstanceHeightSecondValue = -4f;
                    setSelectionInstanceWidthSecondValue = true;
                    SelectionInstanceWidthSecondValue = 7f;
                    if (interpolationValue >= 1)
                    {
                        this.SelectionInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setSelectionInstanceXSecondValue = true;
                    SelectionInstanceXSecondValue = 15f;
                    if (interpolationValue >= 1)
                    {
                        this.SelectionInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.SelectionInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setSelectionInstanceYSecondValue = true;
                    SelectionInstanceYSecondValue = 0f;
                    setTextInstanceCurrentColorCategoryStateSecondValue = true;
                    TextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    setTextInstanceHeightSecondValue = true;
                    TextInstanceHeightSecondValue = -4f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    setTextInstanceCurrentStyleCategoryStateSecondValue = true;
                    TextInstanceCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Normal;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.Text = "";
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    setTextInstanceWidthSecondValue = true;
                    TextInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setTextInstanceXSecondValue = true;
                    TextInstanceXSecondValue = 4f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setTextInstanceYSecondValue = true;
                    TextInstanceYSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthSecondValue = true;
                    WidthSecondValue = 256f;
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
            if (setCaretInstanceCurrentColorCategoryStateFirstValue && setCaretInstanceCurrentColorCategoryStateSecondValue)
            {
                CaretInstance.InterpolateBetween(CaretInstanceCurrentColorCategoryStateFirstValue, CaretInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setCaretInstanceHeightFirstValue && setCaretInstanceHeightSecondValue)
            {
                CaretInstance.Height = CaretInstanceHeightFirstValue * (1 - interpolationValue) + CaretInstanceHeightSecondValue * interpolationValue;
            }
            if (setCaretInstanceTextureHeightFirstValue && setCaretInstanceTextureHeightSecondValue)
            {
                CaretInstance.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(CaretInstanceTextureHeightFirstValue* (1 - interpolationValue) + CaretInstanceTextureHeightSecondValue * interpolationValue);
            }
            if (setCaretInstanceTextureLeftFirstValue && setCaretInstanceTextureLeftSecondValue)
            {
                CaretInstance.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(CaretInstanceTextureLeftFirstValue* (1 - interpolationValue) + CaretInstanceTextureLeftSecondValue * interpolationValue);
            }
            if (setCaretInstanceTextureTopFirstValue && setCaretInstanceTextureTopSecondValue)
            {
                CaretInstance.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(CaretInstanceTextureTopFirstValue* (1 - interpolationValue) + CaretInstanceTextureTopSecondValue * interpolationValue);
            }
            if (setCaretInstanceTextureWidthFirstValue && setCaretInstanceTextureWidthSecondValue)
            {
                CaretInstance.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(CaretInstanceTextureWidthFirstValue* (1 - interpolationValue) + CaretInstanceTextureWidthSecondValue * interpolationValue);
            }
            if (setCaretInstanceWidthFirstValue && setCaretInstanceWidthSecondValue)
            {
                CaretInstance.Width = CaretInstanceWidthFirstValue * (1 - interpolationValue) + CaretInstanceWidthSecondValue * interpolationValue;
            }
            if (setCaretInstanceXFirstValue && setCaretInstanceXSecondValue)
            {
                CaretInstance.X = CaretInstanceXFirstValue * (1 - interpolationValue) + CaretInstanceXSecondValue * interpolationValue;
            }
            if (setCaretInstanceYFirstValue && setCaretInstanceYSecondValue)
            {
                CaretInstance.Y = CaretInstanceYFirstValue * (1 - interpolationValue) + CaretInstanceYSecondValue * interpolationValue;
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
            if (setPlaceholderTextInstanceCurrentColorCategoryStateFirstValue && setPlaceholderTextInstanceCurrentColorCategoryStateSecondValue)
            {
                PlaceholderTextInstance.InterpolateBetween(PlaceholderTextInstanceCurrentColorCategoryStateFirstValue, PlaceholderTextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setPlaceholderTextInstanceHeightFirstValue && setPlaceholderTextInstanceHeightSecondValue)
            {
                PlaceholderTextInstance.Height = PlaceholderTextInstanceHeightFirstValue * (1 - interpolationValue) + PlaceholderTextInstanceHeightSecondValue * interpolationValue;
            }
            if (setPlaceholderTextInstanceWidthFirstValue && setPlaceholderTextInstanceWidthSecondValue)
            {
                PlaceholderTextInstance.Width = PlaceholderTextInstanceWidthFirstValue * (1 - interpolationValue) + PlaceholderTextInstanceWidthSecondValue * interpolationValue;
            }
            if (setSelectionInstanceCurrentColorCategoryStateFirstValue && setSelectionInstanceCurrentColorCategoryStateSecondValue)
            {
                SelectionInstance.InterpolateBetween(SelectionInstanceCurrentColorCategoryStateFirstValue, SelectionInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setSelectionInstanceHeightFirstValue && setSelectionInstanceHeightSecondValue)
            {
                SelectionInstance.Height = SelectionInstanceHeightFirstValue * (1 - interpolationValue) + SelectionInstanceHeightSecondValue * interpolationValue;
            }
            if (setSelectionInstanceWidthFirstValue && setSelectionInstanceWidthSecondValue)
            {
                SelectionInstance.Width = SelectionInstanceWidthFirstValue * (1 - interpolationValue) + SelectionInstanceWidthSecondValue * interpolationValue;
            }
            if (setSelectionInstanceXFirstValue && setSelectionInstanceXSecondValue)
            {
                SelectionInstance.X = SelectionInstanceXFirstValue * (1 - interpolationValue) + SelectionInstanceXSecondValue * interpolationValue;
            }
            if (setSelectionInstanceYFirstValue && setSelectionInstanceYSecondValue)
            {
                SelectionInstance.Y = SelectionInstanceYFirstValue * (1 - interpolationValue) + SelectionInstanceYSecondValue * interpolationValue;
            }
            if (setTextInstanceCurrentColorCategoryStateFirstValue && setTextInstanceCurrentColorCategoryStateSecondValue)
            {
                TextInstance.InterpolateBetween(TextInstanceCurrentColorCategoryStateFirstValue, TextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstanceHeightFirstValue && setTextInstanceHeightSecondValue)
            {
                TextInstance.Height = TextInstanceHeightFirstValue * (1 - interpolationValue) + TextInstanceHeightSecondValue * interpolationValue;
            }
            if (setTextInstanceCurrentStyleCategoryStateFirstValue && setTextInstanceCurrentStyleCategoryStateSecondValue)
            {
                TextInstance.InterpolateBetween(TextInstanceCurrentStyleCategoryStateFirstValue, TextInstanceCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setTextInstanceWidthFirstValue && setTextInstanceWidthSecondValue)
            {
                TextInstance.Width = TextInstanceWidthFirstValue * (1 - interpolationValue) + TextInstanceWidthSecondValue * interpolationValue;
            }
            if (setTextInstanceXFirstValue && setTextInstanceXSecondValue)
            {
                TextInstance.X = TextInstanceXFirstValue * (1 - interpolationValue) + TextInstanceXSecondValue * interpolationValue;
            }
            if (setTextInstanceYFirstValue && setTextInstanceYSecondValue)
            {
                TextInstance.Y = TextInstanceYFirstValue * (1 - interpolationValue) + TextInstanceYSecondValue * interpolationValue;
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
        public void InterpolateBetween (PasswordBoxCategory firstState, PasswordBoxCategory secondState, float interpolationValue) 
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
            bool setPlaceholderTextInstanceCurrentColorCategoryStateFirstValue = false;
            bool setPlaceholderTextInstanceCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.TextRuntime.ColorCategory PlaceholderTextInstanceCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.TextRuntime.ColorCategory PlaceholderTextInstanceCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Black;
            switch(firstState)
            {
                case  PasswordBoxCategory.Enabled:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setPlaceholderTextInstanceCurrentColorCategoryStateFirstValue = true;
                    PlaceholderTextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  PasswordBoxCategory.Disabled:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setPlaceholderTextInstanceCurrentColorCategoryStateFirstValue = true;
                    PlaceholderTextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  PasswordBoxCategory.Highlighted:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Gray;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setPlaceholderTextInstanceCurrentColorCategoryStateFirstValue = true;
                    PlaceholderTextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.DarkGray;
                    break;
                case  PasswordBoxCategory.Selected:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setPlaceholderTextInstanceCurrentColorCategoryStateFirstValue = true;
                    PlaceholderTextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
            }
            switch(secondState)
            {
                case  PasswordBoxCategory.Enabled:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setPlaceholderTextInstanceCurrentColorCategoryStateSecondValue = true;
                    PlaceholderTextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  PasswordBoxCategory.Disabled:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setPlaceholderTextInstanceCurrentColorCategoryStateSecondValue = true;
                    PlaceholderTextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
                    break;
                case  PasswordBoxCategory.Highlighted:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Gray;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setPlaceholderTextInstanceCurrentColorCategoryStateSecondValue = true;
                    PlaceholderTextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.DarkGray;
                    break;
                case  PasswordBoxCategory.Selected:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = true;
                    }
                    setPlaceholderTextInstanceCurrentColorCategoryStateSecondValue = true;
                    PlaceholderTextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Gray;
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
            if (setPlaceholderTextInstanceCurrentColorCategoryStateFirstValue && setPlaceholderTextInstanceCurrentColorCategoryStateSecondValue)
            {
                PlaceholderTextInstance.InterpolateBetween(PlaceholderTextInstanceCurrentColorCategoryStateFirstValue, PlaceholderTextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (interpolationValue < 1)
            {
                mCurrentPasswordBoxCategoryState = firstState;
            }
            else
            {
                mCurrentPasswordBoxCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.PasswordBoxRuntime.VariableState fromState,Harvesteer.GumRuntimes.Controls.PasswordBoxRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.PasswordBoxRuntime.PasswordBoxCategory fromState,Harvesteer.GumRuntimes.Controls.PasswordBoxRuntime.PasswordBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (PasswordBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "PasswordBoxCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentPasswordBoxCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (PasswordBoxCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentPasswordBoxCategoryState = toState;
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
                        Name = "SelectionInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = SelectionInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.Height",
                        Type = "float",
                        Value = SelectionInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.Width",
                        Type = "float",
                        Value = SelectionInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = SelectionInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.X",
                        Type = "float",
                        Value = SelectionInstance.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = SelectionInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.X Units",
                        Type = "PositionUnitType",
                        Value = SelectionInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.Y",
                        Type = "float",
                        Value = SelectionInstance.Y
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
                        Name = "TextInstance.Height",
                        Type = "float",
                        Value = TextInstance.Height
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
                        Name = "TextInstance.HorizontalAlignment",
                        Type = "HorizontalAlignment",
                        Value = TextInstance.HorizontalAlignment
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
                        Name = "TextInstance.X",
                        Type = "float",
                        Value = TextInstance.X
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
                        Name = "TextInstance.Y",
                        Type = "float",
                        Value = TextInstance.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = TextInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = TextInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = PlaceholderTextInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Height",
                        Type = "float",
                        Value = PlaceholderTextInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = PlaceholderTextInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Text",
                        Type = "string",
                        Value = PlaceholderTextInstance.Text
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.VerticalAlignment",
                        Type = "VerticalAlignment",
                        Value = PlaceholderTextInstance.VerticalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Width",
                        Type = "float",
                        Value = PlaceholderTextInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = PlaceholderTextInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = PlaceholderTextInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.X Units",
                        Type = "PositionUnitType",
                        Value = PlaceholderTextInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = PlaceholderTextInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = PlaceholderTextInstance.YUnits
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
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CaretInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Height",
                        Type = "float",
                        Value = CaretInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = CaretInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.SourceFile",
                        Type = "string",
                        Value = CaretInstance.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Texture Address",
                        Type = "TextureAddress",
                        Value = CaretInstance.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Texture Height",
                        Type = "int",
                        Value = CaretInstance.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Texture Left",
                        Type = "int",
                        Value = CaretInstance.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Texture Top",
                        Type = "int",
                        Value = CaretInstance.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Texture Width",
                        Type = "int",
                        Value = CaretInstance.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Width",
                        Type = "float",
                        Value = CaretInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = CaretInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.X",
                        Type = "float",
                        Value = CaretInstance.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = CaretInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.X Units",
                        Type = "PositionUnitType",
                        Value = CaretInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Y",
                        Type = "float",
                        Value = CaretInstance.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = CaretInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = CaretInstance.YUnits
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
                        Value = Width + 256f
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
                        Name = "SelectionInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = SelectionInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.Height",
                        Type = "float",
                        Value = SelectionInstance.Height + -4f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.Width",
                        Type = "float",
                        Value = SelectionInstance.Width + 7f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = SelectionInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.X",
                        Type = "float",
                        Value = SelectionInstance.X + 15f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = SelectionInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.X Units",
                        Type = "PositionUnitType",
                        Value = SelectionInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SelectionInstance.Y",
                        Type = "float",
                        Value = SelectionInstance.Y + 0f
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
                        Name = "TextInstance.Height",
                        Type = "float",
                        Value = TextInstance.Height + -4f
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
                        Name = "TextInstance.HorizontalAlignment",
                        Type = "HorizontalAlignment",
                        Value = TextInstance.HorizontalAlignment
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
                        Value = TextInstance.Width + 0f
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
                        Name = "TextInstance.X",
                        Type = "float",
                        Value = TextInstance.X + 4f
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
                        Name = "TextInstance.Y",
                        Type = "float",
                        Value = TextInstance.Y + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = TextInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = TextInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = PlaceholderTextInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Height",
                        Type = "float",
                        Value = PlaceholderTextInstance.Height + -4f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = PlaceholderTextInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Text",
                        Type = "string",
                        Value = PlaceholderTextInstance.Text
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.VerticalAlignment",
                        Type = "VerticalAlignment",
                        Value = PlaceholderTextInstance.VerticalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Width",
                        Type = "float",
                        Value = PlaceholderTextInstance.Width + -8f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = PlaceholderTextInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = PlaceholderTextInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.X Units",
                        Type = "PositionUnitType",
                        Value = PlaceholderTextInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = PlaceholderTextInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "PlaceholderTextInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = PlaceholderTextInstance.YUnits
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
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = CaretInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Height",
                        Type = "float",
                        Value = CaretInstance.Height + 14f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = CaretInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.SourceFile",
                        Type = "string",
                        Value = CaretInstance.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Texture Address",
                        Type = "TextureAddress",
                        Value = CaretInstance.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Texture Height",
                        Type = "int",
                        Value = CaretInstance.TextureHeight + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Texture Left",
                        Type = "int",
                        Value = CaretInstance.TextureLeft + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Texture Top",
                        Type = "int",
                        Value = CaretInstance.TextureTop + 48
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Texture Width",
                        Type = "int",
                        Value = CaretInstance.TextureWidth + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Width",
                        Type = "float",
                        Value = CaretInstance.Width + 1f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = CaretInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.X",
                        Type = "float",
                        Value = CaretInstance.X + 4f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = CaretInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.X Units",
                        Type = "PositionUnitType",
                        Value = CaretInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Y",
                        Type = "float",
                        Value = CaretInstance.Y + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = CaretInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CaretInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = CaretInstance.YUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (PasswordBoxCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  PasswordBoxCategory.Enabled:
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
                        Name = "PlaceholderTextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = PlaceholderTextInstance.CurrentColorCategoryState
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
                case  PasswordBoxCategory.Disabled:
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
                        Name = "PlaceholderTextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = PlaceholderTextInstance.CurrentColorCategoryState
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
                case  PasswordBoxCategory.Highlighted:
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
                        Name = "PlaceholderTextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = PlaceholderTextInstance.CurrentColorCategoryState
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
                case  PasswordBoxCategory.Selected:
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
                        Name = "PlaceholderTextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = PlaceholderTextInstance.CurrentColorCategoryState
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
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (PasswordBoxCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  PasswordBoxCategory.Enabled:
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
                        Name = "PlaceholderTextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = PlaceholderTextInstance.CurrentColorCategoryState
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
                case  PasswordBoxCategory.Disabled:
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
                        Name = "PlaceholderTextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = PlaceholderTextInstance.CurrentColorCategoryState
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
                case  PasswordBoxCategory.Highlighted:
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
                        Name = "PlaceholderTextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = PlaceholderTextInstance.CurrentColorCategoryState
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
                case  PasswordBoxCategory.Selected:
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
                        Name = "PlaceholderTextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = PlaceholderTextInstance.CurrentColorCategoryState
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
                else if (category.Name == "PasswordBoxCategory")
                {
                    if(state.Name == "Enabled") this.mCurrentPasswordBoxCategoryState = PasswordBoxCategory.Enabled;
                    if(state.Name == "Disabled") this.mCurrentPasswordBoxCategoryState = PasswordBoxCategory.Disabled;
                    if(state.Name == "Highlighted") this.mCurrentPasswordBoxCategoryState = PasswordBoxCategory.Highlighted;
                    if(state.Name == "Selected") this.mCurrentPasswordBoxCategoryState = PasswordBoxCategory.Selected;
                }
            }
            base.ApplyState(state);
        }
        Harvesteer.GumRuntimes.IPasswordBoxBehavior.PasswordBoxCategory Harvesteer.GumRuntimes.IPasswordBoxBehavior.CurrentPasswordBoxCategoryState
        {
            set
            {
                switch(value)
                {
                    case  Harvesteer.GumRuntimes.IPasswordBoxBehavior.PasswordBoxCategory.Enabled:
                        this.CurrentPasswordBoxCategoryState = PasswordBoxCategory.Enabled;
                        break;
                    case  Harvesteer.GumRuntimes.IPasswordBoxBehavior.PasswordBoxCategory.Disabled:
                        this.CurrentPasswordBoxCategoryState = PasswordBoxCategory.Disabled;
                        break;
                    case  Harvesteer.GumRuntimes.IPasswordBoxBehavior.PasswordBoxCategory.Highlighted:
                        this.CurrentPasswordBoxCategoryState = PasswordBoxCategory.Highlighted;
                        break;
                    case  Harvesteer.GumRuntimes.IPasswordBoxBehavior.PasswordBoxCategory.Selected:
                        this.CurrentPasswordBoxCategoryState = PasswordBoxCategory.Selected;
                        break;
                }
            }
        }
        private bool tryCreateFormsObject;
        public Harvesteer.GumRuntimes.NineSliceRuntime Background { get; set; }
        public Harvesteer.GumRuntimes.NineSliceRuntime SelectionInstance { get; set; }
        public Harvesteer.GumRuntimes.TextRuntime TextInstance { get; set; }
        public Harvesteer.GumRuntimes.TextRuntime PlaceholderTextInstance { get; set; }
        public Harvesteer.GumRuntimes.NineSliceRuntime FocusedIndicator { get; set; }
        public Harvesteer.GumRuntimes.SpriteRuntime CaretInstance { get; set; }
        public string PlaceholderText
        {
            get
            {
                return PlaceholderTextInstance.Text;
            }
            set
            {
                if (PlaceholderTextInstance.Text != value)
                {
                    PlaceholderTextInstance.Text = value;
                    PlaceholderTextChanged?.Invoke(this, null);
                }
            }
        }
        public event System.EventHandler PlaceholderTextChanged;
        public PasswordBoxRuntime () 
        	: this(true, true)
        {
        }
        public PasswordBoxRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/PasswordBox");
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
            SelectionInstance = this.GetGraphicalUiElementByName("SelectionInstance") as Harvesteer.GumRuntimes.NineSliceRuntime;
            TextInstance = this.GetGraphicalUiElementByName("TextInstance") as Harvesteer.GumRuntimes.TextRuntime;
            PlaceholderTextInstance = this.GetGraphicalUiElementByName("PlaceholderTextInstance") as Harvesteer.GumRuntimes.TextRuntime;
            FocusedIndicator = this.GetGraphicalUiElementByName("FocusedIndicator") as Harvesteer.GumRuntimes.NineSliceRuntime;
            CaretInstance = this.GetGraphicalUiElementByName("CaretInstance") as Harvesteer.GumRuntimes.SpriteRuntime;
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.PasswordBox(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.PasswordBox FormsControl {get => (FlatRedBall.Forms.Controls.PasswordBox) FormsControlAsObject;}
    }
}
