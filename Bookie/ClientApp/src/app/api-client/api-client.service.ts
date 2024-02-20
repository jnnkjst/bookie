import {Inject, Injectable} from "@angular/core";
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";

@Injectable({providedIn: 'root'})
export class ApiClientService {
  private readonly baseUrl;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  public get(url: string): Observable<any> {
    return this.http.get(this.baseUrl + url);
  }

  public post(url: string, body: any): Observable<any> {
    return this.http.post(url, body);
  }
}
