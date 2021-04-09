using Prd = DotNetAspNetCoreBugReport.Entities.Product;
using PrdEntityModel = DotNetAspNetCoreBugReport.Controls.Dynamic.Product.ProductEntityModel;
using PrdFormModel = DotNetAspNetCoreBugReport.Controls.Dynamic.Product.ProductFormModel;

namespace DotNetAspNetCoreBugReport.Controls.Dynamic.Product
{
    public class ProductFormControl : FormControl<PrdFormModel ,PrdEntityModel, Prd>
    {
        
    }
}