using System;

using R5T.Siscia;


namespace R5T.Gothonia
{
    public interface ITextItemTypeRepository
    {
        TextItemTypeIdentity New();
        TextItemTypeIdentity New(string name);

        void Add(TextItemType textItemType);

        bool Exists(TextItemTypeIdentity identity);

        TextItemType Get(TextItemTypeIdentity identity);

        void SetName(TextItemTypeIdentity identity, string name);
        string GetName(TextItemTypeIdentity identity);

        void Delete(TextItemTypeIdentity identity);
    }
}
