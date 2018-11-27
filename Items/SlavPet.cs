using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Items
{
    public class SlavPet : ModItem
    {
        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Vok Da of Comrades");
            Tooltip.SetDefault("Summons the glory of slavic brethren");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("SlavPet");
            item.buffType = mod.BuffType("SlavPet");
            item.width = 15;
            item.height = 41;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Ale, 8);
            recipe.AddIngredient(ItemID.DirtBlock, 999);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}