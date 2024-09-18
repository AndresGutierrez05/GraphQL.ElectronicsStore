using GraphQL.ElectronicsStore.API.Schema;
using GraphQL.ElectronicsStore.API.Services;
using Microsoft.EntityFrameworkCore;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);
string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContextFactory<ElectronicsStoreDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        builder =>
        {
            builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
        });
});

var app = builder.Build();
app.UseCors(MyAllowSpecificOrigins);
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ElectronicsStoreDbContext>();
    context.Database.Migrate();
}
app.UseRouting();
app.UseEndpoints(static endpoints =>
    {
        HotChocolate.AspNetCore.Extensions.GraphQLEndpointConventionBuilder graphQLEndpointConventionBuilder = endpoints.MapGraphQL();
    }
);
app.Run();