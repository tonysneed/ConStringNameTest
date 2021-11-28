# Connection String Name Test

Reproduction of [issue 186](https://github.com/TrackableEntities/EntityFrameworkCore.Scaffolding.Handlebars/issues/186) in [EntityFrameworkCore.Scaffolding.Handlebars](https://github.com/TrackableEntities/EntityFrameworkCore.Scaffolding.Handlebars).

### From WebApplication1 directory:

```
dotnet ef dbcontext scaffold "Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=NorthwindSlim; Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -o Models -c NorthwindSlimContext -f --context-dir ../WebApplication1.Dal/Contexts --project ../WebApplication1.Dal
```

```
dotnet ef dbcontext scaffold "Name=ConnectionStrings:NorthwindSlimContext" Microsoft.EntityFrameworkCore.SqlServer -o Models -c NorthwindSlimContext -f --context-dir ../WebApplication1.Dal/Contexts --project ../WebApplication1.Dal
```

### From WebApplication1.Dal directory:

```
dotnet ef dbcontext scaffold "Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=NorthwindSlim; Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -o Models --context-dir Contexts -c NorthwindSlimContext -f --startup-project ../WebApplication1
```

```
dotnet ef dbcontext scaffold "Name=ConnectionStrings:NorthwindSlimContext" Microsoft.EntityFrameworkCore.SqlServer -o Models --context-dir Contexts -c NorthwindSlimContext -f --startup-project ../WebApplication1
```
