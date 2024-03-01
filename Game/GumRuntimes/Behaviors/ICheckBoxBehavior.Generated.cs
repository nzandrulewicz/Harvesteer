namespace Harvesteer.GumRuntimes
{
    public interface ICheckBoxBehavior
    {
        #region State Enums
        public enum CheckBoxCategory
        {
            EnabledOn,
            EnabledOff,
            DisabledOn,
            DisabledOff,
            HighlightedOn,
            HighlightedOff,
            PushedOn,
            PushedOff,
            FocusedOn,
            FocusedOff,
            HighlightedFocusedOn,
            HighlightedFocusedOff,
            DisabledFocusedOn,
            DisabledFocusedOff
        }
        #endregion
        CheckBoxCategory CurrentCheckBoxCategoryState {set;}
    }
}
