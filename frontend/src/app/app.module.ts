import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TagokComponent } from './tagok/tagok.component';
import { ShowTagokComponent } from './tagok/show-tagok/show-tagok.component';
import { AddEditTagokComponent } from './tagok/add-edit-tagok/add-edit-tagok.component';
import { MediaComponent } from './media/media.component';
import { ShowMediaComponent } from './media/show-media/show-media.component';
import { AddEditMediaComponent } from './media/add-edit-media/add-edit-media.component';
import { KolcsonzesComponent } from './kolcsonzes/kolcsonzes.component';
import { ShowKolcsComponent } from './kolcsonzes/show-kolcs/show-kolcs.component';
import { AddEditKolcsComponent } from './kolcsonzes/add-edit-kolcs/add-edit-kolcs.component';
import {SharedService} from './shared.service';

import {HttpClientModule} from '@angular/common/http';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    AppComponent,
    TagokComponent,
    ShowTagokComponent,
    AddEditTagokComponent,
    MediaComponent,
    ShowMediaComponent,
    AddEditMediaComponent,
    KolcsonzesComponent,
    ShowKolcsComponent,
    AddEditKolcsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NgbModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
