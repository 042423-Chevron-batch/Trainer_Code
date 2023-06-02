import { PokeStat } from './pokeStat';

export interface Pokemon {
    id: number,
    name: string,
    height: number,
    weight: number,
    stats: Array<PokeStat>,
    types: [
        {
            slot: number,
            type: {
                name: string
            }
        }
    ],
    sprites: {
        front_default: string
    }
}

