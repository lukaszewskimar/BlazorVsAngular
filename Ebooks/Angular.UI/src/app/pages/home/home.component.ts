import { Component, OnInit } from '@angular/core';
import { HttpClient } from "@angular/common/http"

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {

  ebooks: any = []
  loading: boolean = true

  constructor(
    private http: HttpClient
  ) { }

  ngOnInit(): void {
    const response = this.http.get('http://localhost:52035/ebooks');
    response.subscribe({
      next: (items) => {
        this.ebooks = items;
      },
      error: (error) => {
        console.error(error);
      },
      complete: () => {
        this.loading = false;
      }
    })
  }

}
