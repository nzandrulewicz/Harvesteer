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
        void OnPlayerVsEnemyCollided (Entities.Player player, Entities.Enemy enemy) 
        {
            player.Health--;
            enemy.Destroy();
        }
        void OnPlayerPlayerSwordAxisAlignedRectangleInstanceVsEnemyCollided (Entities.Player player, Entities.Enemy enemy) 
        {
            enemy.Destroy();
        }
        
    }
}
