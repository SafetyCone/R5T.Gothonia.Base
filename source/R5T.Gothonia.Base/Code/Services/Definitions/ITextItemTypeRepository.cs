using System;
using System.Threading.Tasks;

using R5T.Siscia;

using R5T.T0064;


namespace R5T.Gothonia
{
    [ServiceDefinitionMarker]
    public interface ITextItemTypeRepository : IServiceDefinition
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
