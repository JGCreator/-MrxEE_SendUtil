namespace MrxEE_SendUtil.Configuration
{
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The utility configuration section.
    /// </summary>
    public class UtilityConfigurationSection : ConfigurationSection
    {
        /// <summary>
        /// Gets the settings.
        /// </summary>
        public static UtilityConfigurationSection Settings { get; } = ConfigurationManager.GetSection("UtilityConfiguration") as UtilityConfigurationSection;

        /// <summary>
        /// Gets or sets the blacklist.
        /// </summary>
        [ConfigurationProperty("blacklist")]
        public GroupBlacklist Blacklist
        {
            get
            {
                return base["blacklist"] as GroupBlacklist;
            }

            set
            {
                base["blacklist"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the input output settings.
        /// </summary>
        [ConfigurationProperty("input_output")]
        public InputOutput InputOutputSettings
        {
            get
            {
                return base["input_output"] as InputOutput;
            }

            set
            {
                base["input_output"] = value;
            }
        }
    }
}
