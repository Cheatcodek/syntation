using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Items
{
    public class SlurpingPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slurping Potion");
            Tooltip.SetDefault(" 'Competely Original!'");
        }


        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;                 
            item.consumable = true;           
            item.width = 20;
            item.height = 28;
            item.value = 100;
            item.rare = 1;
            item.potion = true;
            item.healLife = 30;

            return;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 15);
            recipe.AddRecipe();
        }

    }
}