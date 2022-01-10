import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './lib/shared/material/material.module';
import { SharedModule } from './lib/shared/shared.module';
import { MainModule } from './lib/main/main.module';
import { HomeComponent } from './components/home/home.component';
import { PManufactureComponent } from './components/pmanufacture/pmanufacture.component';
import { WManufactureComponent } from './components/wmanufacture/wmanufacture.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    PManufactureComponent,
    WManufactureComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MaterialModule,
    SharedModule,
    MainModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
