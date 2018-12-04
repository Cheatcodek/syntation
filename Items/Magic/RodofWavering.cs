using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Timers;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Items.Magic
{
    class RodofWavering : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rod of Wavering");

        }


        public override void SetDefaults()
        {
            item.damage = 46;
            item.magic = true;
            item.maxStack = 1;
            item.width = 32;
            item.height = 32;
            item.useTime = 20;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = 20000;
            item.rare = 4;
            item.useTurn = true;
            // item.UseSound = SoundID.Item42;
            item.autoReuse = true;
            item.holdStyle = 0;
            item.mana = 18;
            item.shoot = mod.ProjectileType("DarkBlueWave");
            item.shootSpeed = 24f;


        }

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {


            for (int i = 0; i < 2; i++)
            {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY);
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI); //create the projectile
            }
            return false;
        }




        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "OfFabled", 25);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
