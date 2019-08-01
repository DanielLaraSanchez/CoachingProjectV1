import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { HttpClientModule } from '@angular/common/http'


import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { MainRankingComponent } from './Views/main-ranking/main-ranking.component';

import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LoginPageComponent } from './Views/login-page/login-page.component';
import { LoginComponent } from './Components/login/login.component';
import { AddGameModalComponent } from './Modals/add-game-modal/add-game-modal.component';


//Material Components
import {MatButtonModule} from '@angular/material/button';
import {MatInputModule} from '@angular/material/input';
import {MatTableModule} from '@angular/material/table';
import {MatDialogModule} from '@angular/material/dialog';
import {MatSelectModule} from '@angular/material/select';


//other external libraries
import { SweetAlert2Module } from '@sweetalert2/ngx-sweetalert2';



@NgModule({
  declarations: [
    AppComponent,
    MainRankingComponent,
    LoginPageComponent,
    LoginComponent,
    AddGameModalComponent
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    //Material
    MatInputModule,
    FormsModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatTableModule,
    MatDialogModule,
    MatSelectModule,
    //other external libraries
    SweetAlert2Module.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent],
  entryComponents: [
    AddGameModalComponent
  ]
})
export class AppModule { }
