import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/services/User.service';
import Child from 'src/models/Child';
import User from 'src/models/User';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})
class FormComponent implements OnInit {
  generateExcel(){}

  data:any[]=[];

  constructor(public userService: UserService) { }

  ngOnInit(): void {}
  addUser() {
    this.userService.myUser.children = this.userService.arrChildren;
    this.userService.arrChildren = [];
    localStorage.setItem("currentUser", JSON.stringify(this.userService.myUser));
    this.userService.addUser(this.userService.myUser);
    this.userService.myUser = new User("", "", "", new Date(), 1, 1, null);
    alert("!ברכותינו לרגל כניסתך למאגר");
  }
  addChild() {
    localStorage.setItem("currentUserChild", JSON.stringify(this.userService.myChild));
    this.userService.arrChildren.push(this.userService.myChild);
    this.userService.myChild = new Child("", "", null)
    this.userService.arrChildren.forEach(item => {
      console.log(item)
    });
  }
}
export default FormComponent;
