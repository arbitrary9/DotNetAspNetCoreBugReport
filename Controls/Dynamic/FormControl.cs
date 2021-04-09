using DotNetAspNetCoreBugReport.Contracts.Dynamic;

namespace DotNetAspNetCoreBugReport.Controls.Dynamic
{
    public abstract class FormControl<TFormModel, TEntityModel, TEntity> : IFormControl<TFormModel, TEntityModel, TEntity>
        where TFormModel : IFormModel<TEntityModel, TEntity>, new()
        where TEntityModel : IEntityModel<TEntity>, new()
        where TEntity : Entity, new()
    {
        public TFormModel FormModel { get; set; }
    }
}