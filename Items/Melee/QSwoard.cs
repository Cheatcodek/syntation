using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Syntation.Items.Melee
{
	public class QSwoard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Q Swoard");
			Tooltip.SetDefault("An ancient sword forged by an ancient people \nDue to this they have no idea on how to make a good sword \nIt's jagged edges cause enemies to bleed");
		}
		public override void SetDefaults()
		{
			item.damage = 48;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 24;
			item.useAnimation = 14;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 177013;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {

            target.AddBuff(BuffID.Bleeding , 180);
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
