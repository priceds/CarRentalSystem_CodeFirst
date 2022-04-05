using CarRentalSystem.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NLog;
using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),
 "/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureCors();
            services.ConfigureIISIntegration();
            services.ConfigureLoggerService();

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();

            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminService, AdminService>();

            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IBookingService, BookingService>();

            services.AddScoped<IDriverRepository, DriverRepository>();
            services.AddScoped<IDriverService, DriverService>();

            services.AddScoped<ICarRepository, CarRespository>();
            services.AddScoped<ICarService, CarService>();

            services.AddScoped<IDriverReviewRepository, DriverReviewRepository>();
            services.AddScoped<IDriverReviewService, DriverReviewService>();

    

            services.AddScoped<ICarReviewRepository, CarReviewRepository>();
            services.AddScoped<ICarReviewService, CarReviewService>();

            services.AddScoped<IDriverReviewRepository, DriverReviewRepository>();
            services.AddScoped<IDriverReviewService, DriverReviewService>();

            services.AddScoped<IJourneyCompletionRepository, JourneyCompletionRepository>();
            services.AddScoped<IJourneyCompletionService, JourneyCompletionService>();

            services.AddScoped<IReceiptRepository, ReceiptRepository>();
            services.AddScoped<IReceiptService, ReceiptService>();

            services.AddScoped<ITripReviewRepository, TripReviewRepository>();
            services.AddScoped<ITripReviewService, TripReviewService>();
            services.AddDbContext<CarRentalDbContext>(options => options.UseSqlServer(this.Configuration.GetConnectionString("sqlConnection")));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CarRentalSystem", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarRentalSystem v1"));
            }
            else
            {
                app.UseHsts();

            }
            app.UseStaticFiles();
            app.UseCors("CorsPolicy");
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
