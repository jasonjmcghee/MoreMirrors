using System;
using Terraria.ModLoader;

namespace MoreMirrors {
    public class MoreMirrors : Mod {
        public MoreMirrors() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}
