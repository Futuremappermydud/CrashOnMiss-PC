using HarmonyLib;
using System.Linq;
using System.Threading;
using UnityEngine;

namespace CrashOnMiss.HarmonyPatches
{
    [HarmonyPatch(typeof(ComboUIController))]
    [HarmonyPatch("HandleComboBreakingEventHappened", MethodType.Normal)]
    internal class HaHaNOOB
    {
        static void Prefix()
        {
            Application.Quit();
        }
    }

}