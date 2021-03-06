﻿using Ebooks.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ebooks.Data
{
    public class EbooksContext : DbContext
    {
        public virtual DbSet<Ebook> Ebooks { get; set; }
        public virtual DbSet<Page> Pages { get; set; }

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

            builder.Entity<Page>().HasData(
                new Page()
                {
                    EbookId = 1,
                    Id = 1,
                    PageNo = 1,
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean faucibus condimentum est ut vehicula. Fusce ornare, purus nec auctor malesuada, enim est porttitor justo, sed eleifend orci urna sed enim. Mauris volutpat enim sem, at aliquam libero interdum eget. Donec luctus nisl a mollis placerat. Nam scelerisque magna vel leo auctor, a dapibus ipsum eleifend. Nunc sodales bibendum consequat. Vivamus efficitur risus ac lacus elementum, sit amet condimentum tellus aliquet. In et mi ac nunc bibendum tincidunt sed a orci. Donec vel tortor et magna luctus laoreet ut et urna. Aliquam eu nulla efficitur, cursus enim gravida, rutrum diam. Morbi feugiat neque ac convallis auctor. Suspendisse magna arcu, rhoncus id dolor in, ullamcorper hendrerit velit. Curabitur tincidunt dui eget commodo elementum. Sed eu eleifend mauris. Donec non nisi eros.Aliquam erat arcu, tincidunt sodales tortor vel, lobortis fringilla nibh. Etiam eu tortor et magna ultricies suscipit. Cras scelerisque lorem nec nisl accumsan, in sagittis orci viverra. Ut sit amet urna urna. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin interdum augue at sapien viverra, sed cursus mauris dignissim. Aliquam erat volutpat. Aliquam sed massa sem. Donec id tempor odio, non hendrerit eros. Donec imperdiet eros non dignissim ornare. Aliquam vitae semper metus. Nunc eget dui nulla. Nulla facilisi."
                },
                new Page()
                {
                    EbookId = 1,
                    Id = 2,
                    PageNo = 2,
                    Content = "Phasellus luctus interdum massa at auctor. Praesent fermentum ipsum sit amet pulvinar tristique. Nullam venenatis et neque vitae iaculis. Donec ligula ex, vestibulum laoreet ipsum ut, consectetur cursus ex. Quisque molestie vulputate purus, in luctus nisi. Aliquam consequat, nulla quis tincidunt elementum, nunc felis convallis quam, in consectetur lacus elit ac dui. Quisque posuere tortor sed convallis rutrum. Nunc congue risus et ipsum convallis interdum. Sed ac bibendum nisl. Vestibulum molestie ut odio vel suscipit. Sed semper ac lacus in mollis. Ut non lacus arcu."
                },
                new Page()
                {
                    EbookId = 2,
                    Id = 3,
                    PageNo = 1,
                    Content = "Sed scelerisque scelerisque consequat. Curabitur placerat faucibus sem a luctus. Pellentesque malesuada aliquam scelerisque. Cras blandit ullamcorper est, eget tempus quam consectetur non. Suspendisse maximus gravida velit, eget ultricies nulla egestas vel. Mauris non scelerisque nibh. Sed dictum augue nibh, vitae mollis felis pharetra ac. Nam efficitur libero id urna commodo, sed bibendum lacus vulputate. Duis vitae dui laoreet, tincidunt turpis sed, bibendum erat. Donec rhoncus eget erat id viverra. Pellentesque dolor justo, faucibus ut lorem vitae, pulvinar varius libero. Nulla bibendum egestas lorem, ut lacinia diam tincidunt a. Vivamus eu justo at tellus tempus hendrerit id suscipit mi. Duis porttitor mauris et faucibus tempus."
                }
             );

            base.OnModelCreating(builder);
        }
    }
}
