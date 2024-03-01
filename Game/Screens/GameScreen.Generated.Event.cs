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
        void OnPlayerVsEnemyCollidedTunnel (Entities.Player player, Entities.Enemy enemy) 
        {
            if (this.PlayerVsEnemyCollided != null)
            {
                PlayerVsEnemyCollided(player, enemy);
            }
        }
        void OnPlayerPlayerSwordAxisAlignedRectangleInstanceVsEnemyCollidedTunnel (Entities.Player player, Entities.Enemy enemy) 
        {
            if (this.PlayerPlayerSwordAxisAlignedRectangleInstanceVsEnemyCollided != null)
            {
                PlayerPlayerSwordAxisAlignedRectangleInstanceVsEnemyCollided(player, enemy);
            }
        }
    }
}
