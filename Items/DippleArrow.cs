using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Items
{
    public class DippleArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dipple's Middle Finger");
            Tooltip.SetDefault("A holy fragment of dipple's power, Used to smite your enemies");

        }

        public override void SetDefaults()
        {
            item.damage = 25;    //The damage stat for the Weapon.
            item.ranged = true;  //This defines if it does Ranged damage and if its effected by Ranged increasing Armor/Accessories.
            item.width = 30;  //The size of the width of the hitbox in pixels.
            item.height = 10;   //The size of the height of the hitbox in pixels.
            item.maxStack = 999; //This defines the items max stack
            item.consumable = true;  //Tells the game that this should be used up once fired
            item.knockBack = 1.5f;  //Added with the weapon's knockback
            item.rare = 4;   //The color the title of your Weapon when hovering over it ingame  
            item.shoot = mod.ProjectileType("DipArrow");  //This defines what type of projectile this weapon will shoot 
            item.shootSpeed = 2f; //Added to the weapon's shoot speed
            item.ammo = 40;    //This defines what type of ammo is. 40 is arrow
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