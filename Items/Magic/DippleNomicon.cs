using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Timers;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Items.Magic
{


    public class DippleNomicon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dipplenomicon");
			Tooltip.SetDefault("Glory of thy dip sent upon thy enemy");

        }
		public override void SetDefaults()
		{
			item.damage = 65;
			item.magic = true;
            item.maxStack = 1;
			item.width = 64;
			item.height = 64;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 7;
            item.useTurn = false;
			item.UseSound = SoundID.Item15;
			item.autoReuse = false;
            item.holdStyle = 0;
            item.mana = 2;
            item.shoot = mod.ProjectileType("DipNomicon");
            item.shootSpeed = 15f;


        }

        public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {
            //wip


             for (int i = 0; i < 3; i++)
                 {

                     Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(14)); // multiply the number by 2 to get the real spread
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
