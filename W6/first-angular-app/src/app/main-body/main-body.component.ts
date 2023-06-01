import { Component, OnInit, OnDestroy } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormControl, Validators } from '@angular/forms';

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
    this.makeHttpRequest(1);
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
  numofCats : FormControl = new FormControl(1, [Validators.required, Validators.min(1), Validators.max(10)]);
  cats : CatImg[] = [];
  showFormControl() : void {
    console.log(this.numofCats);
  }

  makeHttpRequest(numCats : number) : void {
    this.http.get<CatImg[]>(`https://api.thecatapi.com/v1/images/search?limit=${numCats}`).subscribe((response) => {
      this.cats = response;
    })
  }
}