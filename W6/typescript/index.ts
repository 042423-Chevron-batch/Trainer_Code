let greet : string = "hello world!";
greet = "hi";
// string, number, string[], {}, boolean, etc.

let age : number | string = 12;

let petNames : Array<string | number> = ['pancake', 'ellie', 'aurynie'];

// You can specify your return type and parameter type here
function greetPeople(name : string) : string {
    return "hello!";
}

greetPeople("ellie!");

interface Pet {
    name: string,
    age: number,
    dob?: Date | string | number
}

let ellie : Pet = {
    name: 'Ellie',
    age: 15
}

function greetPets(petToGreet : Pet) : string | number {
    return `hello ${petToGreet.name}, you are ${petToGreet.age}`;
}

greetPets(ellie);