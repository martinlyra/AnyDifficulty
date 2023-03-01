namespace AnyDifficulty;

using HarmonyLib;
using Kingmaker.Settings.Difficulty;

[HarmonyPatch(
    typeof(DifficultyPreset),
    nameof(DifficultyPreset.CompareTo)
)]
class DifficultyCompareToPatch
{
    static int Postfix(int result, DifficultyPreset other) => other == null ? 1 : -result;
}