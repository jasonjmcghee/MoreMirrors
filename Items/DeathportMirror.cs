using Terraria.ID;
using Terraria.ModLoader;

namespace MoreMirrors.Items {
    class DeathportMirror : ModItem {
        public override void SetDefaults() {
            item.CloneDefaults(ItemID.MagicMirror);
        }

        public override void SetStaticDefaults() {
            Tooltip.SetDefault("Gaze into the mirror to return to where you met your demise- for a price.");
            DisplayName.SetDefault("Deathport Mirror");
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MagicMirror);
            recipe.AddIngredient(ItemID.Tombstone, 5);
            recipe.AddTile(TileID.Teleporter);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceMirror);
            recipe.AddIngredient(ItemID.Tombstone, 5);
            recipe.AddTile(TileID.Teleporter);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

