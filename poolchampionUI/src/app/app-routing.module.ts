import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { MainRankingComponent} from './Views/main-ranking/main-ranking.component';
import { LoginPageComponent } from './Views/login-page/login-page.component';


const routes: Routes = [
  { path: '', component: LoginPageComponent },
  { path: 'mainranking', component: MainRankingComponent }
  // { path: 'signup', component: SignupComponent, data: { animation: 'isRight' }}
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
