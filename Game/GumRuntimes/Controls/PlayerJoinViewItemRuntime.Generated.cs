using System.Linq;
namespace Harvesteer.GumRuntimes.Controls
{
    public partial class PlayerJoinViewItemRuntime : Harvesteer.GumRuntimes.ContainerRuntime, Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
        public enum PlayerJoinCategory
        {
            NotConnected,
            Connected,
            ConnectedAndJoined
        }
        public enum PlayerIndexCategory
        {
            Player1,
            Player2,
            Player3,
            Player4
        }
        public enum GamepadLayoutCategory
        {
            Unknown,
            Keyboard,
            NES,
            SuperNintendo,
            Nintendo64,
            GameCube,
            SwitchPro,
            Genesis,
            Xbox360,
            PlayStationDualShock
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
        PlayerJoinCategory? mCurrentPlayerJoinCategoryState;
        PlayerIndexCategory? mCurrentPlayerIndexCategoryState;
        GamepadLayoutCategory? mCurrentGamepadLayoutCategoryState;
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
                        Background.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
                        Background.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Panel;
                        ControllerDisplayNameTextInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                        ControllerDisplayNameTextInstance.CurrentStyleCategoryState = Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Tiny;
                        InputDeviceIcon.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadXbox;
                        Height = 80f;
                        Background.Height = 0f;
                        Background.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                        Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        ControllerDisplayNameTextInstance.Height = 0f;
                        ControllerDisplayNameTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        ControllerDisplayNameTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        ControllerDisplayNameTextInstance.Text = "<Controller Type>";
                        ControllerDisplayNameTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        ControllerDisplayNameTextInstance.Width = -16f;
                        ControllerDisplayNameTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        ControllerDisplayNameTextInstance.X = 0f;
                        ControllerDisplayNameTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        ControllerDisplayNameTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        ControllerDisplayNameTextInstance.Y = -29f;
                        ControllerDisplayNameTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        ControllerDisplayNameTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        InputDeviceIcon.X = 0f;
                        InputDeviceIcon.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        InputDeviceIcon.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        InputDeviceIcon.Y = 0f;
                        InputDeviceIcon.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        InputDeviceIcon.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        break;
                }
            }
        }
        public PlayerJoinCategory? CurrentPlayerJoinCategoryState
        {
            get
            {
                return mCurrentPlayerJoinCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentPlayerJoinCategoryState = value;
                    switch(mCurrentPlayerJoinCategoryState)
                    {
                        case  PlayerJoinCategory.NotConnected:
                            Background.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Gray;
                            ControllerDisplayNameTextInstance.Visible = false;
                            break;
                        case  PlayerJoinCategory.Connected:
                            Background.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            ControllerDisplayNameTextInstance.Visible = true;
                            break;
                        case  PlayerJoinCategory.ConnectedAndJoined:
                            Background.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Success;
                            ControllerDisplayNameTextInstance.Visible = true;
                            break;
                    }
                }
            }
        }
        public PlayerIndexCategory? CurrentPlayerIndexCategoryState
        {
            get
            {
                return mCurrentPlayerIndexCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentPlayerIndexCategoryState = value;
                    switch(mCurrentPlayerIndexCategoryState)
                    {
                        case  PlayerIndexCategory.Player1:
                            break;
                        case  PlayerIndexCategory.Player2:
                            break;
                        case  PlayerIndexCategory.Player3:
                            break;
                        case  PlayerIndexCategory.Player4:
                            break;
                    }
                }
            }
        }
        public GamepadLayoutCategory? CurrentGamepadLayoutCategoryState
        {
            get
            {
                return mCurrentGamepadLayoutCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentGamepadLayoutCategoryState = value;
                    switch(mCurrentGamepadLayoutCategoryState)
                    {
                        case  GamepadLayoutCategory.Unknown:
                            InputDeviceIcon.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadXbox;
                            InputDeviceIcon.Visible = false;
                            break;
                        case  GamepadLayoutCategory.Keyboard:
                            InputDeviceIcon.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.Keyboard;
                            InputDeviceIcon.Visible = true;
                            break;
                        case  GamepadLayoutCategory.NES:
                            InputDeviceIcon.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadNES;
                            InputDeviceIcon.Visible = true;
                            break;
                        case  GamepadLayoutCategory.SuperNintendo:
                            InputDeviceIcon.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadSNES;
                            InputDeviceIcon.Visible = true;
                            break;
                        case  GamepadLayoutCategory.Nintendo64:
                            InputDeviceIcon.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadNintendo64;
                            InputDeviceIcon.Visible = true;
                            break;
                        case  GamepadLayoutCategory.GameCube:
                            InputDeviceIcon.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadGamecube;
                            InputDeviceIcon.Visible = true;
                            break;
                        case  GamepadLayoutCategory.SwitchPro:
                            InputDeviceIcon.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadSwitchPro;
                            InputDeviceIcon.Visible = true;
                            break;
                        case  GamepadLayoutCategory.Genesis:
                            InputDeviceIcon.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadSegaGenesis;
                            InputDeviceIcon.Visible = true;
                            break;
                        case  GamepadLayoutCategory.Xbox360:
                            InputDeviceIcon.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadXbox;
                            InputDeviceIcon.Visible = true;
                            break;
                        case  GamepadLayoutCategory.PlayStationDualShock:
                            InputDeviceIcon.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadPlaystationDualShock;
                            InputDeviceIcon.Visible = true;
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
            bool setBackgroundHeightFirstValue = false;
            bool setBackgroundHeightSecondValue = false;
            float BackgroundHeightFirstValue= 0;
            float BackgroundHeightSecondValue= 0;
            bool setBackgroundCurrentStyleCategoryStateFirstValue = false;
            bool setBackgroundCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setControllerDisplayNameTextInstanceCurrentColorCategoryStateFirstValue = false;
            bool setControllerDisplayNameTextInstanceCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.TextRuntime.ColorCategory ControllerDisplayNameTextInstanceCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.TextRuntime.ColorCategory ControllerDisplayNameTextInstanceCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.TextRuntime.ColorCategory.Black;
            bool setControllerDisplayNameTextInstanceHeightFirstValue = false;
            bool setControllerDisplayNameTextInstanceHeightSecondValue = false;
            float ControllerDisplayNameTextInstanceHeightFirstValue= 0;
            float ControllerDisplayNameTextInstanceHeightSecondValue= 0;
            bool setControllerDisplayNameTextInstanceCurrentStyleCategoryStateFirstValue = false;
            bool setControllerDisplayNameTextInstanceCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.TextRuntime.StyleCategory ControllerDisplayNameTextInstanceCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Tiny;
            Harvesteer.GumRuntimes.TextRuntime.StyleCategory ControllerDisplayNameTextInstanceCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Tiny;
            bool setControllerDisplayNameTextInstanceWidthFirstValue = false;
            bool setControllerDisplayNameTextInstanceWidthSecondValue = false;
            float ControllerDisplayNameTextInstanceWidthFirstValue= 0;
            float ControllerDisplayNameTextInstanceWidthSecondValue= 0;
            bool setControllerDisplayNameTextInstanceXFirstValue = false;
            bool setControllerDisplayNameTextInstanceXSecondValue = false;
            float ControllerDisplayNameTextInstanceXFirstValue= 0;
            float ControllerDisplayNameTextInstanceXSecondValue= 0;
            bool setControllerDisplayNameTextInstanceYFirstValue = false;
            bool setControllerDisplayNameTextInstanceYSecondValue = false;
            float ControllerDisplayNameTextInstanceYFirstValue= 0;
            float ControllerDisplayNameTextInstanceYSecondValue= 0;
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setInputDeviceIconCurrentIconCategoryStateFirstValue = false;
            bool setInputDeviceIconCurrentIconCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory InputDeviceIconCurrentIconCategoryStateFirstValue= Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory InputDeviceIconCurrentIconCategoryStateSecondValue= Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            bool setInputDeviceIconXFirstValue = false;
            bool setInputDeviceIconXSecondValue = false;
            float InputDeviceIconXFirstValue= 0;
            float InputDeviceIconXSecondValue= 0;
            bool setInputDeviceIconYFirstValue = false;
            bool setInputDeviceIconYSecondValue = false;
            float InputDeviceIconYFirstValue= 0;
            float InputDeviceIconYSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
                    setBackgroundHeightFirstValue = true;
                    BackgroundHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setBackgroundCurrentStyleCategoryStateFirstValue = true;
                    BackgroundCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Panel;
                    if (interpolationValue < 1)
                    {
                        this.Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setControllerDisplayNameTextInstanceCurrentColorCategoryStateFirstValue = true;
                    ControllerDisplayNameTextInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    setControllerDisplayNameTextInstanceHeightFirstValue = true;
                    ControllerDisplayNameTextInstanceHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.ControllerDisplayNameTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ControllerDisplayNameTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    setControllerDisplayNameTextInstanceCurrentStyleCategoryStateFirstValue = true;
                    ControllerDisplayNameTextInstanceCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Tiny;
                    if (interpolationValue < 1)
                    {
                        this.ControllerDisplayNameTextInstance.Text = "<Controller Type>";
                    }
                    if (interpolationValue < 1)
                    {
                        this.ControllerDisplayNameTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    setControllerDisplayNameTextInstanceWidthFirstValue = true;
                    ControllerDisplayNameTextInstanceWidthFirstValue = -16f;
                    if (interpolationValue < 1)
                    {
                        this.ControllerDisplayNameTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setControllerDisplayNameTextInstanceXFirstValue = true;
                    ControllerDisplayNameTextInstanceXFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.ControllerDisplayNameTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ControllerDisplayNameTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setControllerDisplayNameTextInstanceYFirstValue = true;
                    ControllerDisplayNameTextInstanceYFirstValue = -29f;
                    if (interpolationValue < 1)
                    {
                        this.ControllerDisplayNameTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ControllerDisplayNameTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setHeightFirstValue = true;
                    HeightFirstValue = 80f;
                    setInputDeviceIconCurrentIconCategoryStateFirstValue = true;
                    InputDeviceIconCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadXbox;
                    setInputDeviceIconXFirstValue = true;
                    InputDeviceIconXFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setInputDeviceIconYFirstValue = true;
                    InputDeviceIconYFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
                    setBackgroundHeightSecondValue = true;
                    BackgroundHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setBackgroundCurrentStyleCategoryStateSecondValue = true;
                    BackgroundCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Panel;
                    if (interpolationValue >= 1)
                    {
                        this.Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setControllerDisplayNameTextInstanceCurrentColorCategoryStateSecondValue = true;
                    ControllerDisplayNameTextInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.ColorCategory.White;
                    setControllerDisplayNameTextInstanceHeightSecondValue = true;
                    ControllerDisplayNameTextInstanceHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.ControllerDisplayNameTextInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ControllerDisplayNameTextInstance.HorizontalAlignment = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    setControllerDisplayNameTextInstanceCurrentStyleCategoryStateSecondValue = true;
                    ControllerDisplayNameTextInstanceCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.TextRuntime.StyleCategory.Tiny;
                    if (interpolationValue >= 1)
                    {
                        this.ControllerDisplayNameTextInstance.Text = "<Controller Type>";
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ControllerDisplayNameTextInstance.VerticalAlignment = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    setControllerDisplayNameTextInstanceWidthSecondValue = true;
                    ControllerDisplayNameTextInstanceWidthSecondValue = -16f;
                    if (interpolationValue >= 1)
                    {
                        this.ControllerDisplayNameTextInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setControllerDisplayNameTextInstanceXSecondValue = true;
                    ControllerDisplayNameTextInstanceXSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.ControllerDisplayNameTextInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ControllerDisplayNameTextInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setControllerDisplayNameTextInstanceYSecondValue = true;
                    ControllerDisplayNameTextInstanceYSecondValue = -29f;
                    if (interpolationValue >= 1)
                    {
                        this.ControllerDisplayNameTextInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ControllerDisplayNameTextInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    setHeightSecondValue = true;
                    HeightSecondValue = 80f;
                    setInputDeviceIconCurrentIconCategoryStateSecondValue = true;
                    InputDeviceIconCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadXbox;
                    setInputDeviceIconXSecondValue = true;
                    InputDeviceIconXSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setInputDeviceIconYSecondValue = true;
                    InputDeviceIconYSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
            if (setBackgroundCurrentColorCategoryStateFirstValue && setBackgroundCurrentColorCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentColorCategoryStateFirstValue, BackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setBackgroundHeightFirstValue && setBackgroundHeightSecondValue)
            {
                Background.Height = BackgroundHeightFirstValue * (1 - interpolationValue) + BackgroundHeightSecondValue * interpolationValue;
            }
            if (setBackgroundCurrentStyleCategoryStateFirstValue && setBackgroundCurrentStyleCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentStyleCategoryStateFirstValue, BackgroundCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setControllerDisplayNameTextInstanceCurrentColorCategoryStateFirstValue && setControllerDisplayNameTextInstanceCurrentColorCategoryStateSecondValue)
            {
                ControllerDisplayNameTextInstance.InterpolateBetween(ControllerDisplayNameTextInstanceCurrentColorCategoryStateFirstValue, ControllerDisplayNameTextInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setControllerDisplayNameTextInstanceHeightFirstValue && setControllerDisplayNameTextInstanceHeightSecondValue)
            {
                ControllerDisplayNameTextInstance.Height = ControllerDisplayNameTextInstanceHeightFirstValue * (1 - interpolationValue) + ControllerDisplayNameTextInstanceHeightSecondValue * interpolationValue;
            }
            if (setControllerDisplayNameTextInstanceCurrentStyleCategoryStateFirstValue && setControllerDisplayNameTextInstanceCurrentStyleCategoryStateSecondValue)
            {
                ControllerDisplayNameTextInstance.InterpolateBetween(ControllerDisplayNameTextInstanceCurrentStyleCategoryStateFirstValue, ControllerDisplayNameTextInstanceCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setControllerDisplayNameTextInstanceWidthFirstValue && setControllerDisplayNameTextInstanceWidthSecondValue)
            {
                ControllerDisplayNameTextInstance.Width = ControllerDisplayNameTextInstanceWidthFirstValue * (1 - interpolationValue) + ControllerDisplayNameTextInstanceWidthSecondValue * interpolationValue;
            }
            if (setControllerDisplayNameTextInstanceXFirstValue && setControllerDisplayNameTextInstanceXSecondValue)
            {
                ControllerDisplayNameTextInstance.X = ControllerDisplayNameTextInstanceXFirstValue * (1 - interpolationValue) + ControllerDisplayNameTextInstanceXSecondValue * interpolationValue;
            }
            if (setControllerDisplayNameTextInstanceYFirstValue && setControllerDisplayNameTextInstanceYSecondValue)
            {
                ControllerDisplayNameTextInstance.Y = ControllerDisplayNameTextInstanceYFirstValue * (1 - interpolationValue) + ControllerDisplayNameTextInstanceYSecondValue * interpolationValue;
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setInputDeviceIconCurrentIconCategoryStateFirstValue && setInputDeviceIconCurrentIconCategoryStateSecondValue)
            {
                InputDeviceIcon.InterpolateBetween(InputDeviceIconCurrentIconCategoryStateFirstValue, InputDeviceIconCurrentIconCategoryStateSecondValue, interpolationValue);
            }
            if (setInputDeviceIconXFirstValue && setInputDeviceIconXSecondValue)
            {
                InputDeviceIcon.X = InputDeviceIconXFirstValue * (1 - interpolationValue) + InputDeviceIconXSecondValue * interpolationValue;
            }
            if (setInputDeviceIconYFirstValue && setInputDeviceIconYSecondValue)
            {
                InputDeviceIcon.Y = InputDeviceIconYFirstValue * (1 - interpolationValue) + InputDeviceIconYSecondValue * interpolationValue;
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
        public void InterpolateBetween (PlayerJoinCategory firstState, PlayerJoinCategory secondState, float interpolationValue) 
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
            switch(firstState)
            {
                case  PlayerJoinCategory.NotConnected:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Gray;
                    if (interpolationValue < 1)
                    {
                        this.ControllerDisplayNameTextInstance.Visible = false;
                    }
                    break;
                case  PlayerJoinCategory.Connected:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue < 1)
                    {
                        this.ControllerDisplayNameTextInstance.Visible = true;
                    }
                    break;
                case  PlayerJoinCategory.ConnectedAndJoined:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Success;
                    if (interpolationValue < 1)
                    {
                        this.ControllerDisplayNameTextInstance.Visible = true;
                    }
                    break;
            }
            switch(secondState)
            {
                case  PlayerJoinCategory.NotConnected:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Gray;
                    if (interpolationValue >= 1)
                    {
                        this.ControllerDisplayNameTextInstance.Visible = false;
                    }
                    break;
                case  PlayerJoinCategory.Connected:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    if (interpolationValue >= 1)
                    {
                        this.ControllerDisplayNameTextInstance.Visible = true;
                    }
                    break;
                case  PlayerJoinCategory.ConnectedAndJoined:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Success;
                    if (interpolationValue >= 1)
                    {
                        this.ControllerDisplayNameTextInstance.Visible = true;
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
            if (setBackgroundCurrentColorCategoryStateFirstValue && setBackgroundCurrentColorCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentColorCategoryStateFirstValue, BackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (interpolationValue < 1)
            {
                mCurrentPlayerJoinCategoryState = firstState;
            }
            else
            {
                mCurrentPlayerJoinCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        public void InterpolateBetween (PlayerIndexCategory firstState, PlayerIndexCategory secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            switch(firstState)
            {
                case  PlayerIndexCategory.Player1:
                    break;
                case  PlayerIndexCategory.Player2:
                    break;
                case  PlayerIndexCategory.Player3:
                    break;
                case  PlayerIndexCategory.Player4:
                    break;
            }
            switch(secondState)
            {
                case  PlayerIndexCategory.Player1:
                    break;
                case  PlayerIndexCategory.Player2:
                    break;
                case  PlayerIndexCategory.Player3:
                    break;
                case  PlayerIndexCategory.Player4:
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            // all values assigned in this state do not require recursive updates:
            suspendRecursively = false;
            var isSafeToInterpolateWithoutSuppression = true;
            if(isSafeToInterpolateWithoutSuppression) shouldSuspend = false;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (interpolationValue < 1)
            {
                mCurrentPlayerIndexCategoryState = firstState;
            }
            else
            {
                mCurrentPlayerIndexCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        public void InterpolateBetween (GamepadLayoutCategory firstState, GamepadLayoutCategory secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setInputDeviceIconCurrentIconCategoryStateFirstValue = false;
            bool setInputDeviceIconCurrentIconCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory InputDeviceIconCurrentIconCategoryStateFirstValue= Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory InputDeviceIconCurrentIconCategoryStateSecondValue= Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            switch(firstState)
            {
                case  GamepadLayoutCategory.Unknown:
                    setInputDeviceIconCurrentIconCategoryStateFirstValue = true;
                    InputDeviceIconCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadXbox;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.Visible = false;
                    }
                    break;
                case  GamepadLayoutCategory.Keyboard:
                    setInputDeviceIconCurrentIconCategoryStateFirstValue = true;
                    InputDeviceIconCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.Keyboard;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.NES:
                    setInputDeviceIconCurrentIconCategoryStateFirstValue = true;
                    InputDeviceIconCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadNES;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.SuperNintendo:
                    setInputDeviceIconCurrentIconCategoryStateFirstValue = true;
                    InputDeviceIconCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadSNES;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.Nintendo64:
                    setInputDeviceIconCurrentIconCategoryStateFirstValue = true;
                    InputDeviceIconCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadNintendo64;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.GameCube:
                    setInputDeviceIconCurrentIconCategoryStateFirstValue = true;
                    InputDeviceIconCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadGamecube;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.SwitchPro:
                    setInputDeviceIconCurrentIconCategoryStateFirstValue = true;
                    InputDeviceIconCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadSwitchPro;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.Genesis:
                    setInputDeviceIconCurrentIconCategoryStateFirstValue = true;
                    InputDeviceIconCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadSegaGenesis;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.Xbox360:
                    setInputDeviceIconCurrentIconCategoryStateFirstValue = true;
                    InputDeviceIconCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadXbox;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.PlayStationDualShock:
                    setInputDeviceIconCurrentIconCategoryStateFirstValue = true;
                    InputDeviceIconCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadPlaystationDualShock;
                    if (interpolationValue < 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
            }
            switch(secondState)
            {
                case  GamepadLayoutCategory.Unknown:
                    setInputDeviceIconCurrentIconCategoryStateSecondValue = true;
                    InputDeviceIconCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadXbox;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.Visible = false;
                    }
                    break;
                case  GamepadLayoutCategory.Keyboard:
                    setInputDeviceIconCurrentIconCategoryStateSecondValue = true;
                    InputDeviceIconCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.Keyboard;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.NES:
                    setInputDeviceIconCurrentIconCategoryStateSecondValue = true;
                    InputDeviceIconCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadNES;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.SuperNintendo:
                    setInputDeviceIconCurrentIconCategoryStateSecondValue = true;
                    InputDeviceIconCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadSNES;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.Nintendo64:
                    setInputDeviceIconCurrentIconCategoryStateSecondValue = true;
                    InputDeviceIconCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadNintendo64;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.GameCube:
                    setInputDeviceIconCurrentIconCategoryStateSecondValue = true;
                    InputDeviceIconCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadGamecube;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.SwitchPro:
                    setInputDeviceIconCurrentIconCategoryStateSecondValue = true;
                    InputDeviceIconCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadSwitchPro;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.Genesis:
                    setInputDeviceIconCurrentIconCategoryStateSecondValue = true;
                    InputDeviceIconCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadSegaGenesis;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.Xbox360:
                    setInputDeviceIconCurrentIconCategoryStateSecondValue = true;
                    InputDeviceIconCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadXbox;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.Visible = true;
                    }
                    break;
                case  GamepadLayoutCategory.PlayStationDualShock:
                    setInputDeviceIconCurrentIconCategoryStateSecondValue = true;
                    InputDeviceIconCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.GamepadPlaystationDualShock;
                    if (interpolationValue >= 1)
                    {
                        this.InputDeviceIcon.Visible = true;
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
            if (setInputDeviceIconCurrentIconCategoryStateFirstValue && setInputDeviceIconCurrentIconCategoryStateSecondValue)
            {
                InputDeviceIcon.InterpolateBetween(InputDeviceIconCurrentIconCategoryStateFirstValue, InputDeviceIconCurrentIconCategoryStateSecondValue, interpolationValue);
            }
            if (interpolationValue < 1)
            {
                mCurrentGamepadLayoutCategoryState = firstState;
            }
            else
            {
                mCurrentGamepadLayoutCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime.VariableState fromState,Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime.PlayerJoinCategory fromState,Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime.PlayerJoinCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (PlayerJoinCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "PlayerJoinCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentPlayerJoinCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (PlayerJoinCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentPlayerJoinCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime.PlayerIndexCategory fromState,Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime.PlayerIndexCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (PlayerIndexCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "PlayerIndexCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentPlayerIndexCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (PlayerIndexCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentPlayerIndexCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime.GamepadLayoutCategory fromState,Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime.GamepadLayoutCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (GamepadLayoutCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "GamepadLayoutCategory").States.First(item => item.Name == toState.ToString());
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
            tweener.Ended += ()=> this.CurrentGamepadLayoutCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (GamepadLayoutCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
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
            tweener.Ended += ()=> this.CurrentGamepadLayoutCategoryState = toState;
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
            InputDeviceIcon.StopAnimations();
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
                        Name = "Background.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Background.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height",
                        Type = "float",
                        Value = Background.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height Units",
                        Type = "DimensionUnitType",
                        Value = Background.HeightUnits
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
                        Name = "Background.Y Origin",
                        Type = "VerticalAlignment",
                        Value = Background.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y Units",
                        Type = "PositionUnitType",
                        Value = Background.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = ControllerDisplayNameTextInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Height",
                        Type = "float",
                        Value = ControllerDisplayNameTextInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = ControllerDisplayNameTextInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.HorizontalAlignment",
                        Type = "HorizontalAlignment",
                        Value = ControllerDisplayNameTextInstance.HorizontalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = ControllerDisplayNameTextInstance.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Text",
                        Type = "string",
                        Value = ControllerDisplayNameTextInstance.Text
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.VerticalAlignment",
                        Type = "VerticalAlignment",
                        Value = ControllerDisplayNameTextInstance.VerticalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Width",
                        Type = "float",
                        Value = ControllerDisplayNameTextInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = ControllerDisplayNameTextInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.X",
                        Type = "float",
                        Value = ControllerDisplayNameTextInstance.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = ControllerDisplayNameTextInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.X Units",
                        Type = "PositionUnitType",
                        Value = ControllerDisplayNameTextInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Y",
                        Type = "float",
                        Value = ControllerDisplayNameTextInstance.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = ControllerDisplayNameTextInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = ControllerDisplayNameTextInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.X",
                        Type = "float",
                        Value = InputDeviceIcon.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.X Origin",
                        Type = "HorizontalAlignment",
                        Value = InputDeviceIcon.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.X Units",
                        Type = "PositionUnitType",
                        Value = InputDeviceIcon.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Y",
                        Type = "float",
                        Value = InputDeviceIcon.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Y Origin",
                        Type = "VerticalAlignment",
                        Value = InputDeviceIcon.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Y Units",
                        Type = "PositionUnitType",
                        Value = InputDeviceIcon.YUnits
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
                        Value = Height + 80f
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
                        Name = "Background.Height",
                        Type = "float",
                        Value = Background.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height Units",
                        Type = "DimensionUnitType",
                        Value = Background.HeightUnits
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
                        Name = "Background.Y Origin",
                        Type = "VerticalAlignment",
                        Value = Background.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y Units",
                        Type = "PositionUnitType",
                        Value = Background.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = ControllerDisplayNameTextInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Height",
                        Type = "float",
                        Value = ControllerDisplayNameTextInstance.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = ControllerDisplayNameTextInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.HorizontalAlignment",
                        Type = "HorizontalAlignment",
                        Value = ControllerDisplayNameTextInstance.HorizontalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = ControllerDisplayNameTextInstance.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Text",
                        Type = "string",
                        Value = ControllerDisplayNameTextInstance.Text
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.VerticalAlignment",
                        Type = "VerticalAlignment",
                        Value = ControllerDisplayNameTextInstance.VerticalAlignment
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Width",
                        Type = "float",
                        Value = ControllerDisplayNameTextInstance.Width + -16f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = ControllerDisplayNameTextInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.X",
                        Type = "float",
                        Value = ControllerDisplayNameTextInstance.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = ControllerDisplayNameTextInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.X Units",
                        Type = "PositionUnitType",
                        Value = ControllerDisplayNameTextInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Y",
                        Type = "float",
                        Value = ControllerDisplayNameTextInstance.Y + -29f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = ControllerDisplayNameTextInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ControllerDisplayNameTextInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = ControllerDisplayNameTextInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.X",
                        Type = "float",
                        Value = InputDeviceIcon.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.X Origin",
                        Type = "HorizontalAlignment",
                        Value = InputDeviceIcon.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.X Units",
                        Type = "PositionUnitType",
                        Value = InputDeviceIcon.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Y",
                        Type = "float",
                        Value = InputDeviceIcon.Y + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Y Origin",
                        Type = "VerticalAlignment",
                        Value = InputDeviceIcon.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Y Units",
                        Type = "PositionUnitType",
                        Value = InputDeviceIcon.YUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (PlayerJoinCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  PlayerJoinCategory.NotConnected:
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
                        Name = "ControllerDisplayNameTextInstance.Visible",
                        Type = "bool",
                        Value = ControllerDisplayNameTextInstance.Visible
                    }
                    );
                    break;
                case  PlayerJoinCategory.Connected:
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
                        Name = "ControllerDisplayNameTextInstance.Visible",
                        Type = "bool",
                        Value = ControllerDisplayNameTextInstance.Visible
                    }
                    );
                    break;
                case  PlayerJoinCategory.ConnectedAndJoined:
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
                        Name = "ControllerDisplayNameTextInstance.Visible",
                        Type = "bool",
                        Value = ControllerDisplayNameTextInstance.Visible
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (PlayerJoinCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  PlayerJoinCategory.NotConnected:
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
                        Name = "ControllerDisplayNameTextInstance.Visible",
                        Type = "bool",
                        Value = ControllerDisplayNameTextInstance.Visible
                    }
                    );
                    break;
                case  PlayerJoinCategory.Connected:
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
                        Name = "ControllerDisplayNameTextInstance.Visible",
                        Type = "bool",
                        Value = ControllerDisplayNameTextInstance.Visible
                    }
                    );
                    break;
                case  PlayerJoinCategory.ConnectedAndJoined:
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
                        Name = "ControllerDisplayNameTextInstance.Visible",
                        Type = "bool",
                        Value = ControllerDisplayNameTextInstance.Visible
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (PlayerIndexCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  PlayerIndexCategory.Player1:
                    break;
                case  PlayerIndexCategory.Player2:
                    break;
                case  PlayerIndexCategory.Player3:
                    break;
                case  PlayerIndexCategory.Player4:
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (PlayerIndexCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  PlayerIndexCategory.Player1:
                    break;
                case  PlayerIndexCategory.Player2:
                    break;
                case  PlayerIndexCategory.Player3:
                    break;
                case  PlayerIndexCategory.Player4:
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (GamepadLayoutCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  GamepadLayoutCategory.Unknown:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.Keyboard:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.NES:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.SuperNintendo:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.Nintendo64:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.GameCube:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.SwitchPro:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.Genesis:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.Xbox360:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.PlayStationDualShock:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (GamepadLayoutCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  GamepadLayoutCategory.Unknown:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.Keyboard:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.NES:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.SuperNintendo:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.Nintendo64:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.GameCube:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.SwitchPro:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.Genesis:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.Xbox360:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
                    }
                    );
                    break;
                case  GamepadLayoutCategory.PlayStationDualShock:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.IconCategoryState",
                        Type = "IconCategory",
                        Value = InputDeviceIcon.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InputDeviceIcon.Visible",
                        Type = "bool",
                        Value = InputDeviceIcon.Visible
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
                else if (category.Name == "PlayerJoinCategory")
                {
                    if(state.Name == "NotConnected") this.mCurrentPlayerJoinCategoryState = PlayerJoinCategory.NotConnected;
                    if(state.Name == "Connected") this.mCurrentPlayerJoinCategoryState = PlayerJoinCategory.Connected;
                    if(state.Name == "ConnectedAndJoined") this.mCurrentPlayerJoinCategoryState = PlayerJoinCategory.ConnectedAndJoined;
                }
                else if (category.Name == "PlayerIndexCategory")
                {
                    if(state.Name == "Player1") this.mCurrentPlayerIndexCategoryState = PlayerIndexCategory.Player1;
                    if(state.Name == "Player2") this.mCurrentPlayerIndexCategoryState = PlayerIndexCategory.Player2;
                    if(state.Name == "Player3") this.mCurrentPlayerIndexCategoryState = PlayerIndexCategory.Player3;
                    if(state.Name == "Player4") this.mCurrentPlayerIndexCategoryState = PlayerIndexCategory.Player4;
                }
                else if (category.Name == "GamepadLayoutCategory")
                {
                    if(state.Name == "Unknown") this.mCurrentGamepadLayoutCategoryState = GamepadLayoutCategory.Unknown;
                    if(state.Name == "Keyboard") this.mCurrentGamepadLayoutCategoryState = GamepadLayoutCategory.Keyboard;
                    if(state.Name == "NES") this.mCurrentGamepadLayoutCategoryState = GamepadLayoutCategory.NES;
                    if(state.Name == "SuperNintendo") this.mCurrentGamepadLayoutCategoryState = GamepadLayoutCategory.SuperNintendo;
                    if(state.Name == "Nintendo64") this.mCurrentGamepadLayoutCategoryState = GamepadLayoutCategory.Nintendo64;
                    if(state.Name == "GameCube") this.mCurrentGamepadLayoutCategoryState = GamepadLayoutCategory.GameCube;
                    if(state.Name == "SwitchPro") this.mCurrentGamepadLayoutCategoryState = GamepadLayoutCategory.SwitchPro;
                    if(state.Name == "Genesis") this.mCurrentGamepadLayoutCategoryState = GamepadLayoutCategory.Genesis;
                    if(state.Name == "Xbox360") this.mCurrentGamepadLayoutCategoryState = GamepadLayoutCategory.Xbox360;
                    if(state.Name == "PlayStationDualShock") this.mCurrentGamepadLayoutCategoryState = GamepadLayoutCategory.PlayStationDualShock;
                }
            }
            base.ApplyState(state);
        }
        Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.PlayerJoinCategory Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.CurrentPlayerJoinCategoryState
        {
            set
            {
                switch(value)
                {
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.PlayerJoinCategory.NotConnected:
                        this.CurrentPlayerJoinCategoryState = PlayerJoinCategory.NotConnected;
                        break;
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.PlayerJoinCategory.Connected:
                        this.CurrentPlayerJoinCategoryState = PlayerJoinCategory.Connected;
                        break;
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.PlayerJoinCategory.ConnectedAndJoined:
                        this.CurrentPlayerJoinCategoryState = PlayerJoinCategory.ConnectedAndJoined;
                        break;
                }
            }
        }
        Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.GamepadLayoutCategory Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.CurrentGamepadLayoutCategoryState
        {
            set
            {
                switch(value)
                {
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.GamepadLayoutCategory.Unknown:
                        this.CurrentGamepadLayoutCategoryState = GamepadLayoutCategory.Unknown;
                        break;
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.GamepadLayoutCategory.Keyboard:
                        this.CurrentGamepadLayoutCategoryState = GamepadLayoutCategory.Keyboard;
                        break;
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.GamepadLayoutCategory.NES:
                        this.CurrentGamepadLayoutCategoryState = GamepadLayoutCategory.NES;
                        break;
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.GamepadLayoutCategory.SuperNintendo:
                        this.CurrentGamepadLayoutCategoryState = GamepadLayoutCategory.SuperNintendo;
                        break;
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.GamepadLayoutCategory.Nintendo64:
                        this.CurrentGamepadLayoutCategoryState = GamepadLayoutCategory.Nintendo64;
                        break;
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.GamepadLayoutCategory.GameCube:
                        this.CurrentGamepadLayoutCategoryState = GamepadLayoutCategory.GameCube;
                        break;
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.GamepadLayoutCategory.SwitchPro:
                        this.CurrentGamepadLayoutCategoryState = GamepadLayoutCategory.SwitchPro;
                        break;
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.GamepadLayoutCategory.Genesis:
                        this.CurrentGamepadLayoutCategoryState = GamepadLayoutCategory.Genesis;
                        break;
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.GamepadLayoutCategory.Xbox360:
                        this.CurrentGamepadLayoutCategoryState = GamepadLayoutCategory.Xbox360;
                        break;
                    case  Harvesteer.GumRuntimes.IPlayerJoinViewItemBehavior.GamepadLayoutCategory.PlayStationDualShock:
                        this.CurrentGamepadLayoutCategoryState = GamepadLayoutCategory.PlayStationDualShock;
                        break;
                }
            }
        }
        private bool tryCreateFormsObject;
        public Harvesteer.GumRuntimes.NineSliceRuntime Background { get; set; }
        public Harvesteer.GumRuntimes.TextRuntime ControllerDisplayNameTextInstance { get; set; }
        public Harvesteer.GumRuntimes.Elements.IconRuntime InputDeviceIcon { get; set; }
        public event FlatRedBall.Gui.WindowEvent InputDeviceIconClick;
        public PlayerJoinViewItemRuntime () 
        	: this(true, true)
        {
        }
        public PlayerJoinViewItemRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/PlayerJoinViewItem");
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
            ControllerDisplayNameTextInstance = this.GetGraphicalUiElementByName("ControllerDisplayNameTextInstance") as Harvesteer.GumRuntimes.TextRuntime;
            InputDeviceIcon = this.GetGraphicalUiElementByName("InputDeviceIcon") as Harvesteer.GumRuntimes.Elements.IconRuntime;
            InputDeviceIcon.Click += (unused) => InputDeviceIconClick?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.Games.PlayerJoinViewItem(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.Games.PlayerJoinViewItem FormsControl {get => (FlatRedBall.Forms.Controls.Games.PlayerJoinViewItem) FormsControlAsObject;}
    }
}
