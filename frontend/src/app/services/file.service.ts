import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FileService {
  readonly serverUrl = "https://localhost:44387/api/song"
  fetchAudioUrl="https://localhost:4200"

  constructor(private http: HttpClient) { }
  uploadSong(song: any): Observable<any> {
    let fd = new FormData()
    fd.append('song', song, song.name)
    console.log(song.name);
    return this.http.post<any>(`${this.serverUrl}/uploadsong`, fd)

  }
  send (audioFile: File): Observable<any>  {
    const formData: FormData = new FormData();
    formData.append('file', audioFile, audioFile.name);
    console.log(audioFile.name);
    return this.http.post(this.serverUrl, formData);
  }
  getAudio (fileName: string): Observable<any>  {
    return this.http.get(this.fetchAudioUrl + fileName, { responseType: 'blob'});
  }
}
