namespace Harvesteer.GumRuntimes
{
    public interface IButtonBehavior
    {
        #region State Enums
        public enum ButtonCategory
        {
            Enabled,
            Disabled,
            Highlighted,
            Pushed,
            HighlightedFocused,
            Focused,
            DisabledFocused
        }
        #endregion
        ButtonCategory CurrentButtonCategoryState {set;}
    }
}
