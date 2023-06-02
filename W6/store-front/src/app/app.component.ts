import { Component, OnInit } from '@angular/core';
import { PokeapiService } from './Services/pokeapi.service';
import { Pokemon } from './Models/pokemon';
import { FormControl, Validators} from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'store-front';
  pokemon : Pokemon = {
    id: 0,
    name: '',
    height: 0,
    weight: 0,
    stats: [],
    types: [
        {
            slot: 0,
            type: {
                name: ''
            }
        }
    ],
    sprites: {
        front_default: ''
    }
  }

  constructor(private poke: PokeapiService) { }
  pokeName : FormControl = new FormControl('', [Validators.required]);
  searchPokemon() : void {
    console.log(this.pokeName);
    if(this.pokeName.valid) {
      const pokename = this.pokeName.value.toLowerCase();
      this.poke.getPokemonByName(pokename).subscribe({
          next: (response)=> {
            this.pokemon = response;
            console.log(response);
          },
          error: (err) => {
            if(err.status === 404) {
              alert('we werent able to find the pokemon with name ' + this.pokeName.value);
            }
          }
      });
    }
  }

  ngOnInit() : void {
    this.poke.getPokemonByName("pidgeotto").subscribe((response)=> {
      this.pokemon = response;
    });
  }
}
