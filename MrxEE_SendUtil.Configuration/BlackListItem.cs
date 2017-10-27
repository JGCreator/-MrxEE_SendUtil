namespace MrxEE_SendUtil.Configuration
{
    using System.Configuration;

    /// <summary>
    /// The black list item.
    /// </summary>
    public class BlackListItem : ConfigurationElement
    {
        /// <summary>
        /// Gets or sets the group id.
        /// </summary>
        [ConfigurationProperty("groupId")]
        public string GroupId
        {
            get
            {
                return base["groupId"] as string;
            }

            set
            {
                base["groupId"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the group name.
        /// </summary>
        [ConfigurationProperty("groupName")]
        public string GroupName
        {
            get
            {
                return base["groupName"] as string;
            }

            set
            {
                base["groupName"] = value;
            }
        }
    }
}