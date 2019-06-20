import { Component, OnInit } from '@angular/core';


import {FormControl, FormGroupDirective, NgForm, Validators} from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';
import { RouterOutlet } from '@angular/router';

import { fader } from '../../route-animations'


@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent implements OnInit {
needsToRegister: boolean;

  constructor() {
    this.needsToRegister = false;
   }
  emailFormControl = new FormControl('', [
    Validators.required,
    Validators.email,
  ]);
  ngOnInit() {
  }

  switchOnSignup(){
    this.needsToRegister = true;
  }

}
