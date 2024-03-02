using System;
using FlatRedBall;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Specialized;
using FlatRedBall.Audio;
using FlatRedBall.Screens;
using Harvesteer.Entities;
using Harvesteer.Screens;
namespace Harvesteer.Screens
{
    public partial class GameScreen
    {
        void OnPlayerAxisAlignedRectangleInstanceVsEnemyCollidedTunnel (Entities.Player player, Entities.Enemy enemy) 
        {
            if (this.PlayerAxisAlignedRectangleInstanceVsEnemyCollided != null)
            {
                PlayerAxisAlignedRectangleInstanceVsEnemyCollided(player, enemy);
            }
        }
        void OnPlayerSwordCollisionVsEnemyCollidedTunnel (Entities.Player player, Entities.Enemy enemy) 
        {
            if (this.PlayerSwordCollisionVsEnemyCollided != null)
            {
                PlayerSwordCollisionVsEnemyCollided(player, enemy);
            }
        }
    }
}
