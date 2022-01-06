import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { Observable, of } from 'rxjs';
import { filter } from 'rxjs/operators';
import { INavigationItem } from './models/navigationItem';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  constructor(
    private router: Router
  ) { }

  public routes: INavigationItem[] = [];

  ngOnInit(): void {
    this.router.events
      .pipe(
        filter(event => event instanceof NavigationEnd)
      )
      .subscribe(() => {
        // if (this.router.url.startsWith('/employees')) {
        //   this._setRoutesValueForAdmin();
        // }
        this._setDefaultRoutesValue();
      });
  }

  private _setDefaultRoutesValue(): void {
    this.routes = [
      {
        name: 'Home',
        link: '/',
      },
      {
        name: 'About',
        link: '/about',
      },
      {
        name: 'Employees',
        link: '/employees',
      },
      {
        name: 'Work Objects',
        link: '/work-objects',
      },
      {
        name: 'Weldings',
        link: '/weldings',
      },
    ]
  }
}
