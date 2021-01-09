import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {

  ebooks = [
    {
      id: 1,
      name: 'Microsoft Blazor: Building Web Applications in .NET',
      description: 'Build web applications in C# and Microsoft .NET that run in any modern browser. This second edition is updated to work with the release version of Blazor and covers Blazor’s use in creating both server-side and WebAssembly Blazor applications',
      author: 'Peter Himschoot'
    },
    {
      id: 2,
      name: 'Building Single Page Applications in .NET Core 3: Jumpstart Coding Using Blazor and C#',
      description: 'Attention .NET developers who no longer want to use JavaScript for your front end. Quickly and efficiently learn how to use C# for your single-page application (SPA) thanks to Blazor',
      author: 'Michele Aponte'
    },
    {
      id: 3,
      name: 'Pro ASP.NET Core 3: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages',
      description: 'Now in its 8th edition, Pro ASP.NET Core has been thoroughly updated for ASP.NET Core 3 and online for ASP.NET Core 5 and .NET 5.0. This comprehensive, full-color guide is the only book you need to learn ASP.NET Core development.',
      author: 'Adam Freeman'
    }
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
