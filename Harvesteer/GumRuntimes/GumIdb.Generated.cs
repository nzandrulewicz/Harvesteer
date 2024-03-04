namespace FlatRedBall.Gum
{
    public  class GumIdbExtensions
    {
        public static void RegisterTypes () 
        {
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Circle", typeof(Harvesteer.GumRuntimes.CircleRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("ColoredRectangle", typeof(Harvesteer.GumRuntimes.ColoredRectangleRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Container", typeof(Harvesteer.GumRuntimes.ContainerRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Container<T>", typeof(Harvesteer.GumRuntimes.ContainerRuntime<>));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("NineSlice", typeof(Harvesteer.GumRuntimes.NineSliceRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Polygon", typeof(Harvesteer.GumRuntimes.PolygonRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Rectangle", typeof(Harvesteer.GumRuntimes.RectangleRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Sprite", typeof(Harvesteer.GumRuntimes.SpriteRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Text", typeof(Harvesteer.GumRuntimes.TextRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonClose", typeof(Harvesteer.GumRuntimes.Controls.ButtonCloseRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonConfirm", typeof(Harvesteer.GumRuntimes.Controls.ButtonConfirmRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonDeny", typeof(Harvesteer.GumRuntimes.Controls.ButtonDenyRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonIcon", typeof(Harvesteer.GumRuntimes.Controls.ButtonIconRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonStandard", typeof(Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonStandardIcon", typeof(Harvesteer.GumRuntimes.Controls.ButtonStandardIconRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ButtonTab", typeof(Harvesteer.GumRuntimes.Controls.ButtonTabRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/CheckBox", typeof(Harvesteer.GumRuntimes.Controls.CheckBoxRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ComboBox", typeof(Harvesteer.GumRuntimes.Controls.ComboBoxRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/DialogBox", typeof(Harvesteer.GumRuntimes.Controls.DialogBoxRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/Keyboard", typeof(Harvesteer.GumRuntimes.Controls.KeyboardRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/KeyboardKey", typeof(Harvesteer.GumRuntimes.Controls.KeyboardKeyRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ListBox", typeof(Harvesteer.GumRuntimes.Controls.ListBoxRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ListBoxItem", typeof(Harvesteer.GumRuntimes.Controls.ListBoxItemRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/PasswordBox", typeof(Harvesteer.GumRuntimes.Controls.PasswordBoxRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/PlayerJoinView", typeof(Harvesteer.GumRuntimes.Controls.PlayerJoinViewRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/PlayerJoinViewItem", typeof(Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/RadioButton", typeof(Harvesteer.GumRuntimes.Controls.RadioButtonRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ScrollBar", typeof(Harvesteer.GumRuntimes.Controls.ScrollBarRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/ScrollViewer", typeof(Harvesteer.GumRuntimes.Controls.ScrollViewerRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/SettingsView", typeof(Harvesteer.GumRuntimes.Controls.SettingsViewRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/Slider", typeof(Harvesteer.GumRuntimes.Controls.SliderRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/TextBox", typeof(Harvesteer.GumRuntimes.Controls.TextBoxRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/Toast", typeof(Harvesteer.GumRuntimes.Controls.ToastRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/TreeView", typeof(Harvesteer.GumRuntimes.Controls.TreeViewRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/TreeViewItem", typeof(Harvesteer.GumRuntimes.Controls.TreeViewItemRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/TreeViewToggle", typeof(Harvesteer.GumRuntimes.Controls.TreeViewToggleRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Controls/UserControl", typeof(Harvesteer.GumRuntimes.Controls.UserControlRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/CautionLines", typeof(Harvesteer.GumRuntimes.Elements.CautionLinesRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/Divider", typeof(Harvesteer.GumRuntimes.Elements.DividerRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/DividerHorizontal", typeof(Harvesteer.GumRuntimes.Elements.DividerHorizontalRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/DividerVertical", typeof(Harvesteer.GumRuntimes.Elements.DividerVerticalRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/Icon", typeof(Harvesteer.GumRuntimes.Elements.IconRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/Label", typeof(Harvesteer.GumRuntimes.Elements.LabelRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/PercentBar", typeof(Harvesteer.GumRuntimes.Elements.PercentBarRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/PercentBarIcon", typeof(Harvesteer.GumRuntimes.Elements.PercentBarIconRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Elements/VerticalLines", typeof(Harvesteer.GumRuntimes.Elements.VerticalLinesRuntime));
            GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("HealthBar", typeof(Harvesteer.GumRuntimes.HealthBarRuntime));
            
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Button)] = typeof(Harvesteer.GumRuntimes.Controls.ButtonStandardRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.CheckBox)] = typeof(Harvesteer.GumRuntimes.Controls.CheckBoxRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ComboBox)] = typeof(Harvesteer.GumRuntimes.Controls.ComboBoxRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.DialogBox)] = typeof(Harvesteer.GumRuntimes.Controls.DialogBoxRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.OnScreenKeyboard)] = typeof(Harvesteer.GumRuntimes.Controls.KeyboardRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ListBox)] = typeof(Harvesteer.GumRuntimes.Controls.ListBoxRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ListBoxItem)] = typeof(Harvesteer.GumRuntimes.Controls.ListBoxItemRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.PasswordBox)] = typeof(Harvesteer.GumRuntimes.Controls.PasswordBoxRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.PlayerJoinView)] = typeof(Harvesteer.GumRuntimes.Controls.PlayerJoinViewRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.PlayerJoinViewItem)] = typeof(Harvesteer.GumRuntimes.Controls.PlayerJoinViewItemRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.RadioButton)] = typeof(Harvesteer.GumRuntimes.Controls.RadioButtonRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ScrollBar)] = typeof(Harvesteer.GumRuntimes.Controls.ScrollBarRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ScrollViewer)] = typeof(Harvesteer.GumRuntimes.Controls.ScrollViewerRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.SettingsView)] = typeof(Harvesteer.GumRuntimes.Controls.SettingsViewRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Slider)] = typeof(Harvesteer.GumRuntimes.Controls.SliderRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.TextBox)] = typeof(Harvesteer.GumRuntimes.Controls.TextBoxRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Popups.Toast)] = typeof(Harvesteer.GumRuntimes.Controls.ToastRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.TreeView)] = typeof(Harvesteer.GumRuntimes.Controls.TreeViewRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.TreeViewItem)] = typeof(Harvesteer.GumRuntimes.Controls.TreeViewItemRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ToggleButton)] = typeof(Harvesteer.GumRuntimes.Controls.TreeViewToggleRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.UserControl)] = typeof(Harvesteer.GumRuntimes.Controls.UserControlRuntime);
            FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Label)] = typeof(Harvesteer.GumRuntimes.Elements.LabelRuntime);
        }
    }
}
