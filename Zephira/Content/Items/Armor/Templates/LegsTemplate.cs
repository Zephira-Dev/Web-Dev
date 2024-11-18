using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Zephira.Content.Rarities.Animated;
using Zephira.Items.Materials;

namespace Zephira.Items.Armor
{
	// The AutoloadEquip attribute automatically attaches an equip texture to this item.
	// Providing the EquipType.Legs value here will result in TML expecting a X_Legs.png file to be placed next to the item's main texture.
	[AutoloadEquip(EquipType.Legs)]
	public class EclipseLeggings : ModItem
	{
		public static readonly int MoveSpeedBonus = 55;

		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MoveSpeedBonus);

		public override void SetDefaults() {
			Item.width = 18; // Width of the item
			Item.height = 18; // Height of the item
			Item.value = Item.sellPrice(gold: 1); // How many coins the item is worth
			Item.rare = ModContent.RarityType<Eclipse>(); // The rarity of the item
			Item.defense = 75; // The amount of defense the item will give when equipped
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += MoveSpeedBonus / 100f; // Increase the movement speed of the player
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient<EclipseBar>(50)
                .AddIngredient<FailedStar>(50)
				.AddTile<Content.Tiles.EclipseForgeTile>()
				.Register();
		}
	}
}
