import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { CommonModule } from "@angular/common";
import { SharedModule } from "../shared/shared.module";
import { FormsModule } from "@angular/forms";
import { MainComponent } from './components/main/main.component';
import { AboutComponent } from './components/about/about.component';
import { HomeRoutingModule } from "./home-routing.module";

@NgModule({
    declarations: [
        MainComponent,
        AboutComponent
    ],
    imports: [
        RouterModule,
        HomeRoutingModule,
        CommonModule,
        SharedModule,
        FormsModule
    ]
})
export class HomeModule { }