using System;

using R5T.Siscia;


namespace R5T.Gothonia
{
    public static class ITextItemTypeRepositoryExtensions
    {
        public static TextItemType Acquire(this ITextItemTypeRepository repository, string name)
        {
            var exists = repository.Exists(name);

            var identity = exists ? repository.GetIdentity(name) : repository.New(name);

            var output = new TextItemType()
            {
                Identity = identity,
                Name = name,
            };
            return output;
        }

        public static bool Exists(this ITextItemTypeRepository repository, Guid identity)
        {
            var textItemTypeIdentity = TextItemTypeIdentity.From(identity);

            var exists = repository.Exists(textItemTypeIdentity);
            return exists;
        }
    }
}
