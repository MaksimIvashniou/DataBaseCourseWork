import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
    loadChildren: () => import('./lib/home/home.module').then(m => m.HomeModule)
  },
  {
    path: 'PManufacture',
    component: HomeComponent,
    loadChildren: () => import('./lib/pmanufacture/pmanufacture.module').then(m => m.PManufactureModule)
  },
  {
    path: 'WManufacture',
    component: HomeComponent,
    loadChildren: () => import('./lib/wmanufacture/wmanufacture.module').then(m => m.WManufactureModule)
  },
  {
    path: '**',
    redirectTo: '',
    pathMatch: 'full'
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
