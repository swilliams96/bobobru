import { Component, OnInit, Input } from '@angular/core';
import { Table } from '../../entities/table';

@Component({
  selector: 'app-table-editor',
  templateUrl: './table-editor.component.html',
  styleUrls: ['./table-editor.component.css']
})
export class TableEditorComponent implements OnInit {
  @Input() table: Table

  constructor() { }

  ngOnInit() {
  }

}
