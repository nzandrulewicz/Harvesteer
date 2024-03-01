namespace Harvesteer.GumRuntimes
{
    public interface IPlayerJoinViewItemBehavior
    {
        #region State Enums
        public enum PlayerJoinCategory
        {
            NotConnected,
            Connected,
            ConnectedAndJoined
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
        PlayerJoinCategory CurrentPlayerJoinCategoryState {set;}
        GamepadLayoutCategory CurrentGamepadLayoutCategoryState {set;}
    }
}
