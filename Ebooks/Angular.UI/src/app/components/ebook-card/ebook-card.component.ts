import { Component, HostBinding, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-ebook-card',
  templateUrl: './ebook-card.component.html'
})
export class EbookCardComponent implements OnInit {

  @Input()
  ebook = {
    id: 0,
    name: '',
    description: '',
    author: ''
  }

  constructor() { }

  @HostBinding('class') classes = 'card mb-4 box-shadow'

  ngOnInit(): void {
  }

}
