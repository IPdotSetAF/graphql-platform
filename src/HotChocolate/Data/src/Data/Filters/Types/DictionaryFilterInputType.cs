namespace HotChocolate.Data.Filters;

public class DictionaryFilterInputType<TKey,TValue>
    : FilterInputType
    , IDictionaryFilterInputType
    where TValue : FilterInputType
{
    protected override void Configure(IFilterInputTypeDescriptor descriptor)
    {
        descriptor.Field("Key").Type(typeof(TKey));
        descriptor.Field("Value").Type(typeof(TValue));
        descriptor.AllowAnd(true).AllowOr(true);
    }
}
