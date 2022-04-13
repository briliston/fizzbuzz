import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SignalrHubService {

  constructor(@Inject('BASE_URL') private baseUrl: string, private http: HttpClient){}

  getFizzbuzz(): Observable<string> {
    return this.http.get<string>(this.baseUrl + 'api/fizzbuzz')  
      .pipe();
  }

}