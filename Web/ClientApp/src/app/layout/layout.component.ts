import { Component, Inject, Input, OnInit, EventEmitter, Output } from '@angular/core';
import { Table } from '../../entities/table'

const defaultTableName = 'My New Table';
const defaultTableWidth = 10;
const defaultTableHeight = 20;

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html'
})
export class LayoutComponent implements OnInit {    
  @Input() tables: Table[];
  @Output() tableSelected = new EventEmitter();
  @Output() tablesSaved = new EventEmitter();
  @Output() tableAdded = new EventEmitter();

  constructor() { }

  ngOnInit() {}

  selectTable(table: Table) {
    this.tableSelected.emit(table);
  }

  addTable(x: number, y: number, radius: number) {
    var table = <Table>{}
    table.name = defaultTableName;
    table.seatCount = 0;
    table.tableGroupId = 0;
    table.x = x;
    table.y = y;
    table.radius = radius;
    table.height = (radius == 0) ? defaultTableHeight : 0;
    table.width = (radius == 0) ? defaultTableWidth : 0;
    this.tableAdded.emit(table);
  }
}


