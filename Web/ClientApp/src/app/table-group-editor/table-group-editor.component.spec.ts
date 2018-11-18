import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TableGroupEditorComponent } from './table-group-editor.component';

describe('TableGroupEditorComponent', () => {
  let component: TableGroupEditorComponent;
  let fixture: ComponentFixture<TableGroupEditorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TableGroupEditorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TableGroupEditorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
