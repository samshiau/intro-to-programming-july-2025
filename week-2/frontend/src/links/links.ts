import { JsonPipe } from '@angular/common';
import { Component, ChangeDetectionStrategy, resource } from '@angular/core';

@Component({
  selector: 'app-links',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: `
    <p>Links Will Go Here</p>
    @for (link of links.value(); track link.id) {
      <div class="card">
        <div class="card-body">
          <div class="card-title">{{ link.href }}</div>
          {{ link.description }}
        </div>
      </div>
    }
  `,
  styles: ``,
})
export class Links {
  links = resource({
    loader: () =>
      fetch('http://api.realsever-but-not-really.com/links').then((r) =>
        r.json(),
      ),
  });
}
