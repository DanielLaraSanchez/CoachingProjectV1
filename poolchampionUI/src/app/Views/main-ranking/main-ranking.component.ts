import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/Services/data.service';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import {AddGameModalComponent} from '../../Modals/add-game-modal/add-game-modal.component';




@Component({
  selector: 'app-main-ranking',
  templateUrl: './main-ranking.component.html',
  styleUrls: ['./main-ranking.component.css']
})
export class MainRankingComponent implements OnInit {
 ranking: any = [];
 dataSource = this.ranking;
 displayedColumns = ['position','name', 'points'];

  constructor(public _dataService: DataService, public modal: MatDialog) { 
  }



  ngOnInit() {

    this.getRanking();
  }


  public getRanking(){
    this._dataService.getRanking().subscribe(x =>{ 
     this.ranking = x;
     console.log(x)
    });
  }

  public addGameModal():void{
    const dialogRef = this.modal.open(AddGameModalComponent, {
      width: '800px',
      height: '500px'
      // data: {name: this.name, animal: this.animal}
    })
  }

}