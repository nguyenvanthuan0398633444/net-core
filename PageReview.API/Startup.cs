using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PageReview.API.DbContext;
using PageReview.BAL;
using PageReview.BAL.Interface;
using PageReview.DAL;
using PageReview.DAL.Interface;
using PageReview.Domain;

namespace PageReview.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(swagger => {
                ////This is to generate the Default UI of Swagger Documentation  
                //swagger.SwaggerDoc("v1", new OpenApiInfo
                //{
                //    Version = "v1",
                //    Title = "JWT Token Authentication API",
                //    Description = "ASP.NET Core 3.1 Web API"
                //});
                //// To Enable authorization using Swagger (JWT)  
                //swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                //{
                //    Name = "Authorization",
                //    Type = SecuritySchemeType.ApiKey,
                //    Scheme = "Bearer",
                //    BearerFormat = "JWT",
                //    In = ParameterLocation.Header,
                //    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                //});
                //swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
                //{
                //    {
                //          new OpenApiSecurityScheme
                //            {
                //                Reference = new OpenApiReference
                //                {
                //                    Type = ReferenceType.SecurityScheme,
                //                    Id = "Bearer"
                //                }
                //            },
                //            new string[] {}

                //    }
                //});

            });

            services.AddScoped<UserManager<ApplicationUser>, UserManager<ApplicationUser>>();
            services.AddScoped<SignInManager<ApplicationUser>, SignInManager<ApplicationUser>>();
            services.AddScoped<RoleManager<IdentityRole>, RoleManager<IdentityRole>>();

            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IBrandRepository, BrandRepository>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ICommentService, CommentService>();
            
            services.AddScoped<IReplyRepository, ReplyRepository>();
            services.AddScoped<IReplyService, ReplyService>();
            
            services.AddScoped<IVoteRepository, VoteRepository>();
            services.AddScoped<IVoteService, VoteService>();

            services.AddScoped<IGetAllRepository, GetAllRepository>();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PageReviewConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //string issuer = Configuration.GetValue<string>("Tokens:Issuer");
            //string signingKey = Configuration.GetValue<string>("Tokens:Key");
            //byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);

            //services.AddAuthentication(opt =>
            //{
            //    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(options =>
            //{
            //    options.RequireHttpsMetadata = false;
            //    options.SaveToken = true;
            //    options.TokenValidationParameters = new TokenValidationParameters()
            //    {
            //        ValidateIssuer = true,
            //        ValidIssuer = issuer,
            //        ValidateAudience = true,
            //        ValidAudience = issuer,
            //        ValidateLifetime = true,
            //        ValidateIssuerSigningKey = true,
            //        ClockSkew = System.TimeSpan.Zero,
            //        IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
            //    };
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Page Review");
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
