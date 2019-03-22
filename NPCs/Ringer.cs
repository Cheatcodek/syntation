using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Syntation.NPCs
{

    public class Ringer : ModNPC
    {
        Random random = new Random();

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 13;
        }

        public override void SetDefaults()
        {
            
            npc.width = 32;
            npc.height = 32;
            npc.aiStyle = 2;
            npc.defense = 19;  //the npc defense
            npc.lifeMax = 25;// the npc life
            npc.damage = 5;
            npc.friendly = false;
            npc.dontTakeDamageFromHostiles = true;
            animationType = NPCID.FlyingFish;
            NPCID.Sets.ExtraFramesCount[npc.type] = 0;
            NPCID.Sets.AttackFrameCount[npc.type] = 0;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.06f;

        }

        public override void NPCLoot()
        {
            for (int i = 0; i < random.Next(0, 3); i++)
            {
                // Item.NewItem(npc.getRect(), mod.ItemType("OfFabled"));
                // Change "OfFabled" to the throwing weapon Ringer
            }
        }

    }
}