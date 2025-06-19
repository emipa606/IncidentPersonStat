using System.Collections.Generic;
using HarmonyLib;
using RimWorld;
using Verse;

namespace ForceRewardsDetails;

[HarmonyPatch(typeof(QuestPartUtility), nameof(QuestPartUtility.GetRewardStackElementsForThings),
    typeof(IEnumerable<Thing>), typeof(bool))]
public class GetRewardStackElementsForThings_Patch
{
    public static void Prefix(ref bool detailsHidden)
    {
        detailsHidden = false;
    }
}