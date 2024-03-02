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
    public abstract partial class GameScreen : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        public static bool HasBeenLoadedWithGlobalContentManager { get; private set; }= false;
        #endif
        
        protected FlatRedBall.Math.PositionedObjectList<Harvesteer.Entities.Player> PlayerList = new FlatRedBall.Math.PositionedObjectList<Harvesteer.Entities.Player>();
        private Harvesteer.Entities.Player Player1;
        protected FlatRedBall.Math.PositionedObjectList<Harvesteer.Entities.Enemy> EnemyList = new FlatRedBall.Math.PositionedObjectList<Harvesteer.Entities.Enemy>();
        protected FlatRedBall.TileGraphics.LayeredTileMap Map;
        protected FlatRedBall.TileCollisions.TileShapeCollection mSolidCollision;
        public FlatRedBall.TileCollisions.TileShapeCollection SolidCollision
        {
            get
            {
                return mSolidCollision;
            }
            protected set
            {
                mSolidCollision = value;
            }
        }
        private FlatRedBall.Math.Collision.CollidableListVsTileShapeCollectionRelationship<Entities.Player> PlayerVsSolidCollision;
        private FlatRedBall.Math.Collision.ListVsListRelationship<Entities.Player, Entities.Enemy> PlayerBodyCollisionVsEnemy;
        private FlatRedBall.Math.Collision.ListVsListRelationship<Entities.Player, Entities.Enemy> PlayerSwordCollisionVsEnemy;
        private Harvesteer.Entities.EnemySpawner EnemySpawner1;
        public event System.Action<Entities.Player, Entities.Enemy> PlayerAxisAlignedRectangleInstanceVsEnemyCollided;
        public event System.Action<Entities.Player, Entities.Enemy> PlayerSwordCollisionVsEnemyCollided;
        public GameScreen () 
        	: this ("GameScreen")
        {
        }
        public GameScreen (string contentManagerName) 
        	: base (contentManagerName)
        {
            PlayerList.Name = "PlayerList";
            EnemyList.Name = "EnemyList";
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection SolidCollision in Screens\GameScreen (Screen) because properties on the object prevent it
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            PlayerList?.Clear();
            Player1 = new Harvesteer.Entities.Player(ContentManagerName, false);
            Player1.Name = "Player1";
            Player1.CreationSource = "Glue";
            EnemyList?.Clear();
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection SolidCollision in Screens\GameScreen (Screen) because properties on the object prevent it
            EnemySpawner1 = new Harvesteer.Entities.EnemySpawner(ContentManagerName, false);
            EnemySpawner1.Name = "EnemySpawner1";
            EnemySpawner1.CreationSource = "Glue";
            FlatRedBall.Math.Collision.CollisionManager.Self.BeforeCollision += HandleBeforeCollisionGenerated;
            FillCollisionForSolidCollision();
            if (SolidCollision != null)
{
    PlayerVsSolidCollision = FlatRedBall.Math.Collision.CollisionManagerTileShapeCollectionExtensions.CreateTileRelationship(FlatRedBall.Math.Collision.CollisionManager.Self, PlayerList, SolidCollision);
    PlayerVsSolidCollision.Name = "PlayerVsSolidCollision";
    PlayerVsSolidCollision.SetMoveCollision(0f, 1f);
}

            PlayerBodyCollisionVsEnemy = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(PlayerList, EnemyList);
PlayerBodyCollisionVsEnemy.SetFirstSubCollision(item => item.BodyCollision, "BodyCollision");
PlayerBodyCollisionVsEnemy.CollisionLimit = FlatRedBall.Math.Collision.CollisionLimit.All;
PlayerBodyCollisionVsEnemy.ListVsListLoopingMode = FlatRedBall.Math.Collision.ListVsListLoopingMode.PreventDoubleChecksPerFrame;
PlayerBodyCollisionVsEnemy.Name = "PlayerBodyCollisionVsEnemy";
PlayerBodyCollisionVsEnemy.SetMoveCollision(1f, 0.25f);

            PlayerSwordCollisionVsEnemy = FlatRedBall.Math.Collision.CollisionManager.Self.CreateRelationship(PlayerList, EnemyList);
PlayerSwordCollisionVsEnemy.SetFirstSubCollision(item => item.SwordCollision, "SwordCollision");
PlayerSwordCollisionVsEnemy.CollisionLimit = FlatRedBall.Math.Collision.CollisionLimit.All;
PlayerSwordCollisionVsEnemy.ListVsListLoopingMode = FlatRedBall.Math.Collision.ListVsListLoopingMode.PreventDoubleChecksPerFrame;
PlayerSwordCollisionVsEnemy.Name = "PlayerSwordCollisionVsEnemy";

            
            
            PostInitialize();
            base.Initialize(addToManagers);
            this.Name = "GameScreen";
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            mAccumulatedPausedTime = TimeManager.CurrentTime;
            mTimeScreenWasCreated = FlatRedBall.TimeManager.CurrentTime;
            InitializeFactoriesAndSorting();
            Player1.AddToManagers(mLayer);
            EnemySpawner1.AddToManagers(mLayer);
            var Map_gameplayLayer = Map.MapLayers.FindByName("GameplayLayer");
            if (Map_gameplayLayer != null)
            {
                Map_gameplayLayer.ForceUpdateDependencies();
                // What if the map's Z isn't 0? Add its Z to make up for that
                Map.Z = Map.Z - Map_gameplayLayer.Z;
            }
            FlatRedBall.TileEntities.TileEntityInstantiator.CreateEntitiesFrom(Map);
            base.AddToManagers();
            AddToManagersBottomUp();
            BeforeCustomInitialize?.Invoke();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                for (int i = PlayerList.Count - 1; i > -1; i--)
                {
                    if (i < PlayerList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        PlayerList[i].Activity();
                    }
                }
                for (int i = EnemyList.Count - 1; i > -1; i--)
                {
                    if (i < EnemyList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        EnemyList[i].Activity();
                    }
                }
                EnemySpawner1.Activity();
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
                foreach (var item in FlatRedBall.SpriteManager.ManagedPositionedObjects)
                {
                    if (item is FlatRedBall.Entities.IEntity entity)
                    {
                        entity.ActivityEditMode();
                    }
                }
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            Factories.PlayerFactory.Destroy();
            Factories.EnemyFactory.Destroy();
            
            for (int i = PlayerList.Count - 1; i > -1; i--)
            {
                PlayerList[i].Destroy();
            }
            for (int i = EnemyList.Count - 1; i > -1; i--)
            {
                EnemyList[i].Destroy();
            }
            if (EnemySpawner1 != null)
            {
                EnemySpawner1.Destroy();
                EnemySpawner1.Detach();
            }
            PlayerBodyCollisionVsEnemy.CollisionOccurred -= OnPlayerAxisAlignedRectangleInstanceVsEnemyCollidedTunnel;
            PlayerSwordCollisionVsEnemy.CollisionOccurred -= OnPlayerSwordCollisionVsEnemyCollidedTunnel;
            FlatRedBall.Math.Collision.CollisionManager.Self.BeforeCollision -= HandleBeforeCollisionGenerated;
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            PlayerBodyCollisionVsEnemy.CollisionOccurred += OnPlayerAxisAlignedRectangleInstanceVsEnemyCollided;
            PlayerBodyCollisionVsEnemy.CollisionOccurred += OnPlayerAxisAlignedRectangleInstanceVsEnemyCollidedTunnel;
            PlayerSwordCollisionVsEnemy.CollisionOccurred += OnPlayerSwordCollisionVsEnemyCollided;
            PlayerSwordCollisionVsEnemy.CollisionOccurred += OnPlayerSwordCollisionVsEnemyCollidedTunnel;
            if (!PlayerList.Contains(Player1))
            {
                PlayerList.Add(Player1);
            }
            Player1.DamageToDeal = 1m;
            Player1.MaxHealth = 5m;
            if (Player1.Parent == null)
            {
                Player1.X = 200f;
            }
            else
            {
                Player1.RelativeX = 200f;
            }
            if (Player1.Parent == null)
            {
                Player1.Y = -225f;
            }
            else
            {
                Player1.RelativeY = -225f;
            }
            if (Player1.Parent == null)
            {
                Player1.Z = 0f;
            }
            else
            {
                Player1.RelativeZ = 0f;
            }
            Player1.SecondsBetweenDamage = 1;
            if (Map!= null)
            {
                if (Map.Parent == null)
                {
                    Map.Z = -50f;
                }
                else
                {
                    Map.RelativeZ = -50f;
                }
            }
            if (SolidCollision!= null)
            {
                SolidCollision.Visible = true;
            }
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            for (int i = PlayerList.Count - 1; i > -1; i--)
            {
                PlayerList[i].Destroy();
            }
            for (int i = EnemyList.Count - 1; i > -1; i--)
            {
                EnemyList[i].Destroy();
            }
            EnemySpawner1.RemoveFromManagers();
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                Player1.AssignCustomVariables(true);
                EnemySpawner1.AssignCustomVariables(true);
            }
            Player1.DamageToDeal = 1m;
            Player1.MaxHealth = 5m;
            if (Player1.Parent == null)
            {
                Player1.X = 200f;
            }
            else
            {
                Player1.RelativeX = 200f;
            }
            if (Player1.Parent == null)
            {
                Player1.Y = -225f;
            }
            else
            {
                Player1.RelativeY = -225f;
            }
            if (Player1.Parent == null)
            {
                Player1.Z = 0f;
            }
            else
            {
                Player1.RelativeZ = 0f;
            }
            Player1.SecondsBetweenDamage = 1;
            if (Map != null)
            {
                if (Map.Parent == null)
                {
                    Map.Z = -50f;
                }
                else
                {
                    Map.RelativeZ = -50f;
                }
            }
            if (SolidCollision != null)
            {
                SolidCollision.Visible = true;
            }
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            for (int i = 0; i < PlayerList.Count; i++)
            {
                PlayerList[i].ConvertToManuallyUpdated();
            }
            for (int i = 0; i < EnemyList.Count; i++)
            {
                EnemyList[i].ConvertToManuallyUpdated();
            }
            if (Map != null)
            {
            }
            if (SolidCollision != null)
            {
            }
            EnemySpawner1.ConvertToManuallyUpdated();
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
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
                throw new System.Exception( "GameScreen has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            Harvesteer.Entities.EnemySpawner.LoadStaticContent(contentManagerName);
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
            Factories.PlayerFactory.Initialize(ContentManagerName);
            Factories.EnemyFactory.Initialize(ContentManagerName);
            Factories.PlayerFactory.AddList(PlayerList);
            Factories.EnemyFactory.AddList(EnemyList);
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            return null;
        }
        public static object GetFile (string memberName) 
        {
            return null;
        }
        object GetMember (string memberName) 
        {
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        void HandleBeforeCollisionGenerated () 
        {
            for (int i = 0; i < PlayerList.Count; i++)
            {
                var item = PlayerList[i];
                item.LastFrameItemsCollidedAgainst.Clear();
                foreach (var name in item.ItemsCollidedAgainst)
                {
                    item.LastFrameItemsCollidedAgainst.Add(name);
                }
                item.ItemsCollidedAgainst.Clear();
                item.LastFrameObjectsCollidedAgainst.Clear();
                foreach (var name in item.ObjectsCollidedAgainst)
                {
                    item.LastFrameObjectsCollidedAgainst.Add(name);
                }
                item.ObjectsCollidedAgainst.Clear();
            }
            for (int i = 0; i < EnemyList.Count; i++)
            {
                var item = EnemyList[i];
                item.LastFrameItemsCollidedAgainst.Clear();
                foreach (var name in item.ItemsCollidedAgainst)
                {
                    item.LastFrameItemsCollidedAgainst.Add(name);
                }
                item.ItemsCollidedAgainst.Clear();
                item.LastFrameObjectsCollidedAgainst.Clear();
                foreach (var name in item.ObjectsCollidedAgainst)
                {
                    item.LastFrameObjectsCollidedAgainst.Add(name);
                }
                item.ObjectsCollidedAgainst.Clear();
            }
        }
        protected virtual void FillCollisionForSolidCollision () 
        {
            if (SolidCollision != null)
            {
                FlatRedBall.TileCollisions.TileShapeCollectionLayeredTileMapExtensions.AddCollisionFromTilesWithType(SolidCollision, Map, "SolidCollision", false);
            }
        }
        partial void CustomActivityEditMode();
    }
    public partial class GameScreenType
    {
        public string Name { get; set; }
        public override string ToString() {return Name; }
        public Type Type { get; set; }
        public Performance.IEntityFactory Factory { get; set; }
        public Func<string, object> GetFile {get; private set; }
        public Action<string> LoadStaticContent { get; private set; }
        public GameScreen CreateNew(Microsoft.Xna.Framework.Vector3 position) => Factory.CreateNew(position) as GameScreen;
        public GameScreen CreateNew(float x = 0, float y = 0) => Factory.CreateNew(x, y) as GameScreen;
        public static GameScreenType FromName (string name) 
        {
            switch(name)
            {
                case  "Level1":
                    return Level1;
            }
            return null;
        }
        public static GameScreenType Level1 { get; private set; } = new GameScreenType
        {
            Name = "Level1",
            Type = typeof(Screens.Level1),
            GetFile = Harvesteer.Screens.Level1.GetFile,
            LoadStaticContent = Harvesteer.Screens.Level1.LoadStaticContent,
        }
        ;
        public static List<GameScreenType> All = new List<GameScreenType>{
            Level1,
        };
    }
}
