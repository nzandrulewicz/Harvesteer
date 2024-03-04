#pragma warning disable
#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
#define SUPPORTS_GLUEVIEW_2
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
namespace Harvesteer.Screens
{
    public partial class Level1 : GameScreen
    {
        #if DEBUG
        public static bool HasBeenLoadedWithGlobalContentManager { get; private set; }= false;
        #endif
        protected static FlatRedBall.TileGraphics.LayeredTileMap StartingMap;
        
        public Level1 () 
        	: this ("Level1")
        {
        }
        public Level1 (string contentManagerName) 
        	: base (contentManagerName)
        {
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<Player> PlayerList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<Enemy> EnemyList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<PlayerStats> PlayerStatsList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            Map = StartingMap;
            mSolidCollision = new FlatRedBall.TileCollisions.TileShapeCollection(); mSolidCollision.Name = "SolidCollision";
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<Player> PlayerList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<Enemy> EnemyList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<PlayerStats> PlayerStatsList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            
            
            base.Initialize(addToManagers);
            this.Name = "Level1";
        }
        public override void AddToManagers () 
        {
            mAccumulatedPausedTime = TimeManager.CurrentTime;
            mTimeScreenWasCreated = FlatRedBall.TimeManager.CurrentTime;
            StartingMap.AddToManagers(mLayer);
            InitializeFactoriesAndSorting();
            
            base.AddToManagers();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                StartingMap?.AnimateSelf();;
            }
            else
            {
            }
            base.Activity(firstTimeCalled);
            if (!IsActivityFinished)
            {
                CustomActivity(firstTimeCalled);
            }
        }
        public override void ActivityEditMode () 
        {
            if (FlatRedBall.Screens.ScreenManager.IsInEditMode)
            {
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            StartingMap.Destroy();
            StartingMap = null;
            
            if (SolidCollision != null)
            {
                SolidCollision.Visible = false;
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp () 
        {
            base.AddToManagersBottomUp();
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            StartingMap.Destroy();
            if (SolidCollision != null)
            {
                SolidCollision.Visible = false;
            }
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
            }
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
        }
        public static new void LoadStaticContent (string contentManagerName) 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            Harvesteer.Screens.GameScreen.LoadStaticContent(contentManagerName);
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = contentManagerName;
            RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
            // Access the GumProject just in case it's async loaded
            var throwaway = GlobalContent.GumProject;
            #if DEBUG
            if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new System.Exception( "Level1 has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            StartingMap = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/level1/startingmap.tmx", contentManagerName);
            CustomLoadStaticContent(contentManagerName);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void PauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Pause();
            base.PauseThisScreen();
        }
        public override void UnpauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Unpause();
            base.UnpauseThisScreen();
        }
        private void InitializeFactoriesAndSorting () 
        {
        }
        [System.Obsolete("Use GetFile instead")]
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "StartingMap":
                    return StartingMap;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "StartingMap":
                    return StartingMap;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "StartingMap":
                    return StartingMap;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        partial void CustomActivityEditMode();
    }
}
