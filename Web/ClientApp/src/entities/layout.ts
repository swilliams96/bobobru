import { SafeHtml } from "@angular/platform-browser";

export interface Layout {
  layoutId: number;
  restaurantId: number;
  name: string;
  active: boolean;
  image: string;
  safeImage: SafeHtml;
  tableCount: number;
}
