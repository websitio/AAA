import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CostsEditComponent } from './costs-edit.component';

describe('CostsEditComponent', () => {
  let component: CostsEditComponent;
  let fixture: ComponentFixture<CostsEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CostsEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CostsEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
