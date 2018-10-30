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

            projectile.width = 8;
            projectile.height = 16;
            projectile.aiStyle = 1;

            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.ranged = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 400;
            projectile.light = 0.10f;
            aiType = 88; // Acts like the laser

        }

        public override void Kill(int timeLeft)
        {
            // If we are the original projectile, spawn the 5 child projectiles
            if (projectile.ai[1] == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    // Random upward vector.
                    Vector2 vel = new Vector2(Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-10, -8));
                    Projectile.NewProjectile(projectile.Center, vel, projectile.type, projectile.damage, projectile.knockBack, projectile.owner, 0, 1); {
                        Main.PlaySound(SoundID.Item14.WithVolume(2f), projectile.position);
                    }
                }
            }
            // Play explosion sound
            Main.PlaySound(SoundID.Item14.WithVolume(2f), projectile.position);
            // Smoke Dust spawn
            for (int i = 0; i < 50; i++)
            {
                int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 31, 0f, 0f, 100, default(Color), 2f);
                Main.dust[dustIndex].velocity *= 1.4f;
            }

        }
    }
}