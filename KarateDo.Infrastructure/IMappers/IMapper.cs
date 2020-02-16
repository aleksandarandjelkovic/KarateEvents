namespace KarateDo.Infrastructure.IMappers
{
    /// <summary>
    /// To way mapper
    /// </summary>
    /// <typeparam name="TFrom">From type</typeparam>
    /// <typeparam name="TTo">To type</typeparam>
    public interface IMapper<TFrom, TTo>
    {
        TTo To(TFrom type);

        TFrom From(TTo type);
    }

    /// <summary>
    /// Two way mapper with additonal into method to allow an existing object to be updated from 
    /// another object. 
    /// </summary>
    /// <typeparam name="TFrom">From type</typeparam>
    /// <typeparam name="TTo">To type</typeparam>
    public interface IIntoMapper<TFrom, TTo> : IMapper<TFrom, TTo>
    {
        TTo Into(TTo intoType, TFrom vm);
    }

    /// <summary>
    /// One way mapper to map from one type to another
    /// </summary>
    /// <typeparam name="TFrom">From type</typeparam>
    /// <typeparam name="TTo">To type</typeparam>
    public interface IFromMapper<in TFrom, out TTo>
    {
        TTo From(TFrom type);
    }
}
