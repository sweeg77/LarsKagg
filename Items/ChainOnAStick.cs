
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using LasKagMod.Projectiles;

namespace LasKagMod.Items
{
    public class ChainOnAStick : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
            DisplayName.SetDefault("Chain on a Stick");
        }

        public override void SetDefaults()
        {
            Item.DefaultToWhip(ModContent.ProjectileType<ChainProjectile>(), 8, 2, 4);
            Item.shootSpeed = 4;
            Item.rare = ItemRarityID.Green;
            Item.channel = true;
        }

        // Makes the whip receive melee prefixes
        public override bool MeleePrefix()
        {
            return true;
        }
    }
}