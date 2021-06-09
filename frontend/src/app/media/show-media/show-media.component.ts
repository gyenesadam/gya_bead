import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-media',
  templateUrl: './show-media.component.html',
  styleUrls: ['./show-media.component.css']
})
export class ShowMediaComponent implements OnInit {

  constructor(private service:SharedService) { }
  MediaList:any=[];
  ngOnInit(): void {
    this.refreshMediaList();
  }


  
  refreshMediaList(){
    this.service.getMedia().subscribe(data=>{
      this.MediaList=data;

    });
  }

}
