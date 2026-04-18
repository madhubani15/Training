import { Routes } from '@angular/router';
import { Home } from './Order-Tracking-App/home/home';
import { Orders } from './Order-Tracking-App/orders/orders';

export const routes: Routes = [
  { path: '', component: Home },
  { path: 'orders', component: Orders }
];
