using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalMultiTools.Tiles;
using Terraria.GameContent.Creative;

namespace UniversalMultiTools.Items
{
  class PlatinumMultiTool : ModItem
  {
    public override void SetStaticDefaults()
    {
      base.SetStaticDefaults();
      Tooltip.SetDefault("PlatinumMultiTool!");
      CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
      base.SetDefaults();
      Item.damage = 10;
      Item.DamageType = DamageClass.Melee;
      Item.width = 40;
      Item.height = 40;
      Item.useTime = 19;
      Item.useAnimation = 19;
      Item.pick = 59;
      Item.axe = 12;
      Item.hammer = 59;
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
        .AddIngredient(ItemID.PlatinumHammer)
        .AddIngredient(ItemID.PlatinumAxe)
        .AddIngredient(ItemID.PlatinumPickaxe)
        .AddTile(ModContent.TileType<EarlyMultiToolTable>())
        .Register();
    }
  }
}
