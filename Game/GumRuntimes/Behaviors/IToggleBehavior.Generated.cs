namespace Harvesteer.GumRuntimes
{
    public interface IToggleBehavior
    {
        #region State Enums
        public enum ToggleCategory
        {
            EnabledOn,
            EnabledOff,
            DisabledOn,
            DisabledOff,
            HighlightedOn,
            HighlightedOff,
            PushedOn,
            PushedOff
        }
        #endregion
        ToggleCategory CurrentToggleCategoryState {set;}
    }
}
