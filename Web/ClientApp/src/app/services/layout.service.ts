import { Inject, Injectable, Sanitizer } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Table } from '../../entities/table'
import { Layout } from '../../entities/layout'
import { DomSanitizer } from '@angular/platform-browser';

@Injectable()
export class LayoutService {
  private baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getTables(id: number) {
    return this.http.get<Table[]>(this.baseUrl + 'api/Layout/GetTables/' + id)
  }

  getLayouts(id: number) {
    return this.http.get<Layout[]>(this.baseUrl + 'api/Layout/GetLayouts/' + id);
  }

  updateTables(layoutId: number, tables: Table[]) {

  }

  saveTables(tables: Table[]) {
    // get restu
  }

}
