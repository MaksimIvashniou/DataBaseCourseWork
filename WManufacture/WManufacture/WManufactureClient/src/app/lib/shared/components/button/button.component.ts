import { Component, EventEmitter, Input, Output } from '@angular/core';
import { ButtonType } from '../../models/button-type';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.scss']
})
export class ButtonComponent {

  @Input() public caption: string = '';

  @Input() public type: ButtonType = ButtonType.Primary;

  @Output() public buttonClick: EventEmitter<string> = new EventEmitter();

  public onButtonClick(): void {
    this.buttonClick.emit();
  }
}
