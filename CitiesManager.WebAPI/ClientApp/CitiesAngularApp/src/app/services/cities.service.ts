import {Injectable} from '@angular/core';
import {City} from '../models/city';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';

const API_BASE_URL = "http://localhost:5284/api/";

@Injectable({
  providedIn: 'root'
})
export class CitiesService {
  cities: City[] = [];

  constructor(private httpClient: HttpClient) {
  }

  public getCities(): Observable<City[]> {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", "Bearer myToken")

    return this.httpClient.get<City[]>(`${API_BASE_URL}cities`, {headers: headers});
  }

  public postCity(city: City): Observable<City> {
    let headers = new HttpHeaders();
    headers = headers.append("Authorization", "Bearer myToken")

    return this.httpClient.post<City>(`${API_BASE_URL}cities`, city, {headers: headers});
  }
}
