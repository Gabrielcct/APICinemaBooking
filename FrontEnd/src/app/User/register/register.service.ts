import { Injectable } from '@angular/core';
import { UserModelService } from '../model/user.model.service';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {
  url:string= '';

  constructor(
    private userModelService: UserModelService 
  ) { }

  register(body: any){
      
    this.userModelService.register(body).subscribe({
     next: (res:any)=>{
      console.log(res);
      
      }, error: (err)=>{
        console.log(err);
      }
    });
  }


}
