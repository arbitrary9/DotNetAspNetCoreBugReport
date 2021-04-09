namespace DotNetAspNetCoreBugReport.Contracts.Dynamic
{
    public interface IFormModel<TEntityModel, TEntity>
        where TEntityModel : IEntityModel<TEntity>, new()
        where TEntity : Entity, new()
    {
        
    }
}