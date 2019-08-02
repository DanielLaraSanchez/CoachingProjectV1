import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Player } from '../Models/player'
import { Game } from '../Models/game';


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

public getPlayers(){
  return this._http.get(`${this.URL}/Players/getplayers`)
}

public logIn(player: Player){
  return this._http.post(`${this.URL}/Players/login/`, player)
}

//Game Data
public addGame(game: Game){
  const httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json'
    })};
    console.log(JSON.stringify(game), "game")
  
  return this._http.post(`${this.URL}/Games/creategame/`, game, httpOptions)
}


//Ranking Data
public getRanking(){
  return this._http.get(`${this.URL}/Ranking/getranking/`)
}




}
