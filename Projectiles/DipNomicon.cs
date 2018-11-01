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

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {
            //wip
            for (int i = 0; i < 3; i++) 

            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(12)); //12 is the spread in degrees, although like with Set Spread it's technically a 24 degree spread due to the fact that it's randomly between 12 degrees above and 12 degrees below your cursor.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI); //create the projectile
            }
            return false;
        }
    }
}