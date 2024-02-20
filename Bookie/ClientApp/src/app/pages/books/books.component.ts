import {Component} from '@angular/core';
import {Observable} from "rxjs";
import {Book} from "../../models/book";
import {ApiClientService} from "../../api-client/api-client.service";

@Component({
  selector: 'app-home',
  templateUrl: './books.component.html',
})
export class BooksComponent {
  public books: Observable<Book[]>;

  constructor(private apiClient: ApiClientService) {
    this.books = apiClient.get("book");
  }
}
