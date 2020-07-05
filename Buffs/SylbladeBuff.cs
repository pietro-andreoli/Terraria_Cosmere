using System;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Cosmere.Buffs
{
	class SylbladeBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Sylblade");
			Description.SetDefault("Increases jump height and movement speed");
			Main.debuff[Type] = false;
			// Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			CosmerePlayer cPlayer = player.GetModPlayer<CosmerePlayer>();
			cPlayer.sylbladebuff = true;
		}
	}
}
