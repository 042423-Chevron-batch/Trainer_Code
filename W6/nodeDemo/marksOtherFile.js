

let pob = 'dallas';
function extraFunction() {
  return `this is the other ${pob} method`;
}

// module.exports = MarksClass;

module.exports = {
  pob: pob,
  extraFunction: extraFunction
}