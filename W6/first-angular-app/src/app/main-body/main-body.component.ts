import { Component } from '@angular/core';

@Component({
  selector: 'app-main-body',
  templateUrl: './main-body.component.html',
  styleUrls: ['./main-body.component.css']
})
export class MainBodyComponent {
  products : string[] = ["apple", "banana", "orange", "pineapple"];
  greet: string = "hello world!";

  today : Date = new Date();

  show: boolean = false;

  toggleShow() : void {
    this.show = !this.show;
  }

  formInvalid : boolean = false;
}