import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { User } from 'src/app/models/User';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {

  signInForm!: FormGroup
  showAlert: boolean = false
  @Output() success = new EventEmitter<boolean>();
  user = new User()

  constructor(private userService: UserService) { }

  ngOnInit(): void {
    this.signInForm = new FormGroup({
      name: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required,
      Validators.minLength(5)])
    })
  }

  loginUser() {
    if (this.signInForm.valid) {
      //fill the user details 
      this.user.name = this.signInForm.get('name')?.value
      this.user.password = this.signInForm.get('password')?.value
      //send the user for check
      this.userService.checkUser(this.user).subscribe(ans => {
        if (ans) {
          console.log(ans);
          this.userService.CurrentUser = ans
          this.success.emit(true)
        }
        else {
          console.log(ans);
          this.showAlert=true
          // window.location.reload()
          this.signInForm.get('name')?.setValue('')
          this.signInForm.get('password')?.setValue('')
        }
      })
    }
  }
}
