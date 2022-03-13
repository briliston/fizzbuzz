import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent{
  fizzbuzzResults: string[] = new Array();

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<string[]>(baseUrl + 'api/fizzbuzz/getFizzbuzzResults').subscribe(result => {
      this.fizzbuzzResults = result;
    }, error => console.error(error));
  }
}