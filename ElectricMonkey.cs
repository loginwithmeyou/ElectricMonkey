using MelonLoader;
using BTD_Mod_Helper;
using ElectricMonkey;

[assembly: MelonInfo(typeof(ElectricMonkey.ElectricMonkey), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace ElectricMonkey;

public class ElectricMonkey : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<ElectricMonkey>("ElectricMonkey loaded!");
    }
}

