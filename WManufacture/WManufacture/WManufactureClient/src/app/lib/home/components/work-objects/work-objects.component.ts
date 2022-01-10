import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-work-objects',
  templateUrl: './work-objects.component.html',
  styleUrls: ['./work-objects.component.scss']
})
export class WorkObjectsComponent implements OnInit {

  public search: string = '';

  constructor() { }

  ngOnInit(): void {
  }

  public searchChange(value: any, element?: any): void {
    if (element) {
      element.value = '';
    }
    this.search = value.value;
  }
}
