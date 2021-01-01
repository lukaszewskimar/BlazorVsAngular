using Ebooks.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ebooks.Data
{
    public class EbooksContext : DbContext
    {
        public virtual DbSet<Ebook> Ebooks { get; set; }

        public EbooksContext(DbContextOptions<EbooksContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Ebook>().HasData(
                new Ebook
                {
                    Id = 1,
                    Name = "Microsoft Blazor: Building Web Applications in .NET",
                    Description = "Build web applications in C# and Microsoft .NET that run in any modern browser. This second edition is updated to work with the release version of Blazor and covers Blazor’s use in creating both server-side and WebAssembly Blazor applications",
                    Author = "Peter Himschoot"
                },
                new Ebook
                {
                    Id = 2,
                    Name = "Building Single Page Applications in .NET Core 3: Jumpstart Coding Using Blazor and C#",
                    Description = "Attention .NET developers who no longer want to use JavaScript for your front end. Quickly and efficiently learn how to use C# for your single-page application (SPA) thanks to Blazor",
                    Author = "Michele Aponte"
                },
                new Ebook
                {
                    Id = 3,
                    Name = "Pro ASP.NET Core 3: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages",
                    Description = "Now in its 8th edition, Pro ASP.NET Core has been thoroughly updated for ASP.NET Core 3 and online for ASP.NET Core 5 and .NET 5.0. This comprehensive, full-color guide is the only book you need to learn ASP.NET Core development.",
                    Author = "Adam Freeman"
                }
            );

            base.OnModelCreating(builder);
        }
    }
}
