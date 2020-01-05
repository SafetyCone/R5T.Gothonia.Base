using System;
using System.Threading.Tasks;

using R5T.Magyar;
using R5T.Siscia;


namespace R5T.Gothonia
{
    public static class ITextItemRepositoryExtensions
    {
        public static async Task Append(this ITextItemRepository repository, TextItemIdentity identity, string appendix, string separator = StringHelper.Empty)
        {
            var value = repository.GetValue(identity);

            var newValue = $"{value}{separator}{appendix}";

            await repository.SetValue(identity, newValue);
        }

        public static async Task<bool> Exists(this ITextItemRepository repository, Guid identity)
        {
            var textItemIdentity = TextItemIdentity.From(identity);

            var exists = await repository.Exists(textItemIdentity);
            return exists;
        }
    }
}
