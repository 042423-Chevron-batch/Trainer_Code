/**
 * node is a C++ app that runs JS on the server.
 * -- it allows JS to access files on the local system, make calls to access dbs.
 * get node through node.JS
 * Node package manager is the organizational part of Node. if keeps track of all packages and installs/updates them when commanded to.
 * Googles Chrome V8 engine is used by both Chrome and Node.
 * Every Browser verson of the V8 engine.
 **/

// lets create and accesss a file with JS (backed by a node package)

let jerry = require('fs');// imported the 'fs' module

jerry.writeFileSync('./marksfile.txt', 'Marks sentence');
let number = 3
jerry.appendFileSync('./marksfile.txt', `this is the ${number} version of  Marks sentence`);

//let buff = jerry.readFileSync('./marksfile.txt', encode);


const MarksClass1 = require('./marksOtherFile.js');
const mmm = require('./yetanotherfile.js');

// let marksClass1 = new MarksClass(185, 34);

console.log(MarksClass1.extraFunction());

//let mm = new MarksClass.MarksClass(185, 22);
//console.log(mm.marksdeets());

let marksClass11 = new mmm(185, 34);

console.log(marksClass11.marksdeets());
