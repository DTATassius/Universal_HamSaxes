﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UniversalHamSaxes.Tiles;
using UniversalHamSaxes;


namespace UniversalHamSaxes.Items
{
    class PearlwoodHamSaxe : ModItem
    {
        bool toggled = false;



        public override void SetStaticDefaults() // ToolTip for the tool 
        {
            // base.SetStaticDefaults();

            Terraria.GameContent.Creative.CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults() // Basic Item Stats
        {
            base.SetDefaults();
            Item.damage = 5;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 14;
            Item.useAnimation = 21;
            Item.pick = 35;
            Item.axe = 8;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = 3000;
            Item.rare = ItemRarityID.Gray;
            Item.UseSound = SoundID.Item126;
            Item.autoReuse = true;
        }

        public override bool AltFunctionUse(Player player)
        {

            switch (toggled)
            {

                case true: // if hammerMode is true, it will disable hammer power on tools

                    Item.pick = 35;
                    Item.axe = 8;
                    Item.hammer = 0;


                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now [c/df0000:OFF].");

                    break;


                case false: // if hammerMode is false, it will enable hammer power on tools


                    Item.axe = 0;
                    Item.pick = 0;
                    Item.hammer = 35;

                    toggled = !toggled;

                    Main.NewText("Hammer Mode is now [c/1ddb04:ON].");

                    break;


            }
            return base.AltFunctionUse(player);


        }

        public override void AddRecipes() // Recipie for the item
        {


            CreateRecipe()
                .AddIngredient(ModContent.ItemType<PearlwoodAxe>(), 1)
                .AddIngredient(ModContent.ItemType<PearlwoodPickaxe>(), 1)
                .AddIngredient(ItemID.PearlwoodHammer)
                .AddTile<Tiles.ImprovedHamsaxeTable>()
                .Register();

            CreateRecipe()
                .AddIngredient(ModContent.ItemType<PearlwoodAxe>(), 1)
                .AddIngredient(ModContent.ItemType<PearlwoodPickaxe>(), 1)
                .AddIngredient(ItemID.PearlwoodHammer)
                .AddTile<Tiles.HamsaxeTable>()
                .Register();

        }
    }
}