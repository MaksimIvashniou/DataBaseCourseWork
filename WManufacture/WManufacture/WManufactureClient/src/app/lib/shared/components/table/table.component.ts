import { SelectionModel } from '@angular/cdk/collections';
import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { EmployesTable } from '../../models/employes-table';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.scss']
})
export class TableComponent implements OnInit {

  @Input() columns: string[] = [];
  
  @Input() data: EmployesTable[] = [];

  public displayedColumns!: string[];

  public dataSource!: MatTableDataSource<EmployesTable>;

  public selection = new SelectionModel<any>(true, []);

  @ViewChild(MatSort, { static: true }) sort!: MatSort;

  constructor() { }

  ngOnInit() {
    // this.utilsService.$employesTable.subscribe(value => {
    //   this.dataSource = new MatTableDataSource(value);
    // });

    this.displayedColumns = this.columns;

    this.dataSource = new MatTableDataSource(this.data);

    this.dataSource.sort = this.sort;
  }

  isAllSelected() {
    const numSelected = this.selection.selected.length;

    const numRows = this.dataSource.data.length;

    return numSelected === numRows;
  }

  masterToggle() {
    this.isAllSelected()
      ? this.selection.clear()
      : this.dataSource.data.forEach(row => this.selection.select(row));
  }

  checkboxLabel(row?: any): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    else {
      return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.employ + 1}`;
    }
  }

}
