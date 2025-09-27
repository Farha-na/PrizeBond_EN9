using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DAL.DataContext;
using DAL.Interfaces;
using DAL.Repositories;

namespace DAL
{
    public static class DALServiceCollectionExtensions
    {
        public static IServiceCollection AddDAL(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<db_prizebond_DBContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("SchoolConnection")
                    , b => b.MigrationsAssembly("DAL")
                    ));

            services.AddScoped<IBondOwnedRepository, BondOwnedRepository>();

            //services.AddDbContext<specfo_DBContext>(options =>
            //        options.UseSqlServer(configuration.GetConnectionString("SpecfoConnection")
            //        , b => b.MigrationsAssembly("DAL")
            //        ));

            //Register Repositories
            //services.AddScoped<IStudentRepository, StudentRepository>();
            //services.AddScoped<IReportRepository, ReportRepository>();
            //services.AddScoped<IFrontDeskRepository, FrontDeskRepository>();
            //services.AddScoped<IMasterSetupRepository, MasterSetupRepository>();
            //services.AddScoped<IComplaintRepository, ComplaintRepository>();
            //services.AddScoped<IStudentAdmissionRepository, StudentAdmissionRepository>();

            return services;
        }
    }
}