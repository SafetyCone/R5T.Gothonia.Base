using System;

using R5T.Magyar;
using R5T.Siscia;


namespace R5T.Gothonia
{
    public static class ITextItemRepositoryExtensions
    {
        public static void Append(this ITextItemRepository repository, TextItemIdentity identity, string appendix, string separator = StringHelper.Empty)
        {
            var value = repository.GetValue(identity);

            var newValue = $"{value}{separator}{appendix}";

            repository.SetValue(identity, newValue);
        }

        public static bool Exists(this ITextItemRepository repository, Guid identity)
        {
            var textItemIdentity = TextItemIdentity.From(identity);

            var exists = repository.Exists(textItemIdentity);
            return exists;
        }
    }
}
