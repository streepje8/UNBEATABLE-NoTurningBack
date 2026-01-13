using System.Collections.Generic;
using HarmonyLib;
using JetBrains.Annotations;
using Rhythm;
using UnityEngine;

namespace Streep.Unbeatable.NoTurningBack
{
    public static class Patches
    {
        [UsedImplicitly]
        [HarmonyPrefix]
        [HarmonyPatch(typeof(RhythmController))]
        [HarmonyPatch(
            "CreateNote",
            new[] { typeof(NoteInfo), typeof(bool), typeof(Transform) }
        )]
        static void InitPatch(RhythmController __instance, NoteInfo info, bool twinNote, Transform linkedTwin)
        {
            info.side = Side.Right;
        }
        
        [UsedImplicitly]
        [HarmonyPostfix]
        [HarmonyPatch(typeof(RhythmController), "InitializeController")]
        static void InitPatch(RhythmController __instance)
        {
            var flips = AccessTools.Field(typeof(RhythmController), "flips");
            (flips.GetValue(__instance) as Queue<FlipInfo>)?.Clear();
        }
    }
}