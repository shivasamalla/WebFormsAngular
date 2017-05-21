import { Component } from '@angular/core';

export class Hero {
    id: number;
    name: string;
}

@Component({
  selector: 'my-app',
  //template: '<h1>Hello {{name}}</h1>'
  templateUrl: "./hello-world.html"
})
export class AppComponent { name = 'Angular'; }

