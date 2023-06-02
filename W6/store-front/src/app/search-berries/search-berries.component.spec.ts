import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchBerriesComponent } from './search-berries.component';

describe('SearchBerriesComponent', () => {
  let component: SearchBerriesComponent;
  let fixture: ComponentFixture<SearchBerriesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SearchBerriesComponent]
    });
    fixture = TestBed.createComponent(SearchBerriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
