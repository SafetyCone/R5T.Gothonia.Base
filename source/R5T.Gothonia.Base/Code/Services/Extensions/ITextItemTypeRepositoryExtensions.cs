using System;
using System.Threading.Tasks;

using R5T.Siscia;


namespace R5T.Gothonia
{
    public static class ITextItemTypeRepositoryExtensions
    {
        public static async Task<TextItemType> Acquire(this ITextItemTypeRepository repository, string name)
        {
            var exists = await repository.Exists(name);

            var identity = exists
                ? await repository.GetIdentity(name)
                : await repository.New(name);

            var output = new TextItemType()
            {
                Identity = identity,
                Name = name,
            };
            return output;
        }

        public static async Task<bool> Exists(this ITextItemTypeRepository repository, Guid identity)
        {
            var textItemTypeIdentity = TextItemTypeIdentity.From(identity);

            var exists = await repository.Exists(textItemTypeIdentity);
            return exists;
        }
    }
}
