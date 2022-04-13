import { HttpClient } from '@angular/common/http';
import { Component, Inject, Injectable, OnInit } from '@angular/core';
import { WordNumberPairModel } from '../core/models/WordNumberPairModel';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent{
  newPair: WordNumberPairModel = new WordNumberPairModel;
  wordAndNumberPairs: WordNumberPairModel[] = [];
  fizzbuzzResults: string[] = new Array();
  
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string){}

  addPair(){
    this.wordAndNumberPairs.push(this.newPair);
    this.newPair = new WordNumberPairModel;
  }

  getFizzbuzzResults(){
    this.http.get<string[]>(this.baseUrl + 'api/fizzbuzz/fizzbuzzResults').subscribe(result => {
      this.fizzbuzzResults = result;
    }, error => console.error(error));
  }
}