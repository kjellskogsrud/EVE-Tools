// <copyright file="Program.cs" company="Kjell Skogsrud">
// Copyright (c) Kjell Skogsrud. BSD 3-Clause License
// </copyright>

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace EVE_Tools
{
    /// <summary>
    /// The Program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The Main method. This is where the program begins.
        /// </summary>
        /// <param name="args">An array of strings. The arguments passed to the executable.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Gets the <see cref="IHostBuilder"/>.
        /// </summary>
        /// <param name="args">Pass the arguments from the main method.</param>
        /// <returns><see cref="IHostBuilder"/>.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
