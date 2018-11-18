import { Component, OnInit } from '@angular/core';
import { Table } from '../../entities/table';
import { Layout } from '../../entities/layout';
import { LayoutService } from '../services/layout.service';

@Component({
  selector: 'app-restaurant-designer',
  templateUrl: './restaurant-designer.component.html',
})
export class RestaurantDesignerComponent implements OnInit {
  public tables: Table[];
  public table: Table;
  public layout: Layout;
  public isSaved = true;

  constructor(private layoutService: LayoutService) { }

  ngOnInit() {
  }

  addTable(table: Table) {
    this.tables.push(table);
    this.isSaved = false;
  }

  selectTable(table: Table) {
    this.table = table;
  }

  selectLayout(layout: Layout) {
    if (this.isSaved) {
      this.layout = layout;
      if (layout.layoutId) {
        this.layoutService.getTables(layout.layoutId).subscribe(result => {
          this.tables = result;
        })
      } else {
        this.tables = [];
      }
    }
    else {
      console.log("unsaved changes");
    }    
  }

  save() {
    this.isSaved = true;
  }
}
