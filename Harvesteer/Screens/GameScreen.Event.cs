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
using FlatRedBall.Entities;
using System.Diagnostics;

namespace Harvesteer.Screens
{
    public partial class GameScreen
    {
        // Enemey hits Player
        void OnPlayerAxisAlignedRectangleInstanceVsEnemyCollided(Entities.Player player, Entities.Enemy enemy)
        {
            // If the logic of damage to Player is allowed...
            if (player.ShouldTakeDamage(enemy))
            {
                // Player loses health point(s)
                player.TakeDamage(enemy);

                Debug.WriteLine("Player Health: " + player.CurrentHealth.ToString());
            }

            // If Player's current health is depleted...
            if (player.CurrentHealth <= 0)
            {
                // Destory Player
                player.Destroy();

                Debug.WriteLine("Player Died");
            }
        }
        
        void OnPlayerSwordCollisionVsEnemyCollided (Entities.Player player, Entities.Enemy enemy) 
        {
            // If the logic of damage to Enemy is allowed...
            if (player.IsAttackActive && enemy.ShouldTakeDamage(player))
            {
                // Enemy loses health point(s)
                enemy.TakeDamage(player);

                Debug.WriteLine("Enemy Health: " + enemy.CurrentHealth.ToString());
            }

            // If Enemy's current health is depleted...
            if (enemy.CurrentHealth <= 0)
            {
                // Destory Enemy
                enemy.Destroy();

                Debug.WriteLine("Enemy Died");
            }
        }

    }
}
