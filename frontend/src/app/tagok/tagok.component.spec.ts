import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TagokComponent } from './tagok.component';

describe('TagokComponent', () => {
  let component: TagokComponent;
  let fixture: ComponentFixture<TagokComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TagokComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TagokComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
