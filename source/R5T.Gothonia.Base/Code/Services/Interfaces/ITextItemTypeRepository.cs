using System;
using System.Threading.Tasks;

using R5T.Siscia;


namespace R5T.Gothonia
{
    public interface ITextItemTypeRepository
    {
        Task<TextItemTypeIdentity> New();
        Task<TextItemTypeIdentity> New(string name);

        /// <summary>
        /// Returns void to indicate that the identity of the input must be set.
        /// </summary>
        Task Add(TextItemType textItemType);

        Task<bool> Exists(TextItemTypeIdentity identity);
        Task<bool> Exists(string name);

        Task<TextItemTypeIdentity> GetIdentity(string name);
        Task<TextItemType> Get(string name);

        Task<TextItemType> Get(TextItemTypeIdentity identity);

        Task SetName(TextItemTypeIdentity identity, string name);
        Task<string> GetName(TextItemTypeIdentity identity);

        Task Delete(TextItemTypeIdentity identity);
    }
}
