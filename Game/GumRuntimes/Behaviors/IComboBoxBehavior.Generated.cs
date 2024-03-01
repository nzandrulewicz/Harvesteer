namespace Harvesteer.GumRuntimes
{
    public interface IComboBoxBehavior
    {
        #region State Enums
        public enum ComboBoxCategory
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
        ComboBoxCategory CurrentComboBoxCategoryState {set;}
    }
}
