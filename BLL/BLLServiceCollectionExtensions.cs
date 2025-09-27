using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

//using BLL.Interfaces;
using BLL.Services;
using DAL; // BLL can reference DAL

namespace BLL
{
    public static class BLLServiceCollectionExtensions
    {
        public static IServiceCollection AddBLL(this IServiceCollection services, IConfiguration configuration)
        {
            // 1. Register DAL (DbContext + Repositories)
            services.AddDAL(configuration); // internal DAL reference inside BLL

            // 2. Register BLL services
            //services.AddScoped<IStudentService, StudentService>();
            //services.AddScoped<IReportService, ReportService>();
            //services.AddScoped<IFrontDeskService, FrontDeskService>();
            //services.AddScoped<IMasterSetupService, MasterSetupService>();
            //services.AddScoped<IComplaintService, ComplaintService>();
            //services.AddScoped<IStudentAdmissionService, StudentAdmissionService>();

            // Add other BLL services here

            return services;
        }
    }
}