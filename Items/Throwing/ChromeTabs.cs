using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Items.Throwing
{
    class ChromeTabs : ModItem
    {
        Random random = new Random();

        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Chrome Tabs");
            Tooltip.SetDefault("Slows enemies to a halt on hit");
            item.maxStack = 999;
            item.rare = 4;

        }

        public override void SetDefaults()
        {
            item.damage = 26;
            item.thrown = true;
            item.width = 40;
            item.height = 35;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 1;
            item.value = 1200;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("ChromeTabs");
            item.shootSpeed = 12f;
        }

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int i = 0; i < random.Next(3)+3; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(34)); // multiply the number by 2 to get the real spread
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI); //create the projectile
            }
            return false;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {

            target.AddBuff(BuffID.Stoned, random.Next(120)+60);
        }

    }
}
