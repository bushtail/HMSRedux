using MelonLoader;
using UnityEngine;

namespace HMSRedux
{
    internal class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            Settings.onLoad();

            Debug.Log("[homemadesoup_redux] loaded.");
        }
        internal static void Apply(GearItem gear)
        {
            string name = gear.name.ToLower();
            if(gear.m_FoodItem)
            {
                if(name.Contains("homemadesoup"))
                {
                    if(Settings.option.varSoup)
                    {
                        gear.m_FoodItem.m_CaloriesTotal += Settings.option.slideSoup;
                        gear.m_FoodItem.m_CaloriesRemaining += Settings.option.slideSoup;
                    }
                    else
                    {
                        if (Settings.option.badSoup)
                        {
                            gear.m_FoodItem.m_CaloriesTotal += -200f;
                            gear.m_FoodItem.m_CaloriesRemaining += -200f;
                        }
                    }
                }
            }
        }
    }
}
