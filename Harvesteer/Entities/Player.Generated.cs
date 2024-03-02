#pragma warning disable
#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
#define SUPPORTS_GLUEVIEW_2
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall.Graphics;
using FlatRedBall.Math;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
using Harvesteer.DataTypes;
using FlatRedBall.IO.Csv;
namespace Harvesteer.Entities
{
    public partial class Player : FlatRedBall.PositionedObject, FlatRedBall.Graphics.IDestroyable, FlatRedBall.Entities.IEntity, FlatRedBall.Math.Geometry.ICollidable, FlatRedBall.Entities.IDamageArea, FlatRedBall.Entities.IDamageable
    {
        // This is made static so that static lazy-loaded content can access it.
        public static string ContentManagerName { get; set; }
        #if DEBUG
        private double mLastTimeCalledActivity=-1;
        #endif
        #if DEBUG
        public static bool HasBeenLoadedWithGlobalContentManager { get; private set; }= false;
        #endif
        static object mLockObject = new object();
        static System.Collections.Generic.List<string> mRegisteredUnloads = new System.Collections.Generic.List<string>();
        static System.Collections.Generic.List<string> LoadedContentManagers = new System.Collections.Generic.List<string>();
        public static System.Collections.Generic.Dictionary<string, Harvesteer.DataTypes.TopDownValues> TopDownValuesStatic;
        protected static Microsoft.Xna.Framework.Graphics.Texture2D PlayerSprite;
        
        private FlatRedBall.Math.Geometry.AxisAlignedRectangle mBodyCollision;
        public FlatRedBall.Math.Geometry.AxisAlignedRectangle BodyCollision
        {
            get
            {
                return mBodyCollision;
            }
            private set
            {
                mBodyCollision = value;
            }
        }
        private FlatRedBall.Sprite SpriteInstance;
        private FlatRedBall.Math.Geometry.Polygon mSwordCollision;
        public FlatRedBall.Math.Geometry.Polygon SwordCollision
        {
            get
            {
                return mSwordCollision;
            }
            private set
            {
                mSwordCollision = value;
            }
        }
        private System.Double mSecondsBetweenDamage = 0;
        public virtual System.Double SecondsBetweenDamage
        {
            set
            {
                mSecondsBetweenDamage = value;
            }
            get
            {
                return mSecondsBetweenDamage;
            }
        }
        private decimal mDamageToDeal = 1m;
        public virtual decimal DamageToDeal
        {
            set
            {
                mDamageToDeal = value;
            }
            get
            {
                return mDamageToDeal;
            }
        }
        private decimal mMaxHealth = 5m;
        public virtual decimal MaxHealth
        {
            set
            {
                mMaxHealth = value;
            }
            get
            {
                return mMaxHealth;
            }
        }
        private int mTeamIndex = 0;
        public virtual int TeamIndex
        {
            set
            {
                mTeamIndex = value;
            }
            get
            {
                return mTeamIndex;
            }
        }
        private FlatRedBall.Math.Geometry.ShapeCollection mGeneratedCollision;
        public FlatRedBall.Math.Geometry.ShapeCollection Collision
        {
            get
            {
                return mGeneratedCollision;
            }
        }
        public HashSet<string> ItemsCollidedAgainst { get; private set;} = new HashSet<string>();
        public HashSet<string> LastFrameItemsCollidedAgainst { get; private set;} = new HashSet<string>();
        public HashSet<object> ObjectsCollidedAgainst { get; private set;} = new HashSet<object>();
        public HashSet<object> LastFrameObjectsCollidedAgainst { get; private set;} = new HashSet<object>();
        public Action<decimal, FlatRedBall.Entities.IDamageable> ReactToDamageDealt { get; set; }
        public Func<decimal, FlatRedBall.Entities.IDamageable, decimal> ModifyDamageDealt { get; set; }
        public object DamageDealer { get; set; }
        public event Action Destroyed;
        public Action<decimal, FlatRedBall.Entities.IDamageable> KilledDamageable { get; set; }
        public Action<FlatRedBall.Entities.IDamageable> RemovedByCollision { get; set; }
        public bool IsDamageDealingEnabled { get; set; } = true;
        public System.Collections.Generic.Dictionary<FlatRedBall.Entities.IDamageArea, double> DamageAreaLastDamage { get; set; } = new System.Collections.Generic.Dictionary<FlatRedBall.Entities.IDamageArea, double>();
        public Action<decimal, FlatRedBall.Entities.IDamageArea> ReactToDamageReceived { get; set; }
        public Func<decimal, FlatRedBall.Entities.IDamageArea, decimal> ModifyDamageReceived { get; set; }
        public decimal CurrentHealth { get; set; }
        public Action<decimal, FlatRedBall.Entities.IDamageArea> Died { get; set; }
        public bool IsDamageReceivingEnabled { get; set; } = true;
        public double InvulnerabilityTimeAfterDamage { get; set; } = 0;
        public double LastDamageTime { get; set; } = -999;
        protected FlatRedBall.Graphics.Layer LayerProvidedByContainer = null;
        public Player () 
        	: this(FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, true)
        {
        }
        public Player (string contentManagerName) 
        	: this(contentManagerName, true)
        {
        }
        public Player (string contentManagerName, bool addToManagers) 
        	: base()
        {
            ContentManagerName = contentManagerName;
            InitializeEntity(addToManagers);
        }
        protected virtual void InitializeEntity (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            mBodyCollision = new FlatRedBall.Math.Geometry.AxisAlignedRectangle();
            mBodyCollision.Name = "BodyCollision";
            mBodyCollision.CreationSource = "Glue";
            SpriteInstance = new FlatRedBall.Sprite();
            SpriteInstance.Name = "SpriteInstance";
            SpriteInstance.CreationSource = "Glue";
            mSwordCollision = new FlatRedBall.Math.Geometry.Polygon();
            mSwordCollision.Name = "SwordCollision";
            mSwordCollision.CreationSource = "Glue";
            InitializeInput();
            if (TopDownValues?.Count > 0)
            {
                mCurrentMovement = TopDownValues.Values.FirstOrDefault();
            }
            PossibleDirections = PossibleDirections.FourWay;
            mTopDownAnimationLayer = new TopDown.DirectionBasedAnimationLayer();
            mTopDownAnimationLayer.TopDownEntity = this;
            
            PostInitialize();
            if (addToManagers)
            {
                AddToManagers(null);
            }
        }
        public virtual void ReAddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mBodyCollision, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mSwordCollision, LayerProvidedByContainer);
        }
        public virtual void AddToManagers (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            LayerProvidedByContainer = layerToAddTo;
            FlatRedBall.SpriteManager.AddPositionedObject(this);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mBodyCollision, LayerProvidedByContainer);
            FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, LayerProvidedByContainer);
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(mSwordCollision, LayerProvidedByContainer);
            AddToManagersBottomUp(layerToAddTo);
            CustomInitialize();
        }
        public virtual void Activity () 
        {
            #if DEBUG
            if(mLastTimeCalledActivity > 0 && mLastTimeCalledActivity == FlatRedBall.TimeManager.CurrentScreenTime)
            {
                throw new System.Exception("Activity was called twice in the same frame. This can cause objects to move 2x as fast.");
            }
            mLastTimeCalledActivity = FlatRedBall.TimeManager.CurrentScreenTime;
            #endif
            
            ApplyMovementInput();
            CustomActivity();
        }
        public virtual void ActivityEditMode () 
        {
            CustomActivityEditMode();
        }
        public virtual void Destroy () 
        {
            FlatRedBall.SpriteManager.RemovePositionedObject(this);
            
            if (BodyCollision != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(BodyCollision);
            }
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (SwordCollision != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(SwordCollision);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: true);
            Destroyed?.Invoke();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (mBodyCollision.Parent == null)
            {
                mBodyCollision.CopyAbsoluteToRelative();
                mBodyCollision.AttachTo(this, false);
            }
            if (BodyCollision.Parent == null)
            {
                BodyCollision.X = 0f;
            }
            else
            {
                BodyCollision.RelativeX = 0f;
            }
            if (BodyCollision.Parent == null)
            {
                BodyCollision.Y = 0f;
            }
            else
            {
                BodyCollision.RelativeY = 0f;
            }
            BodyCollision.Width = 16f;
            BodyCollision.Height = 16f;
            if (SpriteInstance.Parent == null)
            {
                SpriteInstance.CopyAbsoluteToRelative();
                SpriteInstance.AttachTo(this, false);
            }
            SpriteInstance.Texture = PlayerSprite;
            SpriteInstance.TextureScale = 1f;
            if (mSwordCollision.Parent == null)
            {
                mSwordCollision.CopyAbsoluteToRelative();
                mSwordCollision.AttachTo(this, false);
            }
            if (SwordCollision.Parent == null)
            {
                SwordCollision.RotationZ = -0.7853982f;
            }
            else
            {
                SwordCollision.RelativeRotationZ = -0.7853982f;
            }
            FlatRedBall.Math.Geometry.Point[] SwordCollisionPoints = new FlatRedBall.Math.Geometry.Point[] {new FlatRedBall.Math.Geometry.Point(0, 2), new FlatRedBall.Math.Geometry.Point(22, 2), new FlatRedBall.Math.Geometry.Point(25, 0), new FlatRedBall.Math.Geometry.Point(25, 0), new FlatRedBall.Math.Geometry.Point(22, -2), new FlatRedBall.Math.Geometry.Point(0, -2), new FlatRedBall.Math.Geometry.Point(0, 2) };
            SwordCollision.Points = SwordCollisionPoints;
            mGeneratedCollision = new FlatRedBall.Math.Geometry.ShapeCollection();
            Collision.AxisAlignedRectangles.AddOneWay(mBodyCollision);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp (FlatRedBall.Graphics.Layer layerToAddTo) 
        {
            CurrentHealth = MaxHealth;
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            if (BodyCollision != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(BodyCollision);
            }
            if (SpriteInstance != null)
            {
                FlatRedBall.SpriteManager.RemoveSpriteOneWay(SpriteInstance);
            }
            if (SwordCollision != null)
            {
                FlatRedBall.Math.Geometry.ShapeManager.RemoveOneWay(SwordCollision);
            }
            mGeneratedCollision.RemoveFromManagers(clearThis: false);
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            if (BodyCollision.Parent == null)
            {
                BodyCollision.X = 0f;
            }
            else
            {
                BodyCollision.RelativeX = 0f;
            }
            if (BodyCollision.Parent == null)
            {
                BodyCollision.Y = 0f;
            }
            else
            {
                BodyCollision.RelativeY = 0f;
            }
            BodyCollision.Width = 16f;
            BodyCollision.Height = 16f;
            SpriteInstance.Texture = PlayerSprite;
            SpriteInstance.TextureScale = 1f;
            if (SwordCollision.Parent == null)
            {
                SwordCollision.RotationZ = -0.7853982f;
            }
            else
            {
                SwordCollision.RelativeRotationZ = -0.7853982f;
            }
            SecondsBetweenDamage = 0;
            DamageToDeal = 1m;
            MaxHealth = 5m;
            TeamIndex = 0;
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            this.ForceUpdateDependenciesDeep();
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(this);
            FlatRedBall.SpriteManager.ConvertToManuallyUpdated(SpriteInstance);
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (LoadedContentManagers.Contains(contentManagerName))
            {
                return;
            }
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            ContentManagerName = contentManagerName;
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
                throw new System.Exception( "Player has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            bool registerUnload = false;
            if (LoadedContentManagers.Contains(contentManagerName) == false)
            {
                LoadedContentManagers.Add(contentManagerName);
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("PlayerStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
                if (TopDownValuesStatic == null)
                {
                    {
                        // We put the { and } to limit the scope of oldDelimiter
                        char oldDelimiter = FlatRedBall.IO.Csv.CsvFileManager.Delimiter;
                        FlatRedBall.IO.Csv.CsvFileManager.Delimiter = ',';
                        System.Collections.Generic.Dictionary<string, Harvesteer.DataTypes.TopDownValues> temporaryCsvObject = new System.Collections.Generic.Dictionary<string, Harvesteer.DataTypes.TopDownValues>();
                        FlatRedBall.IO.Csv.CsvFileManager.CsvDeserializeDictionary<string, Harvesteer.DataTypes.TopDownValues>("content/entities/player/topdownvaluesstatic.csv", temporaryCsvObject, FlatRedBall.IO.Csv.DuplicateDictionaryEntryBehavior.Replace);
                        FlatRedBall.IO.Csv.CsvFileManager.Delimiter = oldDelimiter;
                        TopDownValuesStatic = temporaryCsvObject;
                    }
                }
                if (!FlatRedBall.FlatRedBallServices.IsLoaded<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/player/playersprite.png", ContentManagerName))
                {
                    registerUnload = true;
                }
                PlayerSprite = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>(@"content/entities/player/playersprite.png", ContentManagerName);
            }
            if (registerUnload && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                lock (mLockObject)
                {
                    if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBall.FlatRedBallServices.GlobalContentManager)
                    {
                        FlatRedBall.FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("PlayerStaticUnload", UnloadStaticContent);
                        mRegisteredUnloads.Add(ContentManagerName);
                    }
                }
            }
            CustomLoadStaticContent(contentManagerName);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public static void UnloadStaticContent () 
        {
            if (LoadedContentManagers.Count != 0)
            {
                LoadedContentManagers.RemoveAt(0);
                mRegisteredUnloads.RemoveAt(0);
            }
            if (LoadedContentManagers.Count == 0)
            {
                if (TopDownValuesStatic != null)
                {
                    TopDownValuesStatic= null;
                }
                if (PlayerSprite != null)
                {
                    PlayerSprite= null;
                }
            }
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "TopDownValuesStatic":
                    return TopDownValuesStatic;
                case  "PlayerSprite":
                    return PlayerSprite;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "TopDownValuesStatic":
                    return TopDownValuesStatic;
                case  "PlayerSprite":
                    return PlayerSprite;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "PlayerSprite":
                    return PlayerSprite;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
            if (whatToReload == TopDownValuesStatic)
            {
                FlatRedBall.IO.Csv.CsvFileManager.UpdateDictionaryValuesFromCsv(TopDownValuesStatic, "content/entities/player/topdownvaluesstatic.csv");
            }
            if (whatToReload == PlayerSprite)
            {
                var oldTexture = PlayerSprite;
                {
                    var cm = FlatRedBall.FlatRedBallServices.GetContentManagerByName("Global");
                    cm.UnloadAsset(PlayerSprite);
                    PlayerSprite = FlatRedBall.FlatRedBallServices.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("content/entities/player/playersprite.png");
                }
                FlatRedBall.SpriteManager.ReplaceTexture(oldTexture, PlayerSprite);
            }
        }
        protected bool mIsPaused;
        public override void Pause (FlatRedBall.Instructions.InstructionList instructions) 
        {
            base.Pause(instructions);
            mIsPaused = true;
        }
        public virtual void SetToIgnorePausing () 
        {
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(this);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(BodyCollision);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SpriteInstance);
            FlatRedBall.Instructions.InstructionManager.IgnorePausingFor(SwordCollision);
        }
        
        #region Top-Down Methods    

        public void InitializeTopDownInput(FlatRedBall.Input.IInputDevice inputDevice)
        {
            this.MovementInput = inputDevice?.Default2DInput;
            this.InputDevice = inputDevice;
            InputEnabled = inputDevice != null;

            CustomInitializeTopDownInput();
        }

        partial void CustomInitializeTopDownInput();

        private void ApplyMovementInput()
        {
            ////////early out/////////
            if(mCurrentMovement == null)
            {
                return;
            }
            //////end early out

            var absoluteVelocity = this.Velocity;
            var groundVelocity = this.Velocity - GroundVelocity;

            var desiredGroundVelocity = Microsoft.Xna.Framework.Vector3.Zero;
            var desiredAbsoluteVelocity = GroundVelocity;

            if (InputEnabled && MovementInput != null)
            {
                var vector = new Microsoft.Xna.Framework.Vector2(MovementInput.X, MovementInput.Y);
                if(vector.LengthSquared() > 1)
                {
                    vector = Microsoft.Xna.Framework.Vector2ExtensionMethods.AtLength(vector, 1);
                }
                desiredGroundVelocity = new Microsoft.Xna.Framework.Vector3(vector.X, vector.Y, absoluteVelocity.Z) * 
                    mCurrentMovement.MaxSpeed * TopDownSpeedMultiplier;
            }
            desiredAbsoluteVelocity = GroundVelocity + desiredGroundVelocity;

            var absoluteDifference =  desiredAbsoluteVelocity - absoluteVelocity;
            var groundDifference = desiredGroundVelocity - groundVelocity;

            Acceleration = Microsoft.Xna.Framework.Vector3.Zero;

            var absoluteDifferenceLength = absoluteDifference.Length();

            const float differenceEpsilon = .1f;

            if (absoluteDifferenceLength > differenceEpsilon)
            {
                var isMovingRelativeToGround = groundVelocity.X != 0 || groundVelocity.Y != 0;
                var isDesiredGroundVelocityNonZero = desiredGroundVelocity.X != 0 || desiredGroundVelocity.Y != 0;

                // A 0 to 1 ratio of acceleration to deceleration, where 1 means the player is accelerating completely,
                // and 0 means decelerating completely. This value will often be between 0 and 1 because the player may
                // set desired velocity perpendicular to the current velocity
                float accelerationRatio = 1;
                if(isMovingRelativeToGround && isDesiredGroundVelocityNonZero == false)
                {
                    // slowing down completely
                    accelerationRatio = 0;
                }
                else if(isMovingRelativeToGround == false && isDesiredGroundVelocityNonZero)
                {
                    accelerationRatio = 1;
                }
                else
                {
                    // both is moving and has a non-zero desired value
                    var movementAngle = (float)Math.Atan2(absoluteVelocity.Y, absoluteVelocity.X);
                    var desiredAngle = (float)Math.Atan2(absoluteDifference.Y, absoluteDifference.X);

                    accelerationRatio = 1-
                        Math.Abs(FlatRedBall.Math.MathFunctions.AngleToAngle(movementAngle, desiredAngle)) / (float)Math.PI;

                }

                var secondsToTake = Microsoft.Xna.Framework.MathHelper.Lerp(
                    mCurrentMovement.DecelerationTime,
                    mCurrentMovement.AccelerationTime,
                    accelerationRatio);

                if(!mCurrentMovement.UsesAcceleration || secondsToTake == 0)
                {
                    this.Acceleration = Microsoft.Xna.Framework.Vector3.Zero;
                    this.Velocity = desiredAbsoluteVelocity;
                }
                else
                {
                    float accelerationMagnitude;
                    if(this.Velocity.Length() > mCurrentMovement.MaxSpeed * TopDownSpeedMultiplier && mCurrentMovement.IsUsingCustomDeceleration)
                    {
                        accelerationMagnitude = mCurrentMovement.CustomDecelerationValue;
                    }
                    else
                    {
                        // If the TopDownSpeedMultiplier is really small, then this makes acceleration go slower
                        // so it reaches the max speed in the same amount of time. However, if the player is moving
                        // faster than the multiplier, we want to slow down at normal speed rather than multiplied by
                        // TopDownSpeedMulitplier. An extreme case is where TopDownSpeedMultiplier is 0, In that case, the
                        // character would never slow down, which is bad.
                        if(this.Velocity.Length() > mCurrentMovement.MaxSpeed * TopDownSpeedMultiplier)
                        {
                            // This may not give perfect control over deceleration, but that's why CustomDecelerationValue exists
                            accelerationMagnitude = mCurrentMovement.MaxSpeed / secondsToTake;
                        }
                        else
                        {
                            accelerationMagnitude = TopDownSpeedMultiplier * mCurrentMovement.MaxSpeed / secondsToTake;
                        }
                    }
                
                    var nonNormalizedAbsoluteDifference = absoluteDifference;
                    var normalizedAbsoluteDifference = absoluteDifference;
                    normalizedAbsoluteDifference.Normalize();
                
                    var accelerationToSet = accelerationMagnitude * normalizedAbsoluteDifference;
                    var expectedVelocityToAdd = accelerationToSet * TimeManager.SecondDifference;
                
                    if(expectedVelocityToAdd.Length() > nonNormalizedAbsoluteDifference.Length())
                    {
                        // we will overshoot it, so let's adjust the acceleration accordingly:
                        var ratioOfToAdd = nonNormalizedAbsoluteDifference.Length() / expectedVelocityToAdd.Length();
                        this.Acceleration = accelerationToSet * ratioOfToAdd;
                    }
                    else
                        this.Acceleration = accelerationToSet;
                }


                if (mCurrentMovement.UpdateDirectionFromInput)
                {
                    if (desiredGroundVelocity.X != 0 || desiredGroundVelocity.Y != 0)
                    {
                        mDirectionFacing = TopDownDirectionExtensions.FromDirection(desiredGroundVelocity.X, desiredGroundVelocity.Y, PossibleDirections, mDirectionFacing);
                    }
                }
                else if (mCurrentMovement.UpdateDirectionFromVelocity)
                {
                    const float velocityEpsilon = .1f;
                    var shouldAssignDirection = (this.Velocity.Length() - groundVelocity.Length()) > velocityEpsilon || groundDifference.Length() > 0;

                    if(groundVelocity.LengthSquared() == 0)
                    {
                        if(desiredGroundVelocity.X != 0 || desiredGroundVelocity.Y != 0)
                        {
                            // use the desired movement value, so the player can
                            // change directions when facing a wall
                            mDirectionFacing = TopDownDirectionExtensions.FromDirection(desiredGroundVelocity.X, desiredGroundVelocity.Y, PossibleDirections, mDirectionFacing);
                        }
                    }
                    else
                    {
                        mDirectionFacing = TopDownDirectionExtensions.FromDirection(groundVelocity.X, groundVelocity.Y, PossibleDirections, mDirectionFacing);
                    }
                }
            }
            else
            {
                Velocity = desiredAbsoluteVelocity;
                Acceleration = Microsoft.Xna.Framework.Vector3.Zero;
            }

        }

        #endregion


        
        /// <summary>
        /// Sets the MovementInput to either the keyboard or 
        /// Xbox360GamePad index 0. This can be overridden by base classes to default
        /// to different input devices.
        /// </summary>
        protected virtual void InitializeInput()
        {
        
                if (FlatRedBall.Input.InputManager.Xbox360GamePads[0].IsConnected)
                {
                    InitializeTopDownInput(FlatRedBall.Input.InputManager.Xbox360GamePads[0]);
                }
                else
                {
                    InitializeTopDownInput(FlatRedBall.Input.InputManager.Keyboard);
                }
    
        InputEnabled = true;
        

        }
        public virtual void MoveToLayer (FlatRedBall.Graphics.Layer layerToMoveTo) 
        {
            var layerToRemoveFrom = LayerProvidedByContainer;
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(BodyCollision);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(BodyCollision, layerToMoveTo);
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(SpriteInstance);
            }
            if (layerToMoveTo != null || !SpriteManager.AutomaticallyUpdatedSprites.Contains(SpriteInstance))
            {
                FlatRedBall.SpriteManager.AddToLayer(SpriteInstance, layerToMoveTo);
            }
            if (layerToRemoveFrom != null)
            {
                layerToRemoveFrom.Remove(SwordCollision);
            }
            FlatRedBall.Math.Geometry.ShapeManager.AddToLayer(SwordCollision, layerToMoveTo);
            LayerProvidedByContainer = layerToMoveTo;
        }
        partial void CustomActivityEditMode();
    }
    public partial class Player : TopDown.ITopDownEntity
    {
        #region Top Down Fields
        protected virtual System.Collections.Generic.Dictionary<string, Harvesteer.DataTypes.TopDownValues> TopDownValues => TopDownValuesStatic;
        public Microsoft.Xna.Framework.Vector3 GroundVelocity;
        public List<TopDown.AnimationSet> AnimationSets { get; set; } = new List<TopDown.AnimationSet>();
        DataTypes.TopDownValues mCurrentMovement;
        public float TopDownSpeedMultiplier { get; set; } = 1;
        /// <summary>
        /// The current movement variables used when applying input.
        /// </summary>
        public DataTypes.TopDownValues CurrentMovement
        {
            get
            {
                return mCurrentMovement;
            }
            private set
            {
                mCurrentMovement = value;
            }
        }
        public FlatRedBall.Input.IInputDevice InputDevice
        {
            get;
            private set;
        }
        TopDownDirection mDirectionFacing;
        /// <summary>
        /// Which direciton the character is facing.
        /// </summary>
        public TopDownDirection DirectionFacing
        {
            get
            {
                return mDirectionFacing;
            }
            set
            {
                mDirectionFacing = value;
            }
        }
        public PossibleDirections PossibleDirections
        {
            get;
            set;
        }
        /// <summary>
        /// The input object which controls the horizontal movement of the character.
        /// Common examples include a d-pad, analog stick, or keyboard keys.
        /// </summary>
        public FlatRedBall.Input.I2DInput MovementInput { get; set; }
        /// <summary>
        /// Whether input is read to control the movement of the character.
        /// This can be turned off if the player should not be able to control
        /// the character. Velocity and acceleration will still be applied using the current set of movement values.
        /// </summary>
        public bool InputEnabled { get; set; }
        TopDown.DirectionBasedAnimationLayer mTopDownAnimationLayer;
        #endregion
    }
}
