import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class EmployeeService {
  private employees: {
    name: string;
    gender: string;
    department: string[];
    salary: number;
    startDate: { day: number; month: string; year: number };
    notes: string;
  }[] = [];

  constructor() {
    const savedEmployees = localStorage.getItem('employees');
    if (savedEmployees) {
      this.employees = JSON.parse(savedEmployees);
    }
  }

  getEmployees() {
    return this.employees;
  }

  addEmployee(employee: {
    name: string;
    gender: string;
    department: string[];
    salary: number;
    startDate: { day: number; month: string; year: number };
    notes: string;
  }) {
    this.employees.push(employee);
    localStorage.setItem('employees', JSON.stringify(this.employees));
  }
}
