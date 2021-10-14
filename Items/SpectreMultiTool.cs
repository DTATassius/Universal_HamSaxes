using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalMultiTools.Tiles;
using Terraria.GameContent.Creative;

namespace UniversalMultiTools.Items
{
  class SpectreMultiTool : ModItem
  {
    public override void SetStaticDefaults()
    {
      base.SetStaticDefaults();
      Tooltip.SetDefault("It's light... ethereal... it's almost like... it isn't there...");
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      base.SetDefaults();
      Item.damage = 63;
      Item.DamageType = DamageClass.Melee;
      Item.width = 40;
      Item.height = 40;
      Item.useTime = 24;
      Item.useAnimation = 24;
      Item.pick = 200;
      Item.axe = 30;
      Item.hammer = 90;
      Item.useStyle = ItemUseStyleID.Swing;
      Item.knockBack = 6;
      Item.value = 3000;
      Item.rare = ItemRarityID.Blue;
      Item.UseSound = SoundID.Item1;
      Item.autoReuse = true;
    }

    public override void AddRecipes()
    {

      CreateRecipe()
        .AddIngredient(ItemID.SpectrePickaxe, 1)
        .AddIngredient(ItemID.SpectreHamaxe, 1)
        .AddTile(ModContent.TileType<LateMultiToolTable>())
        .Register();
    }
  }
}
