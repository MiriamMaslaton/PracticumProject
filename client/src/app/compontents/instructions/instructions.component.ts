import { Component, OnInit } from '@angular/core';
import { UserService } from '../../services/User.service';

@Component({
  selector: 'app-instructions',
  templateUrl: './instructions.component.html',
  styleUrls: ['./instructions.component.scss']
})

export class InstructionsComponent implements OnInit {
  userFirstName;
  userLastName;

  ngOnInit(): void {
      this.userFirstName = this.userService.myUser.FirstName;
      this.userLastName = this.userService.myUser.LastName;
  }

  constructor(public userService: UserService) {}
}