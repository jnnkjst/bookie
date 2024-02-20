import {Component} from '@angular/core';
import {Observable} from "rxjs";
import {ApiClientService} from "../api-client/api-client.service";
import {Book} from "../models/book";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public books: Observable<Book[]>;


  constructor(private apiClient: ApiClientService) {
    this.books = apiClient.get("book");
  }
}
