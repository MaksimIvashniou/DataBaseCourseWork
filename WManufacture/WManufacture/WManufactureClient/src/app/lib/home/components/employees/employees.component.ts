import { Component, OnInit } from '@angular/core';
import { ButtonType } from 'src/app/lib/shared/models/button-type';
import { SelectOption } from '../../../shared/models/select-option';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.scss']
})
export class EmployeesComponent implements OnInit {

  ButtonType = ButtonType;

  public titleOptions: SelectOption[] = [
    { value: 'chooseTitle', viewValue: 'Выберете разряд' },
    { value: '1', viewValue: '1' },
    { value: '2', viewValue: '2' },
    { value: '3', viewValue: '3' },
    { value: '4', viewValue: '4' },
    { value: '5', viewValue: '5' },
    { value: '6', viewValue: '6' },
  ];

  public objectOptions: SelectOption[] = [
    { value: 'chooseObject', viewValue: 'Выберете объект' },
    { value: 'object1', viewValue: 'Объект 1' },
    { value: 'object2', viewValue: 'Объект 2' },
    { value: 'object3', viewValue: 'Объект 3' },
    { value: 'object4', viewValue: 'Объект 4' },
    { value: 'object5', viewValue: 'Объект 5' },
    { value: 'object6', viewValue: 'Объект 6' },
  ];

  public stateOptions: SelectOption[] = [
    {
      value: 'chooseState',
      viewValue: 'Выберете состояние'
    },
    {
      value: 'busy',
      viewValue: 'Занят'
    },
    {
      value: 'illnes',
      viewValue: 'Больничный'
    },
    {
      value: 'vacation',
      viewValue: 'Отпуск'
    },
    {
      value: 'free',
      viewValue: 'Свободен'
    },
  ];

  public title: string = '';

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

  public titleSelectChange(value: any, element?: any) {
    if (element) {
      element.options.selectedIndex = 0;
    }
    this.titleOptions.forEach((item: { value: string, viewValue: string }) => {
      if (item.value === value.value) {
        this.title = item.viewValue;
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

  public searchEngine(): void {
  //   if (this.search) {
  //     this.utilsService.filterByName(this.search);
  //   }
  //   if (this.title) {
  //     this.utilsService.filterByTitle(this.title);
  //   }
  //   if (this.object) {
  //     this.utilsService.filterByObject(this.object);
  //   }
  //   if (this.state) {
  //     this.utilsService.filterByState(this.state);
  //   }
  }

  public clear(): void {
  //   this.utilsService.restoreTable();
  //   this.titleSelectChange('Выберете разряд', document.getElementById('title'));
  //   this.objectSelectChange('Выберете объект', document.getElementById('object'));
  //   this.stateSelectChange('Выберете состояние', document.getElementById('state'));
  //   this.searchChange('', document.getElementById('search'));
  }
}
