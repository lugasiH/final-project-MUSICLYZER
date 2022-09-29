import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SignInComponent } from './components/sign-in/sign-in.component';
import { SignInModule } from './components/sign-in/sign-in.module';
import { SignUpComponent } from './components/sign-up/sign-up.component';
import { SignUpModule } from './components/sign-up/sign-up.module';
import { UserService } from './services/user.service';
import { UploadSongComponent } from './components/upload-song/upload-song.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { LoaderComponent } from './components/upload-song/loader/loader.component';


@NgModule({
  declarations: [
    AppComponent,
    SignInComponent,
    SignUpComponent,
    UploadSongComponent,
    LoaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    SignInModule,
    SignUpModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
  ],
  providers: [UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
