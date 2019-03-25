using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Projectiles
{
    class DarkBlueWave : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dark Blue Wave");
            Main.RegisterItemAnimation(projectile.type, new DrawAnimationVertical(24, 14));
            Main.projFrames[mod.ProjectileType("DarkBlueWave")] = 4;
        }

        public override void SetDefaults()

        {

            projectile.width = 14;
            projectile.height = 24;
            projectile.aiStyle = 1;

            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            projectile.magic = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 5000;
            projectile.light = 0.8f;
            aiType = 14; // Acts like the bullet

        }

        public override void AI()
        {

            if (++projectile.frameCounter >= 5)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 4)
                {
                    projectile.frame = 0;
                }
            }
        }

        public override void Kill(int timeLeft)
        {

            for (int i = 0; i < 6; i++)
            {
                Dust.NewDust(projectile.position, 22, 22, DustID.Smoke, -1f, 4f, 60, new Color(40, 40, 120), 1f);
            }
        }

    }

}
