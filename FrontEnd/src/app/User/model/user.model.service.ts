
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserModelService {
  url:string = "http://localhost:5264";
  
  constructor(
   private https: HttpClient   
  ){}

  register(body:any):Observable<any>{
    return this.https.post(`${this.url}/api/User`,body);
  }
}
