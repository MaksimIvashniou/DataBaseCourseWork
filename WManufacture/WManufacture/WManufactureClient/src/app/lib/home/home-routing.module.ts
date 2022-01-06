import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './components/about/about.component';
import { EmployeesComponent } from './components/employees/employees.component';
import { MainComponent } from './components/main/main.component';
import { WeldingsComponent } from './components/weldings/weldings.component';
import { WorkObjectsComponent } from './components/work-objects/work-objects.component';

const routes: Routes = [
    {
        path: '',
        component: MainComponent,
    },
    {
        path: 'about',
        component: AboutComponent,
    },
    {
        path: 'employees',
        component: EmployeesComponent,
    },
    {
        path: 'work-objects',
        component: WorkObjectsComponent,
    },
    {
        path: 'weldings',
        component: WeldingsComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class HomeRoutingModule { }