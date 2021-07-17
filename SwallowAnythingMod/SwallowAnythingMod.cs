using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BepInEx;

namespace SwallowAnythingMod
{
    [BepInPlugin("drwoof.swallowanythingmod", "Swallow Anything Mod", "0.1.0")]
    public class SwallowAnythingMod : BaseUnityPlugin
    {
        public SwallowAnythingMod()
        {
            CanBeSwallowedPatch.Patch();
            ReleaseGraspPatch.Patch();
        }
    }
}
