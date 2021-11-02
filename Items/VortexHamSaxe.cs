using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UniversalHamSaxes.Items
{
    class VortexHamSaxe : ModItem
    {
        public override void SetStaticDefaults() // ToolTip for the tool
        {
            base.SetStaticDefaults();
            
            Tooltip.SetDefault("Space and Time warp around this tool, almost as if it's existed for as long as the universe... perhaps even longer...!");
        }

        public override void SetDefaults() // Basic Item Stats
        {
            Item.damage = 65;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 6;
            Item.useAnimation = 12;
            
            Item.pick = 225;
            Item.axe = 30;
            Item.hammer = 100;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 3000;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.tileBoost = 4;
        }


        bool toggled = false;
        public override bool AltFunctionUse(Player player)
        {

            switch (toggled)
            {

                case true: // if hammerMode is true, it will disable hammer power on tools

                    Item.pick = 225;
                    Item.axe = 30;
                    Item.hammer = 0;


                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now OFF.");

                    break;


                case false: // if hammerMode is false, it will enable hammer power on tools


                    Item.axe = 0;
                    Item.pick = 0;
                    Item.hammer = 100;

                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now ON.");

                    break;


            }
            

            
            
                return base.AltFunctionUse(player);


        }

    public override void AddRecipes() // Recipie for the item
        {
          

            CreateRecipe()
                .AddIngredient(ItemID.VortexPickaxe, 1)
                .AddIngredient(ItemID.LunarHamaxeVortex, 1)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}
