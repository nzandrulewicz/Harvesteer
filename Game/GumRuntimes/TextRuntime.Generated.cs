using System.Linq;
namespace Harvesteer.GumRuntimes
{
    public partial class TextRuntime : global::Gum.Wireframe.GraphicalUiElement
    {
        public TextRuntime () 
        	: this(true, true)
        {
        }
        public TextRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        {
            this.HasEvents = false;
            this.ExposeChildrenEvents = false;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.StandardElements.First(item => item.Name == "Text");
                this.ElementSave = elementSave;
                string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
            }
        }
        RenderingLibrary.Graphics.Text mContainedText;
        RenderingLibrary.Graphics.Text ContainedText
        {
            get
            {
                if (mContainedText == null)
                {
                    mContainedText = this.RenderableComponent as RenderingLibrary.Graphics.Text;
                }
                return mContainedText;
            }
        }
        #region State Enums
        public enum VariableState
        {
            Default
        }
        public enum ColorCategory
        {
            Black,
            DarkGray,
            Gray,
            LightGray,
            White,
            PrimaryDark,
            Primary,
            PrimaryLight,
            Success,
            Warning,
            Danger,
            Accent
        }
        public enum StyleCategory
        {
            Tiny,
            Small,
            Normal,
            Emphasis,
            Strong,
            H3,
            H2,
            H1,
            Title
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        ColorCategory? mCurrentColorCategoryState;
        StyleCategory? mCurrentStyleCategoryState;
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
                        Alpha = 255;
                        Blue = 0;
                        SetProperty("CustomFontFile", "");
                        ExposeChildrenEvents = false;
                        Font = "Arial";
                        FontScale = 1f;
                        FontSize = 12;
                        Green = 0;
                        HasEvents = false;
                        Height = 0f;
                        HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        IgnoredByParentSize = false;
                        IsBold = false;
                        IsItalic = false;
                        LineHeightMultiplier = 1f;
                        OutlineThickness = 0;
                        Red = 0;
                        Rotation = 0f;
                        Text = "Hello";
                        TextOverflowHorizontalMode = global::RenderingLibrary.Graphics.TextOverflowHorizontalMode.TruncateWord;
                        TextOverflowVerticalMode = global::RenderingLibrary.Graphics.TextOverflowVerticalMode.SpillOver;
                        UseCustomFont = false;
                        UseFontSmoothing = true;
                        VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        Visible = true;
                        Width = 0f;
                        WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        X = 0f;
                        XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        Y = 0f;
                        YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        break;
                }
            }
        }
        public ColorCategory? CurrentColorCategoryState
        {
            get
            {
                return mCurrentColorCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentColorCategoryState = value;
                    switch(mCurrentColorCategoryState)
                    {
                        case  ColorCategory.Black:
                            Blue = 0;
                            Green = 0;
                            Red = 0;
                            break;
                        case  ColorCategory.DarkGray:
                            Blue = 70;
                            Green = 70;
                            Red = 70;
                            break;
                        case  ColorCategory.Gray:
                            Blue = 130;
                            Green = 130;
                            Red = 130;
                            break;
                        case  ColorCategory.LightGray:
                            Blue = 170;
                            Green = 170;
                            Red = 170;
                            break;
                        case  ColorCategory.White:
                            Blue = 255;
                            Green = 255;
                            Red = 255;
                            break;
                        case  ColorCategory.PrimaryDark:
                            Blue = 137;
                            Green = 120;
                            Red = 4;
                            break;
                        case  ColorCategory.Primary:
                            Blue = 177;
                            Green = 159;
                            Red = 6;
                            break;
                        case  ColorCategory.PrimaryLight:
                            Blue = 193;
                            Green = 180;
                            Red = 74;
                            break;
                        case  ColorCategory.Success:
                            Blue = 48;
                            Green = 167;
                            Red = 62;
                            break;
                        case  ColorCategory.Warning:
                            Blue = 25;
                            Green = 171;
                            Red = 232;
                            break;
                        case  ColorCategory.Danger:
                            Blue = 41;
                            Green = 18;
                            Red = 212;
                            break;
                        case  ColorCategory.Accent:
                            Blue = 138;
                            Green = 48;
                            Red = 140;
                            break;
                    }
                }
            }
        }
        public StyleCategory? CurrentStyleCategoryState
        {
            get
            {
                return mCurrentStyleCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentStyleCategoryState = value;
                    switch(mCurrentStyleCategoryState)
                    {
                        case  StyleCategory.Tiny:
                            FontSize = 10;
                            IsBold = false;
                            IsItalic = false;
                            break;
                        case  StyleCategory.Small:
                            FontSize = 12;
                            IsBold = false;
                            IsItalic = false;
                            break;
                        case  StyleCategory.Normal:
                            FontSize = 14;
                            IsBold = false;
                            IsItalic = false;
                            break;
                        case  StyleCategory.Emphasis:
                            FontSize = 14;
                            IsBold = false;
                            IsItalic = true;
                            break;
                        case  StyleCategory.Strong:
                            FontSize = 14;
                            IsBold = true;
                            IsItalic = false;
                            break;
                        case  StyleCategory.H3:
                            FontSize = 16;
                            IsBold = true;
                            IsItalic = false;
                            break;
                        case  StyleCategory.H2:
                            FontSize = 18;
                            IsBold = true;
                            IsItalic = false;
                            break;
                        case  StyleCategory.H1:
                            FontSize = 22;
                            IsBold = true;
                            IsItalic = false;
                            break;
                        case  StyleCategory.Title:
                            FontSize = 28;
                            IsBold = true;
                            IsItalic = false;
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
            bool setAlphaFirstValue = false;
            bool setAlphaSecondValue = false;
            int AlphaFirstValue= 0;
            int AlphaSecondValue= 0;
            bool setBlueFirstValue = false;
            bool setBlueSecondValue = false;
            int BlueFirstValue= 0;
            int BlueSecondValue= 0;
            bool setFontScaleFirstValue = false;
            bool setFontScaleSecondValue = false;
            float FontScaleFirstValue= 0;
            float FontScaleSecondValue= 0;
            bool setFontSizeFirstValue = false;
            bool setFontSizeSecondValue = false;
            int FontSizeFirstValue= 0;
            int FontSizeSecondValue= 0;
            bool setGreenFirstValue = false;
            bool setGreenSecondValue = false;
            int GreenFirstValue= 0;
            int GreenSecondValue= 0;
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setLineHeightMultiplierFirstValue = false;
            bool setLineHeightMultiplierSecondValue = false;
            float LineHeightMultiplierFirstValue= 0;
            float LineHeightMultiplierSecondValue= 0;
            bool setOutlineThicknessFirstValue = false;
            bool setOutlineThicknessSecondValue = false;
            int OutlineThicknessFirstValue= 0;
            int OutlineThicknessSecondValue= 0;
            bool setRedFirstValue = false;
            bool setRedSecondValue = false;
            int RedFirstValue= 0;
            int RedSecondValue= 0;
            bool setRotationFirstValue = false;
            bool setRotationSecondValue = false;
            float RotationFirstValue= 0;
            float RotationSecondValue= 0;
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
                    setAlphaFirstValue = true;
                    AlphaFirstValue = 255;
                    setBlueFirstValue = true;
                    BlueFirstValue = 0;
                    if (interpolationValue < 1)
                    {
                        SetProperty("CustomFontFile", "");
                    }
                    if (interpolationValue < 1)
                    {
                        this.ExposeChildrenEvents = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Font = "Arial";
                    }
                    setFontScaleFirstValue = true;
                    FontScaleFirstValue = 1f;
                    setFontSizeFirstValue = true;
                    FontSizeFirstValue = 12;
                    setGreenFirstValue = true;
                    GreenFirstValue = 0;
                    if (interpolationValue < 1)
                    {
                        this.HasEvents = false;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    if (interpolationValue < 1)
                    {
                        this.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IgnoredByParentSize = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IsBold = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IsItalic = false;
                    }
                    setLineHeightMultiplierFirstValue = true;
                    LineHeightMultiplierFirstValue = 1f;
                    setOutlineThicknessFirstValue = true;
                    OutlineThicknessFirstValue = 0;
                    setRedFirstValue = true;
                    RedFirstValue = 0;
                    setRotationFirstValue = true;
                    RotationFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Text = "Hello";
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextOverflowHorizontalMode = global::RenderingLibrary.Graphics.TextOverflowHorizontalMode.TruncateWord;
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextOverflowVerticalMode = global::RenderingLibrary.Graphics.TextOverflowVerticalMode.SpillOver;
                    }
                    if (interpolationValue < 1)
                    {
                        this.UseCustomFont = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.UseFontSmoothing = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Visible = true;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setXFirstValue = true;
                    XFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setYFirstValue = true;
                    YFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setAlphaSecondValue = true;
                    AlphaSecondValue = 255;
                    setBlueSecondValue = true;
                    BlueSecondValue = 0;
                    if (interpolationValue >= 1)
                    {
                        SetProperty("CustomFontFile", "");
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ExposeChildrenEvents = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Font = "Arial";
                    }
                    setFontScaleSecondValue = true;
                    FontScaleSecondValue = 1f;
                    setFontSizeSecondValue = true;
                    FontSizeSecondValue = 12;
                    setGreenSecondValue = true;
                    GreenSecondValue = 0;
                    if (interpolationValue >= 1)
                    {
                        this.HasEvents = false;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IgnoredByParentSize = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IsBold = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IsItalic = false;
                    }
                    setLineHeightMultiplierSecondValue = true;
                    LineHeightMultiplierSecondValue = 1f;
                    setOutlineThicknessSecondValue = true;
                    OutlineThicknessSecondValue = 0;
                    setRedSecondValue = true;
                    RedSecondValue = 0;
                    setRotationSecondValue = true;
                    RotationSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Text = "Hello";
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextOverflowHorizontalMode = global::RenderingLibrary.Graphics.TextOverflowHorizontalMode.TruncateWord;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextOverflowVerticalMode = global::RenderingLibrary.Graphics.TextOverflowVerticalMode.SpillOver;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.UseCustomFont = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.UseFontSmoothing = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Visible = true;
                    }
                    setWidthSecondValue = true;
                    WidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    setXSecondValue = true;
                    XSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setYSecondValue = true;
                    YSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
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
            if (setAlphaFirstValue && setAlphaSecondValue)
            {
                Alpha = FlatRedBall.Math.MathFunctions.RoundToInt(AlphaFirstValue* (1 - interpolationValue) + AlphaSecondValue * interpolationValue);
            }
            if (setBlueFirstValue && setBlueSecondValue)
            {
                Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BlueFirstValue* (1 - interpolationValue) + BlueSecondValue * interpolationValue);
            }
            if (setFontScaleFirstValue && setFontScaleSecondValue)
            {
                FontScale = FontScaleFirstValue * (1 - interpolationValue) + FontScaleSecondValue * interpolationValue;
            }
            if (setFontSizeFirstValue && setFontSizeSecondValue)
            {
                FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(FontSizeFirstValue* (1 - interpolationValue) + FontSizeSecondValue * interpolationValue);
            }
            if (setGreenFirstValue && setGreenSecondValue)
            {
                Green = FlatRedBall.Math.MathFunctions.RoundToInt(GreenFirstValue* (1 - interpolationValue) + GreenSecondValue * interpolationValue);
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setLineHeightMultiplierFirstValue && setLineHeightMultiplierSecondValue)
            {
                LineHeightMultiplier = LineHeightMultiplierFirstValue * (1 - interpolationValue) + LineHeightMultiplierSecondValue * interpolationValue;
            }
            if (setOutlineThicknessFirstValue && setOutlineThicknessSecondValue)
            {
                OutlineThickness = FlatRedBall.Math.MathFunctions.RoundToInt(OutlineThicknessFirstValue* (1 - interpolationValue) + OutlineThicknessSecondValue * interpolationValue);
            }
            if (setRedFirstValue && setRedSecondValue)
            {
                Red = FlatRedBall.Math.MathFunctions.RoundToInt(RedFirstValue* (1 - interpolationValue) + RedSecondValue * interpolationValue);
            }
            if (setRotationFirstValue && setRotationSecondValue)
            {
                Rotation = RotationFirstValue * (1 - interpolationValue) + RotationSecondValue * interpolationValue;
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
        public void InterpolateBetween (ColorCategory firstState, ColorCategory secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setBlueFirstValue = false;
            bool setBlueSecondValue = false;
            int BlueFirstValue= 0;
            int BlueSecondValue= 0;
            bool setGreenFirstValue = false;
            bool setGreenSecondValue = false;
            int GreenFirstValue= 0;
            int GreenSecondValue= 0;
            bool setRedFirstValue = false;
            bool setRedSecondValue = false;
            int RedFirstValue= 0;
            int RedSecondValue= 0;
            switch(firstState)
            {
                case  ColorCategory.Black:
                    setBlueFirstValue = true;
                    BlueFirstValue = 0;
                    setGreenFirstValue = true;
                    GreenFirstValue = 0;
                    setRedFirstValue = true;
                    RedFirstValue = 0;
                    break;
                case  ColorCategory.DarkGray:
                    setBlueFirstValue = true;
                    BlueFirstValue = 70;
                    setGreenFirstValue = true;
                    GreenFirstValue = 70;
                    setRedFirstValue = true;
                    RedFirstValue = 70;
                    break;
                case  ColorCategory.Gray:
                    setBlueFirstValue = true;
                    BlueFirstValue = 130;
                    setGreenFirstValue = true;
                    GreenFirstValue = 130;
                    setRedFirstValue = true;
                    RedFirstValue = 130;
                    break;
                case  ColorCategory.LightGray:
                    setBlueFirstValue = true;
                    BlueFirstValue = 170;
                    setGreenFirstValue = true;
                    GreenFirstValue = 170;
                    setRedFirstValue = true;
                    RedFirstValue = 170;
                    break;
                case  ColorCategory.White:
                    setBlueFirstValue = true;
                    BlueFirstValue = 255;
                    setGreenFirstValue = true;
                    GreenFirstValue = 255;
                    setRedFirstValue = true;
                    RedFirstValue = 255;
                    break;
                case  ColorCategory.PrimaryDark:
                    setBlueFirstValue = true;
                    BlueFirstValue = 137;
                    setGreenFirstValue = true;
                    GreenFirstValue = 120;
                    setRedFirstValue = true;
                    RedFirstValue = 4;
                    break;
                case  ColorCategory.Primary:
                    setBlueFirstValue = true;
                    BlueFirstValue = 177;
                    setGreenFirstValue = true;
                    GreenFirstValue = 159;
                    setRedFirstValue = true;
                    RedFirstValue = 6;
                    break;
                case  ColorCategory.PrimaryLight:
                    setBlueFirstValue = true;
                    BlueFirstValue = 193;
                    setGreenFirstValue = true;
                    GreenFirstValue = 180;
                    setRedFirstValue = true;
                    RedFirstValue = 74;
                    break;
                case  ColorCategory.Success:
                    setBlueFirstValue = true;
                    BlueFirstValue = 48;
                    setGreenFirstValue = true;
                    GreenFirstValue = 167;
                    setRedFirstValue = true;
                    RedFirstValue = 62;
                    break;
                case  ColorCategory.Warning:
                    setBlueFirstValue = true;
                    BlueFirstValue = 25;
                    setGreenFirstValue = true;
                    GreenFirstValue = 171;
                    setRedFirstValue = true;
                    RedFirstValue = 232;
                    break;
                case  ColorCategory.Danger:
                    setBlueFirstValue = true;
                    BlueFirstValue = 41;
                    setGreenFirstValue = true;
                    GreenFirstValue = 18;
                    setRedFirstValue = true;
                    RedFirstValue = 212;
                    break;
                case  ColorCategory.Accent:
                    setBlueFirstValue = true;
                    BlueFirstValue = 138;
                    setGreenFirstValue = true;
                    GreenFirstValue = 48;
                    setRedFirstValue = true;
                    RedFirstValue = 140;
                    break;
            }
            switch(secondState)
            {
                case  ColorCategory.Black:
                    setBlueSecondValue = true;
                    BlueSecondValue = 0;
                    setGreenSecondValue = true;
                    GreenSecondValue = 0;
                    setRedSecondValue = true;
                    RedSecondValue = 0;
                    break;
                case  ColorCategory.DarkGray:
                    setBlueSecondValue = true;
                    BlueSecondValue = 70;
                    setGreenSecondValue = true;
                    GreenSecondValue = 70;
                    setRedSecondValue = true;
                    RedSecondValue = 70;
                    break;
                case  ColorCategory.Gray:
                    setBlueSecondValue = true;
                    BlueSecondValue = 130;
                    setGreenSecondValue = true;
                    GreenSecondValue = 130;
                    setRedSecondValue = true;
                    RedSecondValue = 130;
                    break;
                case  ColorCategory.LightGray:
                    setBlueSecondValue = true;
                    BlueSecondValue = 170;
                    setGreenSecondValue = true;
                    GreenSecondValue = 170;
                    setRedSecondValue = true;
                    RedSecondValue = 170;
                    break;
                case  ColorCategory.White:
                    setBlueSecondValue = true;
                    BlueSecondValue = 255;
                    setGreenSecondValue = true;
                    GreenSecondValue = 255;
                    setRedSecondValue = true;
                    RedSecondValue = 255;
                    break;
                case  ColorCategory.PrimaryDark:
                    setBlueSecondValue = true;
                    BlueSecondValue = 137;
                    setGreenSecondValue = true;
                    GreenSecondValue = 120;
                    setRedSecondValue = true;
                    RedSecondValue = 4;
                    break;
                case  ColorCategory.Primary:
                    setBlueSecondValue = true;
                    BlueSecondValue = 177;
                    setGreenSecondValue = true;
                    GreenSecondValue = 159;
                    setRedSecondValue = true;
                    RedSecondValue = 6;
                    break;
                case  ColorCategory.PrimaryLight:
                    setBlueSecondValue = true;
                    BlueSecondValue = 193;
                    setGreenSecondValue = true;
                    GreenSecondValue = 180;
                    setRedSecondValue = true;
                    RedSecondValue = 74;
                    break;
                case  ColorCategory.Success:
                    setBlueSecondValue = true;
                    BlueSecondValue = 48;
                    setGreenSecondValue = true;
                    GreenSecondValue = 167;
                    setRedSecondValue = true;
                    RedSecondValue = 62;
                    break;
                case  ColorCategory.Warning:
                    setBlueSecondValue = true;
                    BlueSecondValue = 25;
                    setGreenSecondValue = true;
                    GreenSecondValue = 171;
                    setRedSecondValue = true;
                    RedSecondValue = 232;
                    break;
                case  ColorCategory.Danger:
                    setBlueSecondValue = true;
                    BlueSecondValue = 41;
                    setGreenSecondValue = true;
                    GreenSecondValue = 18;
                    setRedSecondValue = true;
                    RedSecondValue = 212;
                    break;
                case  ColorCategory.Accent:
                    setBlueSecondValue = true;
                    BlueSecondValue = 138;
                    setGreenSecondValue = true;
                    GreenSecondValue = 48;
                    setRedSecondValue = true;
                    RedSecondValue = 140;
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            // all values assigned in this state do not require recursive updates:
            suspendRecursively = false;
            var isSafeToInterpolateWithoutSuppression = true;
            isSafeToInterpolateWithoutSuppression &= this.Parent as Gum.Wireframe.GraphicalUiElement == null && this.XUnits == Gum.Converters.GeneralUnitType.PixelsFromSmall && this.XOrigin == RenderingLibrary.Graphics.HorizontalAlignment.Left;
            if(isSafeToInterpolateWithoutSuppression) shouldSuspend = false;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setBlueFirstValue && setBlueSecondValue)
            {
                Blue = FlatRedBall.Math.MathFunctions.RoundToInt(BlueFirstValue* (1 - interpolationValue) + BlueSecondValue * interpolationValue);
            }
            if (setGreenFirstValue && setGreenSecondValue)
            {
                Green = FlatRedBall.Math.MathFunctions.RoundToInt(GreenFirstValue* (1 - interpolationValue) + GreenSecondValue * interpolationValue);
            }
            if (setRedFirstValue && setRedSecondValue)
            {
                Red = FlatRedBall.Math.MathFunctions.RoundToInt(RedFirstValue* (1 - interpolationValue) + RedSecondValue * interpolationValue);
            }
            if (interpolationValue < 1)
            {
                mCurrentColorCategoryState = firstState;
            }
            else
            {
                mCurrentColorCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        public void InterpolateBetween (StyleCategory firstState, StyleCategory secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setFontSizeFirstValue = false;
            bool setFontSizeSecondValue = false;
            int FontSizeFirstValue= 0;
            int FontSizeSecondValue= 0;
            switch(firstState)
            {
                case  StyleCategory.Tiny:
                    setFontSizeFirstValue = true;
                    FontSizeFirstValue = 10;
                    if (interpolationValue < 1)
                    {
                        this.IsBold = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.Small:
                    setFontSizeFirstValue = true;
                    FontSizeFirstValue = 12;
                    if (interpolationValue < 1)
                    {
                        this.IsBold = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.Normal:
                    setFontSizeFirstValue = true;
                    FontSizeFirstValue = 14;
                    if (interpolationValue < 1)
                    {
                        this.IsBold = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.Emphasis:
                    setFontSizeFirstValue = true;
                    FontSizeFirstValue = 14;
                    if (interpolationValue < 1)
                    {
                        this.IsBold = false;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IsItalic = true;
                    }
                    break;
                case  StyleCategory.Strong:
                    setFontSizeFirstValue = true;
                    FontSizeFirstValue = 14;
                    if (interpolationValue < 1)
                    {
                        this.IsBold = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.H3:
                    setFontSizeFirstValue = true;
                    FontSizeFirstValue = 16;
                    if (interpolationValue < 1)
                    {
                        this.IsBold = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.H2:
                    setFontSizeFirstValue = true;
                    FontSizeFirstValue = 18;
                    if (interpolationValue < 1)
                    {
                        this.IsBold = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.H1:
                    setFontSizeFirstValue = true;
                    FontSizeFirstValue = 22;
                    if (interpolationValue < 1)
                    {
                        this.IsBold = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.Title:
                    setFontSizeFirstValue = true;
                    FontSizeFirstValue = 28;
                    if (interpolationValue < 1)
                    {
                        this.IsBold = true;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
            }
            switch(secondState)
            {
                case  StyleCategory.Tiny:
                    setFontSizeSecondValue = true;
                    FontSizeSecondValue = 10;
                    if (interpolationValue >= 1)
                    {
                        this.IsBold = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.Small:
                    setFontSizeSecondValue = true;
                    FontSizeSecondValue = 12;
                    if (interpolationValue >= 1)
                    {
                        this.IsBold = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.Normal:
                    setFontSizeSecondValue = true;
                    FontSizeSecondValue = 14;
                    if (interpolationValue >= 1)
                    {
                        this.IsBold = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.Emphasis:
                    setFontSizeSecondValue = true;
                    FontSizeSecondValue = 14;
                    if (interpolationValue >= 1)
                    {
                        this.IsBold = false;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IsItalic = true;
                    }
                    break;
                case  StyleCategory.Strong:
                    setFontSizeSecondValue = true;
                    FontSizeSecondValue = 14;
                    if (interpolationValue >= 1)
                    {
                        this.IsBold = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.H3:
                    setFontSizeSecondValue = true;
                    FontSizeSecondValue = 16;
                    if (interpolationValue >= 1)
                    {
                        this.IsBold = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.H2:
                    setFontSizeSecondValue = true;
                    FontSizeSecondValue = 18;
                    if (interpolationValue >= 1)
                    {
                        this.IsBold = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.H1:
                    setFontSizeSecondValue = true;
                    FontSizeSecondValue = 22;
                    if (interpolationValue >= 1)
                    {
                        this.IsBold = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IsItalic = false;
                    }
                    break;
                case  StyleCategory.Title:
                    setFontSizeSecondValue = true;
                    FontSizeSecondValue = 28;
                    if (interpolationValue >= 1)
                    {
                        this.IsBold = true;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IsItalic = false;
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
            if (setFontSizeFirstValue && setFontSizeSecondValue)
            {
                FontSize = FlatRedBall.Math.MathFunctions.RoundToInt(FontSizeFirstValue* (1 - interpolationValue) + FontSizeSecondValue * interpolationValue);
            }
            if (interpolationValue < 1)
            {
                mCurrentStyleCategoryState = firstState;
            }
            else
            {
                mCurrentStyleCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.TextRuntime.VariableState fromState,Harvesteer.GumRuntimes.TextRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.TextRuntime.ColorCategory fromState,Harvesteer.GumRuntimes.TextRuntime.ColorCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ColorCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ColorCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentColorCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ColorCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentColorCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.TextRuntime.StyleCategory fromState,Harvesteer.GumRuntimes.TextRuntime.StyleCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (StyleCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "StyleCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentStyleCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (StyleCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentStyleCategoryState = toState;
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
                        Name = "Alpha",
                        Type = "int",
                        Value = Alpha
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CustomFontFile",
                        Type = "string",
                        Value = CustomFontFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ExposeChildrenEvents",
                        Type = "bool",
                        Value = ExposeChildrenEvents
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Font",
                        Type = "string",
                        Value = Font
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Font Scale",
                        Type = "float",
                        Value = FontScale
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "HasEvents",
                        Type = "bool",
                        Value = HasEvents
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
                        Name = "Height Units",
                        Type = "DimensionUnitType",
                        Value = HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "HorizontalAlignment",
                        Type = "HorizontalAlignment",
                        Value = HorizontalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IgnoredByParentSize",
                        Type = "bool",
                        Value = IgnoredByParentSize
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LineHeightMultiplier",
                        Type = "float",
                        Value = LineHeightMultiplier
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "OutlineThickness",
                        Type = "int",
                        Value = OutlineThickness
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Rotation",
                        Type = "float",
                        Value = Rotation
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Text",
                        Type = "string",
                        Value = Text
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextOverflowHorizontalMode",
                        Type = "TextOverflowHorizontalMode",
                        Value = TextOverflowHorizontalMode
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextOverflowVerticalMode",
                        Type = "TextOverflowVerticalMode",
                        Value = TextOverflowVerticalMode
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UseCustomFont",
                        Type = "bool",
                        Value = UseCustomFont
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UseFontSmoothing",
                        Type = "bool",
                        Value = UseFontSmoothing
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalAlignment",
                        Type = "VerticalAlignment",
                        Value = VerticalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Visible",
                        Type = "bool",
                        Value = Visible
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
                        Name = "X Units",
                        Type = "PositionUnitType",
                        Value = XUnits
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
                        Name = "Y Units",
                        Type = "PositionUnitType",
                        Value = YUnits
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
                        Name = "Alpha",
                        Type = "int",
                        Value = Alpha + 255
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "CustomFontFile",
                        Type = "string",
                        Value = CustomFontFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ExposeChildrenEvents",
                        Type = "bool",
                        Value = ExposeChildrenEvents
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Font",
                        Type = "string",
                        Value = Font
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Font Scale",
                        Type = "float",
                        Value = FontScale + 1f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize + 12
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "HasEvents",
                        Type = "bool",
                        Value = HasEvents
                    }
                    );
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
                        Name = "HorizontalAlignment",
                        Type = "HorizontalAlignment",
                        Value = HorizontalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IgnoredByParentSize",
                        Type = "bool",
                        Value = IgnoredByParentSize
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "LineHeightMultiplier",
                        Type = "float",
                        Value = LineHeightMultiplier + 1f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "OutlineThickness",
                        Type = "int",
                        Value = OutlineThickness + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Rotation",
                        Type = "float",
                        Value = Rotation + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Text",
                        Type = "string",
                        Value = Text
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextOverflowHorizontalMode",
                        Type = "TextOverflowHorizontalMode",
                        Value = TextOverflowHorizontalMode
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "TextOverflowVerticalMode",
                        Type = "TextOverflowVerticalMode",
                        Value = TextOverflowVerticalMode
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UseCustomFont",
                        Type = "bool",
                        Value = UseCustomFont
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "UseFontSmoothing",
                        Type = "bool",
                        Value = UseFontSmoothing
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalAlignment",
                        Type = "VerticalAlignment",
                        Value = VerticalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Visible",
                        Type = "bool",
                        Value = Visible
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
                        Name = "X Units",
                        Type = "PositionUnitType",
                        Value = XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Y",
                        Type = "float",
                        Value = Y + 0f
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
                        Name = "Y Units",
                        Type = "PositionUnitType",
                        Value = YUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ColorCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  ColorCategory.Black:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    break;
                case  ColorCategory.DarkGray:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    break;
                case  ColorCategory.Gray:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    break;
                case  ColorCategory.LightGray:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    break;
                case  ColorCategory.White:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    break;
                case  ColorCategory.PrimaryDark:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    break;
                case  ColorCategory.Primary:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    break;
                case  ColorCategory.PrimaryLight:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    break;
                case  ColorCategory.Success:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    break;
                case  ColorCategory.Warning:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    break;
                case  ColorCategory.Danger:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    break;
                case  ColorCategory.Accent:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ColorCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  ColorCategory.Black:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 0
                    }
                    );
                    break;
                case  ColorCategory.DarkGray:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 70
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 70
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 70
                    }
                    );
                    break;
                case  ColorCategory.Gray:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 130
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 130
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 130
                    }
                    );
                    break;
                case  ColorCategory.LightGray:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 170
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 170
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 170
                    }
                    );
                    break;
                case  ColorCategory.White:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 255
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 255
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 255
                    }
                    );
                    break;
                case  ColorCategory.PrimaryDark:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 137
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 120
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 4
                    }
                    );
                    break;
                case  ColorCategory.Primary:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 177
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 159
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 6
                    }
                    );
                    break;
                case  ColorCategory.PrimaryLight:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 193
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 180
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 74
                    }
                    );
                    break;
                case  ColorCategory.Success:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 48
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 167
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 62
                    }
                    );
                    break;
                case  ColorCategory.Warning:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 25
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 171
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 232
                    }
                    );
                    break;
                case  ColorCategory.Danger:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 41
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 18
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 212
                    }
                    );
                    break;
                case  ColorCategory.Accent:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Blue",
                        Type = "int",
                        Value = Blue + 138
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Green",
                        Type = "int",
                        Value = Green + 48
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Red",
                        Type = "int",
                        Value = Red + 140
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (StyleCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  StyleCategory.Tiny:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.Small:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.Normal:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.Emphasis:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.Strong:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.H3:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.H2:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.H1:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.Title:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (StyleCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  StyleCategory.Tiny:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize + 10
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.Small:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize + 12
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.Normal:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize + 14
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.Emphasis:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize + 14
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.Strong:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize + 14
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.H3:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize + 16
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.H2:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize + 18
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.H1:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize + 22
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
                    }
                    );
                    break;
                case  StyleCategory.Title:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FontSize",
                        Type = "int",
                        Value = FontSize + 28
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsBold",
                        Type = "bool",
                        Value = IsBold
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IsItalic",
                        Type = "bool",
                        Value = IsItalic
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
                else if (category.Name == "ColorCategory")
                {
                    if(state.Name == "Black") this.mCurrentColorCategoryState = ColorCategory.Black;
                    if(state.Name == "DarkGray") this.mCurrentColorCategoryState = ColorCategory.DarkGray;
                    if(state.Name == "Gray") this.mCurrentColorCategoryState = ColorCategory.Gray;
                    if(state.Name == "LightGray") this.mCurrentColorCategoryState = ColorCategory.LightGray;
                    if(state.Name == "White") this.mCurrentColorCategoryState = ColorCategory.White;
                    if(state.Name == "PrimaryDark") this.mCurrentColorCategoryState = ColorCategory.PrimaryDark;
                    if(state.Name == "Primary") this.mCurrentColorCategoryState = ColorCategory.Primary;
                    if(state.Name == "PrimaryLight") this.mCurrentColorCategoryState = ColorCategory.PrimaryLight;
                    if(state.Name == "Success") this.mCurrentColorCategoryState = ColorCategory.Success;
                    if(state.Name == "Warning") this.mCurrentColorCategoryState = ColorCategory.Warning;
                    if(state.Name == "Danger") this.mCurrentColorCategoryState = ColorCategory.Danger;
                    if(state.Name == "Accent") this.mCurrentColorCategoryState = ColorCategory.Accent;
                }
                else if (category.Name == "StyleCategory")
                {
                    if(state.Name == "Tiny") this.mCurrentStyleCategoryState = StyleCategory.Tiny;
                    if(state.Name == "Small") this.mCurrentStyleCategoryState = StyleCategory.Small;
                    if(state.Name == "Normal") this.mCurrentStyleCategoryState = StyleCategory.Normal;
                    if(state.Name == "Emphasis") this.mCurrentStyleCategoryState = StyleCategory.Emphasis;
                    if(state.Name == "Strong") this.mCurrentStyleCategoryState = StyleCategory.Strong;
                    if(state.Name == "H3") this.mCurrentStyleCategoryState = StyleCategory.H3;
                    if(state.Name == "H2") this.mCurrentStyleCategoryState = StyleCategory.H2;
                    if(state.Name == "H1") this.mCurrentStyleCategoryState = StyleCategory.H1;
                    if(state.Name == "Title") this.mCurrentStyleCategoryState = StyleCategory.Title;
                }
            }
            base.ApplyState(state);
        }
        public int Alpha
        {
            get
            {
                return ContainedText.Alpha;
            }
            set
            {
                ContainedText.Alpha = value;
                NotifyPropertyChanged();
            }
        }
        public int Blue
        {
            get
            {
                return ContainedText.Blue;
            }
            set
            {
                ContainedText.Blue = value;
                NotifyPropertyChanged();
            }
        }
        public float FontScale
        {
            get
            {
                return ContainedText.FontScale;
            }
            set
            {
                ContainedText.FontScale = value;
                UpdateLayout();
            }
        }
        public int Green
        {
            get
            {
                return ContainedText.Green;
            }
            set
            {
                ContainedText.Green = value;
                NotifyPropertyChanged();
            }
        }
        public RenderingLibrary.Graphics.HorizontalAlignment HorizontalAlignment
        {
            get
            {
                return ContainedText.HorizontalAlignment;
            }
            set
            {
                ContainedText.HorizontalAlignment = value;
                NotifyPropertyChanged();
            }
        }
        public float LineHeightMultiplier
        {
            get
            {
                return ContainedText.LineHeightMultiplier;
            }
            set
            {
                ContainedText.LineHeightMultiplier = value;
                NotifyPropertyChanged();
            }
        }
        public int? MaxLettersToShow
        {
            get
            {
                return ContainedText.MaxLettersToShow;
            }
            set
            {
                ContainedText.MaxLettersToShow = value;
                NotifyPropertyChanged();
            }
        }
        public int Red
        {
            get
            {
                return ContainedText.Red;
            }
            set
            {
                ContainedText.Red = value;
                NotifyPropertyChanged();
            }
        }
        public string Text
        {
            get
            {
                return ContainedText.RawText;
            }
            set
            {
                var widthBefore = ContainedText.WrappedTextWidth;
                var heightBefore = ContainedText.WrappedTextHeight;
                if (this.WidthUnits == Gum.DataTypes.DimensionUnitType.RelativeToChildren)
                {
                    // make it have no line wrap width before assignign the text:
                    ContainedText.Width = 0;
                }
                global::Gum.Wireframe.CustomSetPropertyOnRenderable.TrySetPropertyOnText(ContainedText, this, nameof(Text), value);
                NotifyPropertyChanged();
                var shouldUpdate = widthBefore != ContainedText.WrappedTextWidth || heightBefore != ContainedText.WrappedTextHeight;
                if (shouldUpdate)
                {
                    UpdateLayout(Gum.Wireframe.GraphicalUiElement.ParentUpdateType.IfParentWidthHeightDependOnChildren | Gum.Wireframe.GraphicalUiElement.ParentUpdateType.IfParentStacks, int.MaxValue/2);
                }
            }
        }
        public global::RenderingLibrary.Graphics.TextOverflowHorizontalMode TextOverflowHorizontalMode
        {
            get
            {
                return ContainedText.IsTruncatingWithEllipsisOnLastLine ? global::RenderingLibrary.Graphics.TextOverflowHorizontalMode.EllipsisLetter : RenderingLibrary.Graphics.TextOverflowHorizontalMode.TruncateWord;
            }
            set
            {
                if (value == global::RenderingLibrary.Graphics.TextOverflowHorizontalMode.EllipsisLetter)
                {
                    ContainedText.IsTruncatingWithEllipsisOnLastLine = true;
                }
                else
                {
                    ContainedText.IsTruncatingWithEllipsisOnLastLine = false;
                }
            }
        }
        public global::RenderingLibrary.Graphics.TextOverflowVerticalMode TextOverflowVerticalMode
        {
            get
            {
                return ContainedText.TextOverflowVerticalMode;
            }
            set
            {
                ContainedText.TextOverflowVerticalMode = value;
                NotifyPropertyChanged();
            }
        }
        public RenderingLibrary.Graphics.VerticalAlignment VerticalAlignment
        {
            get
            {
                return ContainedText.VerticalAlignment;
            }
            set
            {
                ContainedText.VerticalAlignment = value;
                NotifyPropertyChanged();
            }
        }
        public Microsoft.Xna.Framework.Color Color
        {
            get
            {
                return RenderingLibrary.Graphics.XNAExtensions.ToXNA(ContainedText.Color);
            }
            set
            {
                ContainedText.Color = RenderingLibrary.Graphics.XNAExtensions.ToSystemDrawing(value);
                NotifyPropertyChanged();
            }
        }
        public RenderingLibrary.Graphics.BitmapFont BitmapFont
        {
            get
            {
                return ContainedText.BitmapFont;
            }
            set
            {
                ContainedText.BitmapFont = value;
                NotifyPropertyChanged();
            }
        }
        public System.Collections.Generic.List<string> WrappedText
        {
            get
            {
                return ContainedText.WrappedText;
            }
        }
        public override void SetInitialState () 
        {
            var wasSuppressed = this.IsLayoutSuspended;
            if(!wasSuppressed) this.SuspendLayout();
            this.CurrentVariableState = VariableState.Default;
            if(!wasSuppressed) this.ResumeLayout();
        }
        public RenderingLibrary.Graphics.TextRenderingPositionMode? OverrideTextRenderingPositionMode
        {
            get => mContainedText.OverrideTextRenderingPositionMode;
            set => mContainedText.OverrideTextRenderingPositionMode = value;
        }
    }
}
