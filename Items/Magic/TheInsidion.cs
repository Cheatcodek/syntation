using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Timers;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Items.Magic
{

    public class TheInsidion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Insidion");
            Tooltip.SetDefault("A Book of fire and insidious intent");


        }

        public override void SetDefaults()
        {
            item.damage = 35;
            item.magic = true;
            item.maxStack = 1;
            item.width = 32;
            item.height = 32;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = 20000;
            item.rare = 6;
            item.useTurn = false;
            item.UseSound = SoundID.Item42;
            item.autoReuse = true;
            item.holdStyle = 0;
            item.mana = 6;
            item.shoot = mod.ProjectileType("InsidiousFire");
            item.shootSpeed = 8f;


        }

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {


            for (int i = 0; i < 3; i++)
            {

                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(28)); // multiply the number by 2 to get the real spread
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI); //create the projectile
            }
            return false;
        }




        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
