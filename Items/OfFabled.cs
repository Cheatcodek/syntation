using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.Items
{
    public class OfFabled : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Of Fabled");
            Tooltip.SetDefault("A material found only in bizarre places \nSome say it can make untold amounts of glorious weaponry \nOthers know it is a volatile and strange material");

        }
        public override void SetDefaults()
        {
            item.rare = 3;
            item.maxStack = 999;

        }

    }
}