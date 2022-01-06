import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { MaterialModule } from "./material/material.module";
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { RouterModule } from "@angular/router";
import { InputComponent } from './components/input/input.component';
import { SelectComponent } from './components/select/select.component';
import { ButtonComponent } from './components/button/button.component';
import { TableComponent } from './components/table/table.component';
import { CheckboxComponent } from './components/checkbox/checkbox.component';


@NgModule({
    declarations: [
        HeaderComponent,
        FooterComponent,
        InputComponent,
        SelectComponent,
        ButtonComponent,
        TableComponent,
        CheckboxComponent
    ],
    imports: [
        CommonModule,
        MaterialModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule
    ],
    exports: [
        HeaderComponent,
        FooterComponent,
        InputComponent,
        SelectComponent,
        ButtonComponent,
        TableComponent,
        CheckboxComponent
    ]
})
export class SharedModule { }