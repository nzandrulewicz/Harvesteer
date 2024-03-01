namespace Harvesteer.GumRuntimes
{
    public interface IListBoxBehavior
    {
        #region State Enums
        public enum ListBoxCategory
        {
            Enabled,
            Disabled,
            Focused,
            DisabledFocused
        }
        #endregion
        ListBoxCategory CurrentListBoxCategoryState {set;}
    }
}
