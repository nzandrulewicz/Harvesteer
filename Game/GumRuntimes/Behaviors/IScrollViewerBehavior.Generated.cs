namespace Harvesteer.GumRuntimes
{
    public interface IScrollViewerBehavior
    {
        #region State Enums
        public enum ScrollBarVisibility
        {
            NoScrollBar,
            VerticalScrollVisible
        }
        #endregion
        ScrollBarVisibility CurrentScrollBarVisibilityState {set;}
    }
}
