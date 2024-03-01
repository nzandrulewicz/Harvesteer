namespace Harvesteer.GumRuntimes
{
    public interface ITreeViewBehavior
    {
        #region State Enums
        public enum TreeViewCategory
        {
            Enabled,
            Disabled,
            Focused,
            DisabledFocused
        }
        #endregion
        TreeViewCategory CurrentTreeViewCategoryState {set;}
    }
}
