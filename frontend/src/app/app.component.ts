import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  sign=false
  showSignin=true
  showSignup=false
  show(){
    if(this.sign==true)
    this.showSignin=this.showSignup=false
    if(this.showSignin==true)
    {
      this.showSignin=false
      this.showSignup=true
      
    }
    else{
      this.showSignin=true
      this.showSignup=false
    }
    console.log(this.sign);
    
  }
hide(status:boolean){
  this.sign=status;
  this.showSignin=this.showSignup=false
}

}
