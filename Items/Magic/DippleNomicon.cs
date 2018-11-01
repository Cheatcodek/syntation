using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
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
            item.holdStyle = 1;
            item.mana = 20;
            item.shoot = mod.ProjectileType("DipNomicon");
            item.shootSpeed = 15f;


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
