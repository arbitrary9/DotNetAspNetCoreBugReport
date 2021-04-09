using DotNetAspNetCoreBugReport.Contracts.Dynamic;

namespace DotNetAspNetCoreBugReport.Controls.Dynamic
{
    public abstract class EntityModel<TEntity> : IEntityModel<TEntity>
        where TEntity : Entity, new()
    {
        
    }
}