namespace Harvesteer.GumRuntimes
{
    public interface IRadioButtonBehavior
    {
        #region State Enums
        public enum RadioButtonCategory
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
        RadioButtonCategory CurrentRadioButtonCategoryState {set;}
    }
}
