using Cosmere.Buffs;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace Cosmere
{
	class CosmerePlayer : ModPlayer
	{
		public bool patternbladeBuff;
		public bool sylbladebuff;

		public override void ResetEffects()
		{
			patternbladeBuff = false;
			sylbladebuff = false;
		}

		public override void ModifyHitByNPC(NPC npc, ref int damage, ref bool crit)
		{
			// If the Patternblade buff is applied, run Patternblade effects.
			if (patternbladeBuff == true)
			{
				if (PatternbladeBuff.CheckDodge())
				{
					damage = 1;
					mod.Logger.Info("PatternbladeBuff: Player dodged the attack. Setting damage to 1.");
				}
			}

		}
	}
}
