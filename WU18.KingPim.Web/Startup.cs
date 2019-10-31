using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WU18.KingPim.Data.DataAccess;
using WU18.KingPim.Entities.Mappings;
using WU18.KingPim.Entities.Repositories;

namespace WU18.KingPim.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddMvc();

            services.AddDbContext<KingPimContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("WU18.KingPimConnection")));
            //AutoMapper profile start
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            //AutoMapper profile end
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, KingPimContext ctx)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            Seeder.FillDbIfEmpty(ctx);

        }

        
    }
}