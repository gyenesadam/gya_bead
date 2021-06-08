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

  ngOnInit(): void {
    this.refreshTagokList();
  }

  refreshTagokList(){
    this.service.getTagok().subscribe(data=>{
      this.TagList=data;

    });
  }

}
