import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditTagokComponent } from './add-edit-tagok.component';

describe('AddEditTagokComponent', () => {
  let component: AddEditTagokComponent;
  let fixture: ComponentFixture<AddEditTagokComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddEditTagokComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEditTagokComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
