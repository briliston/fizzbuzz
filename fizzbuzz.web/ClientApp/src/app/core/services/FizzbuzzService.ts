import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { FizzbuzzParametersModel } from '../models/FizzbuzzParametersModel';

@Injectable({
  providedIn: 'root',
})
export class FizzbuzzService {

  constructor(private http: HttpClient) { }

  post(parameters: FizzbuzzParametersModel) {
    return this.http.post(`api/fizzbuzz/post`, parameters);
  }
}