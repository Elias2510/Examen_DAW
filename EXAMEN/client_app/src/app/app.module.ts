// src/app/app.module.ts
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
    // ... alte componente
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule  // Adăugați această linie
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}

