using HarmonyLib;
using UnityEngine;

namespace HMSRedux
{
    [HarmonyPatch(typeof(GearItem), "Awake", null)]
    public class GearItem_Awake
    {
        private static void Postfix(GearItem __instance)
        {
            Implementation.Apply(__instance);
        }
    }
}
