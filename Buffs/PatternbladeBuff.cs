using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Cosmere.Buffs
{
	class PatternbladeBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Patternblade");
			Description.SetDefault("Adds chance to dodge attacks");
			//Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;

		}

		public override void Update(Player player, ref int buffIndex)
		{
			base.Update(player, ref buffIndex);
		}
	}
}
