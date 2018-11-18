import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Table } from '../../entities/table';
import { Layout } from '../../entities/layout';
import { Link } from '../../entities/link';
import { ClickMode } from '../../entities/clickMode';

@Component({
  selector: 'app-restaurant-designer-menu',
  templateUrl: './restaurant-designer-menu.component.html',
  styleUrls: ['./restaurant-designer-menu.component.css']
})
export class RestaurantDesignerMenuComponent implements OnInit {
  public isLayout = true;
  public isTable = false;
  public isLink = false;
  @Input() table: Table;
  @Input() layout: Layout;
  @Input() links: Link[];
  @Output() linkDeleted = new EventEmitter();
  @Output() clickModeSet = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  private resetMenu() {
    this.isLayout = false;
    this.isTable = false
    this.isLink = false;
  }

  selectLayout() {
    this.resetMenu();
    this.isLayout = true;
    this.clickModeSet.emit(ClickMode.tableSelect);
  }

  selectTable() {
    this.resetMenu();
    this.isTable = true;
    this.clickModeSet.emit(ClickMode.dragAndDrop);
  }

  selectLink() {
    this.resetMenu();
    this.isLink = true;
    this.clickModeSet.emit(ClickMode.linkMaker);
  }

  deleteLink(link: Link) {
    this.linkDeleted.emit(link)
  }
}
