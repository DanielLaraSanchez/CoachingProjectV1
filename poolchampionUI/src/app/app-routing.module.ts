import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { MainRankingComponent} from './Views/main-ranking/main-ranking.component';
import { LoginComponent } from './Views/login/login.component';


const routes: Routes = [
  { path: '', component: LoginComponent },
  { path: 'mainranking', component: MainRankingComponent }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [ RouterModule ]
})
export class AppRoutingModule { }
