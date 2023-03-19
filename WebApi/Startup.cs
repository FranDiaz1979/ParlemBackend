//namespace WebApi
//{
//    using Microsoft.AspNetCore.Builder;
//    using Microsoft.AspNetCore.Hosting;
//    using Microsoft.EntityFrameworkCore;
//    using Microsoft.Extensions.Configuration;
//    using Microsoft.Extensions.DependencyInjection;
//    using Microsoft.Extensions.Hosting;
//    using SQLiteDatabase;
//    using System;

//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddDbContext<ParlemDbContext>(options =>
//                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
//        }


//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            // Configura la aplicación
//        }
//    }

//}
