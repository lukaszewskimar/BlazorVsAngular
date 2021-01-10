import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EbookDetailsComponent } from './pages/ebook-details/ebook-details.component';
import { HomeComponent } from './pages/home/home.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'ebooks/:ebook_id',
    component: EbookDetailsComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
    useHash: true
  })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
