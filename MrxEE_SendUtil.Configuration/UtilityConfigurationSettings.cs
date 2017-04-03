namespace MrxEE_SendUtil.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UtilityConfigurationSettings : ConfigurationSection
    {
        private static UtilityConfigurationSettings settings =
            ConfigurationManager.GetSection("UtilityConfiguration") as UtilityConfigurationSettings;

        
    }
}
