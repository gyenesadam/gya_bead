import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-show-tagok',
  templateUrl: './show-tagok.component.html',
  styleUrls: ['./show-tagok.component.css']
})
export class ShowTagokComponent implements OnInit {

  constructor(private service:SharedService) { }

  TagList:any=[];
  //ModalTitle: string;
  indithato:boolean=false;
  tag:any;

  ngOnInit(): void {
    this.refreshTagokList();
  }

addClick() {
this.tag={
  TagID:0,
  Nev:"",
  SZIG:"",
  IR:"",
  Varos:"",
  Statusz:""
  }
//this.ModalTitle="Tag hozzáadása";
this.indithato=true;
}
closeClick(){
  this.indithato=false;
  this.refreshTagokList();
}



  refreshTagokList(){
    this.service.getTagok().subscribe(data=>{
      this.TagList=data;

    });
  }

}
