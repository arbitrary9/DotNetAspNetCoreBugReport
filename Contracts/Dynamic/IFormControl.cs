namespace DotNetAspNetCoreBugReport.Contracts.Dynamic
{
    public interface IFormControl<TFormModel, TEntityModel, TEntity>
        where TFormModel : IFormModel<TEntityModel, TEntity>, new()
        where TEntityModel : IEntityModel<TEntity>, new()
        where TEntity : Entity, new()
    {
        TFormModel FormModel { get; set; }
    }
}