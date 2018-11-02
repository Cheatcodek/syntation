using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Projectiles
{
    public class PSumsum : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sumsum");
        }
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 28;
            projectile.aiStyle = 16;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 200;
        }
        public override void Kill(int timeLeft)
        {
            Vector2 position = projectile.Center;
            Main.PlaySound(SoundID.Item14, projectile.position);
            int radius = 40;
            projectile.damage = 45;
            for (int x = -radius; x <= radius; x++)
            {
                for (int y = -radius; y <= radius; y++)
                {
                    int xPosition = (int)(x + position.X / 16.0f);
                    int yPosition = (int)(y + position.Y / 16.0f);

                    if ((x * x + y * y) <= radius + 0.5)
                    {
                        Dust.NewDust(position, 22, 22, DustID.Smoke, 0.0f, 0.0f, 120, new Color(), 1f);
                    }
                }
            }
        }
    }
}