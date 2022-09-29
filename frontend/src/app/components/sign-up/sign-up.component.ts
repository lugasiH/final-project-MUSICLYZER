import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {
  signUpForm!: FormGroup;
  @Input() status!:boolean
  @Output() statusChenged=new EventEmitter<boolean>();
  constructor(private form:FormBuilder) { }

  ngOnInit(): void {
this.signUpForm = this.form.group({
      name: this.form.control('', [Validators.required]),
      password: this.form.control('', [Validators.required,
                                     Validators.minLength(5)]),
      confirmPassword:this.form.control(''),
      email:this.form.control('',[Validators.email])                               
    })
  }
 hideSign(){
   this.status=true
   this.statusChenged.emit(this.status)
 }
  resetForm(){
    this.signUpForm = new FormGroup({
    name: new FormControl(''),
    password: new FormControl(''),
    confirmPassword:new FormControl(''),
    email:new FormControl('')
    })
}
  onSumit() {this.hideSign() ,console.log(this.status);
  }

}
