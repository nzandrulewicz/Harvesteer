namespace Harvesteer.GumRuntimes
{
    public interface ISliderBehavior
    {
        #region State Enums
        public enum SliderCategory
        {
            Enabled,
            Focused,
            Highlighted,
            HighlightedFocused
        }
        #endregion
        SliderCategory CurrentSliderCategoryState {set;}
    }
}
