using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;

namespace UniversalHamSaxes.Items
{
    class TungstenHamSaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("The Tungsten tool to rule them all!");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.damage = 8;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 21;
            Item.useAnimation = 21;
            Item.pick = 50;
            Item.axe = 11;
            Item.hammer = 50;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 3000;
            Item.rare = ItemRarityID.Red;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.TungstenPickaxe)
                .AddIngredient(ItemID.TungstenHammer)
                .AddIngredient(ItemID.TungstenAxe)
                .AddTile(ModContent.TileType<EarlyHamSaxeTable>())
                .Register();
        }
    }
}
