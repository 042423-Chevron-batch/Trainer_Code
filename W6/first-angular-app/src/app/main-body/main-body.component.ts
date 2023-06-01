import { Component, OnInit, OnDestroy } from '@angular/core';
import { HttpClient } from '@angular/common/http';

interface CatImg {
  height: number,
  id : string,
  url : string,
  width : number
}
@Component({
  selector: 'app-main-body',
  templateUrl: './main-body.component.html',
  styleUrls: ['./main-body.component.css']
})
export class MainBodyComponent implements OnInit, OnDestroy {

  // This is constructor for this class
  // Dependency injection happens here
  constructor(private http: HttpClient) { }

  // Lifecycle hooks- This particular method, gets called whenever the componet loads for the first time
  // This is great place to do any data fetching before you load the component
  ngOnInit(): void {
    this.makeHttpRequest();
  }

  ngOnDestroy(): void {
    console.log('this one is called when this component unmounts');
    // This is a great place to do any sort of clean ups
  }
  products : string[] = ["apple", "banana", "orange", "pineapple"];
  greet: string = "hello world!";

  today : Date = new Date();

  show: boolean = false;

  toggleShow() : void {
    this.show = !this.show;
  }

  formInvalid : boolean = false;
  cats : CatImg[] = [];

  makeHttpRequest() : void {
    this.http.get<CatImg[]>("https://api.thecatapi.com/v1/images/search?limit=10").subscribe((response) => {
      this.cats = response;
    })
  }
}