using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Projectiles
{
    public class DipNomicon : ModProjectile
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dipple heads");

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
            projectile.penetrate = 1;
            projectile.timeLeft = 1000;
            projectile.light = 0.10f;
            aiType = 88; // Acts like the laser

        }

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Item14, projectile.position);
            int i = 0;
            while (i < 8)
            {
                Dust.NewDust(projectile.position, 22, 22, DustID.Smoke, 0.0f, 0.0f, 120, new Color(120, 20 , 20), 1f);
                i++;
            }
        }

    }
}