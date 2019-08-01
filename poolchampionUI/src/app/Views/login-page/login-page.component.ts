import { Component, OnInit } from '@angular/core';


import { FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';

import { DataService } from 'src/app/Services/data.service';
import { Player } from 'src/app/Models/player';

import * as sweetAlert from 'sweetalert2'


@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent implements OnInit {
  userDetails: object = {};
  needsToRegister: boolean;

  constructor(public _dataService: DataService, public router: Router) {
    this.needsToRegister = false;
  }





  emailFormControl = new FormControl('', [
    Validators.required,
    Validators.email,
  ]);

  passwordFormControl = new FormControl('', [
    Validators.required
  ]);



  userNameSignUpFormControl = new FormControl('', [
    Validators.required
  ]);

  emailSignUpFormControl = new FormControl('', [
    Validators.required,
    Validators.email,
  ]);

  passwordSignUpFormControl = new FormControl('', [
    Validators.required

  ]);



  ngOnInit() {
  }

  switchOnSignup() {
    this.needsToRegister = true;
  }

  public login() {
    const player: Player = new Player();
    player.EmailAddress = this.emailFormControl.value;
    player.Password = this.passwordFormControl.value;
    console.log(player)

    this._dataService.logIn(player).subscribe(x => {
      if (x === null) {
        sweetAlert.default.fire({
          type: 'error',
          title: 'Oops...',
          text: 'The username or password you entered is incorrect. maybe both!',
          // footer: '<a href>Why do I have this issue?</a>'
        });
       this.resetLoginForm();
       
      } else {
        this.userDetails = x;
        sessionStorage.setItem("userDetails", JSON.stringify(x));
        this.router.navigate(['mainranking'])
      }


      console.log(x)
    })
  }

  public signUp() {
    const newPlayer: Player = new Player();
    newPlayer.Name = this.userNameSignUpFormControl.value;
    newPlayer.EmailAddress = this.emailSignUpFormControl.value;
    newPlayer.Password = this.passwordSignUpFormControl.value;
    this._dataService.addPlayer(newPlayer).subscribe(x => console.log(x)) //need to do proper authorization and authentication (currently dont even know the difference between them two)
    this.router.navigate(['mainranking'])
  }


  private resetLoginForm(){
    this.emailFormControl.clearValidators();
    this.passwordFormControl.clearValidators();
    this.emailFormControl.reset();
    this.passwordFormControl.reset();
   
  }

}
