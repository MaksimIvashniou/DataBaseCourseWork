import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { CommonModule } from "@angular/common";
import { SharedModule } from "../shared/shared.module";
import { FormsModule } from "@angular/forms";
import { PManufactureRoutingModule } from "./pmanufacture-routing.module";
import { MainComponent } from "./components/main/main.component";

@NgModule({
    declarations: [
        MainComponent
    ],
    imports: [
        RouterModule,
        PManufactureRoutingModule,
        CommonModule,
        SharedModule,
        FormsModule
    ]
})
export class PManufactureModule { }