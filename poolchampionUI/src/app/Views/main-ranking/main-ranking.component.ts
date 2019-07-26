import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/Services/data.service';
import { Observable } from 'rxjs';
import {MatTableModule} from '@angular/material/table';
import { queueComponentIndexForCheck } from '@angular/core/src/render3/instructions';


@Component({
  selector: 'app-main-ranking',
  templateUrl: './main-ranking.component.html',
  styleUrls: ['./main-ranking.component.css']
})
export class MainRankingComponent implements OnInit {
 ranking: any = [];
 dataSource = this.ranking;
 displayedColumns = ['position','name', 'points'];

  constructor(public _dataService: DataService) { 
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

  // public getIndex(element: any){
  //     return .indexOf()
  // }

}
