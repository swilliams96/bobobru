import { Injectable } from '@angular/core';

@Injectable()
export class SaveStateService {
  isSaved = true;

  constructor() { }

  break() {
    this.isSaved = false;
  }

  reset() {
    this.isSaved = true;
  }
}
