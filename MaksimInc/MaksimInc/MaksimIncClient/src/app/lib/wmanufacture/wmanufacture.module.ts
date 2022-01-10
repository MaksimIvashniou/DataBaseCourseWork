import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { CommonModule } from "@angular/common";
import { SharedModule } from "../shared/shared.module";
import { FormsModule } from "@angular/forms";
import { WManufactureRoutingModule } from "./wmanufacture-routing.module";
import { MainComponent } from "./components/main/main.component";

@NgModule({
    declarations: [
        MainComponent
    ],
    imports: [
        RouterModule,
        WManufactureRoutingModule,
        CommonModule,
        SharedModule,
        FormsModule
    ]
})
export class WManufactureModule { }