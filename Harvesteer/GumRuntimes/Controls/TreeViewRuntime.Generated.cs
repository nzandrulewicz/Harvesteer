using System.Linq;
namespace Harvesteer.GumRuntimes.Controls
{
    public partial class TreeViewRuntime : Harvesteer.GumRuntimes.ContainerRuntime, Harvesteer.GumRuntimes.ITreeViewBehavior
    {
        #region State Enums
        public enum VariableState
        {
            Default
        }
        #endregion
        #region State Fields
        VariableState mCurrentVariableState;
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
                        InnerPanelInstance.Parent = this.GetGraphicalUiElementByName("ClipContainerInstance") ?? this;
                        Background.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                        Background.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                        FocusedIndicator.CurrentColorCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Warning;
                        FocusedIndicator.CurrentStyleCategoryState = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                        Background.Height = 0f;
                        Background.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        Background.Width = 0f;
                        Background.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        Background.X = 0f;
                        Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        Background.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        Background.Y = 0f;
                        Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                        VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        VerticalScrollBarInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        VerticalScrollBarInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        ClipContainerInstance.ClipsChildren = true;
                        ClipContainerInstance.Height = -4f;
                        ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        ClipContainerInstance.Width = -27f;
                        ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        ClipContainerInstance.X = 2f;
                        ClipContainerInstance.Y = 2f;
                        ClipContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                        InnerPanelInstance.Height = 0f;
                        InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                        InnerPanelInstance.Width = 0f;
                        InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                        InnerPanelInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        InnerPanelInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                        InnerPanelInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        InnerPanelInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        FocusedIndicator.Height = 2f;
                        FocusedIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        FocusedIndicator.Visible = false;
                        FocusedIndicator.Y = 2f;
                        FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                        FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                        break;
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
            bool setBackgroundCurrentColorCategoryStateFirstValue = false;
            bool setBackgroundCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory BackgroundCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory BackgroundCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setBackgroundHeightFirstValue = false;
            bool setBackgroundHeightSecondValue = false;
            float BackgroundHeightFirstValue= 0;
            float BackgroundHeightSecondValue= 0;
            bool setBackgroundCurrentStyleCategoryStateFirstValue = false;
            bool setBackgroundCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory BackgroundCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setBackgroundWidthFirstValue = false;
            bool setBackgroundWidthSecondValue = false;
            float BackgroundWidthFirstValue= 0;
            float BackgroundWidthSecondValue= 0;
            bool setBackgroundXFirstValue = false;
            bool setBackgroundXSecondValue = false;
            float BackgroundXFirstValue= 0;
            float BackgroundXSecondValue= 0;
            bool setBackgroundYFirstValue = false;
            bool setBackgroundYSecondValue = false;
            float BackgroundYFirstValue= 0;
            float BackgroundYSecondValue= 0;
            bool setClipContainerInstanceHeightFirstValue = false;
            bool setClipContainerInstanceHeightSecondValue = false;
            float ClipContainerInstanceHeightFirstValue= 0;
            float ClipContainerInstanceHeightSecondValue= 0;
            bool setClipContainerInstanceWidthFirstValue = false;
            bool setClipContainerInstanceWidthSecondValue = false;
            float ClipContainerInstanceWidthFirstValue= 0;
            float ClipContainerInstanceWidthSecondValue= 0;
            bool setClipContainerInstanceXFirstValue = false;
            bool setClipContainerInstanceXSecondValue = false;
            float ClipContainerInstanceXFirstValue= 0;
            float ClipContainerInstanceXSecondValue= 0;
            bool setClipContainerInstanceYFirstValue = false;
            bool setClipContainerInstanceYSecondValue = false;
            float ClipContainerInstanceYFirstValue= 0;
            float ClipContainerInstanceYSecondValue= 0;
            bool setFocusedIndicatorCurrentColorCategoryStateFirstValue = false;
            bool setFocusedIndicatorCurrentColorCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory FocusedIndicatorCurrentColorCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory FocusedIndicatorCurrentColorCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Black;
            bool setFocusedIndicatorHeightFirstValue = false;
            bool setFocusedIndicatorHeightSecondValue = false;
            float FocusedIndicatorHeightFirstValue= 0;
            float FocusedIndicatorHeightSecondValue= 0;
            bool setFocusedIndicatorCurrentStyleCategoryStateFirstValue = false;
            bool setFocusedIndicatorCurrentStyleCategoryStateSecondValue = false;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory FocusedIndicatorCurrentStyleCategoryStateFirstValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory FocusedIndicatorCurrentStyleCategoryStateSecondValue= Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
            bool setFocusedIndicatorYFirstValue = false;
            bool setFocusedIndicatorYSecondValue = false;
            float FocusedIndicatorYFirstValue= 0;
            float FocusedIndicatorYSecondValue= 0;
            bool setInnerPanelInstanceHeightFirstValue = false;
            bool setInnerPanelInstanceHeightSecondValue = false;
            float InnerPanelInstanceHeightFirstValue= 0;
            float InnerPanelInstanceHeightSecondValue= 0;
            bool setInnerPanelInstanceWidthFirstValue = false;
            bool setInnerPanelInstanceWidthSecondValue = false;
            float InnerPanelInstanceWidthFirstValue= 0;
            float InnerPanelInstanceWidthSecondValue= 0;
            switch(firstState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateFirstValue = true;
                    BackgroundCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setBackgroundHeightFirstValue = true;
                    BackgroundHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setBackgroundCurrentStyleCategoryStateFirstValue = true;
                    BackgroundCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setBackgroundWidthFirstValue = true;
                    BackgroundWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setBackgroundXFirstValue = true;
                    BackgroundXFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Background.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setBackgroundYFirstValue = true;
                    BackgroundYFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ClipContainerInstance.ClipsChildren = true;
                    }
                    setClipContainerInstanceHeightFirstValue = true;
                    ClipContainerInstanceHeightFirstValue = -4f;
                    if (interpolationValue < 1)
                    {
                        this.ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setClipContainerInstanceWidthFirstValue = true;
                    ClipContainerInstanceWidthFirstValue = -27f;
                    if (interpolationValue < 1)
                    {
                        this.ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setClipContainerInstanceXFirstValue = true;
                    ClipContainerInstanceXFirstValue = 2f;
                    setClipContainerInstanceYFirstValue = true;
                    ClipContainerInstanceYFirstValue = 2f;
                    if (interpolationValue < 1)
                    {
                        this.ClipContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setFocusedIndicatorCurrentColorCategoryStateFirstValue = true;
                    FocusedIndicatorCurrentColorCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Warning;
                    setFocusedIndicatorHeightFirstValue = true;
                    FocusedIndicatorHeightFirstValue = 2f;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setFocusedIndicatorCurrentStyleCategoryStateFirstValue = true;
                    FocusedIndicatorCurrentStyleCategoryStateFirstValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setFocusedIndicatorYFirstValue = true;
                    FocusedIndicatorYFirstValue = 2f;
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                    }
                    setInnerPanelInstanceHeightFirstValue = true;
                    InnerPanelInstanceHeightFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.Parent = this.GetGraphicalUiElementByName("ClipContainerInstance") ?? this;
                    }
                    setInnerPanelInstanceWidthFirstValue = true;
                    InnerPanelInstanceWidthFirstValue = 0f;
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue < 1)
                    {
                        this.InnerPanelInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalScrollBarInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue < 1)
                    {
                        this.VerticalScrollBarInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    break;
            }
            switch(secondState)
            {
                case  VariableState.Default:
                    setBackgroundCurrentColorCategoryStateSecondValue = true;
                    BackgroundCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.DarkGray;
                    setBackgroundHeightSecondValue = true;
                    BackgroundHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setBackgroundCurrentStyleCategoryStateSecondValue = true;
                    BackgroundCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Bordered;
                    setBackgroundWidthSecondValue = true;
                    BackgroundWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setBackgroundXSecondValue = true;
                    BackgroundXSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Background.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    setBackgroundYSecondValue = true;
                    BackgroundYSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.Background.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.Background.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ClipContainerInstance.ClipsChildren = true;
                    }
                    setClipContainerInstanceHeightSecondValue = true;
                    ClipContainerInstanceHeightSecondValue = -4f;
                    if (interpolationValue >= 1)
                    {
                        this.ClipContainerInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setClipContainerInstanceWidthSecondValue = true;
                    ClipContainerInstanceWidthSecondValue = -27f;
                    if (interpolationValue >= 1)
                    {
                        this.ClipContainerInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    setClipContainerInstanceXSecondValue = true;
                    ClipContainerInstanceXSecondValue = 2f;
                    setClipContainerInstanceYSecondValue = true;
                    ClipContainerInstanceYSecondValue = 2f;
                    if (interpolationValue >= 1)
                    {
                        this.ClipContainerInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.ClipContainerInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    setFocusedIndicatorCurrentColorCategoryStateSecondValue = true;
                    FocusedIndicatorCurrentColorCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.ColorCategory.Warning;
                    setFocusedIndicatorHeightSecondValue = true;
                    FocusedIndicatorHeightSecondValue = 2f;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                    }
                    setFocusedIndicatorCurrentStyleCategoryStateSecondValue = true;
                    FocusedIndicatorCurrentStyleCategoryStateSecondValue = Harvesteer.GumRuntimes.NineSliceRuntime.StyleCategory.Solid;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.Visible = false;
                    }
                    setFocusedIndicatorYSecondValue = true;
                    FocusedIndicatorYSecondValue = 2f;
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.FocusedIndicator.YUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.ChildrenLayout = Gum.Managers.ChildrenLayout.TopToBottomStack;
                    }
                    setInnerPanelInstanceHeightSecondValue = true;
                    InnerPanelInstanceHeightSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.HeightUnits = Gum.DataTypes.DimensionUnitType.RelativeToChildren;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.Parent = this.GetGraphicalUiElementByName("ClipContainerInstance") ?? this;
                    }
                    setInnerPanelInstanceWidthSecondValue = true;
                    InnerPanelInstanceWidthSecondValue = 0f;
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.WidthUnits = Gum.DataTypes.DimensionUnitType.RelativeToContainer;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Top;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.InnerPanelInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalScrollBarInstance.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Right;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalScrollBarInstance.XUnits = Gum.Converters.GeneralUnitType.PixelsFromLarge;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalScrollBarInstance.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                    }
                    if (interpolationValue >= 1)
                    {
                        this.VerticalScrollBarInstance.YUnits = Gum.Converters.GeneralUnitType.PixelsFromMiddle;
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
            if (setBackgroundCurrentColorCategoryStateFirstValue && setBackgroundCurrentColorCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentColorCategoryStateFirstValue, BackgroundCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setBackgroundHeightFirstValue && setBackgroundHeightSecondValue)
            {
                Background.Height = BackgroundHeightFirstValue * (1 - interpolationValue) + BackgroundHeightSecondValue * interpolationValue;
            }
            if (setBackgroundCurrentStyleCategoryStateFirstValue && setBackgroundCurrentStyleCategoryStateSecondValue)
            {
                Background.InterpolateBetween(BackgroundCurrentStyleCategoryStateFirstValue, BackgroundCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setBackgroundWidthFirstValue && setBackgroundWidthSecondValue)
            {
                Background.Width = BackgroundWidthFirstValue * (1 - interpolationValue) + BackgroundWidthSecondValue * interpolationValue;
            }
            if (setBackgroundXFirstValue && setBackgroundXSecondValue)
            {
                Background.X = BackgroundXFirstValue * (1 - interpolationValue) + BackgroundXSecondValue * interpolationValue;
            }
            if (setBackgroundYFirstValue && setBackgroundYSecondValue)
            {
                Background.Y = BackgroundYFirstValue * (1 - interpolationValue) + BackgroundYSecondValue * interpolationValue;
            }
            if (setClipContainerInstanceHeightFirstValue && setClipContainerInstanceHeightSecondValue)
            {
                ClipContainerInstance.Height = ClipContainerInstanceHeightFirstValue * (1 - interpolationValue) + ClipContainerInstanceHeightSecondValue * interpolationValue;
            }
            if (setClipContainerInstanceWidthFirstValue && setClipContainerInstanceWidthSecondValue)
            {
                ClipContainerInstance.Width = ClipContainerInstanceWidthFirstValue * (1 - interpolationValue) + ClipContainerInstanceWidthSecondValue * interpolationValue;
            }
            if (setClipContainerInstanceXFirstValue && setClipContainerInstanceXSecondValue)
            {
                ClipContainerInstance.X = ClipContainerInstanceXFirstValue * (1 - interpolationValue) + ClipContainerInstanceXSecondValue * interpolationValue;
            }
            if (setClipContainerInstanceYFirstValue && setClipContainerInstanceYSecondValue)
            {
                ClipContainerInstance.Y = ClipContainerInstanceYFirstValue * (1 - interpolationValue) + ClipContainerInstanceYSecondValue * interpolationValue;
            }
            if (setFocusedIndicatorCurrentColorCategoryStateFirstValue && setFocusedIndicatorCurrentColorCategoryStateSecondValue)
            {
                FocusedIndicator.InterpolateBetween(FocusedIndicatorCurrentColorCategoryStateFirstValue, FocusedIndicatorCurrentColorCategoryStateSecondValue, interpolationValue);
            }
            if (setFocusedIndicatorHeightFirstValue && setFocusedIndicatorHeightSecondValue)
            {
                FocusedIndicator.Height = FocusedIndicatorHeightFirstValue * (1 - interpolationValue) + FocusedIndicatorHeightSecondValue * interpolationValue;
            }
            if (setFocusedIndicatorCurrentStyleCategoryStateFirstValue && setFocusedIndicatorCurrentStyleCategoryStateSecondValue)
            {
                FocusedIndicator.InterpolateBetween(FocusedIndicatorCurrentStyleCategoryStateFirstValue, FocusedIndicatorCurrentStyleCategoryStateSecondValue, interpolationValue);
            }
            if (setFocusedIndicatorYFirstValue && setFocusedIndicatorYSecondValue)
            {
                FocusedIndicator.Y = FocusedIndicatorYFirstValue * (1 - interpolationValue) + FocusedIndicatorYSecondValue * interpolationValue;
            }
            if (setInnerPanelInstanceHeightFirstValue && setInnerPanelInstanceHeightSecondValue)
            {
                InnerPanelInstance.Height = InnerPanelInstanceHeightFirstValue * (1 - interpolationValue) + InnerPanelInstanceHeightSecondValue * interpolationValue;
            }
            if (setInnerPanelInstanceWidthFirstValue && setInnerPanelInstanceWidthSecondValue)
            {
                InnerPanelInstance.Width = InnerPanelInstanceWidthFirstValue * (1 - interpolationValue) + InnerPanelInstanceWidthSecondValue * interpolationValue;
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
        #endregion
        #region State Interpolate To
        public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (Harvesteer.GumRuntimes.Controls.TreeViewRuntime.VariableState fromState,Harvesteer.GumRuntimes.Controls.TreeViewRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
        #endregion
        #region State Animations
        #endregion
        public override void StopAnimations () 
        {
            base.StopAnimations();
            VerticalScrollBarInstance.StopAnimations();
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
                        Name = "Background.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Background.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height",
                        Type = "float",
                        Value = Background.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height Units",
                        Type = "DimensionUnitType",
                        Value = Background.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = Background.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Width",
                        Type = "float",
                        Value = Background.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Width Units",
                        Type = "DimensionUnitType",
                        Value = Background.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X",
                        Type = "float",
                        Value = Background.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X Origin",
                        Type = "HorizontalAlignment",
                        Value = Background.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X Units",
                        Type = "PositionUnitType",
                        Value = Background.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y",
                        Type = "float",
                        Value = Background.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y Origin",
                        Type = "VerticalAlignment",
                        Value = Background.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y Units",
                        Type = "PositionUnitType",
                        Value = Background.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = VerticalScrollBarInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.X Units",
                        Type = "PositionUnitType",
                        Value = VerticalScrollBarInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = VerticalScrollBarInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = VerticalScrollBarInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Clips Children",
                        Type = "bool",
                        Value = ClipContainerInstance.ClipsChildren
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Height",
                        Type = "float",
                        Value = ClipContainerInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = ClipContainerInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Width",
                        Type = "float",
                        Value = ClipContainerInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = ClipContainerInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.X",
                        Type = "float",
                        Value = ClipContainerInstance.X
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Y",
                        Type = "float",
                        Value = ClipContainerInstance.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = ClipContainerInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = ClipContainerInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Children Layout",
                        Type = "ChildrenLayout",
                        Value = InnerPanelInstance.ChildrenLayout
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Height",
                        Type = "float",
                        Value = InnerPanelInstance.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = InnerPanelInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Parent",
                        Type = "string",
                        Value = InnerPanelInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Width",
                        Type = "float",
                        Value = InnerPanelInstance.Width
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = InnerPanelInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = InnerPanelInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.X Units",
                        Type = "PositionUnitType",
                        Value = InnerPanelInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = InnerPanelInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = InnerPanelInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = FocusedIndicator.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Height",
                        Type = "float",
                        Value = FocusedIndicator.Height
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Height Units",
                        Type = "DimensionUnitType",
                        Value = FocusedIndicator.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = FocusedIndicator.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y",
                        Type = "float",
                        Value = FocusedIndicator.Y
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y Origin",
                        Type = "VerticalAlignment",
                        Value = FocusedIndicator.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y Units",
                        Type = "PositionUnitType",
                        Value = FocusedIndicator.YUnits
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
                        Name = "Background.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = Background.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height",
                        Type = "float",
                        Value = Background.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Height Units",
                        Type = "DimensionUnitType",
                        Value = Background.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = Background.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Width",
                        Type = "float",
                        Value = Background.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Width Units",
                        Type = "DimensionUnitType",
                        Value = Background.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X",
                        Type = "float",
                        Value = Background.X + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X Origin",
                        Type = "HorizontalAlignment",
                        Value = Background.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.X Units",
                        Type = "PositionUnitType",
                        Value = Background.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y",
                        Type = "float",
                        Value = Background.Y + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y Origin",
                        Type = "VerticalAlignment",
                        Value = Background.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "Background.Y Units",
                        Type = "PositionUnitType",
                        Value = Background.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = VerticalScrollBarInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.X Units",
                        Type = "PositionUnitType",
                        Value = VerticalScrollBarInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = VerticalScrollBarInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "VerticalScrollBarInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = VerticalScrollBarInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Clips Children",
                        Type = "bool",
                        Value = ClipContainerInstance.ClipsChildren
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Height",
                        Type = "float",
                        Value = ClipContainerInstance.Height + -4f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = ClipContainerInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Width",
                        Type = "float",
                        Value = ClipContainerInstance.Width + -27f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = ClipContainerInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.X",
                        Type = "float",
                        Value = ClipContainerInstance.X + 2f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Y",
                        Type = "float",
                        Value = ClipContainerInstance.Y + 2f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = ClipContainerInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "ClipContainerInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = ClipContainerInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Children Layout",
                        Type = "ChildrenLayout",
                        Value = InnerPanelInstance.ChildrenLayout
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Height",
                        Type = "float",
                        Value = InnerPanelInstance.Height + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Height Units",
                        Type = "DimensionUnitType",
                        Value = InnerPanelInstance.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Parent",
                        Type = "string",
                        Value = InnerPanelInstance.Parent
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Width",
                        Type = "float",
                        Value = InnerPanelInstance.Width + 0f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Width Units",
                        Type = "DimensionUnitType",
                        Value = InnerPanelInstance.WidthUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.X Origin",
                        Type = "HorizontalAlignment",
                        Value = InnerPanelInstance.XOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.X Units",
                        Type = "PositionUnitType",
                        Value = InnerPanelInstance.XUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Y Origin",
                        Type = "VerticalAlignment",
                        Value = InnerPanelInstance.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "InnerPanelInstance.Y Units",
                        Type = "PositionUnitType",
                        Value = InnerPanelInstance.YUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.ColorCategoryState",
                        Type = "ColorCategory",
                        Value = FocusedIndicator.CurrentColorCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Height",
                        Type = "float",
                        Value = FocusedIndicator.Height + 2f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Height Units",
                        Type = "DimensionUnitType",
                        Value = FocusedIndicator.HeightUnits
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.StyleCategoryState",
                        Type = "StyleCategory",
                        Value = FocusedIndicator.CurrentStyleCategoryState
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Visible",
                        Type = "bool",
                        Value = FocusedIndicator.Visible
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y",
                        Type = "float",
                        Value = FocusedIndicator.Y + 2f
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y Origin",
                        Type = "VerticalAlignment",
                        Value = FocusedIndicator.YOrigin
                    }
                    );
                    newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                    {
                        SetsValue = true,
                        Name = "FocusedIndicator.Y Units",
                        Type = "PositionUnitType",
                        Value = FocusedIndicator.YUnits
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
            }
            base.ApplyState(state);
        }
        Harvesteer.GumRuntimes.ITreeViewBehavior.TreeViewCategory Harvesteer.GumRuntimes.ITreeViewBehavior.CurrentTreeViewCategoryState
        {
            set
            {
                switch(value)
                {
                    case  Harvesteer.GumRuntimes.ITreeViewBehavior.TreeViewCategory.Enabled:
                        //Cannot assign this state because this element is missing the category TreeViewCategory
                        //this.CurrentTreeViewCategoryState = TreeViewCategory.Enabled;
                        break;
                    case  Harvesteer.GumRuntimes.ITreeViewBehavior.TreeViewCategory.Disabled:
                        //Cannot assign this state because this element is missing the category TreeViewCategory
                        //this.CurrentTreeViewCategoryState = TreeViewCategory.Disabled;
                        break;
                    case  Harvesteer.GumRuntimes.ITreeViewBehavior.TreeViewCategory.Focused:
                        //Cannot assign this state because this element is missing the category TreeViewCategory
                        //this.CurrentTreeViewCategoryState = TreeViewCategory.Focused;
                        break;
                    case  Harvesteer.GumRuntimes.ITreeViewBehavior.TreeViewCategory.DisabledFocused:
                        //Cannot assign this state because this element is missing the category TreeViewCategory
                        //this.CurrentTreeViewCategoryState = TreeViewCategory.DisabledFocused;
                        break;
                }
            }
        }
        private bool tryCreateFormsObject;
        public Harvesteer.GumRuntimes.NineSliceRuntime Background { get; set; }
        public Harvesteer.GumRuntimes.Controls.ScrollBarRuntime VerticalScrollBarInstance { get; set; }
        public Harvesteer.GumRuntimes.ContainerRuntime ClipContainerInstance { get; set; }
        public Harvesteer.GumRuntimes.ContainerRuntime InnerPanelInstance { get; set; }
        public Harvesteer.GumRuntimes.NineSliceRuntime FocusedIndicator { get; set; }
        public event FlatRedBall.Gui.WindowEvent VerticalScrollBarInstanceClick;
        public TreeViewRuntime () 
        	: this(true, true)
        {
        }
        public TreeViewRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
        	: base(false, tryCreateFormsObject)
        {
            this.tryCreateFormsObject = tryCreateFormsObject;
            if (fullInstantiation)
            {
                Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "Controls/TreeView");
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
            Background = this.GetGraphicalUiElementByName("Background") as Harvesteer.GumRuntimes.NineSliceRuntime;
            VerticalScrollBarInstance = this.GetGraphicalUiElementByName("VerticalScrollBarInstance") as Harvesteer.GumRuntimes.Controls.ScrollBarRuntime;
            ClipContainerInstance = this.GetGraphicalUiElementByName("ClipContainerInstance") as Harvesteer.GumRuntimes.ContainerRuntime;
            InnerPanelInstance = this.GetGraphicalUiElementByName("InnerPanelInstance") as Harvesteer.GumRuntimes.ContainerRuntime;
            FocusedIndicator = this.GetGraphicalUiElementByName("FocusedIndicator") as Harvesteer.GumRuntimes.NineSliceRuntime;
            VerticalScrollBarInstance.Click += (unused) => VerticalScrollBarInstanceClick?.Invoke(this);
            if (tryCreateFormsObject)
            {
                FormsControlAsObject = new FlatRedBall.Forms.Controls.TreeView(this);
            }
        }
        private void CallCustomInitialize () 
        {
            CustomInitialize();
        }
        partial void CustomInitialize();
        public FlatRedBall.Forms.Controls.TreeView FormsControl {get => (FlatRedBall.Forms.Controls.TreeView) FormsControlAsObject;}
    }
}
