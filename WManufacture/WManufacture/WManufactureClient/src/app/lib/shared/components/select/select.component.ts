import { Component, EventEmitter, Input, Output } from '@angular/core';
import { SelectOption } from 'src/app/lib/shared/models/select-option';

@Component({
  selector: 'app-select',
  templateUrl: './select.component.html',
  styleUrls: ['./select.component.scss']
})
export class SelectComponent {

  @Input() public selectId!: string;

  @Input() public selectOptions!: SelectOption[];

  @Output() public selectChange: EventEmitter<string> = new EventEmitter();

  public onSelectOptionChange(event: any): void {
    this.selectChange.emit(event.target);
  }
}
