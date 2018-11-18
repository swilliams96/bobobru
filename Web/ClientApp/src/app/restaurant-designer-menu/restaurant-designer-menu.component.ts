import { Component, OnInit, Input } from '@angular/core';
import { Table } from '../../entities/table';
import { Layout } from '../../entities/layout';

@Component({
  selector: 'app-restaurant-designer-menu',
  templateUrl: './restaurant-designer-menu.component.html',
  styleUrls: ['./restaurant-designer-menu.component.css']
})
export class RestaurantDesignerMenuComponent implements OnInit {
  public isLayout = true;
  public isTable = false;
  public isTableGroup = false;
  @Input() table: Table;
  @Input() layout: Layout;


  constructor() { }

  ngOnInit() {
  }

  private resetMenu() {
    this.isLayout = false;
    this.isTable = false
    this.isTableGroup = false;
  }

  selectLayout() {
    this.resetMenu();
    this.isLayout = true;
  }

  selectTable() {
    this.resetMenu();
    this.isTable = true;
  }

  selectTableGroup() {
    this.resetMenu();
    this.isTableGroup = true;
  }
}
