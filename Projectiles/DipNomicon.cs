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


    }
}