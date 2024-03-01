using System.Linq;
namespace Harvesteer.GumRuntimes.Elements
{
    public partial class IconRuntime : Harvesteer.GumRuntimes.ContainerRuntime
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
        public enum IconCategory
        {
            None,
            ArrowUpDown,
            Arrow1,
            Arrow2,
            Arrow3,
            Basket,
            Battery,
            Check,
            CheckeredFlag,
            Circle1,
            Circle2,
            Close,
            Crosshairs,
            Currency,
            Cursor,
            CursorText,
            Delete,
            Enter,
            Expand,
            Gamepad,
            GamepadNES,
            GamepadSNES,
            GamepadNintendo64,
            GamepadGamecube,
            GamepadSwitchPro,
            GamepadXbox,
            GamepadPlaystationDualShock,
            GamepadSegaGenesis,
            Gear,
            FastForward,
            FastForwardBar,
            FitToScreen,
            Flame1,
            Flame2,
            Heart,
            Info,
            Keyboard,
            Leaf,
            Lightning,
            Minimize,
            Monitor,
            Mouse,
            Music,
            Pause,
            Pencil,
            Play,
            PlayBar,
            Power,
            Radiation,
            Reduce,
            Shield,
            Shot,
            Skull,
            Sliders,
            SoundMaximum,
            SoundMinimum,
            Speech,
            Star,
            Stop,
            Temperature,
            Touch,
            Trash,
            Trophy,
            User,
            UserAdd,
            UserDelete,
            UserGear,
            UserMulti,
            UserRemove,
            Warning,
            Wrench
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        IconCategory? mCurrentIconCategoryState;
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
                        IconSprite.CurrentColorCategoryState = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                        Height = 32f;
                        Width = 32f;
                        IconSprite.Height = 0f;
                        IconSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        SetProperty("IconSprite.SourceFile", "UISpriteSheet.png");
                        IconSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                        IconSprite.TextureHeight = 32;
                        IconSprite.TextureLeft = 288;
                        IconSprite.TextureTop = 0;
                        IconSprite.TextureWidth = 32;
                        IconSprite.Width = 0f;
                        IconSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        IconSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        IconSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        IconSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        IconSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        break;
                }
            }
        }
        public IconCategory? CurrentIconCategoryState
        {
            get
            {
                return mCurrentIconCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentIconCategoryState = value;
                    switch(mCurrentIconCategoryState)
                    {
                        case  IconCategory.None:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 288;
                            IconSprite.TextureTop = 0;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = false;
                            break;
                        case  IconCategory.ArrowUpDown:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 384;
                            IconSprite.TextureTop = 256;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Arrow1:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 288;
                            IconSprite.TextureTop = 256;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Arrow2:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 320;
                            IconSprite.TextureTop = 256;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Arrow3:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 256;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Basket:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 288;
                            IconSprite.TextureTop = 224;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Battery:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 320;
                            IconSprite.TextureTop = 224;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Check:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 384;
                            IconSprite.TextureTop = 128;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.CheckeredFlag:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 384;
                            IconSprite.TextureTop = 288;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Circle1:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 448;
                            IconSprite.TextureTop = 128;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Circle2:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 416;
                            IconSprite.TextureTop = 128;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Close:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 416;
                            IconSprite.TextureTop = 192;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Crosshairs:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 288;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Currency:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 224;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Cursor:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 384;
                            IconSprite.TextureTop = 32;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.CursorText:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 416;
                            IconSprite.TextureTop = 32;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Delete:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 288;
                            IconSprite.TextureTop = 320;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Enter:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 320;
                            IconSprite.TextureTop = 320;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Expand:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 384;
                            IconSprite.TextureTop = 192;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Gamepad:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 320;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.GamepadNES:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 416;
                            IconSprite.TextureTop = 320;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.GamepadSNES:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 448;
                            IconSprite.TextureTop = 320;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.GamepadNintendo64:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 384;
                            IconSprite.TextureTop = 352;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.GamepadGamecube:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 416;
                            IconSprite.TextureTop = 352;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.GamepadSwitchPro:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 320;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.GamepadXbox:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 384;
                            IconSprite.TextureTop = 320;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.GamepadPlaystationDualShock:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 352;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.GamepadSegaGenesis:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 448;
                            IconSprite.TextureTop = 352;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Gear:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 320;
                            IconSprite.TextureTop = 96;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.FastForward:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 384;
                            IconSprite.TextureTop = 160;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.FastForwardBar:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 416;
                            IconSprite.TextureTop = 160;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.FitToScreen:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 288;
                            IconSprite.TextureTop = 192;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Flame1:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 320;
                            IconSprite.TextureTop = 64;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Flame2:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 64;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Heart:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 320;
                            IconSprite.TextureTop = 128;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Info:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 416;
                            IconSprite.TextureTop = 256;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Keyboard:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 320;
                            IconSprite.TextureTop = 32;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Leaf:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 288;
                            IconSprite.TextureTop = 64;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Lightning:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 416;
                            IconSprite.TextureTop = 64;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Minimize:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 192;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Monitor:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 448;
                            IconSprite.TextureTop = 192;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Mouse:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 448;
                            IconSprite.TextureTop = 32;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Music:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 384;
                            IconSprite.TextureTop = 224;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Pause:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 320;
                            IconSprite.TextureTop = 160;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Pencil:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 288;
                            IconSprite.TextureTop = 96;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Play:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 288;
                            IconSprite.TextureTop = 160;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.PlayBar:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 448;
                            IconSprite.TextureTop = 160;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Power:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 288;
                            IconSprite.TextureTop = 288;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Radiation:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 384;
                            IconSprite.TextureTop = 64;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Reduce:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 320;
                            IconSprite.TextureTop = 192;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Shield:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 416;
                            IconSprite.TextureTop = 288;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Shot:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 320;
                            IconSprite.TextureTop = 288;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Skull:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 448;
                            IconSprite.TextureTop = 288;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Sliders:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 96;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.SoundMaximum:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 448;
                            IconSprite.TextureTop = 224;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.SoundMinimum:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 416;
                            IconSprite.TextureTop = 224;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Speech:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 448;
                            IconSprite.TextureTop = 96;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Star:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 128;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Stop:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 160;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Temperature:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 448;
                            IconSprite.TextureTop = 64;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Touch:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 32;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Trash:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 416;
                            IconSprite.TextureTop = 96;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Trophy:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 288;
                            IconSprite.TextureTop = 128;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.User:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 288;
                            IconSprite.TextureTop = 0;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.UserAdd:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 384;
                            IconSprite.TextureTop = 0;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.UserDelete:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 416;
                            IconSprite.TextureTop = 0;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.UserGear:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 352;
                            IconSprite.TextureTop = 0;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.UserMulti:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 320;
                            IconSprite.TextureTop = 0;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.UserRemove:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 448;
                            IconSprite.TextureTop = 0;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Warning:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 448;
                            IconSprite.TextureTop = 256;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
                            break;
                        case  IconCategory.Wrench:
                            IconSprite.TextureHeight = 32;
                            IconSprite.TextureLeft = 384;
                            IconSprite.TextureTop = 96;
                            IconSprite.TextureWidth = 32;
                            IconSprite.Visible = true;
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
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setIconSpriteCurrentColorCategoryStateFirstValue = false;
            bool setIconSpriteCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory IconSpriteCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory IconSpriteCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Black;
            bool setIconSpriteHeightFirstValue = false;
            bool setIconSpriteHeightSecondValue = false;
            float IconSpriteHeightFirstValue= 0;
            float IconSpriteHeightSecondValue= 0;
            bool setIconSpriteTextureHeightFirstValue = false;
            bool setIconSpriteTextureHeightSecondValue = false;
            int IconSpriteTextureHeightFirstValue= 0;
            int IconSpriteTextureHeightSecondValue= 0;
            bool setIconSpriteTextureLeftFirstValue = false;
            bool setIconSpriteTextureLeftSecondValue = false;
            int IconSpriteTextureLeftFirstValue= 0;
            int IconSpriteTextureLeftSecondValue= 0;
            bool setIconSpriteTextureTopFirstValue = false;
            bool setIconSpriteTextureTopSecondValue = false;
            int IconSpriteTextureTopFirstValue= 0;
            int IconSpriteTextureTopSecondValue= 0;
            bool setIconSpriteTextureWidthFirstValue = false;
            bool setIconSpriteTextureWidthSecondValue = false;
            int IconSpriteTextureWidthFirstValue= 0;
            int IconSpriteTextureWidthSecondValue= 0;
            bool setIconSpriteWidthFirstValue = false;
            bool setIconSpriteWidthSecondValue = false;
            float IconSpriteWidthFirstValue= 0;
            float IconSpriteWidthSecondValue= 0;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setHeightFirstValue = true;
                    HeightFirstValue = 32f;
                    setIconSpriteCurrentColorCategoryStateFirstValue = true;
                    IconSpriteCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    setIconSpriteHeightFirstValue = true;
                    IconSpriteHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        SetProperty("IconSprite.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 288;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 0;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    setIconSpriteWidthFirstValue = true;
                    IconSpriteWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthFirstValue = true;
                    WidthFirstValue = 32f;
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setHeightSecondValue = true;
                    HeightSecondValue = 32f;
                    setIconSpriteCurrentColorCategoryStateSecondValue = true;
                    IconSpriteCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    setIconSpriteHeightSecondValue = true;
                    IconSpriteHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        SetProperty("IconSprite.SourceFile", "UISpriteSheet.png");
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.TextureAddress = Gum.Managers.TextureAddress.Custom;
                    }
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 288;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 0;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    setIconSpriteWidthSecondValue = true;
                    IconSpriteWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setWidthSecondValue = true;
                    WidthSecondValue = 32f;
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
            if (setIconSpriteCurrentColorCategoryStateFirstValue && setIconSpriteCurrentColorCategoryStateSecondValue)
            {
                IconSprite.InterpolateBetween(IconSpriteCurrentColorCategoryStateFirstValue, IconSpriteCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setIconSpriteHeightFirstValue && setIconSpriteHeightSecondValue)
            {
                IconSprite.Height = IconSpriteHeightFirstValue * (1 - interpolationValue) + IconSpriteHeightSecondValue * interpolationValue;
            }
            if (setIconSpriteTextureHeightFirstValue && setIconSpriteTextureHeightSecondValue)
            {
                IconSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(IconSpriteTextureHeightFirstValue* (1 - interpolationValue) + IconSpriteTextureHeightSecondValue * interpolationValue);
            }
            if (setIconSpriteTextureLeftFirstValue && setIconSpriteTextureLeftSecondValue)
            {
                IconSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(IconSpriteTextureLeftFirstValue* (1 - interpolationValue) + IconSpriteTextureLeftSecondValue * interpolationValue);
            }
            if (setIconSpriteTextureTopFirstValue && setIconSpriteTextureTopSecondValue)
            {
                IconSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(IconSpriteTextureTopFirstValue* (1 - interpolationValue) + IconSpriteTextureTopSecondValue * interpolationValue);
            }
            if (setIconSpriteTextureWidthFirstValue && setIconSpriteTextureWidthSecondValue)
            {
                IconSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(IconSpriteTextureWidthFirstValue* (1 - interpolationValue) + IconSpriteTextureWidthSecondValue * interpolationValue);
            }
            if (setIconSpriteWidthFirstValue && setIconSpriteWidthSecondValue)
            {
                IconSprite.Width = IconSpriteWidthFirstValue * (1 - interpolationValue) + IconSpriteWidthSecondValue * interpolationValue;
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
        public void InterpolateBetween (IconCategory firstState, IconCategory secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setIconSpriteTextureHeightFirstValue = false;
            bool setIconSpriteTextureHeightSecondValue = false;
            int IconSpriteTextureHeightFirstValue= 0;
            int IconSpriteTextureHeightSecondValue= 0;
            bool setIconSpriteTextureLeftFirstValue = false;
            bool setIconSpriteTextureLeftSecondValue = false;
            int IconSpriteTextureLeftFirstValue= 0;
            int IconSpriteTextureLeftSecondValue= 0;
            bool setIconSpriteTextureTopFirstValue = false;
            bool setIconSpriteTextureTopSecondValue = false;
            int IconSpriteTextureTopFirstValue= 0;
            int IconSpriteTextureTopSecondValue= 0;
            bool setIconSpriteTextureWidthFirstValue = false;
            bool setIconSpriteTextureWidthSecondValue = false;
            int IconSpriteTextureWidthFirstValue= 0;
            int IconSpriteTextureWidthSecondValue= 0;
            switch(firstState)
            {
                case  IconCategory.None:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 288;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 0;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = false;
                    }
                    break;
                case  IconCategory.ArrowUpDown:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 384;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 256;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Arrow1:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 288;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 256;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Arrow2:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 320;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 256;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Arrow3:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 256;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Basket:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 288;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 224;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Battery:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 320;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 224;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Check:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 384;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 128;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.CheckeredFlag:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 384;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 288;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Circle1:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 448;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 128;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Circle2:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 416;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 128;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Close:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 416;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 192;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Crosshairs:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 288;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Currency:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 224;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Cursor:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 384;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 32;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.CursorText:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 416;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 32;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Delete:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 288;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 320;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Enter:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 320;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 320;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Expand:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 384;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 192;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Gamepad:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 320;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadNES:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 416;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 320;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadSNES:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 448;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 320;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadNintendo64:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 384;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 352;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadGamecube:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 416;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 352;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadSwitchPro:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 320;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadXbox:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 384;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 320;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadPlaystationDualShock:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 352;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadSegaGenesis:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 448;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 352;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Gear:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 320;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 96;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.FastForward:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 384;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 160;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.FastForwardBar:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 416;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 160;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.FitToScreen:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 288;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 192;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Flame1:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 320;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 64;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Flame2:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 64;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Heart:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 320;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 128;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Info:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 416;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 256;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Keyboard:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 320;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 32;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Leaf:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 288;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 64;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Lightning:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 416;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 64;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Minimize:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 192;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Monitor:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 448;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 192;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Mouse:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 448;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 32;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Music:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 384;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 224;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Pause:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 320;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 160;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Pencil:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 288;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 96;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Play:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 288;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 160;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.PlayBar:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 448;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 160;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Power:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 288;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 288;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Radiation:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 384;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 64;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Reduce:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 320;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 192;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Shield:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 416;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 288;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Shot:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 320;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 288;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Skull:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 448;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 288;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Sliders:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 96;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.SoundMaximum:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 448;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 224;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.SoundMinimum:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 416;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 224;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Speech:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 448;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 96;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Star:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 128;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Stop:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 160;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Temperature:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 448;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 64;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Touch:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 32;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Trash:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 416;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 96;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Trophy:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 288;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 128;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.User:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 288;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 0;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.UserAdd:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 384;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 0;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.UserDelete:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 416;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 0;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.UserGear:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 352;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 0;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.UserMulti:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 320;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 0;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.UserRemove:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 448;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 0;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Warning:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 448;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 256;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Wrench:
                    setIconSpriteTextureHeightFirstValue = true;
                    IconSpriteTextureHeightFirstValue = 32;
                    setIconSpriteTextureLeftFirstValue = true;
                    IconSpriteTextureLeftFirstValue = 384;
                    setIconSpriteTextureTopFirstValue = true;
                    IconSpriteTextureTopFirstValue = 96;
                    setIconSpriteTextureWidthFirstValue = true;
                    IconSpriteTextureWidthFirstValue = 32;
                    if (interpolationValue < 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
            }
            switch(secondState)
            {
                case  IconCategory.None:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 288;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 0;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = false;
                    }
                    break;
                case  IconCategory.ArrowUpDown:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 384;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 256;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Arrow1:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 288;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 256;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Arrow2:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 320;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 256;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Arrow3:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 256;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Basket:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 288;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 224;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Battery:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 320;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 224;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Check:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 384;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 128;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.CheckeredFlag:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 384;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 288;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Circle1:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 448;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 128;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Circle2:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 416;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 128;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Close:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 416;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 192;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Crosshairs:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 288;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Currency:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 224;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Cursor:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 384;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 32;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.CursorText:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 416;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 32;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Delete:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 288;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 320;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Enter:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 320;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 320;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Expand:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 384;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 192;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Gamepad:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 320;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadNES:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 416;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 320;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadSNES:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 448;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 320;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadNintendo64:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 384;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 352;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadGamecube:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 416;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 352;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadSwitchPro:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 320;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadXbox:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 384;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 320;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadPlaystationDualShock:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 352;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.GamepadSegaGenesis:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 448;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 352;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Gear:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 320;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 96;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.FastForward:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 384;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 160;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.FastForwardBar:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 416;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 160;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.FitToScreen:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 288;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 192;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Flame1:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 320;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 64;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Flame2:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 64;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Heart:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 320;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 128;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Info:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 416;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 256;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Keyboard:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 320;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 32;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Leaf:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 288;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 64;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Lightning:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 416;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 64;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Minimize:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 192;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Monitor:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 448;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 192;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Mouse:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 448;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 32;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Music:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 384;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 224;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Pause:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 320;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 160;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Pencil:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 288;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 96;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Play:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 288;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 160;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.PlayBar:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 448;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 160;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Power:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 288;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 288;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Radiation:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 384;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 64;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Reduce:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 320;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 192;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Shield:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 416;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 288;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Shot:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 320;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 288;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Skull:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 448;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 288;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Sliders:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 96;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.SoundMaximum:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 448;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 224;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.SoundMinimum:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 416;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 224;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Speech:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 448;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 96;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Star:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 128;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Stop:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 160;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Temperature:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 448;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 64;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Touch:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 32;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Trash:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 416;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 96;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Trophy:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 288;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 128;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.User:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 288;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 0;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.UserAdd:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 384;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 0;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.UserDelete:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 416;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 0;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.UserGear:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 352;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 0;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.UserMulti:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 320;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 0;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.UserRemove:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 448;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 0;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Warning:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 448;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 256;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
                    }
                    break;
                case  IconCategory.Wrench:
                    setIconSpriteTextureHeightSecondValue = true;
                    IconSpriteTextureHeightSecondValue = 32;
                    setIconSpriteTextureLeftSecondValue = true;
                    IconSpriteTextureLeftSecondValue = 384;
                    setIconSpriteTextureTopSecondValue = true;
                    IconSpriteTextureTopSecondValue = 96;
                    setIconSpriteTextureWidthSecondValue = true;
                    IconSpriteTextureWidthSecondValue = 32;
                    if (interpolationValue >= 1)
                    {
                        this.IconSprite.Visible = true;
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
            if (setIconSpriteTextureHeightFirstValue && setIconSpriteTextureHeightSecondValue)
            {
                IconSprite.TextureHeight = FlatRedBall.Math.MathFunctions.RoundToInt(IconSpriteTextureHeightFirstValue* (1 - interpolationValue) + IconSpriteTextureHeightSecondValue * interpolationValue);
            }
            if (setIconSpriteTextureLeftFirstValue && setIconSpriteTextureLeftSecondValue)
            {
                IconSprite.TextureLeft = FlatRedBall.Math.MathFunctions.RoundToInt(IconSpriteTextureLeftFirstValue* (1 - interpolationValue) + IconSpriteTextureLeftSecondValue * interpolationValue);
            }
            if (setIconSpriteTextureTopFirstValue && setIconSpriteTextureTopSecondValue)
            {
                IconSprite.TextureTop = FlatRedBall.Math.MathFunctions.RoundToInt(IconSpriteTextureTopFirstValue* (1 - interpolationValue) + IconSpriteTextureTopSecondValue * interpolationValue);
            }
            if (setIconSpriteTextureWidthFirstValue && setIconSpriteTextureWidthSecondValue)
            {
                IconSprite.TextureWidth = FlatRedBall.Math.MathFunctions.RoundToInt(IconSpriteTextureWidthFirstValue* (1 - interpolationValue) + IconSpriteTextureWidthSecondValue * interpolationValue);
            }
            if (interpolationValue < 1)
            {
                mCurrentIconCategoryState = firstState;
            }
            else
            {
                mCurrentIconCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Elements.IconRuntime.VariableState fromState,Harvesteer.GumRuntimes.Elements.IconRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory fromState,Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (IconCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "IconCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentIconCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (IconCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentIconCategoryState = toState;
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
                        Name = "IconSprite.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = IconSprite.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Height",
                        Type = "float",
                        Value = IconSprite.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Height Units",
                        Type = "DimensionUnitType",
                        Value = IconSprite.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.SourceFile",
                        Type = "string",
                        Value = IconSprite.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Address",
                        Type = "TextureAddress",
                        Value = IconSprite.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Width",
                        Type = "float",
                        Value = IconSprite.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Width Units",
                        Type = "DimensionUnitType",
                        Value = IconSprite.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconSprite.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.X Units",
                        Type = "PositionUnitType",
                        Value = IconSprite.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconSprite.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Y Units",
                        Type = "PositionUnitType",
                        Value = IconSprite.YUnits
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
                        Value = Height + 32f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width + 32f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = IconSprite.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Height",
                        Type = "float",
                        Value = IconSprite.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Height Units",
                        Type = "DimensionUnitType",
                        Value = IconSprite.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.SourceFile",
                        Type = "string",
                        Value = IconSprite.SourceFile
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Address",
                        Type = "TextureAddress",
                        Value = IconSprite.TextureAddress
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Width",
                        Type = "float",
                        Value = IconSprite.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Width Units",
                        Type = "DimensionUnitType",
                        Value = IconSprite.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconSprite.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.X Units",
                        Type = "PositionUnitType",
                        Value = IconSprite.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconSprite.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Y Units",
                        Type = "PositionUnitType",
                        Value = IconSprite.YUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (IconCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  IconCategory.None:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.ArrowUpDown:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Arrow1:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Arrow2:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Arrow3:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Basket:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Battery:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Check:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.CheckeredFlag:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Circle1:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Circle2:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Close:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Crosshairs:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Currency:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Cursor:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.CursorText:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Delete:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Enter:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Expand:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Gamepad:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadNES:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadSNES:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadNintendo64:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadGamecube:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadSwitchPro:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadXbox:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadPlaystationDualShock:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadSegaGenesis:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Gear:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.FastForward:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.FastForwardBar:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.FitToScreen:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Flame1:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Flame2:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Heart:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Info:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Keyboard:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Leaf:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Lightning:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Minimize:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Monitor:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Mouse:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Music:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Pause:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Pencil:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Play:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.PlayBar:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Power:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Radiation:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Reduce:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Shield:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Shot:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Skull:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Sliders:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.SoundMaximum:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.SoundMinimum:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Speech:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Star:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Stop:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Temperature:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Touch:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Trash:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Trophy:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.User:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.UserAdd:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.UserDelete:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.UserGear:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.UserMulti:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.UserRemove:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Warning:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Wrench:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (IconCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  IconCategory.None:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.ArrowUpDown:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 384
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 256
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Arrow1:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 256
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Arrow2:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 256
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Arrow3:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 256
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Basket:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 224
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Battery:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 224
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Check:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 384
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 128
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.CheckeredFlag:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 384
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Circle1:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 448
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 128
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Circle2:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 416
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 128
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Close:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 416
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 192
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Crosshairs:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Currency:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 224
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Cursor:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 384
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.CursorText:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 416
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Delete:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Enter:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Expand:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 384
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 192
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Gamepad:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadNES:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 416
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadSNES:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 448
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadNintendo64:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 384
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadGamecube:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 416
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadSwitchPro:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadXbox:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 384
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadPlaystationDualShock:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.GamepadSegaGenesis:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 448
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Gear:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 96
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.FastForward:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 384
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 160
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.FastForwardBar:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 416
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 160
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.FitToScreen:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 192
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Flame1:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 64
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Flame2:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 64
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Heart:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 128
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Info:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 416
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 256
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Keyboard:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Leaf:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 64
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Lightning:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 416
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 64
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Minimize:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 192
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Monitor:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 448
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 192
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Mouse:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 448
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Music:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 384
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 224
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Pause:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 160
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Pencil:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 96
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Play:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 160
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.PlayBar:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 448
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 160
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Power:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Radiation:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 384
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 64
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Reduce:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 192
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Shield:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 416
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Shot:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Skull:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 448
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Sliders:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 96
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.SoundMaximum:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 448
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 224
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.SoundMinimum:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 416
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 224
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Speech:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 448
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 96
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Star:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 128
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Stop:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 160
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Temperature:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 448
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 64
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Touch:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Trash:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 416
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 96
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Trophy:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 128
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.User:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 288
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.UserAdd:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 384
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.UserDelete:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 416
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.UserGear:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 352
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.UserMulti:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 320
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.UserRemove:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 448
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 0
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Warning:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 448
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 256
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
                    }
                    );
                    break;
                case  IconCategory.Wrench:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Height",
                        Type = "int",
                        Value = IconSprite.TextureHeight + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Left",
                        Type = "int",
                        Value = IconSprite.TextureLeft + 384
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Top",
                        Type = "int",
                        Value = IconSprite.TextureTop + 96
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Texture Width",
                        Type = "int",
                        Value = IconSprite.TextureWidth + 32
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconSprite.Visible",
                        Type = "bool",
                        Value = IconSprite.Visible
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
                else if (category.Name == "IconCategory")
                {
                    if(state.Name == "None") this.mCurrentIconCategoryState = IconCategory.None;
                    if(state.Name == "ArrowUpDown") this.mCurrentIconCategoryState = IconCategory.ArrowUpDown;
                    if(state.Name == "Arrow1") this.mCurrentIconCategoryState = IconCategory.Arrow1;
                    if(state.Name == "Arrow2") this.mCurrentIconCategoryState = IconCategory.Arrow2;
                    if(state.Name == "Arrow3") this.mCurrentIconCategoryState = IconCategory.Arrow3;
                    if(state.Name == "Basket") this.mCurrentIconCategoryState = IconCategory.Basket;
                    if(state.Name == "Battery") this.mCurrentIconCategoryState = IconCategory.Battery;
                    if(state.Name == "Check") this.mCurrentIconCategoryState = IconCategory.Check;
                    if(state.Name == "CheckeredFlag") this.mCurrentIconCategoryState = IconCategory.CheckeredFlag;
                    if(state.Name == "Circle1") this.mCurrentIconCategoryState = IconCategory.Circle1;
                    if(state.Name == "Circle2") this.mCurrentIconCategoryState = IconCategory.Circle2;
                    if(state.Name == "Close") this.mCurrentIconCategoryState = IconCategory.Close;
                    if(state.Name == "Crosshairs") this.mCurrentIconCategoryState = IconCategory.Crosshairs;
                    if(state.Name == "Currency") this.mCurrentIconCategoryState = IconCategory.Currency;
                    if(state.Name == "Cursor") this.mCurrentIconCategoryState = IconCategory.Cursor;
                    if(state.Name == "CursorText") this.mCurrentIconCategoryState = IconCategory.CursorText;
                    if(state.Name == "Delete") this.mCurrentIconCategoryState = IconCategory.Delete;
                    if(state.Name == "Enter") this.mCurrentIconCategoryState = IconCategory.Enter;
                    if(state.Name == "Expand") this.mCurrentIconCategoryState = IconCategory.Expand;
                    if(state.Name == "Gamepad") this.mCurrentIconCategoryState = IconCategory.Gamepad;
                    if(state.Name == "GamepadNES") this.mCurrentIconCategoryState = IconCategory.GamepadNES;
                    if(state.Name == "GamepadSNES") this.mCurrentIconCategoryState = IconCategory.GamepadSNES;
                    if(state.Name == "GamepadNintendo64") this.mCurrentIconCategoryState = IconCategory.GamepadNintendo64;
                    if(state.Name == "GamepadGamecube") this.mCurrentIconCategoryState = IconCategory.GamepadGamecube;
                    if(state.Name == "GamepadSwitchPro") this.mCurrentIconCategoryState = IconCategory.GamepadSwitchPro;
                    if(state.Name == "GamepadXbox") this.mCurrentIconCategoryState = IconCategory.GamepadXbox;
                    if(state.Name == "GamepadPlaystationDualShock") this.mCurrentIconCategoryState = IconCategory.GamepadPlaystationDualShock;
                    if(state.Name == "GamepadSegaGenesis") this.mCurrentIconCategoryState = IconCategory.GamepadSegaGenesis;
                    if(state.Name == "Gear") this.mCurrentIconCategoryState = IconCategory.Gear;
                    if(state.Name == "FastForward") this.mCurrentIconCategoryState = IconCategory.FastForward;
                    if(state.Name == "FastForwardBar") this.mCurrentIconCategoryState = IconCategory.FastForwardBar;
                    if(state.Name == "FitToScreen") this.mCurrentIconCategoryState = IconCategory.FitToScreen;
                    if(state.Name == "Flame1") this.mCurrentIconCategoryState = IconCategory.Flame1;
                    if(state.Name == "Flame2") this.mCurrentIconCategoryState = IconCategory.Flame2;
                    if(state.Name == "Heart") this.mCurrentIconCategoryState = IconCategory.Heart;
                    if(state.Name == "Info") this.mCurrentIconCategoryState = IconCategory.Info;
                    if(state.Name == "Keyboard") this.mCurrentIconCategoryState = IconCategory.Keyboard;
                    if(state.Name == "Leaf") this.mCurrentIconCategoryState = IconCategory.Leaf;
                    if(state.Name == "Lightning") this.mCurrentIconCategoryState = IconCategory.Lightning;
                    if(state.Name == "Minimize") this.mCurrentIconCategoryState = IconCategory.Minimize;
                    if(state.Name == "Monitor") this.mCurrentIconCategoryState = IconCategory.Monitor;
                    if(state.Name == "Mouse") this.mCurrentIconCategoryState = IconCategory.Mouse;
                    if(state.Name == "Music") this.mCurrentIconCategoryState = IconCategory.Music;
                    if(state.Name == "Pause") this.mCurrentIconCategoryState = IconCategory.Pause;
                    if(state.Name == "Pencil") this.mCurrentIconCategoryState = IconCategory.Pencil;
                    if(state.Name == "Play") this.mCurrentIconCategoryState = IconCategory.Play;
                    if(state.Name == "PlayBar") this.mCurrentIconCategoryState = IconCategory.PlayBar;
                    if(state.Name == "Power") this.mCurrentIconCategoryState = IconCategory.Power;
                    if(state.Name == "Radiation") this.mCurrentIconCategoryState = IconCategory.Radiation;
                    if(state.Name == "Reduce") this.mCurrentIconCategoryState = IconCategory.Reduce;
                    if(state.Name == "Shield") this.mCurrentIconCategoryState = IconCategory.Shield;
                    if(state.Name == "Shot") this.mCurrentIconCategoryState = IconCategory.Shot;
                    if(state.Name == "Skull") this.mCurrentIconCategoryState = IconCategory.Skull;
                    if(state.Name == "Sliders") this.mCurrentIconCategoryState = IconCategory.Sliders;
                    if(state.Name == "SoundMaximum") this.mCurrentIconCategoryState = IconCategory.SoundMaximum;
                    if(state.Name == "SoundMinimum") this.mCurrentIconCategoryState = IconCategory.SoundMinimum;
                    if(state.Name == "Speech") this.mCurrentIconCategoryState = IconCategory.Speech;
                    if(state.Name == "Star") this.mCurrentIconCategoryState = IconCategory.Star;
                    if(state.Name == "Stop") this.mCurrentIconCategoryState = IconCategory.Stop;
                    if(state.Name == "Temperature") this.mCurrentIconCategoryState = IconCategory.Temperature;
                    if(state.Name == "Touch") this.mCurrentIconCategoryState = IconCategory.Touch;
                    if(state.Name == "Trash") this.mCurrentIconCategoryState = IconCategory.Trash;
                    if(state.Name == "Trophy") this.mCurrentIconCategoryState = IconCategory.Trophy;
                    if(state.Name == "User") this.mCurrentIconCategoryState = IconCategory.User;
                    if(state.Name == "UserAdd") this.mCurrentIconCategoryState = IconCategory.UserAdd;
                    if(state.Name == "UserDelete") this.mCurrentIconCategoryState = IconCategory.UserDelete;
                    if(state.Name == "UserGear") this.mCurrentIconCategoryState = IconCategory.UserGear;
                    if(state.Name == "UserMulti") this.mCurrentIconCategoryState = IconCategory.UserMulti;
                    if(state.Name == "UserRemove") this.mCurrentIconCategoryState = IconCategory.UserRemove;
                    if(state.Name == "Warning") this.mCurrentIconCategoryState = IconCategory.Warning;
                    if(state.Name == "Wrench") this.mCurrentIconCategoryState = IconCategory.Wrench;
                }
            }
            base.ApplyState(state);
        }
        public Harvesteer.GumRuntimes.SpriteRuntime IconSprite { get; set; }
        public SpriteRuntime.ColorCategory? IconColor
        {
            get
            {
                return IconSprite.CurrentColorCategoryState;
            }
            set
            {
                if (IconSprite.CurrentColorCategoryState != value)
                {
                    IconSprite.CurrentColorCategoryState = value;
                    IconColorChanged?.Invoke(this, null);
                }
            }
        }
        public event System.EventHandler IconColorChanged;
        public IconRuntime () 
        	: this(true, true)
        {
        }
        public IconRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Elements/Icon");
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
            IconSprite = this.GetGraphicalUiElementByName("IconSprite") as Harvesteer.GumRuntimes.SpriteRuntime;
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
    }
}
