import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FileService } from 'src/app/services/file.service';

@Component({
  selector: 'app-upload-song',
  templateUrl: './upload-song.component.html',
  styleUrls: ['./upload-song.component.css'],
  providers:[FileService]
})
export class UploadSongComponent implements OnInit {
  proccess:boolean=false
  constructor(private fs: FileService, private http: HttpClient) { }
  song: any
  ngOnInit(): void {
  }

  uploadSong(event:any) {
this.song=event.target.files[0];
console.log(this.song);

  }
  sendSong(req: any): void {
    this.fs.getAudio(req.fileName)
      .subscribe((data: any) => {
        const file = new File([data], req.fileName);
        this.fs.send(file)
          .subscribe((data: any) => {
        console.log(data);
          }, error => {
            console.log(error);
          });
      });
      this.proccess=true
  }
    // let file = this.song
    // console.log(file[0]);
    // //this.fs.uploadSong(file[0])
    // this.fs.send(file[0]).subscribe(ans => console.log(ans));
  
}
