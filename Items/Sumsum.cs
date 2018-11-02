using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Items
{
    public class Sumsum : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Sumsum Nort 11");
            Tooltip.SetDefault(" A plastic explosive encase within the rotten shell of a phone \n Bought in bulk and launched in bulk");

        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.damage = 30;    //The damage stat for the Weapon.
            item.noMelee = true; 
            item.width = 14;  //The size of the width of the hitbox in pixels.
            item.height = 28;   //The size of the height of the hitbox in pixels.
            item.maxStack = 999; //This defines the items max stack
            item.consumable = true;  //Tells the game that this should be used up once fired
            item.useTime = 20;
            item.knockBack = 1.5f;  
            item.rare = 4;   
            item.shoot = mod.ProjectileType("PSumsum");  
            item.shootSpeed = 8f; 
            item.noUseGraphic = true;
            item.ammo = 0;    
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 4);
            recipe.AddIngredient(ItemID.Grenade);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}