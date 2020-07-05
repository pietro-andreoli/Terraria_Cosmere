using log4net.Appender;
using log4net.Repository.Hierarchy;
using System;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Cosmere.Buffs
{
	class PatternbladeBuff : ModBuff
	{
		private const int dodgeMin = 1;
		private const int dodgeMax = 11;
		private const int dodgeCrit = dodgeMax - 1;
		
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Patternblade");
			Description.SetDefault("Adds chance to dodge attacks");
			Main.debuff[Type] = false;
			// Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;

		}

		public override void Update(Player player, ref int buffIndex)
		{
			CosmerePlayer cPlayer = player.GetModPlayer<CosmerePlayer>();
			cPlayer.patternbladeBuff = true;
			
			
		}
		
		/// <summary>
		/// Checks if the player dodges an attack. Designed to be called in an OnHitByNPC hook.
		/// See dodgeMin, dodgeMax and dodgeCrit for odds.
		/// </summary>
		/// <returns>A bool where true means a successful dodge and false means a failed dodge.</returns>
		public static bool CheckDodge()
		{
			Random rand = new Random();
			int dodgeChance = rand.Next(dodgeMin, dodgeMax);
			return dodgeChance == dodgeCrit;
		}
				
	}
}
