using System.Collections.Generic;
using HarmonyLib;
using RimWorld;
using Verse;

namespace ForceRewardsDetails;

[HarmonyPatch(typeof(QuestPartUtility), "GetRewardStackElementsForThings", typeof(IEnumerable<Thing>), typeof(bool))]
public class GetRewardStackElementsForThings_Patch
{
    public static void Prefix(ref IEnumerable<Thing> things, ref bool detailsHidden)
    {
        detailsHidden = false;
    }
}