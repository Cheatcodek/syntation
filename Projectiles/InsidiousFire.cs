using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Projectiles
{
    public class InsidiousFire : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Insidious Fire");
            Main.RegisterItemAnimation(projectile.type, new DrawAnimationVertical(16, 16));
            Main.projFrames[mod.ProjectileType("InsidiousFire")] = 4;
        }

        public override void SetDefaults()

        {

            projectile.width = 32;
            projectile.height = 32;
            projectile.aiStyle = 1;

            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            projectile.magic = true;
            projectile.penetrate = 3;
            projectile.timeLeft = 5000;
            projectile.light = 5f;
            aiType = 19; // Acts like the 

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
            Main.PlaySound(SoundID.Item34.WithVolume(.25f), projectile.position);

            for (int i = 0; i < 4;)
            {
                Dust.NewDust(projectile.position, 22, 22, DustID.Smoke, 0.0f, 0.0f, 120, new Color(60, 10, 10), 1f);
                i++;
            }
        }

    }
}