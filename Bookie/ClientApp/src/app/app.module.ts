import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';
import {RouterModule} from '@angular/router';
import {AppComponent} from './app.component';
import {NavMenuComponent} from './pages/nav-menu/nav-menu.component';
import {FetchDataComponent} from './pages/fetch-data/fetch-data.component';
import {BookComponent} from './components/book/book.component';
import {provideAnimationsAsync} from '@angular/platform-browser/animations/async';
import {MatToolbarModule} from "@angular/material/toolbar";
import {MatCardModule} from "@angular/material/card";
import {MatButtonModule} from "@angular/material/button";
import {BooksComponent} from "./pages/books/books.component";
import {ToolbarComponent} from "./components/toolbar/toolbar.component";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    FetchDataComponent,
    BookComponent,
    BooksComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      {path: "", component: NavMenuComponent, pathMatch: 'full'},
      {path: 'books', component: BooksComponent, pathMatch: 'full'},
      {path: 'fetch-data', component: FetchDataComponent},
    ]),
    MatToolbarModule,
    MatCardModule,
    MatButtonModule,
    ToolbarComponent
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
