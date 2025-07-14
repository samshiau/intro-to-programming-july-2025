import { ChangeDetectionStrategy, Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { CounterStore } from './services/counter-stores';

@Component({
  selector: 'app-demos',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [RouterLink, RouterOutlet],
  providers: [CounterStore],
  template: `
    <div class="flex flex-row gap-4">
      <a routerLink="counter" class="btn btn-primary">Counter</a>
      <a routerLink="prefs" class="btn btn-primary">Prefs</a>
    </div>
    <div>
      <router-outlet />
    </div>
  `,
  styles: ``,
})
export class Demo {}
