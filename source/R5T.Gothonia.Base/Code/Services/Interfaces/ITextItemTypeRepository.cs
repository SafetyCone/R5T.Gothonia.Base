using System;

using R5T.Siscia;


namespace R5T.Gothonia
{
    public interface ITextItemTypeRepository
    {
        TextItemTypeIdentity New();
        TextItemTypeIdentity New(string name);

        /// <summary>
        /// Returns void to indicate that the identity of the input must be set.
        /// </summary>
        void Add(TextItemType textItemType);

        bool Exists(TextItemTypeIdentity identity);
        bool Exists(string name);

        TextItemTypeIdentity GetIdentity(string name);
        TextItemType Get(string name);

        TextItemType Get(TextItemTypeIdentity identity);

        void SetName(TextItemTypeIdentity identity, string name);
        string GetName(TextItemTypeIdentity identity);

        void Delete(TextItemTypeIdentity identity);
    }
}
