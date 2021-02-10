using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Siscia;


namespace R5T.Gothonia
{
    public interface ITextItemRepository
    {
        Task<TextItemIdentity> New();
        Task<TextItemIdentity> New(TextItemTypeIdentity typeIdentity, string value);

        Task<TextItemIdentity> Add(TextItem textItem);

        Task<bool> Exists(TextItemIdentity identity);

        Task SetItemType(TextItemIdentity identity, TextItemTypeIdentity typeIdentity);
        Task<TextItemTypeIdentity> GetItemType(TextItemIdentity identity);

        Task SetValue(TextItemIdentity identity, string value);
        Task<string> GetValue(TextItemIdentity identity);

        Task Delete(TextItemIdentity identity);

        Task<List<(string TypeName, string Value)>> GetTypedValuePairs(IEnumerable<TextItemIdentity> textItemIdentities);
    }
}
