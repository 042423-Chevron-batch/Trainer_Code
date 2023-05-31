"use strict";
let greet = "hello world!";
greet = "hi";
// string, number, string[], {}, boolean, etc.
let age = 12;
let petNames = ['pancake', 'ellie', 'aurynie'];
// You can specify your return type and parameter type here
function greetPeople(name) {
    return "hello!";
}
greetPeople("ellie!");
let ellie = {
    name: 'Ellie',
    age: 15,
    dob: new Date(2008, 5, 30)
};
function greetPets(petToGreet) {
    return `hello ${petToGreet.name}, you are ${petToGreet.age}`;
}
greetPets(ellie);
