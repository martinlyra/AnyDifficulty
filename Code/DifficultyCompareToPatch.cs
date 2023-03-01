namespace AnyDifficulty;

using HarmonyLib;
using Kingmaker.Settings.Difficulty;

[HarmonyPatch(
    typeof(DifficultyPreset),
    nameof(DifficultyPreset.CompareTo)
)]
class DifficultyCompareToPatch
{
    static int Postfix(DifficultyPreset other, ref int __result) => other == null ? 1 : -__result;
}