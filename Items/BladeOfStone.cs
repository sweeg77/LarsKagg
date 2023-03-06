using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LarsKagg.Items
{
    public class BladeOfStone : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A crude blade made out of common rock.");
        }

        public override void SetDefaults()
        {
            Item.damage = 8;
            Item.DamageType = DamageClass.Melee;
            Item.width = 34;
            Item.height = 34;
            Item.useTime = 19;
            Item.useAnimation = 19;
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
            recipe.AddIngredient(ItemID.StoneBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}