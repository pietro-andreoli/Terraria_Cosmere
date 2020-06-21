using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cosmere.Items
{
	public class Sylblade : ModItem
    {
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Ride the storms with Syl!");
		}

		public override void SetDefaults() 
		{
			// Because this item can be found in post-plantera time period, I will set the item to have damage 250
			item.damage = 250;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.useTurn = true; 
			item.knockBack = 6;
			item.value = 1000000;
			
			// The Sylblade will be yellow tier, post-plantera item that can be found in the dungeons.
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

			// The critical strike chance the weapon has.
			item.crit = 50; 
		}

		// Adding the buffs on the sword. I want to give the buffs to the player when the sword is in their inventory.
        public override void UpdateInventory(Player player)
        {
            base.UpdateInventory(player);
			// increase movement speed:
			player.moveSpeed += 0.25f;

			// 

		}

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}