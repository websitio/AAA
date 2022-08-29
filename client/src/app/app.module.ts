import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import{HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';
 // import { ComponentsModule } from './components/components.module';
import { NavComponent } from './components/nav/nav.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
 import { RegisterComponent } from './components/register/register.component';
import { HomeComponent } from './components/home/home.component';
 import {AppMaterialModule} from './components/shared/app-material.module';
import { ThemeComponent } from './components/theme/theme.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,  
    RegisterComponent, 
    HomeComponent, 
    ThemeComponent
  ],
  imports: [
    BrowserModule,   
    AppMaterialModule,
    AppRoutingModule, 
    HttpClientModule, 
    BrowserAnimationsModule,   
    FormsModule,  
    BsDropdownModule.forRoot() ,
    
    //ComponentsModule
  ],
  providers: [HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
