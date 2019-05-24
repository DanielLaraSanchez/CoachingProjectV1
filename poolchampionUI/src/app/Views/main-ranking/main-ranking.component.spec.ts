import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MainRankingComponent } from './main-ranking.component';

describe('MainRankingComponent', () => {
  let component: MainRankingComponent;
  let fixture: ComponentFixture<MainRankingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MainRankingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MainRankingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
