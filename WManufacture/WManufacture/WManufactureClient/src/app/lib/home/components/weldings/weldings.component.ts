import { Component, OnInit } from '@angular/core';
import { ButtonType } from 'src/app/lib/shared/models/button-type';
import { SelectOption } from 'src/app/lib/shared/models/select-option';

@Component({
  selector: 'app-weldings',
  templateUrl: './weldings.component.html',
  styleUrls: ['./weldings.component.scss']
})
export class WeldingsComponent implements OnInit {

  ButtonType = ButtonType;

  public modelOptions: SelectOption[] = [
    { value: 'chooseModel', viewValue: 'Выберете модель'},
  ];

  public objectOptions: SelectOption[] = [
    { value: 'chooseObject', viewValue: 'Выберете объект'},
  ];

  public stateOption: SelectOption[] =  [
    { value: 'chooseState', viewValue: 'Выберете состояние'},
  ];

  public model: string = '';

  public object: string = '';

  public state: string = '';

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

  public modelSelectChange(value: any, element?: any) {
    if (element) {
      element.options.selectedIndex = 0;
    }
    this.modelOptions.forEach((item: { value: string, viewValue: string }) => {
      if (item.value === value.value) {
        this.model = item.viewValue;
      }
    });
  }

  public objectSelectChange(value: any, element?: any) {
    if (element) {
      element.options.selectedIndex = 0;
    }
    this.objectOptions.forEach((item: { value: string, viewValue: string }) => {
      if (item.value === value.value) {
        this.object = item.viewValue;
      }
    });
  }

  public stateSelectChange(value: any, element?: any) {
    if (element) {
      element.options.selectedIndex = 0;
    }
    this.objectOptions.forEach((item: { value: string, viewValue: string }) => {
      if (item.value === value.value) {
        this.state = item.viewValue;
      }
    });
  }
}
