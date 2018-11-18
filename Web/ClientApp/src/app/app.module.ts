import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { LayoutComponent } from './layout/layout.component'
import { LayoutService } from './services/layout.service';
import { RestaurantDesignerComponent } from './restaurant-designer/restaurant-designer.component';
import { RestaurantDesignerNavComponent } from './restaurant-designer-nav/restaurant-designer-nav.component';
import { RestaurantDesignerMenuComponent } from './restaurant-designer-menu/restaurant-designer-menu.component';
import { TableEditorComponent } from './table-editor/table-editor.component';
import { TableGroupEditorComponent } from './table-group-editor/table-group-editor.component';
import { LayoutEditorComponent } from './layout-editor/layout-editor.component';

@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    RestaurantDesignerComponent,    
    RestaurantDesignerNavComponent,
    RestaurantDesignerMenuComponent,
    TableEditorComponent,
    TableGroupEditorComponent,
    LayoutEditorComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'restaurantdesigner', component: RestaurantDesignerComponent }
    ])
  ],
  providers: [LayoutService],
  bootstrap: [AppComponent]
})
export class AppModule { }
