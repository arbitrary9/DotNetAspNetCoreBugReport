namespace DotNetAspNetCoreBugReport.Contracts.Dynamic
{
    public interface IEntityModel<TEntity>
        where TEntity : Entity, new()
    {
        
    }
}