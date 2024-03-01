namespace Harvesteer.GumRuntimes
{
    public interface IListBoxItemBehavior
    {
        #region State Enums
        public enum ListBoxItemCategory
        {
            Enabled,
            Highlighted,
            Selected,
            Focused
        }
        #endregion
        ListBoxItemCategory CurrentListBoxItemCategoryState {set;}
    }
}
