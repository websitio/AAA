import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
 import { HomeComponent } from './home/home.component';
import { NavComponent } from './nav/nav.component';
 // import { RegisterComponent } from './register/register.component';
import { FormsModule } from '@angular/forms';
// import { LearnmoreComponent } from './learnmore/learnmore.component';
//import { CategoriesListComponent } from './categories/categories-list/categories-list.component';
//import { CategoriesEditComponent } from './categories/categories-edit/categories-edit.component';
//import { CategoriesDetailComponent } from './categories/categories-detail/categories-detail.component';
//import { CostsListComponent } from './costs/costs-list/costs-list.component';
//import { CostsDetailComponent } from './costs/costs-detail/costs-detail.component';
// import { CostsEditComponent } from './costs/costs-edit/costs-edit.component';
//import { ThemeComponent } from './theme/theme.component';



@NgModule({
  declarations: [
 //   HomeComponent,
 //   ThemeComponent,
    // RegisterComponent
    // NavComponent
  
 //   LearnmoreComponent,
 //CategoriesListComponent,
 //CategoriesEditComponent,
 //CategoriesDetailComponent,
 //CostsListComponent,
 //CostsDetailComponent,
 // CostsEditComponent
  ],
  imports: [
    CommonModule
  ],
  exports:  [
    // RegisterComponent
    // HomeComponent
  ]
})
export class ComponentsModule { }
