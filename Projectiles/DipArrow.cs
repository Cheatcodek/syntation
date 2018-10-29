using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Projectiles
{
    public class DipArrow : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dipple's Holy Arrow");

        }

        public override void SetDefaults()

        {
            projectile.width = 27;  
            projectile.height = 9;  
            projectile.aiStyle = 1; 
            projectile.friendly = true;  
            projectile.hostile = false; 
            projectile.tileCollide = true; 
            projectile.ignoreWater = true; 
            projectile.ranged = true;   
            projectile.penetrate = 99; 
            projectile.timeLeft = 400; 
            projectile.light = 0.10f; 
            aiType = 1; 
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height); 
            Main.PlaySound(SoundID.Item10, projectile.position); 
        }

    }
}