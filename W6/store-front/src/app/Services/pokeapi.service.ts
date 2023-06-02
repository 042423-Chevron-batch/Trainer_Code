import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Environment } from 'src/environment';
import { Observable } from 'rxjs';
import { Pokemon } from '../Models/pokemon';
@Injectable({
  providedIn: 'root'
})
export class PokeapiService {

  constructor(private http: HttpClient) { }

  getPokemonByName(name: string) : Observable<Pokemon> {
    return this.http.get<Pokemon>(`${Environment.pokeApiBaseURL}${name}`);
  }
}