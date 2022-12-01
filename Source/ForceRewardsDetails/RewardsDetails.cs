using System.Reflection;
using HarmonyLib;
using Verse;

namespace ForceRewardsDetails;

public class RewardsDetails : Mod
{
    public RewardsDetails(ModContentPack content)
        : base(content)
    {
        new Harmony("Vanya.Tools.ForceRewardsDetails").PatchAll(Assembly.GetExecutingAssembly());
        Log.Message("[ForceRewardsDetails] applied.");
    }
}
