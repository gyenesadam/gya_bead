import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-kolcs',
  templateUrl: './show-kolcs.component.html',
  styleUrls: ['./show-kolcs.component.css']
})
export class ShowKolcsComponent implements OnInit {

  constructor(private service:SharedService) { }
  KolcsList:any=[];
  ngOnInit(): void {
    this.refreshKolcsList();
  }


  
  refreshKolcsList(){
    this.service.getKolcsonzes().subscribe(data=>{
      this.KolcsList=data;

    });
  }

}
