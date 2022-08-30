import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoriesDetailComponent } from './components/categories/categories-detail/categories-detail.component';
import { CategoriesListComponent } from './components/categories/categories-list/categories-list.component';
import { CostsDetailComponent } from './components/costs/costs-detail/costs-detail.component';
import { CostsListComponent } from './components/costs/costs-list/costs-list.component';
import { HomeComponent } from './components/home/home.component';
import { LearnmoreComponent } from './components/learnmore/learnmore.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'costs', component: CostsListComponent},
  {path: 'costs/:id', component: CostsDetailComponent},
  {path: 'categories', component: CategoriesListComponent},
  {path: 'categories/:id', component: CategoriesDetailComponent},
  {path: 'learn', component: LearnmoreComponent},
  {path: '**', component: HomeComponent, pathMatch : 'full'}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
