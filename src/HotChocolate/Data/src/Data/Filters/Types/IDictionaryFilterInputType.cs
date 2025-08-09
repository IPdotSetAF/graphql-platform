using HotChocolate.Data.Filters.Expressions;

namespace HotChocolate.Data.Filters;

/// <summary>
/// Marks a <see cref="FilterInputType"/> as an <see cref="DictionaryFilterInputType{T1,T2}"/>.
/// This is makes the identification and the mapping of a comparable types on
/// <see cref="FilterOperationHandler{TContext,T}"/> easier.
/// <example><see cref="QueryableDictionaryAnyOperationHandler"/></example>
/// </summary>
public interface IDictionaryFilterInputType
{
}
