using NeoModLoader.api;

namespace Xenentomon
{
    public class ModClass : BasicMod<ModClass>
    {
        protected override void OnModLoad()
        {
            LogInfo("Xenentomon: loaded.");
        }
    }
}