import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowTagokComponent } from './show-tagok.component';

describe('ShowTagokComponent', () => {
  let component: ShowTagokComponent;
  let fixture: ComponentFixture<ShowTagokComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowTagokComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowTagokComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
