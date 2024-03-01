using Harvesteer.Entities;
using System;
using FlatRedBall.Math;
using FlatRedBall.Graphics;
using Harvesteer.Performance;

namespace Harvesteer.Factories
{
    public class EnemyFactory : IEntityFactory
    {
        public static FlatRedBall.Math.Axis? SortAxis { get; set;}
        public static Enemy CreateNew (float x = 0, float y = 0, float z = 0) 
        {
            return CreateNew(null, x, y, z);
        }
        public static Enemy CreateNew (Microsoft.Xna.Framework.Vector3 position) 
        {
            return CreateNew(null, position.X, position.Y, position.Z);
        }
        public static Enemy CreateNew (Microsoft.Xna.Framework.Vector2 position) 
        {
            return CreateNew(null, position.X, position.Y, 0);
        }
        public static Enemy CreateNew (Layer layer, Microsoft.Xna.Framework.Vector3 position) 
        {
            return CreateNew(layer , position.X, position.Y, position.Z);
        }
        public static Enemy CreateNew (Layer layer, float x = 0, float y = 0, float z = 0) 
        {
            Enemy instance = null;
            instance = new Enemy(mContentManagerName ?? FlatRedBall.Screens.ScreenManager.CurrentScreen.ContentManagerName, false);
            instance.AddToManagers(layer);
            NewInstancesCreatedThisScreen++;
            instance.X = x;
            instance.Y = y;
            instance.Z = z;
            foreach (var list in ListsToAddTo)
            {
                if (SortAxis == FlatRedBall.Math.Axis.X && list is PositionedObjectList<Enemy>)
                {
                    var index = (list as PositionedObjectList<Enemy>).GetFirstAfter(x, Axis.X, 0, list.Count);
                    list.Insert(index, instance);
                }
                else if (SortAxis == FlatRedBall.Math.Axis.Y && list is PositionedObjectList<Enemy>)
                {
                    var index = (list as PositionedObjectList<Enemy>).GetFirstAfter(y, Axis.Y, 0, list.Count);
                    list.Insert(index, instance);
                }
                else
                {
                    // Sort Z not supported
                    list.Add(instance);
                }
            }
            if (EntitySpawned != null)
            {
                EntitySpawned(instance);
            }
            return instance;
        }
        
        public static void Initialize (string contentManager) 
        {
            mContentManagerName = contentManager;
        }
        
        public static void Destroy () 
        {
            mContentManagerName = null;
            ListsToAddTo.Clear();
            SortAxis = null;
            NewInstancesCreatedThisScreen = 0;
            EntitySpawned = null;
        }
        void IEntityFactory.Destroy() => Destroy();
        
        private static void FactoryInitialize () 
        {
            int numberToPreAllocate = 20;
            // If in edit mode and viewing a screen, don't pre-allocate because the content manager may not be set which would cause a crash
            if (FlatRedBall.Screens.ScreenManager.IsInEditMode && FlatRedBall.Screens.ScreenManager.CurrentScreen?.GetType().Name == "EntityViewingScreen")
            {
                numberToPreAllocate = 0;
            }
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (Enemy objectToMakeUnused) 
        {
            MakeUnused(objectToMakeUnused, true);
        }
        
        /// <summary>
        /// Makes the argument objectToMakeUnused marked as unused.  This method is generated to be used
        /// by generated code.  Use Destroy instead when writing custom code so that your code will behave
        /// the same whether your Entity is pooled or not.
        /// </summary>
        public static void MakeUnused (Enemy objectToMakeUnused, bool callDestroy) 
        {
            if (callDestroy)
            {
                objectToMakeUnused.Destroy();
            }
        }
        
        public static void AddList<T> (System.Collections.Generic.IList<T> newList) where T : Enemy
        {
            ListsToAddTo.Add(newList as System.Collections.IList);
        }
        public static void RemoveList<T> (System.Collections.Generic.IList<T> listToRemove) where T : Enemy
        {
            ListsToAddTo.Remove(listToRemove as System.Collections.IList);
        }
        public static void ClearListsToAddTo () 
        {
            ListsToAddTo.Clear();
        }
        
        
        static string mContentManagerName;
        static System.Collections.Generic.List<System.Collections.IList> ListsToAddTo = new System.Collections.Generic.List<System.Collections.IList>();
        public static int NewInstancesCreatedThisScreen;
        int IEntityFactory.NewInstancesCreatedThisScreen => NewInstancesCreatedThisScreen;
        /// <summary> Event raised whenever an instance is created through this factory.
        /// These events are cleared out whenever a Screen is destroyed, so there is 
        /// no reason to explicitly remove added events. </summary>
        public static event Action<Enemy> EntitySpawned;
        object IEntityFactory.CreateNew (float x = 0, float y = 0) 
        {
            return EnemyFactory.CreateNew(x, y);
        }
        object IEntityFactory.CreateNew (Microsoft.Xna.Framework.Vector3 position) 
        {
            return EnemyFactory.CreateNew(position);
        }
        object IEntityFactory.CreateNew (Layer layer) 
        {
            return EnemyFactory.CreateNew(layer);
        }
        void IEntityFactory.Initialize (string contentManagerName) 
        {
            EnemyFactory.Initialize(contentManagerName);
        }
        void IEntityFactory.ClearListsToAddTo () 
        {
            EnemyFactory.ClearListsToAddTo();
        }
        System.Collections.Generic.List<System.Collections.IList> IEntityFactory.ListsToAddTo => EnemyFactory.ListsToAddTo;
        static EnemyFactory mSelf;
        public static EnemyFactory Self
        {
            get
            {
                if (mSelf == null)
                {
                    mSelf = new EnemyFactory();
                }
                return mSelf;
            }
        }
    }
}
