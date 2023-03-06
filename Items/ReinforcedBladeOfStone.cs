using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LasKagMod.Items
{
    public class ReinforcedBladeOfStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A crude blade made out of common rock, now reinforced with copper");
        }

        public override void SetDefaults()
        {
            Item.damage = 10;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 18;
            Item.useAnimation = 16;
            Item.useStyle = 1;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = false;
            Item.useTurn = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(null, "BladeOfStone", 1);
            recipe.AddIngredient(ItemID.CopperShortsword, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}