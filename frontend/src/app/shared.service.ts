import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl="http://localhost:59010/api"           //BACKEND API URL cím!!!!!!!!!!!!!!!!!!!!!
  constructor(private http:HttpClient) { }

  getTagok():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Tagok');
  }

  addTagok(val:any) {
    return this.http.post(this.APIUrl+'/Tagok',val);
  }

  updateTagok(val:any) {
    return this.http.put(this.APIUrl+'/Tagok',val);
  }

  deleteTagok(val:any) {
    return this.http.delete(this.APIUrl+'/Tagok/'+val);
  }

  getMedia():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Media');
  }

  addMedia(val:any) {
    return this.http.post(this.APIUrl+'/Media',val);
  }

  updateMedia(val:any) {
    return this.http.put(this.APIUrl+'/Media',val);
  }

  deleteMedia(val:any) {
    return this.http.delete(this.APIUrl+'/Media/'+val);
  }


  getKolcsonzes():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Kolcsonzes');
  }

  addKolcsonzes(val:any) {
    return this.http.post(this.APIUrl+'Kolcsonzes',val);
  }

  updateKolcsonzes(val:any) {
    return this.http.put(this.APIUrl+'/Kolcsonzes',val);
  }

  deleteKolcsonzes(val:any) {
    return this.http.delete(this.APIUrl+'Kolcsonzes/'+val);
  }
}
