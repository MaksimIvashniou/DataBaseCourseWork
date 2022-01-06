import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { CommonModule } from "@angular/common";
import { SharedModule } from "../shared/shared.module";
import { FormsModule } from "@angular/forms";
import { MainComponent } from './components/main/main.component';
import { AboutComponent } from './components/about/about.component';
import { HomeRoutingModule } from "./home-routing.module";
import { EmployeesComponent } from './components/employees/employees.component';
import { WorkObjectsComponent } from './components/work-objects/work-objects.component';
import { WeldingsComponent } from './components/weldings/weldings.component';

@NgModule({
    declarations: [
        MainComponent,
        AboutComponent,
        EmployeesComponent,
        WorkObjectsComponent,
        WeldingsComponent
    ],
    imports: [
        RouterModule,
        HomeRoutingModule,
        CommonModule,
        SharedModule,
        FormsModule
    ],
    exports: [
    ]
})
export class HomeModule { }