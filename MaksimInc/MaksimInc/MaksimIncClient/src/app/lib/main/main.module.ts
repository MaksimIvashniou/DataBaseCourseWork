import { NgModule } from "@angular/core";
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { CommonModule } from "@angular/common";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { RouterModule } from "@angular/router";
import { MaterialModule } from "../shared/material/material.module";
import { SharedModule } from "../shared/shared.module";

@NgModule({
    declarations: [
        HeaderComponent,
        FooterComponent
    ],
    imports: [
        CommonModule,
        MaterialModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        SharedModule
    ],
    exports: [
        HeaderComponent,
        FooterComponent
    ]
})
export class MainModule { }