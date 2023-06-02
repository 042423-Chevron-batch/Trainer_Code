
class MarksClass {
  constructor(height, width) {
    this.height = height;
    this.width = width;
  }

  marksdeets = function () {
    return `Marks height is ${this.height} and his circumference is ${this.width}.`;

  }
}

module.exports = MarksClass;