
//create a listener for the XML button
let xmlbutton = document.getElementById("xmljokebutton");
let fetchbutton = document.getElementsByClassName("fetchjokebutton");

function xmlSingleJoke() {
  //do everything to create the XHR object and call for one joke.
  // e.stopPropagation();
  console.log('The callback function was called.')
  let xhr = new XMLHttpRequest();

  xhr.onreadystatechange = function () {
    console.log(`The readystate is - ${this.readyState}`);

    switch (this.readyState) {
      case 1:
        console.log(`The readystate is 1?- ${this.readyState}`);
        break;
      case 2:
        console.log(`The readystate is 2?- ${this.readyState}`);
        break;
      case 3:
        console.log(`The readystate is 3?- ${this.readyState}`);
        break;
      case 4:
        //print the joke to the console.
        console.log(`The joke is \n ${this.responseText}`);
        let jsonReturn = JSON.parse(this.responseText);
        console.log(`The joke is... \n\t${jsonReturn.value}\n\n`);
        break;
    }
    console.log('The callback function is finished.')
  }

  console.log('about to open');
  xhr.open('GET', 'https://api.chucknorris.io/jokes/random');
  console.log('opened');
  xhr.send();
  console.log('sent');
}

function xmlRpsStores(e) {
  //do everything to create the XHR object and call for one joke.
  // e.stopPropagation();
  console.log('The STORES callback function was called.')
  let xhr = new XMLHttpRequest();

  xhr.onreadystatechange = function () {
    console.log(`The readystate is - ${this.readyState}`);

    switch (this.readyState) {
      case 1:
        console.log(`The readystate is 1?- ${this.readyState}`);
        break;
      case 2:
        console.log(`The readystate is 2?- ${this.readyState}`);
        break;
      case 3:
        console.log(`The readystate is 3?- ${this.readyState}`);
        break;
      case 4:
        //print the joke to the console.
        console.log(`The joke is \n ${this.responseText}`);
        let jsonReturn = JSON.parse(this.responseText);
        //console.log(`The joke is... \n\t${jsonReturn.value}\n\n`);
        break;
    }
    console.log('The callback function is finished.')
  }

  console.log('about to open');
  xhr.open('GET', 'http://localhost:5200/RockPaperScissors/stores');
  console.log('opened');
  xhr.send();
  console.log('sent');
}

// event listener
xmlbutton.addEventListener('click', xmlRpsStores);


//FETCH!!!!
fetch('https://api.chucknorris.io/jokes/random')
  .then(res => res.json(), err => new Error("there was an error"))
  .then(jsonres => console.log(jsonres))
  .finally(fin => console.log('The end has come...'))
  .catch(err => console.log(err))