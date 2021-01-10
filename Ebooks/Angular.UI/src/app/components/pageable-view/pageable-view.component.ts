import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-pageable-view',
  templateUrl: './pageable-view.component.html'
})
export class PageableViewComponent implements OnInit {

  @Input()
  data = []

  activeIndex = 0;
  
  constructor() { }

  ngOnInit(): void {
  }

}
