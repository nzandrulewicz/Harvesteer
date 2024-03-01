namespace Harvesteer.GumRuntimes
{
    public interface IScrollBarBehavior
    {
        #region State Enums
        public enum ScrollBarCategory
        {
        }
        #endregion
        ScrollBarCategory CurrentScrollBarCategoryState {set;}
    }
}
