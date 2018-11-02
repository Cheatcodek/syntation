using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Items.Melee
{
	public class TheStick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Stick");
			Tooltip.SetDefault("Due to the sheer stupidity of this 'Weapon', enemies fly away almost harmlessly");
		}
		public override void SetDefaults()
		{
			item.damage = 1;
			item.melee = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 1;
			item.knockBack = 9;
			item.value = 0;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
