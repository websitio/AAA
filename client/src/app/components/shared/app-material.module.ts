import { NgModule } from "@angular/core";
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { MatButtonModule } from "@angular/material/button";
import { MatIconModule } from "@angular/material/icon";
import { MatMenuModule } from "@angular/material/menu";
import { MatToolbarModule } from "@angular/material/toolbar";

import { MatTabsModule } from '@angular/material/tabs';
import {MatInputModule} from '@angular/material/input';
import { MatSelectModule } from "@angular/material/select";

import { MatSliderModule } from '@angular/material/slider';
import { MatRadioModule } from '@angular/material/radio';
import { FormsModule } from '@angular/forms';

@NgModule({
  imports: [MatButtonModule,
    MatIconModule,  MatSelectModule,
    MatListModule,
    MatMenuModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatInputModule,
    MatTabsModule,
    MatRadioModule,

 
    FormsModule,
 
  ],

  exports: [
    MatButtonModule,
    MatIconModule,  MatSelectModule,
    MatMenuModule,
    MatToolbarModule,
    MatSidenavModule, MatInputModule,
    MatListModule,MatTabsModule, MatSliderModule,
    FormsModule, MatRadioModule


  ]
})

export class AppMaterialModule {}
