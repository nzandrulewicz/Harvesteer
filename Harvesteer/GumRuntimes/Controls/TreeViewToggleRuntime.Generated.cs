using System.Linq;
namespace Harvesteer.GumRuntimes.Controls
{
    public partial class TreeViewToggleRuntime : Harvesteer.GumRuntimes.ContainerRuntime, Harvesteer.GumRuntimes.IToggleBehavior
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
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
        #region State Fields
        VariableState mCurrentVariableState;
        ToggleCategory? mCurrentToggleCategoryState;
        #endregion
        #region State Properties
        public VariableState CurrentVariableState
        {
            get
            {
                return mCurrentVariableState;
            }
            set
            {
                mCurrentVariableState = value;
                switch(mCurrentVariableState)
                {
                    case  VariableState.Default:
                        IconInstance.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                        NineSliceInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                        NineSliceInstance.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                        IconInstance.CurrentIconCategoryState = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.Arrow2;
                        Height = 24f;
                        HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        Width = 24f;
                        WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        IconInstance.Height = 0f;
                        IconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        IconInstance.Width = 0f;
                        IconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        break;
                }
            }
        }
        public ToggleCategory? CurrentToggleCategoryState
        {
            get
            {
                return mCurrentToggleCategoryState;
            }
            set
            {
                if (value != null)
                {
                    mCurrentToggleCategoryState = value;
                    switch(mCurrentToggleCategoryState)
                    {
                        case  ToggleCategory.EnabledOn:
                            NineSliceInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            IconInstance.Rotation = -90f;
                            IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            break;
                        case  ToggleCategory.EnabledOff:
                            NineSliceInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                            IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            IconInstance.Rotation = 0f;
                            IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            break;
                        case  ToggleCategory.DisabledOn:
                            NineSliceInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                            IconInstance.Rotation = -90f;
                            IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            break;
                        case  ToggleCategory.DisabledOff:
                            NineSliceInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                            IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                            IconInstance.Rotation = 0f;
                            IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            break;
                        case  ToggleCategory.HighlightedOn:
                            NineSliceInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            IconInstance.Rotation = -90f;
                            IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            break;
                        case  ToggleCategory.HighlightedOff:
                            NineSliceInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                            IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            IconInstance.Rotation = 0f;
                            IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            break;
                        case  ToggleCategory.PushedOn:
                            NineSliceInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                            IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            IconInstance.Rotation = -90f;
                            IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                            break;
                        case  ToggleCategory.PushedOff:
                            NineSliceInstance.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                            IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                            IconInstance.Rotation = 0f;
                            IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                            break;
                    }
                }
            }
        }
        #endregion
        #region State Interpolation
        public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setHeightFirstValue = false;
            bool setHeightSecondValue = false;
            float HeightFirstValue= 0;
            float HeightSecondValue= 0;
            bool setIconInstanceHeightFirstValue = false;
            bool setIconInstanceHeightSecondValue = false;
            float IconInstanceHeightFirstValue= 0;
            float IconInstanceHeightSecondValue= 0;
            bool setIconInstanceCurrentIconCategoryStateFirstValue = false;
            bool setIconInstanceCurrentIconCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory IconInstanceCurrentIconCategoryStateFirstValue= Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory IconInstanceCurrentIconCategoryStateSecondValue= Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.None;
            bool setIconInstanceWidthFirstValue = false;
            bool setIconInstanceWidthSecondValue = false;
            float IconInstanceWidthFirstValue= 0;
            float IconInstanceWidthSecondValue= 0;
            bool setNineSliceInstanceCurrentColorCategoryStateFirstValue = false;
            bool setNineSliceInstanceCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setNineSliceInstanceCurrentStyleCategoryStateFirstValue = false;
            bool setNineSliceInstanceCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory NineSliceInstanceCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory NineSliceInstanceCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setWidthFirstValue = false;
            bool setWidthSecondValue = false;
            float WidthFirstValue= 0;
            float WidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setHeightFirstValue = true;
                    HeightFirstValue = 24f;
                    if (interpolationValue < 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setIconInstanceHeightFirstValue = true;
                    IconInstanceHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setIconInstanceCurrentIconCategoryStateFirstValue = true;
                    IconInstanceCurrentIconCategoryStateFirstValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.Arrow2;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                    }
                    setIconInstanceWidthFirstValue = true;
                    IconInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                    NineSliceInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setNineSliceInstanceCurrentStyleCategoryStateFirstValue = true;
                    NineSliceInstanceCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setWidthFirstValue = true;
                    WidthFirstValue = 24f;
                    if (interpolationValue < 1)
                    {
                        this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setHeightSecondValue = true;
                    HeightSecondValue = 24f;
                    if (interpolationValue >= 1)
                    {
                        this.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setIconInstanceHeightSecondValue = true;
                    IconInstanceHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setIconInstanceCurrentIconCategoryStateSecondValue = true;
                    IconInstanceCurrentIconCategoryStateSecondValue = Harvesteer.GumRuntimes.Elements.IconRuntime.IconCategory.Arrow2;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.Parent = this.GetGraphicalUiElementByName("NineSliceInstance") ?? this;
                    }
                    setIconInstanceWidthSecondValue = true;
                    IconInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                    NineSliceInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    setNineSliceInstanceCurrentStyleCategoryStateSecondValue = true;
                    NineSliceInstanceCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setWidthSecondValue = true;
                    WidthSecondValue = 24f;
                    if (interpolationValue >= 1)
                    {
                        this.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setHeightFirstValue && setHeightSecondValue)
            {
                Height = HeightFirstValue * (1 - interpolationValue) + HeightSecondValue * interpolationValue;
            }
            if (setIconInstanceHeightFirstValue && setIconInstanceHeightSecondValue)
            {
                IconInstance.Height = IconInstanceHeightFirstValue * (1 - interpolationValue) + IconInstanceHeightSecondValue * interpolationValue;
            }
            if (setIconInstanceCurrentIconCategoryStateFirstValue && setIconInstanceCurrentIconCategoryStateSecondValue)
            {
                IconInstance.InterpolateBetween(IconInstanceCurrentIconCategoryStateFirstValue, IconInstanceCurrentIconCategoryStateSecondValue, interpolationValue);
            }
            if (setIconInstanceWidthFirstValue && setIconInstanceWidthSecondValue)
            {
                IconInstance.Width = IconInstanceWidthFirstValue * (1 - interpolationValue) + IconInstanceWidthSecondValue * interpolationValue;
            }
            if (setNineSliceInstanceCurrentColorCategoryStateFirstValue && setNineSliceInstanceCurrentColorCategoryStateSecondValue)
            {
                NineSliceInstance.InterpolateBetween(NineSliceInstanceCurrentColorCategoryStateFirstValue, NineSliceInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setNineSliceInstanceCurrentStyleCategoryStateFirstValue && setNineSliceInstanceCurrentStyleCategoryStateSecondValue)
            {
                NineSliceInstance.InterpolateBetween(NineSliceInstanceCurrentStyleCategoryStateFirstValue, NineSliceInstanceCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setWidthFirstValue && setWidthSecondValue)
            {
                Width = WidthFirstValue * (1 - interpolationValue) + WidthSecondValue * interpolationValue;
            }
            if (interpolationValue < 1)
            {
                mCurrentVariableState = firstState;
            }
            else
            {
                mCurrentVariableState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        public void InterpolateBetween (ToggleCategory firstState, ToggleCategory secondState, float interpolationValue) 
        {
            #if DEBUG
            if (float.IsNaN(interpolationValue))
            {
                throw new System.Exception("interpolationValue cannot be NaN");
            }
            #endif
            bool setIconInstanceRotationFirstValue = false;
            bool setIconInstanceRotationSecondValue = false;
            float IconInstanceRotationFirstValue= 0;
            float IconInstanceRotationSecondValue= 0;
            bool setNineSliceInstanceCurrentColorCategoryStateFirstValue = false;
            bool setNineSliceInstanceCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory NineSliceInstanceCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            switch(firstState)
            {
                case  ToggleCategory.EnabledOn:
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    setIconInstanceRotationFirstValue = true;
                    IconInstanceRotationFirstValue = -90f;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                    NineSliceInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    break;
                case  ToggleCategory.EnabledOff:
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    setIconInstanceRotationFirstValue = true;
                    IconInstanceRotationFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                    NineSliceInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    break;
                case  ToggleCategory.DisabledOn:
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    setIconInstanceRotationFirstValue = true;
                    IconInstanceRotationFirstValue = -90f;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                    NineSliceInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    break;
                case  ToggleCategory.DisabledOff:
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    setIconInstanceRotationFirstValue = true;
                    IconInstanceRotationFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                    NineSliceInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    break;
                case  ToggleCategory.HighlightedOn:
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    setIconInstanceRotationFirstValue = true;
                    IconInstanceRotationFirstValue = -90f;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                    NineSliceInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    break;
                case  ToggleCategory.HighlightedOff:
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    setIconInstanceRotationFirstValue = true;
                    IconInstanceRotationFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                    NineSliceInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    break;
                case  ToggleCategory.PushedOn:
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    setIconInstanceRotationFirstValue = true;
                    IconInstanceRotationFirstValue = -90f;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                    NineSliceInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                    break;
                case  ToggleCategory.PushedOff:
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    setIconInstanceRotationFirstValue = true;
                    IconInstanceRotationFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue < 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateFirstValue = true;
                    NineSliceInstanceCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                    break;
            }
            switch(secondState)
            {
                case  ToggleCategory.EnabledOn:
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    setIconInstanceRotationSecondValue = true;
                    IconInstanceRotationSecondValue = -90f;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                    NineSliceInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    break;
                case  ToggleCategory.EnabledOff:
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    setIconInstanceRotationSecondValue = true;
                    IconInstanceRotationSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                    NineSliceInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Primary;
                    break;
                case  ToggleCategory.DisabledOn:
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    setIconInstanceRotationSecondValue = true;
                    IconInstanceRotationSecondValue = -90f;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                    NineSliceInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    break;
                case  ToggleCategory.DisabledOff:
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.Gray;
                    }
                    setIconInstanceRotationSecondValue = true;
                    IconInstanceRotationSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                    NineSliceInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    break;
                case  ToggleCategory.HighlightedOn:
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    setIconInstanceRotationSecondValue = true;
                    IconInstanceRotationSecondValue = -90f;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                    NineSliceInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    break;
                case  ToggleCategory.HighlightedOff:
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    setIconInstanceRotationSecondValue = true;
                    IconInstanceRotationSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                    NineSliceInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryLight;
                    break;
                case  ToggleCategory.PushedOn:
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    setIconInstanceRotationSecondValue = true;
                    IconInstanceRotationSecondValue = -90f;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Bottom;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                    NineSliceInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                    break;
                case  ToggleCategory.PushedOff:
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.IconColor = Harvesteer.GumRuntimes.SpriteRuntime.ColorCategory.White;
                    }
                    setIconInstanceRotationSecondValue = true;
                    IconInstanceRotationSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.IconInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    setNineSliceInstanceCurrentColorCategoryStateSecondValue = true;
                    NineSliceInstanceCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.PrimaryDark;
                    break;
            }
            var wasSuppressed = mIsLayoutSuspended;
            var shouldSuspend = wasSuppressed == false;
            var suspendRecursively = true;
            if (shouldSuspend)
            {
                SuspendLayout(suspendRecursively);
            }
            if (setIconInstanceRotationFirstValue && setIconInstanceRotationSecondValue)
            {
                IconInstance.Rotation = IconInstanceRotationFirstValue * (1 - interpolationValue) + IconInstanceRotationSecondValue * interpolationValue;
            }
            if (setNineSliceInstanceCurrentColorCategoryStateFirstValue && setNineSliceInstanceCurrentColorCategoryStateSecondValue)
            {
                NineSliceInstance.InterpolateBetween(NineSliceInstanceCurrentColorCategoryStateFirstValue, NineSliceInstanceCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (interpolationValue < 1)
            {
                mCurrentToggleCategoryState = firstState;
            }
            else
            {
                mCurrentToggleCategoryState = secondState;
            }
            if (shouldSuspend)
            {
                ResumeLayout(suspendRecursively);
            }
        }
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.TreeViewToggleRuntime.VariableState fromState,Harvesteer.GumRuntimes.Controls.TreeViewToggleRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
        {
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.States.First(item => item.Name == toState.ToString());
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
            tweener.Ended += ()=> this.CurrentVariableState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
            tweener.Ended += ()=> this.CurrentVariableState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.TreeViewToggleRuntime.ToggleCategory fromState,Harvesteer.GumRuntimes.Controls.TreeViewToggleRuntime.ToggleCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
        {
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (ToggleCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.Categories.First(item => item.Name == "ToggleCategory").States.First(item => item.Name == toState.ToString());
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
            tweener.Ended += ()=> this.CurrentToggleCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (ToggleCategory toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
        {
            Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
            Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
            FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
            if (owner == null)
            {
                tweener.Owner = this;
            }
            else
            {
                tweener.Owner = owner;
            }
            tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
            tweener.Ended += ()=> this.CurrentToggleCategoryState = toState;
            tweener.Start();
            StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
            return tweener;
        }
        #endregion
        #region State Animations
        #endregion
        public override void StopAnimations () 
        {
            base.StopAnimations();
            IconInstance.StopAnimations();
        }
        public override FlatRedBall.Gum.Animation.GumAnimation GetAnimation (string animationName) 
        {
            return base.GetAnimation(animationName);
        }
        #region Get Current Values on State
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  VariableState.Default:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height",
                        Type = "float",
                        Value = Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height Units",
                        Type = "DimensionUnitType",
                        Value = HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width Units",
                        Type = "DimensionUnitType",
                        Value = WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = NineSliceInstance.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Height",
                        Type = "float",
                        Value = IconInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = IconInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconCategoryState",
                        Type = "IconCategory",
                        Value = IconInstance.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Parent",
                        Type = "string",
                        Value = IconInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Width",
                        Type = "float",
                        Value = IconInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = IconInstance.WidthUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  VariableState.Default:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height",
                        Type = "float",
                        Value = Height + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Height Units",
                        Type = "DimensionUnitType",
                        Value = HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width",
                        Type = "float",
                        Value = Width + 24f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Width Units",
                        Type = "DimensionUnitType",
                        Value = WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = NineSliceInstance.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Height",
                        Type = "float",
                        Value = IconInstance.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = IconInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconCategoryState",
                        Type = "IconCategory",
                        Value = IconInstance.CurrentIconCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Parent",
                        Type = "string",
                        Value = IconInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Width",
                        Type = "float",
                        Value = IconInstance.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = IconInstance.WidthUnits
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (ToggleCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  ToggleCategory.EnabledOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "RenderingLibrary.Graphics.HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "RenderingLibrary.Graphics.VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.EnabledOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.DisabledOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "string",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.DisabledOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.HighlightedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.HighlightedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.PushedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.PushedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
            }
            return newState;
        }
        private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (ToggleCategory state) 
        {
            Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
            switch(state)
            {
                case  ToggleCategory.EnabledOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation + -90f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "RenderingLibrary.Graphics.HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "RenderingLibrary.Graphics.VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.EnabledOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.DisabledOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "string",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation + -90f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.DisabledOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.HighlightedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation + -90f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.HighlightedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.PushedOn:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation + -90f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
                case  ToggleCategory.PushedOff:
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "NineSliceInstance.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = NineSliceInstance.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.IconColor",
                        Type = "ColorCategory",
                        Value = IconInstance.IconColor
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Rotation",
                        Type = "float",
                        Value = IconInstance.Rotation + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = IconInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "IconInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = IconInstance.YOrigin
                    }
                    );
                    break;
            }
            return newState;
        }
        #endregion
        public override void ApplyState (Gum.DataTypes.Variables.StateSave state) 
        {
            bool matches = this.ElementSave.AllStates.Contains(state);
            if (matches)
            {
                var category = this.ElementSave.Categories.FirstOrDefault(item => item.States.Contains(state));
                if (category == null)
                {
                    if (state.Name == "Default") this.mCurrentVariableState = VariableState.Default;
                }
                else if (category.Name == "ToggleCategory")
                {
                    if(state.Name == "EnabledOn") this.mCurrentToggleCategoryState = ToggleCategory.EnabledOn;
                    if(state.Name == "EnabledOff") this.mCurrentToggleCategoryState = ToggleCategory.EnabledOff;
                    if(state.Name == "DisabledOn") this.mCurrentToggleCategoryState = ToggleCategory.DisabledOn;
                    if(state.Name == "DisabledOff") this.mCurrentToggleCategoryState = ToggleCategory.DisabledOff;
                    if(state.Name == "HighlightedOn") this.mCurrentToggleCategoryState = ToggleCategory.HighlightedOn;
                    if(state.Name == "HighlightedOff") this.mCurrentToggleCategoryState = ToggleCategory.HighlightedOff;
                    if(state.Name == "PushedOn") this.mCurrentToggleCategoryState = ToggleCategory.PushedOn;
                    if(state.Name == "PushedOff") this.mCurrentToggleCategoryState = ToggleCategory.PushedOff;
                }
            }
            base.ApplyState(state);
        }
        Harvesteer.GumRuntimes.IToggleBehavior.ToggleCategory Harvesteer.GumRuntimes.IToggleBehavior.CurrentToggleCategoryState
        {
            set
            {
                switch(value)
                {
                    case  Harvesteer.GumRuntimes.IToggleBehavior.ToggleCategory.EnabledOn:
                        this.CurrentToggleCategoryState = ToggleCategory.EnabledOn;
                        break;
                    case  Harvesteer.GumRuntimes.IToggleBehavior.ToggleCategory.EnabledOff:
                        this.CurrentToggleCategoryState = ToggleCategory.EnabledOff;
                        break;
                    case  Harvesteer.GumRuntimes.IToggleBehavior.ToggleCategory.DisabledOn:
                        this.CurrentToggleCategoryState = ToggleCategory.DisabledOn;
                        break;
                    case  Harvesteer.GumRuntimes.IToggleBehavior.ToggleCategory.DisabledOff:
                        this.CurrentToggleCategoryState = ToggleCategory.DisabledOff;
                        break;
                    case  Harvesteer.GumRuntimes.IToggleBehavior.ToggleCategory.HighlightedOn:
                        this.CurrentToggleCategoryState = ToggleCategory.HighlightedOn;
                        break;
                    case  Harvesteer.GumRuntimes.IToggleBehavior.ToggleCategory.HighlightedOff:
                        this.CurrentToggleCategoryState = ToggleCategory.HighlightedOff;
                        break;
                    case  Harvesteer.GumRuntimes.IToggleBehavior.ToggleCategory.PushedOn:
                        this.CurrentToggleCategoryState = ToggleCategory.PushedOn;
                        break;
                    case  Harvesteer.GumRuntimes.IToggleBehavior.ToggleCategory.PushedOff:
                        this.CurrentToggleCategoryState = ToggleCategory.PushedOff;
                        break;
                }
            }
        }
        private bool tryCreateFormsObject;
        public Harvesteer.GumRuntimes.NineSliceRuntime NineSliceInstance { get; set; }
        public Harvesteer.GumRuntimes.Elements.IconRuntime IconInstance { get; set; }
        public event FlatRedBall.Gui.WindowEvent IconInstanceClick;
        public TreeViewToggleRuntime () 
        	: this(true, true)
        {
        }
        public TreeViewToggleRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/TreeViewToggle");
                this.ElementSave = elementSave;
                string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
            }
        }
        public override void SetInitialState () 
        {
            var wasSuppressed = this.IsLayoutSuspended;
            if(!wasSuppressed) this.SuspendLayout();
            base.SetInitialState();
            this.CurrentVariableState = VariableState.Default;
            if(!wasSuppressed) this.ResumeLayout();
            CallCustomInitialize();
        }
        public override void CreateChildrenRecursively (Gum.DataTypes.ElementSave elementSave, RenderingLibrary.ISystemManagers systemManagers) 
        {
            base.CreateChildrenRecursively(elementSave, systemManagers);
            this.AssignInternalReferences();
        }
        private void AssignInternalReferences () 
        {
            NineSliceInstance = this.GetGraphicalUiElementByName("NineSliceInstance") as Harvesteer.GumRuntimes.NineSliceRuntime;
            IconInstance = this.GetGraphicalUiElementByName("IconInstance") as Harvesteer.GumRuntimes.Elements.IconRuntime;
            IconInstance.Click += (unused) => IconInstanceClick?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.ToggleButton(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.ToggleButton FormsControl {get => (FlatRedBall.Forms.Controls.ToggleButton) FormsControlAsObject;}
    }
}
