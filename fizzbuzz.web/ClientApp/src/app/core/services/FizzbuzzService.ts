import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { WordNumberPairModel } from '../models/WordNumberPairModel';

@Injectable({
  providedIn: 'root',
})
export class FizzbuzzService {

  constructor(private http: HttpClient) { }

  getFizzbuzzResults(){
      return this.http.get<string[]>('/api/fizzbuzz/getFizzbuzzResults');
  }
}