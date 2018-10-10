namespace MrxEE_SendUtil.Configuration
{
    using System.Configuration;

    /// <summary>
    /// The input output.
    /// </summary>
    public class InputOutput : ConfigurationElement
    {
        /// <summary>
        /// Gets or sets the input directory.
        /// </summary>
        [ConfigurationProperty("inputDir")]
        public string InputDir
        {
            get
            {
                return base["inputDir"] as string;
            }

            set
            {
                base["inputDir"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the output directory.
        /// </summary>
        [ConfigurationProperty("outputDir")]
        public string OutputDir
        {
            get
            {
                return base["outputDir"] as string;
            }

            set
            {
                base["outputDir"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the archive directory.
        /// </summary>
        [ConfigurationProperty("archiveDir")]
        public string ArchiveDir
        {
            get
            {
                return base["archiveDir"] as string;
            }

            set
            {
                base["archiveDir"] = value;
            }
        }
    }
}