using DotNetAspNetCoreBugReport.Contracts.Dynamic;

namespace DotNetAspNetCoreBugReport.Controls.Dynamic
{
    public abstract class FormModel<TEntityModel, TEntity> : IFormModel<TEntityModel, TEntity>
        where TEntityModel : IEntityModel<TEntity>, new()
        where TEntity : Entity, new()
    {
        
    }
}