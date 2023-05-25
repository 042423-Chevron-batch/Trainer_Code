function formSubmitted(e, x) {
  e.preventDefault();
  console.log(`you submitted ${x} form.`);
  console.log(e);
  console.log(e.target[1].value);
}

console.log(`Hello, world`);
var x = 5;// old version Don't use unless you have to.
let y = 6;// new version. Use this to enforce scope.

console.log(`The value of x and y is ${x + y}`);

function myScope(x1) {
  var y1 = "Mark"
  console.log(`${y1} has ${x1} pogs`);
}

// using var lets you use values defined inside a scope outside of that scope.
{
  var yy = 4// var values can be used outside the scope in which they are defined.
}

myScope(42);
console.log(yy);

const Y2 = 43
console.log(Y2);
//Y2 = 3;// you can't reassign a const variable


// JS has WEAK TYPING
let y4 = "Mark as a string";
console.log(y4)
y4 = 43;
console.log(y4)
y4 = 240973.000321
console.log(y4)

// Number and big int type
let y5 = 25042000n;// big int
console.log(typeof y5);// Number

// string
let y6 = "Mark"
console.log(typeof y6);// string

// boolean
console.log(typeof (5 > 3));

//ubdefined
let y7;
console.log(typeof y7);

// operand = the thing acted upon
// operator = the thing doing the act
let y8 = 10 ** 3;
let y9 = Math.pow(y8, 3)
console.log(`y8 is ${y8}\ny9 is ${y9}`);
let y10 = Math.floor(324.543);
console.log(y10);
let y11 = Math.ceil(324.543);
console.log(y11);
let y12 = Math.round(324.443);
console.log(y12);

y8 += y9;// these are the same.
y8 = y8 + y9;
console.log(y8);

console.log(1200 % 6);// modulo gives the remainder

y9 /= y10// these are the same
y9 = y9 / y10;
console.log(y9);

//JS has =, ==, ===
// =  assignment
y13 = 21;

// == comparison with "type coersion"
let y14 = "2345"
let y15 = 2345;
console.log(y14 == y15);

let y16 = 1000000000n;
let y17 = 1000000000;
console.log(y16 == y17);

// === strict equality
console.log(y14 === y15);
console.log(y16 === y17);

// truthy and falsy
let y18 = null;

if (y18) {
  console.log("y18 is true");
}
else {
  console.log("y18 is false");
}

console.log(Boolean(y18));//false
console.log(Boolean(`false`));//true

// user interaction
// alert("You have run out of time");
// let answer1 = prompt("This is you prompt", "yes");
// console.log(answer1);

// JSON (JavaScript Object Notation)
let mark = {
  age: 43,
  fname: "Mark",
  lname: "moore",
}

//let answer2 = prompt("How old is Mark?", 1000);

//console.log(`${mark.fname} is ${answer2} years old.`);

console.log(mark);// print mark Object
let marStr = JSON.stringify(mark);
console.log(marStr);// print mark Object
let mark1 = JSON.parse(marStr);
console.log(mark1);// print mark Object


// JS flow control statements

// 1. if/else
let q1 = "";
let q2 = NaN;
if (q1) {
  //take this branch if the compared value is true
  console.log(`(true)q1 is ${q1}`);
}
else if (q2) {
  //take this branch if the compared value is true
  console.log(`(q2 is true) q1 is ${q1}`);
}
else {
  console.log(`none of the above is true`);
}


//2. for loop
for (let x = 0; x < 20; x++) {
  console.log(`x is ${x}`);
}

// foreach loop on arrays
let x1 = [1, 2, 3, 4, 5];
x1.forEach(function (el, index, array) {
  array[index] = el * 2
});

console.log(x1);
x1.forEach(w => console.log(w));

//3. do/while
// 5. while
let mybool1 = true;
let iterator = 0;
while (mybool1) {
  console.log(`The value of myBool1 ids ${mybool1}. iterator is ${iterator}`);
  iterator += ++iterator;
  if (iterator > 30) {
    mybool1 = !mybool1;
  }
}

mybool1 = false;
do {
  console.log(`The value of myBool1 ids ${mybool1}. iterator is ${iterator}`);
  iterator += ++iterator;
  if (iterator > 30) {
    mybool1 = !mybool1;
  }
} while (mybool1);

// 4. switch
const expr = 'Oranges';
switch (expr) {
  case 'Oranges':
    console.log('Oranges are $0.59 a pound.');
    break;
  case 'Mangoes':
  case 'Papayas':
    console.log('Mangoes and papayas are $2.79 a pound.');
    // Expected output: "Mangoes and papayas are $2.79 a pound."
    break;
  default:
    console.log(`Sorry, we are out of ${expr}.`);
}

// function declaration
function myFunc1(v1) {
  switch (typeof v1) {
    case 'function':
      myFunc1(25);
      break;
    case 'string':
      console.log(`v1 is a string => ${v1}`);
      break;
    case ('number' && (v1 == 25))://TODO
      console.log(`Congrats! you nailed it! => ${v1}`);
    case 'number':
      console.log(`v1 is a number => ${v1}`);
      break;
    case 'bigint':
      console.log(`v1 is a bigint => ${v1}`);
      break;
    default:
      console.log(`Sorry, we are out of ${v1}.`);
  }
}

//arrow function version of the above function.
let myFunc4 = (v1) => {
  switch (typeof v1) {
    case 'function':
      myFunc1(25);
      break;
    case 'string':
      console.log(`v1 is a string => ${v1}`);
      break;
    case ('number' && (v1 == 25))://TODO
      console.log(`Congrats! you nailed it! => ${v1}`);
    case 'number':
      console.log(`v1 is a number => ${v1}`);
      break;
    case 'bigint':
      console.log(`v1 is a bigint => ${v1}`);
      break;
    default:
      console.log(`Sorry, we are out of ${v1}.`);
  }
}


//myFunc1();// call the function
//console.log(myFunc1);
// console.log(myFunc1);
myFunc1(myFunc1);// myFunc1 becomes a 'callback function when used as an argument.
myFunc1("fly!");
myFunc1(1000n);

// function expression
let myFunc2 = function (x, y, z) {
  return `This is ${x} ${y} ${z}`;
}

console.log(myFunc2(1, 2, 3));

let res1 = myFunc2(1, 2);
console.log(res1);

// arrow syntax (arrow function)
let myFunc3 = (x, y, z) => `This is ${x} ${y} ${z}`;
let res2 = myFunc3(1, 2);
console.log(res2);

// IIFE (Immediately Invoked Function Expressions)
(function () {
  console.log(`This is the IIFE!`);
})()


// closure and nested scope.
function makeCounter() {
  let count = 0;
  return function () {
    return count++;
  }
}

let res3 = makeCounter();
// console.log(makeCounter());
console.log(res3());
console.log(res3());
console.log(res3());
console.log(res3());
console.log(res3());
console.log(res3());

let closureEx = function (x) {
  return function (y) {
    return x + y;
  }
}

console.log(closureEx());
let closureEx1 = closureEx(100);
console.log(closureEx1);
let closureEx2 = closureEx1(100)
console.log(closureEx2);

try {
  console.log("This is the message int he try block.");
  throw new SyntaxError()
  console.log("This is the message int he try block.");
} catch (err) {
  console.log(`the error is ${err}.. in the catch block`);
}
finally {
  console.log(`I'm the finally block that always runs.`);
}

// save an item to localstorage
let var1 = "Mark is a Not-so-nice guy."
localStorage.setItem(1, var1);

// get an item our of local storage.
let var2 = localStorage.getItem(1);
console.log(var1);

//daving an object to localstorage.
let obj1 = {
  height: 12.2,
  weight: 52,
  Remarks: "This is so useful!"
}

localStorage.setItem(2, JSON.stringify(obj1));

// get an item our of local storage.
let var3 = JSON.parse(localStorage.getItem(2));

console.log(var3);
let cart = {
  item1: 19382848385838281
}

localStorage.setItem(2684837475893, 2);
localStorage.setItem(2684837475891, 1);
localStorage.setItem(2684837475892, 3);
localStorage.setItem(2684837475894, 5);
localStorage.setItem(2684837475895, 1);






