import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Player } from '../Models/player'


@Injectable({
  providedIn: 'root'
})
export class DataService {

  URL = 'https://localhost:44331/api';

  constructor(public _http: HttpClient) { }


//Player Data
public addPlayer(player: Player){
  return this._http.post(`${this.URL}/Players/signup/`, player)
}

//Game Data



//Ranking Data
public getRanking(){
  return this._http.get(`${this.URL}/Ranking/getranking/`)
}




}
