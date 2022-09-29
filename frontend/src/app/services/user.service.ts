import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../models/User';
import { Observable } from 'rxjs';
import { Form } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  // formData!: User ;
  private _currentUser!:User;

  private serverUrl="https://localhost:44387/api/user"
  constructor(private http:HttpClient) { }

  checkUser(u:any): Observable<any> {
    return this.http.post<User>(`${this.serverUrl}/check`, u)
  }
  // addUser(u:User):Observable<User>{
  //   return this.http.post<User>(`${this.serverUrl}/add`, u, options)
  // }
  set CurrentUser(u:User){
    this._currentUser = u
  }
 addUser(u:any):Observable<any> {
  return this.http.post<User>(`${this.serverUrl}/add`, u)
}
}
