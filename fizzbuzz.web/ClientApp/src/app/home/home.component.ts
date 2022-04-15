import { HttpClient } from '@angular/common/http';
import { Component, Inject, Injectable, OnDestroy, OnInit } from '@angular/core';
import { FizzbuzzParametersModel } from '../core/models/FizzbuzzParametersModel';
import { WordNumberPairModel } from '../core/models/WordNumberPairModel';
import { FizzbuzzService } from '../core/services/FizzbuzzService';
import { SignalRService } from '../core/services/SignalRService';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit, OnDestroy{
  newPair: WordNumberPairModel = new WordNumberPairModel;
  wordAndNumberPairs: WordNumberPairModel[] = [];
  total: number = 100;
  parameters: FizzbuzzParametersModel = new FizzbuzzParametersModel;
  fizzbuzzResults: string[] = new Array();
  
  constructor(private signalRService: SignalRService, private fizzbuzzService: FizzbuzzService){}

  ngOnInit(): void {
    this.signalRService.startConnection();
    this.signalRService.connectionToHub?.on("publishresult", (data) => {
      this.fizzbuzzResults.push(data);
    });
  }

  ngOnDestroy(): void {
    this.signalRService.connectionToHub?.off("publishresult");
    this.signalRService.stopConnection();
  }

  addPair(){
    this.wordAndNumberPairs.push(this.newPair);
    this.newPair = new WordNumberPairModel;
  }

  getFizzbuzzResults(){
    this.fizzbuzzResults = [];
    this.parameters = { total: this.total, entries: this.wordAndNumberPairs, connectionId: this.signalRService.connectionToHub!.connectionId ?? ""};

    this.fizzbuzzService.post(this.parameters).subscribe(() => {});
  }
  
  clearFizzbuzzResults() {
    this.fizzbuzzResults = [];
  }
}