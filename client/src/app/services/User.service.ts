import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import Child from 'src/models/Child';
import User from 'src/models/User';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  routeUrl = `${environment.baseUrl}`;
  arrChildren: Child[] = []
  myUser: User = new User("","","", new Date(),1,1,this.arrChildren);
  myChild:Child = new Child("", "", new Date())

  addUser(u: User) {
    console.log("befor server",u)
    return this.http.post<User>(`${this.routeUrl}/User`, u).subscribe(succ =>
      console.log("user add Successfully", succ));
  }
  constructor(public http: HttpClient) {} 
}