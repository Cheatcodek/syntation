using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.NPCs
{
  
    public class Mindscrew : ModNPC
    {
        Random random = new Random();

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.FlyingFish];
        }

        public override void SetDefaults()
        {
            npc.width = 52;
            npc.height = 54;
            npc.aiStyle = 2;
            npc.defense = 19;  //the npc defense
            npc.lifeMax = 375;// the npc life
            npc.damage = 55;
            npc.friendly = false;
            npc.dontTakeDamageFromHostiles = true;
            animationType = NPCID.FlyingFish;
            NPCID.Sets.ExtraFramesCount[npc.type] = 0;
            NPCID.Sets.AttackFrameCount[npc.type] = 0;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (Main.hardMode)
            {

                return SpawnCondition.OverworldNightMonster.Chance * 0.06f;
            }
            else
            {
                return 0f;
            }
        }

        public override void NPCLoot()
        {
            for (int i = 0; i < random.Next(0,3); i++)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("OfFabled"));
            }
        }

    }
}