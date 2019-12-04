using System;

using R5T.Siscia;


namespace R5T.Gothonia
{
    public static class ITextItemTypeRepositoryExtensions
    {
        public static bool Exists(this ITextItemTypeRepository repository, Guid identity)
        {
            var textItemTypeIdentity = TextItemTypeIdentity.From(identity);

            var exists = repository.Exists(textItemTypeIdentity);
            return exists;
        }
    }
}
