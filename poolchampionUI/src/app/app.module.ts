import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { MainRankingComponent } from './Views/main-ranking/main-ranking.component';
import { LoginComponent } from './Views/login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    MainRankingComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
