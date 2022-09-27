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
 // import {AppMaterialModule} from './components/shared/app-material.module';
// import { ThemeComponent } from './components/theme/theme.component';
import { LearnmoreComponent } from './components/learnmore/learnmore.component';
import { CategoriesListComponent } from './components/categories/categories-list/categories-list.component';
import { CategoriesEditComponent } from './components/categories/categories-edit/categories-edit.component';
import { CategoriesDetailComponent } from './components/categories/categories-detail/categories-detail.component';
import { CostsListComponent } from './components/costs/costs-list/costs-list.component';
import { CostsDetailComponent } from './components/costs/costs-detail/costs-detail.component';
import { CostsEditComponent } from './components/costs/costs-edit/costs-edit.component';
// import {ToastrModule} from 'ngx-toastr';


@NgModule({
  declarations: [
    AppComponent,
    NavComponent,  
    RegisterComponent, 
    HomeComponent, 
    LearnmoreComponent,
    CategoriesDetailComponent,
    CategoriesListComponent,
    CategoriesEditComponent,
    CostsDetailComponent,
    CostsEditComponent,
    CostsListComponent
   // ThemeComponent
  ],
  imports: [
    BrowserModule,   
    //AppMaterialModule,
    AppRoutingModule, 
    HttpClientModule, 
    BrowserAnimationsModule,   
    FormsModule,  
    BsDropdownModule.forRoot() 
    // ToastrModule.forRoot({positionClass: 'toast-top-right'})
    
    //ComponentsModule
  ],
  providers: [HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
