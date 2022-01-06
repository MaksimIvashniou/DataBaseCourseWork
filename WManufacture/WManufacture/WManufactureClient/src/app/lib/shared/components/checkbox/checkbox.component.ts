import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-checkbox',
  templateUrl: './checkbox.component.html',
  styleUrls: ['./checkbox.component.scss']
})
export class CheckboxComponent {

  @Input() public caption: string = '';

  @Input() public isChecked: boolean = false;

  @Input() public isIndeterminate: boolean = false;

  @Input() public ariaLabel: string = '';

  @Output() public checkboxChange: EventEmitter<boolean> = new EventEmitter();

  public onCheckboxChange($event: any): void {
    this.checkboxChange.emit($event.checked);
  }
}
