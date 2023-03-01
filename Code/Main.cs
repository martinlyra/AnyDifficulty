namespace AnyDifficulty;

using HarmonyLib;
using System.Reflection;
using UnityModManagerNet;

public class Main
{
    private static bool Load(UnityModManager.ModEntry modEntry) {
        new Harmony(modEntry.Info.Id).PatchAll(Assembly.GetExecutingAssembly());
        return true;
    }
}
