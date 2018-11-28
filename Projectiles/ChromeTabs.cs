using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Projectiles
{
    public class ChromeTabs : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chrome Tabs");
        }

        public override void SetDefaults()

        {

            projectile.width = 40;
            projectile.height = 35;
            projectile.aiStyle = 1;

            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.thrown = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 5000;
            projectile.light = 0.5f;
            aiType = 88; // Acts like the laser

        }



        public override void Kill(int timeLeft)
        {

            for (int i = 0; i < 4; i++)
            {
                Dust.NewDust(projectile.position, 22, 22, DustID.Smoke, 0.0f, 0.0f, 120, new Color(255, 255, 255), 1f);
            }
        }

    }
}