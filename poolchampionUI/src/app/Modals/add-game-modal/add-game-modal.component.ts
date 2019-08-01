import { Component, OnInit, OnChanges, ChangeDetectorRef } from '@angular/core';
import { DataService } from 'src/app/Services/data.service';
import { Player } from 'src/app/Models/player';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';


@Component({
  selector: 'app-add-game-modal',
  templateUrl: './add-game-modal.component.html',
  styleUrls: ['./add-game-modal.component.css']
})
export class AddGameModalComponent implements OnInit, OnChanges {
userDetails: object = {};
players : Player[];
playersInSingleGame = [];
selectedValue;



  constructor(public _dataService: DataService, public dialog: MatDialog, public changeDetection: ChangeDetectorRef) { 
    this.userDetails = JSON.parse(sessionStorage.getItem("userDetails"));
    this.playersInSingleGame[0] = this.userDetails;
  }

  ngOnInit() {
    this.getPlayers()
    console.log(this.userDetails)
  }

  ngOnChanges() {
  }

  selectWinner(){
    if(this.playersInSingleGame.length < 2){
      this.playersInSingleGame.push(this.selectedValue)
      console.log(this.playersInSingleGame)
    }else{
      this.playersInSingleGame.pop()
      this.playersInSingleGame.push(this.selectedValue)

    }
  }

  public getPlayers(){
    this._dataService.getPlayers().subscribe(x => {
      this.players = x as Player[];
      console.log(x, "players")
    })
  }

  public addGame(oponent){
    console.log(oponent)
    this.dialog.closeAll()

  }
}
