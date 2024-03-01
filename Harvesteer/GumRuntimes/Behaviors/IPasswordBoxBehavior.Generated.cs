namespace Harvesteer.GumRuntimes
{
    public interface IPasswordBoxBehavior
    {
        #region State Enums
        public enum PasswordBoxCategory
        {
            Enabled,
            Disabled,
            Highlighted,
            Selected
        }
        #endregion
        PasswordBoxCategory CurrentPasswordBoxCategoryState {set;}
    }
}
