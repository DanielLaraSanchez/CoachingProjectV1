import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/Services/data.service';

@Component({
  selector: 'app-main-ranking',
  templateUrl: './main-ranking.component.html',
  styleUrls: ['./main-ranking.component.css']
})
export class MainRankingComponent implements OnInit {

  constructor(public _dataService: DataService) { }

  ngOnInit() {

    this.getRanking();
  }


  public getRanking(){
    this._dataService.getRanking().subscribe(x => console.log(x));
  }

}
