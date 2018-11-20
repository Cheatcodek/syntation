using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Syntation.Projectiles.Pets
{
    public class SlavPet : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            aiType = ProjectileID.ZephyrFish;
            Main.projFrames[projectile.type] = 1;
            Main.projPet[projectile.type] = true;
        }
        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false; 
            return true;
        }
       // public override void AI()
        // {

        // I'll add this back in later maybe
           // if (Player.dead)
           // {
             //   modPlayer.examplePet = false;
            //}
            //if (modPlayer.examplePet)
            //{
              //  projectile.timeLeft = 2;
            //}
        //}
    }
}