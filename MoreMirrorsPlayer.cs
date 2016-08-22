using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace MoreMirrors {
    class MoreMirrorsPlayer : ModPlayer {
        public Vector2 magicMirrorUseLocation = new Vector2(-1, -1);

        public override void PostItemCheck() {
            base.PostItemCheck();
            Item sItem = this.player.inventory[this.player.selectedItem];
            if (sItem.name == "Memory Mirror") {
                if (Main.mouseRight && Main.mouseRightRelease) {
                    if (!magicMirrorUseLocation.Equals(new Vector2(-1, -1))) {
                        this.player.Teleport(this.magicMirrorUseLocation);
                    }
                } else if (this.player.itemAnimation > 0) {
                    if (this.player.itemTime == 0) {
                        this.player.itemTime = sItem.useTime;
                    } else if (this.player.itemTime == sItem.useTime / 2) {
                        this.magicMirrorUseLocation = this.player.position;
                        this.player.Spawn();
                    }
                }
            } else if (sItem.name == "Deathport Mirror" && this.player.itemAnimation > 0) {
                if (this.player.itemTime == 0) {
                    this.player.itemTime = sItem.useTime;
                } else if (this.player.itemTime == sItem.useTime / 2) {
                    this.player.statLife /= 2;
                    float deathPosX = this.player.lastDeathPostion.X + 8 - this.player.width / 2;
                    float deathPosY = this.player.lastDeathPostion.Y - this.player.height;
                    this.player.Teleport(new Vector2(deathPosX, deathPosY));
                }
            }
        }
    }
}
