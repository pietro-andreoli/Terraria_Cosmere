﻿using log4net.Repository.Hierarchy;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Cosmere.Items
{
	class Patternblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Shallan's Blade.");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void HoldItem(Player player)
		{
			CosmerePlayer cPlayer = player.GetModPlayer<CosmerePlayer>();
			// mod.Logger.Info("patternBuff applied");
			cPlayer.patternbladeBuff = true;

			// Applies PattenbladeBuff to player for 2 frames. Duration does not matter as this buff is applied while holding the item.
			player.AddBuff(BuffType<Buffs.PatternbladeBuff>(), 2);
			
		}
	}
}
