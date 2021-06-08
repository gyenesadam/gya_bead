import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {TagokComponent} from './tagok/tagok.component';
import {MediaComponent} from './media/media.component';
import {KolcsonzesComponent} from './kolcsonzes/kolcsonzes.component';

const routes: Routes = [
  {path:'tagok',component:TagokComponent},
  {path:'media',component:MediaComponent},
  {path:'kolcsonzes',component:KolcsonzesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
