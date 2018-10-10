namespace MrxEE_SendUtil.Configuration
{
    using System;
    using System.Configuration;

    /// <summary>
    /// The group blacklist.
    /// </summary>
    public class GroupBlacklist : ConfigurationElementCollection
    {
        /// <summary>Gets the type of the <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
        /// <returns>The <see cref="T:System.Configuration.ConfigurationElementCollectionType" /> of this collection.</returns>
        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        /// <summary>Gets the name used to identify this collection of elements in the configuration file when overridden in a derived class.</summary>
        /// <returns>The name of the collection; otherwise, an empty string. The default is an empty string.</returns>
        protected override string ElementName
        {
            get { return "balcklist"; }
        }

        /// <summary>
        /// The black list collection indexer.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// The <see cref="BlackListItem"/>.
        /// </returns>
        public BlackListItem this[int index]
        {
            get
            {
                return (BlackListItem)this.BaseGet(index);
            }
            set
            {
                if (this.BaseGet(index) != null)
                {
                    this.BaseRemoveAt(index);
                }
                this.BaseAdd(index, value);
            }
        }

        /// <summary>
        /// The black list collection itemizer.
        /// </summary>
        /// <param name="groupId">
        /// The group id.
        /// </param>
        /// <returns>
        /// The <see cref="BlackListItem"/>.
        /// </returns>
        public new BlackListItem this[string groupId]
        {
            get
            {
                return (BlackListItem)this.BaseGet(groupId);
            }
        }

        /// <summary>
        /// The index of.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int IndexOf(BlackListItem item)
        {
            return this.BaseIndexOf(item);
        }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        public void Add(BlackListItem item)
        {
            this.BaseAdd(item);
        }

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        public void Remove(BlackListItem item)
        {
            if (this.BaseIndexOf(item) >= 0)
            {
                this.BaseRemove(item.GroupId);
            }
        }

        /// <summary>
        /// The remove at.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        public void RemoveAt(int index)
        {
            this.BaseRemoveAt(index);
        }

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="groupId">
        /// The group id.
        /// </param>
        public void Remove(string groupId)
        {
            this.BaseRemove(groupId);
        }

        /// <summary>
        /// The clear.
        /// </summary>
        public void Clear()
        {
            this.BaseClear();
        }

        /// <summary>When overridden in a derived class, creates a new <see cref="T:System.Configuration.ConfigurationElement" />.</summary>
        /// <returns>A newly created <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new BlackListItem();
        }

        /// <summary>Gets the element key for a specified configuration element when overridden in a derived class.</summary>
        /// <returns>An <see cref="T:System.Object" /> that acts as the key for the specified <see cref="T:System.Configuration.ConfigurationElement" />.</returns>
        /// <param name="element">The <see cref="T:System.Configuration.ConfigurationElement" /> to return the key for. </param>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((BlackListItem)element).GroupId;
        }

        /// <summary>Adds a configuration element to the <see cref="T:System.Configuration.ConfigurationElementCollection" />.</summary>
        /// <param name="element">The <see cref="T:System.Configuration.ConfigurationElement" /> to add.</param>
        protected override void BaseAdd(ConfigurationElement element)
        {
            this.BaseAdd(element, false);
        }
    }
}