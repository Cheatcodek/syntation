using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Projectiles
{
    public class DipYeet : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dipple's Earthshattering Yeet");

        }

        public override void SetDefaults()

        {
            projectile.width = 50;  
            projectile.height = 50;  
            projectile.aiStyle = 1; 

            projectile.friendly = true;  
            projectile.hostile = false; 
            projectile.tileCollide = true; 
            projectile.ignoreWater = true; 
            projectile.ranged = true;   
            projectile.penetrate = 99; 
            projectile.timeLeft = 400; 
            projectile.light = 0.10f; 
            aiType = 88; // Acts like the laser
            Main.projFrames[projectile.type] = -1;
        }

       // public DrawAnimation GetAnimation()
       // {
           // return new DrawAnimationVertical(13, 4);
       // }
    }
}