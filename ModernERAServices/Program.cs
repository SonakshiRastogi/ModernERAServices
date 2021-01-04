using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace ModernERAServices
{
    public class Program
	{
		public static void Main(string[] args)
		{
			CreateWebHostBuilder(args).Build().Run();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseKestrel(options =>
				{
					options.Limits.MaxRequestBodySize = null;
					options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(30);
				})
			.UseUrls("https://0.0.0.0:" + Environment.GetEnvironmentVariable("PORT"))
			.UseStartup<Startup>();
	}
}
