using System;
using System.Collections.Generic;
using System.Text;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.AI.Pathfinding;
using FlatRedBall.Graphics.Animation;
using FlatRedBall.Graphics.Particle;
using FlatRedBall.Math.Geometry;
using Microsoft.Xna.Framework;

namespace Harvesteer.Entities
{
    public partial class EnemySpawner
    {
        double lastSpawnTime;
        bool IsTimeToSpawn
        {
            get
            {
                float spawnFrequency = 1 / EnemiesPerSecond;
                return TimeManager.CurrentScreenSecondsSince(lastSpawnTime) > spawnFrequency;
            }
        }

        private void CustomInitialize()
        {

        }

        private void CustomActivity()
        {
            if (IsTimeToSpawn)
            {
                PerformSpawn();
            }

            this.EnemiesPerSecond += TimeManager.SecondDifference * this.SpawnRateIncrease;
        }

        private void PerformSpawn()
        {
            Vector3 position = GetRandomEnemyPosition();
            Vector3 velocity = GetRandomEnemySpeed(position);

            Enemy enemy = Factories.EnemyFactory.CreateNew();
            enemy.Position = position;
            enemy.Velocity = velocity;

            lastSpawnTime = TimeManager.CurrentScreenTime;
        }

        private void CustomDestroy()
        {

        }

        private static void CustomLoadStaticContent(string contentManagerName)
        {

        }

        private Vector3 GetRandomEnemyPosition()
        {
            return new Vector3(64, -64, 0);

            int randomSide = FlatRedBallServices.Random.Next(4);

            // Let's get the absolute coordinates of the edge of the screen:
            float topEdge = Camera.Main.AbsoluteTopYEdgeAt(0);
            float bottomEdge = Camera.Main.AbsoluteBottomYEdgeAt(0);
            float leftEdge = Camera.Main.AbsoluteLeftXEdgeAt(0);
            float rightEdge = Camera.Main.AbsoluteRightXEdgeAt(0);

            // Now let's set the values according to randomSide
            float minX = 0;
            float maxX = 0;
            float minY = 0;
            float maxY = 0;
            switch (randomSide)
            {
                case 0: // top
                    minX = leftEdge;
                    maxX = rightEdge;
                    minY = topEdge;
                    maxY = topEdge;
                    break;
                case 1: // right
                    minX = rightEdge;
                    maxX = rightEdge;
                    minY = bottomEdge;
                    maxY = topEdge;
                    break;
                case 2: // bottom
                    minX = leftEdge;
                    maxX = rightEdge;
                    minY = bottomEdge;
                    maxY = bottomEdge;
                    break;
                case 3: // left
                    minX = leftEdge;
                    maxX = leftEdge;
                    minY = bottomEdge;
                    maxY = topEdge;
                    break;
            }

            float offScreenX = FlatRedBallServices.Random.Between(minX, maxX);
            float offScreenY = FlatRedBallServices.Random.Between(minY, maxY);

            float amountToMoveBy = 64;
            switch (randomSide)
            {
                case 0: // top
                    offScreenY += amountToMoveBy;
                    break;
                case 1: // right
                    offScreenX += amountToMoveBy;
                    break;
                case 2: // bottom
                    offScreenY -= amountToMoveBy;
                    break;
                case 3: // left
                    offScreenX -= amountToMoveBy;
                    break;
            }

            // Now we can return the value
            return new Vector3(offScreenX, offScreenY, 0);

        }

        private Vector3 GetRandomEnemySpeed(Vector3 position)
        {
            Vector3 centerOfGameScreen = new Vector3(Camera.Main.X, Camera.Main.Y, 0);

            Vector3 directionToCenter = centerOfGameScreen - position;

            directionToCenter.Normalize();

            //float speed = MinVelocity + FlatRedBallServices.Random.Between(MinVelocity, MaxVelocity);

            return directionToCenter;
        }
    }
}

