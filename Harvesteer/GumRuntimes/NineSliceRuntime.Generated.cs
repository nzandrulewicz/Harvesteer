using System.Linq;
namespace Harvesteer.GumRuntimes
{
    public partial class NineSliceRuntime : global::Gum.Wireframe.GraphicalUiElement
    {
        public NineSliceRuntime () 
        	: this(true, true)
        {
        }
        public NineSliceRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        {
            this.HasEvents = false;
            this.ExposeChildrenEvents = false;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.StandardElements.First(item => item.Name == "NineSlice");
                this.ElementSave = elementSave;
                string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
            }
        }
        RenderingLibrary.Graphics.NineSlice mContainedNineSlice;
        RenderingLibrary.Graphics.NineSlice ContainedNineSlice
        {
            get
            {
                if (mContainedNineSlice == null)
                {
                    mContainedNineSlice = this.RenderableComponent as RenderingLibrary.Graphics.NineSlice;
                }
                return mContainedNineSlice;
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
            Solid,
            Bordered,
            BracketHorizontal,
            BracketVertical,
            Tab,
            TabBordered,
            Outlined,
            OutlinedHeavy,
            Panel
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
                        Blend = Gum.RenderingLibrary.Blend.Normal;
                        Blue = 255;
                        ExposeChildrenEvents = false;
                        Green = 255;
                        HasEvents = false;
                        Height = 0f;
                        HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        IgnoredByParentSize = false;
                        Red = 255;
                        SetProperty("SourceFile", "UISpriteSheet.png");
                        TextureAddress = Gum.Managers.TextureAddress.Custom;
                        TextureHeight = 24;
                        TextureLeft = 0;
                        TextureTop = 48;
                        TextureWidth = 24;
                        Visible = true;
                        Width = 0f;
                        WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        X = 0f;
                        XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        Y = 0f;
                        YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
                        case  StyleCategory.Solid:
                            TextureHeight = 24;
                            TextureLeft = 0;
                            TextureTop = 48;
                            TextureWidth = 24;
                            break;
                        case  StyleCategory.Bordered:
                            TextureHeight = 24;
                            TextureLeft = 24;
                            TextureTop = 48;
                            TextureWidth = 24;
                            break;
                        case  StyleCategory.BracketHorizontal:
                            TextureHeight = 24;
                            TextureLeft = 72;
                            TextureTop = 72;
                            TextureWidth = 24;
                            break;
                        case  StyleCategory.BracketVertical:
                            TextureHeight = 24;
                            TextureLeft = 48;
                            TextureTop = 72;
                            TextureWidth = 24;
                            break;
                        case  StyleCategory.Tab:
                            TextureHeight = 24;
                            TextureLeft = 48;
                            TextureTop = 48;
                            TextureWidth = 24;
                            break;
                        case  StyleCategory.TabBordered:
                            TextureHeight = 24;
                            TextureLeft = 72;
                            TextureTop = 48;
                            TextureWidth = 24;
                            break;
                        case  StyleCategory.Outlined:
                            TextureHeight = 24;
                            TextureLeft = 0;
                            TextureTop = 72;
                            TextureWidth = 24;
                            break;
                        case  StyleCategory.OutlinedHeavy:
                            TextureHeight = 24;
                            TextureLeft = 24;
                            TextureTop = 72;
                            TextureWidth = 24;
                            break;
                        case  StyleCategory.Panel:
                            TextureHeight = 24;
                            TextureLeft = 96;
                            TextureTop = 48;
                            TextureWidth = 24;
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
            bool setGreenFirstValue = false;
            bool setGreenSecondValue = false;
            int GreenFirstValue= 0;
            int GreenSecondValue= 0;
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setRedFirstValue = false;
            bool setRedSecondValue = false;
            int RedFirstValue= 0;
            int RedSecondValue= 0;
            bool setTextureHeightFirstValue = false;
            bool setTextureHeightSecondValue = false;
            int TextureHeightFirstValue= 0;
            int TextureHeightSecondValue= 0;
            bool setTextureLeftFirstValue = false;
            bool setTextureLeftSecondValue = false;
            int TextureLeftFirstValue= 0;
            int TextureLeftSecondValue= 0;
            bool setTextureTopFirstValue = false;
            bool setTextureTopSecondValue = false;
            int TextureTopFirstValue= 0;
            int TextureTopSecondValue= 0;
            bool setTextureWidthFirstValue = false;
            bool setTextureWidthSecondValue = false;
            int TextureWidthFirstValue= 0;
            int TextureWidthSecondValue= 0;
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
                    if (interpolationValue < 1)
                    {
                        this.Blend = Gum.RenderingLibrary.Blend.Normal;
                    }
                    setBlueFirstValue = true;
                    BlueFirstValue = 255;
                    if (interpolationValue < 1)
                    {
                        this.ExposeChildrenEvents = false;
                    }
                    setGreenFirstValue = true;
                    GreenFirstValue = 255;
                    if (interpolationValue < 1)
                    {
                        this.HasEvents = false;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IgnoredByParentSize = false;
                    }
                    setRedFirstValue = true;
                    RedFirstValue = 255;
                    if (interpolationValue < 1)
                    {
                        SetProperty("SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue < 1)
                    {
                        this.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setTextureHeightFirstValue = true;
                    TextureHeightFirstValue = 24;
                    setTextureLeftFirstValue = true;
                    TextureLeftFirstValue = 0;
                    setTextureTopFirstValue = true;
                    TextureTopFirstValue = 48;
                    setTextureWidthFirstValue = true;
                    TextureWidthFirstValue = 24;
                    if (interpolationValue < 1)
                    {
                        this.Visible = true;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setXFirstValue = true;
                    XFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setYFirstValue = true;
                    YFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setAlphaSecondValue = true;
                    AlphaSecondValue = 255;
                    if (interpolationValue >= 1)
                    {
                        this.Blend = Gum.RenderingLibrary.Blend.Normal;
                    }
                    setBlueSecondValue = true;
                    BlueSecondValue = 255;
                    if (interpolationValue >= 1)
                    {
                        this.ExposeChildrenEvents = false;
                    }
                    setGreenSecondValue = true;
                    GreenSecondValue = 255;
                    if (interpolationValue >= 1)
                    {
                        this.HasEvents = false;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IgnoredByParentSize = false;
                    }
                    setRedSecondValue = true;
                    RedSecondValue = 255;
                    if (interpolationValue >= 1)
                    {
                        SetProperty("SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue >= 1)
                    {
                        this.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setTextureHeightSecondValue = true;
                    TextureHeightSecondValue = 24;
                    setTextureLeftSecondValue = true;
                    TextureLeftSecondValue = 0;
                    setTextureTopSecondValue = true;
                    TextureTopSecondValue = 48;
                    setTextureWidthSecondValue = true;
                    TextureWidthSecondValue = 24;
                    if (interpolationValue >= 1)
                    {
                        this.Visible = true;
                    }
                    setWidthSecondValue = true;
                    WidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setXSecondValue = true;
                    XSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setYSecondValue = true;
                    YSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
            if (setGreenFirstValue && setGreenSecondValue)
            {
                Green = FlatRedBall.Math.MathFunctions.RoundToInt(GreenFirstValue* (1 - interpolationValue) + GreenSecondValue * interpolationValue);
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setRedFirstValue && setRedSecondValue)
            {
                Red = FlatRedBall.Math.MathFunctions.RoundToInt(RedFirstValue* (1 - interpolationValue) + RedSecondValue * interpolationValue);
            }
            if (setTextureHeightFirstValue && setTextureHeightSecondValue)
            {
                TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TextureHeightFirstValue* (1 - interpolationValue) + TextureHeightSecondValue * interpolationValue);
            }
            if (setTextureLeftFirstValue && setTextureLeftSecondValue)
            {
                TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TextureLeftFirstValue* (1 - interpolationValue) + TextureLeftSecondValue * interpolationValue);
            }
            if (setTextureTopFirstValue && setTextureTopSecondValue)
            {
                TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TextureTopFirstValue* (1 - interpolationValue) + TextureTopSecondValue * interpolationValue);
            }
            if (setTextureWidthFirstValue && setTextureWidthSecondValue)
            {
                TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TextureWidthFirstValue* (1 - interpolationValue) + TextureWidthSecondValue * interpolationValue);
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
            bool setTextureHeightFirstValue = false;
            bool setTextureHeightSecondValue = false;
            int TextureHeightFirstValue= 0;
            int TextureHeightSecondValue= 0;
            bool setTextureLeftFirstValue = false;
            bool setTextureLeftSecondValue = false;
            int TextureLeftFirstValue= 0;
            int TextureLeftSecondValue= 0;
            bool setTextureTopFirstValue = false;
            bool setTextureTopSecondValue = false;
            int TextureTopFirstValue= 0;
            int TextureTopSecondValue= 0;
            bool setTextureWidthFirstValue = false;
            bool setTextureWidthSecondValue = false;
            int TextureWidthFirstValue= 0;
            int TextureWidthSecondValue= 0;
            switch(firstState)
            {
                case  StyleCategory.Solid:
                    setTextureHeightFirstValue = true;
                    TextureHeightFirstValue = 24;
                    setTextureLeftFirstValue = true;
                    TextureLeftFirstValue = 0;
                    setTextureTopFirstValue = true;
                    TextureTopFirstValue = 48;
                    setTextureWidthFirstValue = true;
                    TextureWidthFirstValue = 24;
                    break;
                case  StyleCategory.Bordered:
                    setTextureHeightFirstValue = true;
                    TextureHeightFirstValue = 24;
                    setTextureLeftFirstValue = true;
                    TextureLeftFirstValue = 24;
                    setTextureTopFirstValue = true;
                    TextureTopFirstValue = 48;
                    setTextureWidthFirstValue = true;
                    TextureWidthFirstValue = 24;
                    break;
                case  StyleCategory.BracketHorizontal:
                    setTextureHeightFirstValue = true;
                    TextureHeightFirstValue = 24;
                    setTextureLeftFirstValue = true;
                    TextureLeftFirstValue = 72;
                    setTextureTopFirstValue = true;
                    TextureTopFirstValue = 72;
                    setTextureWidthFirstValue = true;
                    TextureWidthFirstValue = 24;
                    break;
                case  StyleCategory.BracketVertical:
                    setTextureHeightFirstValue = true;
                    TextureHeightFirstValue = 24;
                    setTextureLeftFirstValue = true;
                    TextureLeftFirstValue = 48;
                    setTextureTopFirstValue = true;
                    TextureTopFirstValue = 72;
                    setTextureWidthFirstValue = true;
                    TextureWidthFirstValue = 24;
                    break;
                case  StyleCategory.Tab:
                    setTextureHeightFirstValue = true;
                    TextureHeightFirstValue = 24;
                    setTextureLeftFirstValue = true;
                    TextureLeftFirstValue = 48;
                    setTextureTopFirstValue = true;
                    TextureTopFirstValue = 48;
                    setTextureWidthFirstValue = true;
                    TextureWidthFirstValue = 24;
                    break;
                case  StyleCategory.TabBordered:
                    setTextureHeightFirstValue = true;
                    TextureHeightFirstValue = 24;
                    setTextureLeftFirstValue = true;
                    TextureLeftFirstValue = 72;
                    setTextureTopFirstValue = true;
                    TextureTopFirstValue = 48;
                    setTextureWidthFirstValue = true;
                    TextureWidthFirstValue = 24;
                    break;
                case  StyleCategory.Outlined:
                    setTextureHeightFirstValue = true;
                    TextureHeightFirstValue = 24;
                    setTextureLeftFirstValue = true;
                    TextureLeftFirstValue = 0;
                    setTextureTopFirstValue = true;
                    TextureTopFirstValue = 72;
                    setTextureWidthFirstValue = true;
                    TextureWidthFirstValue = 24;
                    break;
                case  StyleCategory.OutlinedHeavy:
                    setTextureHeightFirstValue = true;
                    TextureHeightFirstValue = 24;
                    setTextureLeftFirstValue = true;
                    TextureLeftFirstValue = 24;
                    setTextureTopFirstValue = true;
                    TextureTopFirstValue = 72;
                    setTextureWidthFirstValue = true;
                    TextureWidthFirstValue = 24;
                    break;
                case  StyleCategory.Panel:
                    setTextureHeightFirstValue = true;
                    TextureHeightFirstValue = 24;
                    setTextureLeftFirstValue = true;
                    TextureLeftFirstValue = 96;
                    setTextureTopFirstValue = true;
                    TextureTopFirstValue = 48;
                    setTextureWidthFirstValue = true;
                    TextureWidthFirstValue = 24;
                    break;
            }
            switch(secondState)
            {
                case  StyleCategory.Solid:
                    setTextureHeightSecondValue = true;
                    TextureHeightSecondValue = 24;
                    setTextureLeftSecondValue = true;
                    TextureLeftSecondValue = 0;
                    setTextureTopSecondValue = true;
                    TextureTopSecondValue = 48;
                    setTextureWidthSecondValue = true;
                    TextureWidthSecondValue = 24;
                    break;
                case  StyleCategory.Bordered:
                    setTextureHeightSecondValue = true;
                    TextureHeightSecondValue = 24;
                    setTextureLeftSecondValue = true;
                    TextureLeftSecondValue = 24;
                    setTextureTopSecondValue = true;
                    TextureTopSecondValue = 48;
                    setTextureWidthSecondValue = true;
                    TextureWidthSecondValue = 24;
                    break;
                case  StyleCategory.BracketHorizontal:
                    setTextureHeightSecondValue = true;
                    TextureHeightSecondValue = 24;
                    setTextureLeftSecondValue = true;
                    TextureLeftSecondValue = 72;
                    setTextureTopSecondValue = true;
                    TextureTopSecondValue = 72;
                    setTextureWidthSecondValue = true;
                    TextureWidthSecondValue = 24;
                    break;
                case  StyleCategory.BracketVertical:
                    setTextureHeightSecondValue = true;
                    TextureHeightSecondValue = 24;
                    setTextureLeftSecondValue = true;
                    TextureLeftSecondValue = 48;
                    setTextureTopSecondValue = true;
                    TextureTopSecondValue = 72;
                    setTextureWidthSecondValue = true;
                    TextureWidthSecondValue = 24;
                    break;
                case  StyleCategory.Tab:
                    setTextureHeightSecondValue = true;
                    TextureHeightSecondValue = 24;
                    setTextureLeftSecondValue = true;
                    TextureLeftSecondValue = 48;
                    setTextureTopSecondValue = true;
                    TextureTopSecondValue = 48;
                    setTextureWidthSecondValue = true;
                    TextureWidthSecondValue = 24;
                    break;
                case  StyleCategory.TabBordered:
                    setTextureHeightSecondValue = true;
                    TextureHeightSecondValue = 24;
                    setTextureLeftSecondValue = true;
                    TextureLeftSecondValue = 72;
                    setTextureTopSecondValue = true;
                    TextureTopSecondValue = 48;
                    setTextureWidthSecondValue = true;
                    TextureWidthSecondValue = 24;
                    break;
                case  StyleCategory.Outlined:
                    setTextureHeightSecondValue = true;
                    TextureHeightSecondValue = 24;
                    setTextureLeftSecondValue = true;
                    TextureLeftSecondValue = 0;
                    setTextureTopSecondValue = true;
                    TextureTopSecondValue = 72;
                    setTextureWidthSecondValue = true;
                    TextureWidthSecondValue = 24;
                    break;
                case  StyleCategory.OutlinedHeavy:
                    setTextureHeightSecondValue = true;
                    TextureHeightSecondValue = 24;
                    setTextureLeftSecondValue = true;
                    TextureLeftSecondValue = 24;
                    setTextureTopSecondValue = true;
                    TextureTopSecondValue = 72;
                    setTextureWidthSecondValue = true;
                    TextureWidthSecondValue = 24;
                    break;
                case  StyleCategory.Panel:
                    setTextureHeightSecondValue = true;
                    TextureHeightSecondValue = 24;
                    setTextureLeftSecondValue = true;
                    TextureLeftSecondValue = 96;
                    setTextureTopSecondValue = true;
                    TextureTopSecondValue = 48;
                    setTextureWidthSecondValue = true;
                    TextureWidthSecondValue = 24;
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setTextureHeightFirstValue && setTextureHeightSecondValue)
            {
                TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(TextureHeightFirstValue* (1 - interpolationValue) + TextureHeightSecondValue * interpolationValue);
            }
            if (setTextureLeftFirstValue && setTextureLeftSecondValue)
            {
                TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(TextureLeftFirstValue* (1 - interpolationValue) + TextureLeftSecondValue * interpolationValue);
            }
            if (setTextureTopFirstValue && setTextureTopSecondValue)
            {
                TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(TextureTopFirstValue* (1 - interpolationValue) + TextureTopSecondValue * interpolationValue);
            }
            if (setTextureWidthFirstValue && setTextureWidthSecondValue)
            {
                TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(TextureWidthFirstValue* (1 - interpolationValue) + TextureWidthSecondValue * interpolationValue);
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.NineSliceRuntime.VariableState fromState,Harvesteer.GumRuntimes.NineSliceRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory fromState,Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory fromState,Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                        Name = "Blend",
                        Type = "Blend",
                        Value = Blend
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
                        Name = "ExposeChildrenEvents",
                        Type = "bool",
                        Value = ExposeChildrenEvents
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
                        Name = "IgnoredByParentSize",
                        Type = "bool",
                        Value = IgnoredByParentSize
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
                        Name = "SourceFile",
                        Type = "string",
                        Value = SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Address",
                        Type = "TextureAddress",
                        Value = TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth
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
                        Name = "Blend",
                        Type = "Blend",
                        Value = Blend
                    }
                    );
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
                        Name = "ExposeChildrenEvents",
                        Type = "bool",
                        Value = ExposeChildrenEvents
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
                        Name = "IgnoredByParentSize",
                        Type = "bool",
                        Value = IgnoredByParentSize
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
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "SourceFile",
                        Type = "string",
                        Value = SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Address",
                        Type = "TextureAddress",
                        Value = TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop + 48
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth + 24
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
                case  StyleCategory.Solid:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth
                    }
                    );
                    break;
                case  StyleCategory.Bordered:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth
                    }
                    );
                    break;
                case  StyleCategory.BracketHorizontal:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth
                    }
                    );
                    break;
                case  StyleCategory.BracketVertical:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth
                    }
                    );
                    break;
                case  StyleCategory.Tab:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth
                    }
                    );
                    break;
                case  StyleCategory.TabBordered:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth
                    }
                    );
                    break;
                case  StyleCategory.Outlined:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth
                    }
                    );
                    break;
                case  StyleCategory.OutlinedHeavy:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth
                    }
                    );
                    break;
                case  StyleCategory.Panel:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth
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
                case  StyleCategory.Solid:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop + 48
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth + 24
                    }
                    );
                    break;
                case  StyleCategory.Bordered:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop + 48
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth + 24
                    }
                    );
                    break;
                case  StyleCategory.BracketHorizontal:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft + 72
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop + 72
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth + 24
                    }
                    );
                    break;
                case  StyleCategory.BracketVertical:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft + 48
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop + 72
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth + 24
                    }
                    );
                    break;
                case  StyleCategory.Tab:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft + 48
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop + 48
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth + 24
                    }
                    );
                    break;
                case  StyleCategory.TabBordered:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft + 72
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop + 48
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth + 24
                    }
                    );
                    break;
                case  StyleCategory.Outlined:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop + 72
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth + 24
                    }
                    );
                    break;
                case  StyleCategory.OutlinedHeavy:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop + 72
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth + 24
                    }
                    );
                    break;
                case  StyleCategory.Panel:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Height",
                        Type = "int",
                        Value = TextureHeight + 24
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Left",
                        Type = "int",
                        Value = TextureLeft + 96
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Top",
                        Type = "int",
                        Value = TextureTop + 48
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Texture Width",
                        Type = "int",
                        Value = TextureWidth + 24
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
                    if(state.Name == "Solid") this.mCurrentStyleCategoryState = StyleCategory.Solid;
                    if(state.Name == "Bordered") this.mCurrentStyleCategoryState = StyleCategory.Bordered;
                    if(state.Name == "BracketHorizontal") this.mCurrentStyleCategoryState = StyleCategory.BracketHorizontal;
                    if(state.Name == "BracketVertical") this.mCurrentStyleCategoryState = StyleCategory.BracketVertical;
                    if(state.Name == "Tab") this.mCurrentStyleCategoryState = StyleCategory.Tab;
                    if(state.Name == "TabBordered") this.mCurrentStyleCategoryState = StyleCategory.TabBordered;
                    if(state.Name == "Outlined") this.mCurrentStyleCategoryState = StyleCategory.Outlined;
                    if(state.Name == "OutlinedHeavy") this.mCurrentStyleCategoryState = StyleCategory.OutlinedHeavy;
                    if(state.Name == "Panel") this.mCurrentStyleCategoryState = StyleCategory.Panel;
                }
            }
            base.ApplyState(state);
        }
        public int Alpha
        {
            get
            {
                return ContainedNineSlice.Alpha;
            }
            set
            {
                ContainedNineSlice.Alpha = value;
                NotifyPropertyChanged();
            }
        }
        public Gum.RenderingLibrary.Blend Blend
        {
            get
            {
                return Gum.RenderingLibrary.BlendExtensions.ToBlend(ContainedNineSlice.BlendState);
            }
            set
            {
                ContainedNineSlice.BlendState = Gum.RenderingLibrary.BlendExtensions.ToBlendState(value);
                NotifyPropertyChanged();
            }
        }
        public int Blue
        {
            get
            {
                return ContainedNineSlice.Blue;
            }
            set
            {
                ContainedNineSlice.Blue = value;
                NotifyPropertyChanged();
            }
        }
        public float? CustomFrameTextureCoordinateWidth
        {
            get
            {
                return ContainedNineSlice.CustomFrameTextureCoordinateWidth;
            }
            set
            {
                ContainedNineSlice.CustomFrameTextureCoordinateWidth = value;
                NotifyPropertyChanged();
            }
        }
        public int Green
        {
            get
            {
                return ContainedNineSlice.Green;
            }
            set
            {
                ContainedNineSlice.Green = value;
                NotifyPropertyChanged();
            }
        }
        public int Red
        {
            get
            {
                return ContainedNineSlice.Red;
            }
            set
            {
                ContainedNineSlice.Red = value;
                NotifyPropertyChanged();
            }
        }
        public Microsoft.Xna.Framework.Graphics.Texture2D SourceFile
        {
            get
            {
                return ContainedNineSlice.TopLeftTexture;
            }
            set
            {
                ContainedNineSlice.SetSingleTexture(value);
            }
        }
        public Microsoft.Xna.Framework.Color Color
        {
            get
            {
                return RenderingLibrary.Graphics.XNAExtensions.ToXNA(ContainedNineSlice.Color);
            }
            set
            {
                ContainedNineSlice.Color = RenderingLibrary.Graphics.XNAExtensions.ToSystemDrawing(value);
                NotifyPropertyChanged();
            }
        }
        public override void SetInitialState () 
        {
            var wasSuppressed = this.IsLayoutSuspended;
            if(!wasSuppressed) this.SuspendLayout();
            this.CurrentVariableState = VariableState.Default;
            if(!wasSuppressed) this.ResumeLayout();
        }
    }
}
