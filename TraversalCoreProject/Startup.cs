using BusinessLayer.Container;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;
using TraversalCoreProject.CQRS.Handlers;
using TraversalCoreProject.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProject.Models;

namespace TraversalCoreProject
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
			services.AddScoped<GetAllDestinationQueryHandler>();
			services.AddScoped<GetDestinationByIdQueryHandler>();
			services.AddScoped<GetAllDestinationQueryHandler>();
			services.AddScoped<CreateDestinationCommandHandler>();
			services.AddScoped<DeleteDestinationCommandHandler>();
			services.AddScoped<UpdateDestinationCommandHandler>();

			services.AddMediatR(typeof(Startup));


			services.AddLogging(x =>
			{
				x.ClearProviders();
				x.SetMinimumLevel(LogLevel.Debug);
				x.AddDebug();
			});

			services.AddDbContext<Context>();
			services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<Context>();

			services.AddHttpClient();

			services.ContainerDependencies();

			services.AddAutoMapper(typeof(Startup));
			services.CustomValidator();

			services.AddControllersWithViews().AddFluentValidation();

			services.AddControllersWithViews();

			services.AddMvc(config =>
			{
				var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
				config.Filters.Add(new AuthorizeFilter(policy));
			});

			services.AddLocalization(opt =>
			{
				opt.ResourcesPath = "Resources";
			});

			services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();

			services.ConfigureApplicationCookie(options =>
			{
				options.LoginPath = "/Login/SignIn/";
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
		{
			var path = Directory.GetCurrentDirectory();
			loggerFactory.AddFile($"{path}\\Logs\\Log1.txt");

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseAuthentication();
			app.UseRouting();

			app.UseAuthorization();

			var suppotedCultures = new[] { "en", "fr", "es", "gr", "tr", "de" };
			var localizationOptions=new RequestLocalizationOptions().SetDefaultCulture(suppotedCultures[4]).AddSupportedCultures(suppotedCultures).AddSupportedUICultures(suppotedCultures);
			app.UseRequestLocalization(localizationOptions);

			app.Use(async (context, next) =>
			{
				var cultureQuery = context.Request.Cookies["culture"];
				if (!string.IsNullOrEmpty(cultureQuery))
				{
					var culture = new System.Globalization.CultureInfo(cultureQuery);
					System.Globalization.CultureInfo.CurrentCulture = culture;
					System.Globalization.CultureInfo.CurrentUICulture = culture;
				}
				await next();
			});

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Default}/{action=Index}/{id?}");
			});

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
				  name: "areas",
				  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
				);
			});

			

		}
	}
}
