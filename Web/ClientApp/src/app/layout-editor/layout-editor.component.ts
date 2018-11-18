import { Component, OnInit, Input } from '@angular/core';
import { Layout } from '../../entities/layout';

@Component({
  selector: 'app-layout-editor',
  templateUrl: './layout-editor.component.html',
  styleUrls: ['./layout-editor.component.css']
})
export class LayoutEditorComponent implements OnInit {
  @Input() layout: Layout;

  constructor() { }

  ngOnInit() {
  }

}
