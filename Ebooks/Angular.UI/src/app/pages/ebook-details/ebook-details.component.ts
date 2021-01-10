import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from "@angular/common/http"

@Component({
  selector: 'app-ebook-details',
  templateUrl: './ebook-details.component.html'
})
export class EbookDetailsComponent implements OnInit {
  ebook: any = {}
  loading: boolean = true

  constructor(
    private route: ActivatedRoute,
    private http: HttpClient
  ) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(params=>{
      var ebookId = params.get('ebook_id')
      const response = this.http.get('http://localhost:52035/ebooks/'+ ebookId);
      response.subscribe({
        next: (item) => {
          this.ebook = item;
        },
        error: (error) => {
          console.error(error);
        },
        complete: () => {
          this.loading = false;
        }
      })
    })
  }

}
