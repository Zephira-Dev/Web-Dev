using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeverEndingVoid.Content.Items.Weapons
{
    public class NEVAscythe : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 200; // The item texture's width.
            Item.height = 200; // The item texture's height.

            Item.useStyle = ItemUseStyleID.Swing; // The useStyle of the Item.
            Item.useTime = 10; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
            Item.useAnimation = 10; // The time span of the using animation of the weapon, suggest setting it the same as useTime.
            Item.autoReuse = true; // Whether the weapon can be used more than once automatically by holding the use button.

            Item.DamageType = DamageClass.Melee; // Whether your item is part of the melee class.
            Item.damage = 666666666; // The damage your item deals.
            Item.knockBack = 6; // The force of knockback of the weapon. Maximum is 20
            Item.crit = 6; // The critical strike chance the weapon has. The player, by default, has a 4% critical strike chance.

            Item.value = Item.buyPrice(gold: 1); // The value of the weapon in copper coins.
            Item.rare = ItemRarityID.Lime;
            Item.UseSound = SoundID.Item1; // The sound when the weapon is being used.
        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LunarBar, 1000);
            recipe.AddTile(TileID.GlassKiln);
            recipe.Register();
        }
    }
}