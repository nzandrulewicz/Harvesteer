namespace Harvesteer.GumRuntimes
{
    public interface ITextBoxBehavior
    {
        #region State Enums
        public enum TextBoxCategory
        {
            Enabled,
            Disabled,
            Highlighted,
            Selected
        }
        public enum LineModeCategory
        {
            Single,
            Multi
        }
        #endregion
        TextBoxCategory CurrentTextBoxCategoryState {set;}
        LineModeCategory CurrentLineModeCategoryState {set;}
    }
}
