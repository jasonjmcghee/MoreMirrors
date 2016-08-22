using Terraria.ID;
using Terraria.ModLoader;

namespace MoreMirrors.Items {
    class MemoryMirror : ModItem {
        public override void SetDefaults() {
            item.CloneDefaults(ItemID.MagicMirror);
            item.name = "Memory Mirror";
            item.toolTip = "Gaze in the mirror to return home, gaze into the back to return to the place from which you came.";
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MagicMirror, 2);
            recipe.AddIngredient(ItemID.Gel, 10);
            recipe.AddTile(TileID.Teleporter);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MagicMirror);
            recipe.AddIngredient(ItemID.Gel, 10);
            recipe.AddIngredient(ItemID.IceMirror);
            recipe.AddTile(TileID.Teleporter);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceMirror, 2);
            recipe.AddIngredient(ItemID.Gel, 10);
            recipe.AddTile(TileID.Teleporter);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceMirror, 2);
            recipe.AddIngredient(ItemID.Fireblossom);
            recipe.AddTile(TileID.Teleporter);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
