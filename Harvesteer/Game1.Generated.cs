using System.Linq;
namespace Harvesteer
{
    public partial class Game1
    {
        RenderingLibrary.Graphics.IRenderable GetRenderable (string name, global::RenderingLibrary.ISystemManagers managers) 
        {
            var asBaseType = Gum.Wireframe.RuntimeObjectCreator.TryHandleAsBaseType(name, managers);
            return asBaseType;
        }
        partial void GeneratedInitializeEarly () 
        {
        }
        partial void GeneratedInitialize () 
        {
            global::GumRuntime.ElementSaveExtensions.CustomCreateGraphicalComponentFunc = GetRenderable;
            global::Gum.Wireframe.GraphicalUiElement.SetPropertyOnRenderable = global::Gum.Wireframe.CustomSetPropertyOnRenderable.SetPropertyOnRenderable;
            global::Gum.Wireframe.GraphicalUiElement.UpdateFontFromProperties = global::Gum.Wireframe.CustomSetPropertyOnRenderable.UpdateToFontValues;
            global::Gum.Wireframe.GraphicalUiElement.ThrowExceptionsForMissingFiles = global::Gum.Wireframe.CustomSetPropertyOnRenderable.ThrowExceptionsForMissingFiles;
            global::Gum.Wireframe.GraphicalUiElement.AddRenderableToManagers = global::Gum.Wireframe.CustomSetPropertyOnRenderable.AddRenderableToManagers;
            global::Gum.Wireframe.GraphicalUiElement.RemoveRenderableFromManagers = global::Gum.Wireframe.CustomSetPropertyOnRenderable.RemoveRenderableFromManagers;
            Harvesteer.GlobalContent.Initialize();
            var args = System.Environment.GetCommandLineArgs();
            bool? changeResize = null;
            var resizeArgs = args.FirstOrDefault(item => item.StartsWith("AllowWindowResizing="));
            if (!string.IsNullOrEmpty(resizeArgs))
            {
                var afterEqual = resizeArgs.Split('=')[1];
                changeResize = bool.Parse(afterEqual);
            }
            if (changeResize != null)
            {
                CameraSetup.Data.AllowWindowResizing = changeResize.Value;
            }
            CameraSetup.SetupCamera(FlatRedBall.Camera.Main, graphics);
            System.Type startScreenType = typeof(Harvesteer.Screens.Level1);
            var commandLineArgs = System.Environment.GetCommandLineArgs();
            if (commandLineArgs.Length > 0)
            {
                var thisAssembly = this.GetType().Assembly;
                // see if any of these are screens:
                foreach (var item in commandLineArgs)
                {
                    var type = thisAssembly.GetType(item);
                    if (type != null)
                    {
                        startScreenType = type;
                        break;
                    }
                }
            }
            if (startScreenType != null)
            {
                FlatRedBall.Screens.ScreenManager.Start(startScreenType);
            }
            // This value is used for parallax. If the game doesn't change its resolution, this this code should solve parallax with zooming cameras.
            global::FlatRedBall.TileGraphics.MapDrawableBatch.NativeCameraWidth = Harvesteer.CameraSetup.Data.ResolutionWidth;
            global::FlatRedBall.TileGraphics.MapDrawableBatch.NativeCameraHeight = Harvesteer.CameraSetup.Data.ResolutionHeight;
        }
        partial void GeneratedUpdate (Microsoft.Xna.Framework.GameTime gameTime) 
        {
        }
        partial void GeneratedDrawEarly (Microsoft.Xna.Framework.GameTime gameTime) 
        {
        }
        partial void GeneratedDraw (Microsoft.Xna.Framework.GameTime gameTime) 
        {
        }
    }
}
