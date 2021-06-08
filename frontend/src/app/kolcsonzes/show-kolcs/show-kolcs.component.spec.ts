import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowKolcsComponent } from './show-kolcs.component';

describe('ShowKolcsComponent', () => {
  let component: ShowKolcsComponent;
  let fixture: ComponentFixture<ShowKolcsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowKolcsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowKolcsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
