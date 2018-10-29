using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Items
{
	public class DippleYeet : ModItem
	{
		public override void SetStaticDefaults()
		{
            // WIP
            // WIP
            // WIP
            // DO NOT USE YET
			DisplayName.SetDefault("Dipple's Earthshattering Yeet");
			Tooltip.SetDefault("A tool for yeeting sent by the gods in order to smite the unworthy");

        }
		public override void SetDefaults()
		{
			item.damage = 225;
			item.magic = true;
            item.maxStack = 1;
			item.width = 64;
			item.height = 64;
			item.useTime = 60;
			item.useAnimation = 60;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 6;
            item.useTurn = true;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
            item.holdStyle = 3;
            item.mana = 1;
            item.shoot = mod.ProjectileType("DipYeet");
            item.shootSpeed = 1f;
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
