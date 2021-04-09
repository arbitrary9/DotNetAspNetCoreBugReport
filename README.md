# DotNetAspNetCoreBugReport
error CS0246: The type or namespace name 'FormControl&lt;,,>' could not be found<br/>
error CS0246: The type or namespace name 'FormModel&lt;,>' could not be found<br/>
error CS0246: The type or namespace name 'EntityModel&lt;>' could not be found<br/>

run project: dotnet watch run

# I think that bug actually is because Using Alias like this 
```
DotNetAspNetCoreBugReport.Controls.Dynamic.Product.ProductFormControl.cs : 1-3
```
```
using Prd = DotNetAspNetCoreBugReport.Entities.Product;<br/>
using PrdEntityModel = DotNetAspNetCoreBugReport.Controls.Dynamic.Product.ProductEntityModel;<br/>
using PrdFormModel = DotNetAspNetCoreBugReport.Controls.Dynamic.Product.ProductFormModel;<br/>
```
# bug reported 
https://github.com/dotnet/aspnetcore/issues/31636
