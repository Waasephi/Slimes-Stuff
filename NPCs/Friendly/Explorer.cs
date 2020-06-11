using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using OurStuffAddon.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Friendly
{
	[AutoloadHead]
	public class Explorer : ModNPC
	{
		public override bool Autoload(ref string name)
		{
			name = "Explorer";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName automatically assigned from .lang files, but the commented line below is the normal approach.
			// DisplayName.SetDefault("Example Person");
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = 441; //that is the NPCID for the tax collector
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money) //Whether or not the conditions have been met for this town NPC to be able to move into town.
		{
			if (NPC.downedBoss1)  //so after the EoC is killed
			{
				return true;
			}
			return false;
		}

		public override bool CheckConditions(int left, int right, int top, int bottom)    //Allows you to define special conditions required for this town NPC's house
		{
			return true;  //so when a house is available the npc will  spawn
		}

		public override string TownNPCName()     //Allows you to give this town NPC any name when it spawns
		{
			switch (WorldGen.genRand.Next(6))
			{
				case 0:
					return "Christopher";

				case 1:
					return "Marco";

				case 2:
					return "Leif";

				case 3:
					return "Clark";

				case 4:
					return "Lewis";

				case 5:
					return "Alexander";

				default:
					return "Erik";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2)  //Allows you to set the text for the buttons that appear on this town NPC's chat window.
		{
			button = "Shop";   //this defines the buy button name
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool openShop) //Allows you to make something happen whenever a button is clicked on this town NPC's chat window. The firstButton parameter tells whether the first button or second button (button and button2 from SetChatButtons) was clicked. Set the shop parameter to true to open this NPC's shop.
		{
			if (firstButton)
			{
				openShop = true;   //so when you click on buy button opens the shop
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)       //Allows you to add items to this town NPC's shop. Add an item by setting the defaults of shop.item[nextSlot] then incrementing nextSlot.
		{
			shop.item[nextSlot].SetDefaults(ItemID.GoldCoin);
			nextSlot++;
			if (NPC.downedSlimeKing)   //this make so when the king slime is killed the town npc will sell this
			{
				shop.item[nextSlot].SetDefaults(ItemID.RecallPotion);  //an example of how to add a vanilla terraria item
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.WormholePotion);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.Gel);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<SeafoamCrystal>());  //this is an example of how to add a modded item
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<SeafoamScale>());  //this is an example of how to add a modded item
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ModContent.ItemType<ShadowCrystal>());  //this is an example of how to add a modded item
				nextSlot++;
			}
			if (NPC.downedQueenBee)   //this make so when Skeletron is killed the town npc will sell this
			{
				shop.item[nextSlot].SetDefaults(ItemID.BeeWax);
				nextSlot++;
			}
			if (NPC.downedBoss3)   //this make so when Skeletron is killed the town npc will sell this
			{
				shop.item[nextSlot].SetDefaults(ItemID.Bone);
				nextSlot++;
			}
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<RelicShard>());  //this is an example of how to add a modded item
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<SkyEssence>());  //this is an example of how to add a modded item
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ModContent.ItemType<SpiritShard>());  //this is an example of how to add a modded item
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.Lens);
			nextSlot++;
			if (NPC.downedMoonlord)   //this make so when Skeletron is killed the town npc will sell this
			{
				shop.item[nextSlot].SetDefaults(3456);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(3457);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(3458);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(3459);
				nextSlot++;
			}
		}

		public override string GetChat()       //Allows you to give this town NPC a chat message when a player talks to it.
		{
			int guideNPC = NPC.FindFirstNPC(NPCID.Guide); //this make so when this npc is close to the Guide
			if (guideNPC >= 0 && Main.rand.Next(4) == 0) //has 1 in 3 chance to show this message
			{
				return "That " + Main.npc[guideNPC].GivenName + " over there... He knows a bit too much about this world. Something is up with him. Keep an eye out okay?";
			}
			switch (Main.rand.Next(6))    //this are the messages when you talk to the npc
			{
				case 0:
					return "You wanna buy something? These days I usually just stay around here so I dont have much use for any of it... Yes you still have to pay!";

				case 1:
					return "You want to know how I got all of this stuff? Thats for me to know, and for you to never find out!";

				case 2:
					return "What is that look you are giving me? No I do not have a hoarding problem!";

				case 3:
					return "I've travelled all around this land and obtained many an item... Want to take a look?";

				case 4:
					return "Hey thanks for the home and stuff... What? No I'm not going to give you a discount...";

				case 5:
					return "Why do I sell a gold coin for 5 gold coins? Because why not?";

				default:
					return "I don't know why i have all this random stuff... but its fun to collect them none the less!";
			}
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)//  Allows you to determine the damage and knockback of this town NPC attack
		{
			damage = 40;  //npc damage
			knockback = 2f;   //npc knockback
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)  //Allows you to determine the cooldown between each of this town NPC's attack. The cooldown will be a number greater than or equal to the first parameter, and less then the sum of the two parameters.
		{
			cooldown = 5;
			randExtraCooldown = 10;
		}

		//------------------------------------This is an example of how to make the npc use a sward attack-------------------------------
		public override void DrawTownAttackSwing(ref Texture2D item, ref int itemSize, ref float scale, ref Vector2 offset)//Allows you to customize how this town NPC's weapon is drawn when this NPC is swinging it (this NPC must have an attack type of 3). Item is the Texture2D instance of the item to be drawn (use Main.itemTexture[id of item]), itemSize is the width and height of the item's hitbox
		{
			scale = 1f;
			item = Main.itemTexture[ItemID.EnchantedSword]; //this defines the item that this npc will use
			itemSize = 56;
		}

		public override void TownNPCAttackSwing(ref int itemWidth, ref int itemHeight) //  Allows you to determine the width and height of the item this town NPC swings when it attacks, which controls the range of this NPC's swung weapon.
		{
			itemWidth = 56;
			itemHeight = 56;
		}

		//----------------------------------This is an example of how to make the npc use a gun and a projectile ----------------------------------
		/*public override void DrawTownAttackGun(ref float scale, ref int item, ref int closeness) //Allows you to customize how this town NPC's weapon is drawn when this NPC is shooting (this NPC must have an attack type of 1). Scale is a multiplier for the item's drawing size, item is the ID of the item to be drawn, and closeness is how close the item should be drawn to the NPC.
          {
              scale = 1f;
              item = ModContent.ItemType<GunName>();
              closeness = 20;
          }
          public override void TownNPCAttackProj(ref int projType, ref int attackDelay)//Allows you to determine the projectile type of this town NPC's attack, and how long it takes for the projectile to actually appear
          {
              projType = ProjectileID.CrystalBullet;
              attackDelay = 1;
          }

          public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)//Allows you to determine the speed at which this town NPC throws a projectile when it attacks. Multiplier is the speed of the projectile, gravityCorrection is how much extra the projectile gets thrown upwards, and randomOffset allows you to randomize the projectile's velocity in a square centered around the original velocity
          {
              multiplier = 7f;
             // randomOffset = 4f;
          }   */
	}
}