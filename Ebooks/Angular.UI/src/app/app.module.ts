import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { EbookCardComponent } from './components/ebook-card/ebook-card.component';
import { HttpClientModule } from '@angular/common/http';
import { EbookDetailsComponent } from './pages/ebook-details/ebook-details.component';
import { PageableViewComponent } from './components/pageable-view/pageable-view.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    EbookCardComponent,
    EbookDetailsComponent,
    PageableViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
