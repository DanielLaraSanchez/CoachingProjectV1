import { Component, OnInit } from '@angular/core';


import {FormControl, FormGroupDirective, NgForm, Validators} from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';
import { RouterOutlet, Router } from '@angular/router';

import { fader } from '../../route-animations'
import { DataService } from 'src/app/Services/data.service';
import { Player } from 'src/app/Models/player';
import { routerNgProbeToken } from '@angular/router/src/router_module';


@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent implements OnInit {
needsToRegister: boolean;

  constructor(public _dataService: DataService, public router: Router) {
    this.needsToRegister = false;
   }



   userNameFormControl = new FormControl('', [
    Validators.required
  ]);

  emailFormControl = new FormControl('', [
    Validators.required,
    Validators.email,
  ]);

  passwordFormControl = new FormControl('', [
    Validators.required
  ]);



  ngOnInit() {
  }

  switchOnSignup(){
    this.needsToRegister = true;
  }

 public signUp(){
    console.log(this.emailFormControl)
   const newPlayer : Player = new Player();
   newPlayer.Name = this.userNameFormControl.value;
   newPlayer.EmailAddress = this.emailFormControl.value;
   newPlayer.Password = this.passwordFormControl.value;
    this._dataService.addPlayer(newPlayer).subscribe(x => console.log(x)) //need to do proper authorization and authentication (currently dont even know the difference between them two)
    this.router.navigate(['mainranking'])
  }

}
