using System;

using R5T.Siscia;


namespace R5T.Gothonia
{
    public interface ITextItemRepository
    {
        TextItemIdentity New();
        TextItemIdentity New(TextItemTypeIdentity typeIdentity, string value);

        TextItemIdentity Add(TextItem textItem);

        bool Exists(TextItemIdentity identity);

        void SetItemType(TextItemIdentity identity, TextItemTypeIdentity typeIdentity);
        TextItemTypeIdentity GetItemType(TextItemIdentity identity);

        void SetValue(TextItemIdentity identity, string value);
        string GetValue(TextItemIdentity identity);

        void Delete(TextItemIdentity identity);
    }
}
