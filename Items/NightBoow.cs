using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WINGS_OF_PIDARAS.Items
{
	public class NightBoow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night Boow"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a boow of nihgt ranger, but this hero is dead from dark-magic forest. So its boow now you");
		}

		public override void SetDefaults()
		{
			Item.damage = 70;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 20;
			Item.height = 78;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 5;
			Item.knockBack = 3;
			Item.value = 10000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Arrow;
            Item.shootSpeed = 6f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}



        
	}
}