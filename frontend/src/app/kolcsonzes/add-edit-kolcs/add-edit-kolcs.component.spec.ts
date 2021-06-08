import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditKolcsComponent } from './add-edit-kolcs.component';

describe('AddEditKolcsComponent', () => {
  let component: AddEditKolcsComponent;
  let fixture: ComponentFixture<AddEditKolcsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddEditKolcsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddEditKolcsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
