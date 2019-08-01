import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { DataService } from 'src/app/Services/data.service';
import { Player } from 'src/app/Models/player';
import {MatDialog} from '@angular/material/dialog';
import { Game } from 'src/app/Models/game';


@Component({
  selector: 'app-add-game-modal',
  templateUrl: './add-game-modal.component.html',
  styleUrls: ['./add-game-modal.component.css']
})
export class AddGameModalComponent implements OnInit {
userDetails;
players : Player[];
playersInSingleGame = [];
oponent;
winner;




  constructor(public _dataService: DataService, public dialog: MatDialog, public changeDetection: ChangeDetectorRef) { 
    this.userDetails = JSON.parse(sessionStorage.getItem("userDetails"));
    this.playersInSingleGame[0] = this.userDetails;
  }

  ngOnInit() {
    this.getPlayers()
    console.log(this.userDetails)
  }

 
  selectOponent(){
    if(this.playersInSingleGame.length < 2){
      this.playersInSingleGame.push(this.oponent)
      console.log(this.playersInSingleGame)
    }else{
      this.playersInSingleGame.pop()
      this.playersInSingleGame.push(this.oponent)

    }
  }



  public getPlayers(){
    this._dataService.getPlayers().subscribe(x => {
      this.players = x as Player[];
      console.log(x, "players")
    })
  }

  public addGame(){
    let newGame = new Game();
    newGame.Player1 = this.playersInSingleGame[0];
    newGame.Player2 = this.playersInSingleGame[1];
    newGame.Creator = this.playersInSingleGame[0];
    newGame.Winner = this.winner;

    console.log(newGame)
    this._dataService.addGame(newGame).subscribe(x => console.log(x));
    this.dialog.closeAll()
  }

  public selectWinner(){
    console.log(this.winner)
  }
}
