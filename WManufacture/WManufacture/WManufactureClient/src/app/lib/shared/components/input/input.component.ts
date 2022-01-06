import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-input',
  templateUrl: './input.component.html',
  styleUrls: ['./input.component.scss']
})
export class InputComponent {

  @Input() public inputId!: string;

  @Input() public placeholder!: string;

  @Output() public inputChange: EventEmitter<string> = new EventEmitter();

  public onInputChange(event: any): void {
    this.inputChange.emit(event.target);
  }
}
