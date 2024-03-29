import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { LookupComponent } from './lookup.component';
import { GenderListComponent } from './gender/gender-list/gender-list.component';
import { EquityListComponent } from './equity/equity-list/equity-list.component';
import { EmployeeDeptsListComponent } from './employee-depts/employee-depts-list/employee-depts-list.component';

const routes: Routes = [{
  path: '',
  component: LookupComponent,
  children: [
    {
      path: 'equity',
      component: EquityListComponent,
    },
    {
      path: 'gender',
      component: GenderListComponent,
    },
    {
      path: 'employee-depts',
      component: EmployeeDeptsListComponent,
    },
  ]
}]

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class LookupRoutingModule { }
