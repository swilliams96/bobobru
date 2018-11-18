import { ShapeType } from './shapeType'

export interface Table {
  tableId: number;
  tableGroupId: number;
  name: string;
  x: number;
  y: number;
  width: number;
  height: number;
  radius: number;
  seatCount: number;
}
