using ModSettings;
using System.Reflection;

namespace HMSRedux
{
    internal class HMSSettings : JsonModSettings
    {
        [Name("Not-So-Good Soup")]
        [Description("Enables/disables the homemade soup nerf.")]
        public bool badSoup = true;

        [Name("Variably-Good Soup (Overrides Not-So-Good Soup)")]
        [Description("Enables/disables a custom addend to the calorie value of soup (negative reduces).")]
        public bool varSoup = false;

        [Name("Soup-It-Yourself (Applies after restart)")]
        [Description("Addend the caloric value of soup using a positive (buff) or negative (debuff) number.")]
        [Slider(-500f, 500f)]
        public float slideSoup = -200f;

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if(field.Name == nameof(varSoup))
            {
                SetFieldVisible("slideSoup", varSoup);
            }
        }
    }
    internal class Settings
    {
        public static HMSSettings option;
        public static void onLoad()
        {
            option = new HMSSettings();
            option.AddToModSettings("Home Made Soup Redux Settings", MenuType.Both);
        }
    }
}
