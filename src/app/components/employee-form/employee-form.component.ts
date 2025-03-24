import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeService } from '../../services/employee.service';

@Component({
  selector: 'app-employee-form',
  templateUrl: './employee-form.component.html',
  styleUrls: ['./employee-form.component.scss']
})
export class EmployeeFormComponent {
  employee = {
    name: '',
    gender: '',
    department: {
      HR: false,
      Sales: false,
      Finance: false,
      Engineer: false,
      Others: false
    },
    salary: '',
    startDate: {
      day: '',
      month: '',
      year: ''
    },
    notes: ''
  };

  salaryOptions = [25000, 30000, 35000, 40000, 45000, 50000];
  days = Array.from({ length: 31 }, (_, i) => i + 1);
  months = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];
  years = Array.from({ length: 50 }, (_, i) => new Date().getFullYear() - i);

  constructor(private employeeService: EmployeeService, private router: Router) {}

  addEmployee() {
    const selectedDepartments = Object.keys(this.employee.department)
      .filter((key) => this.employee.department[key as keyof typeof this.employee.department]);

    const newEmployee = {
      name: this.employee.name,
      gender: this.employee.gender,
      department: selectedDepartments,
      salary: Number(this.employee.salary),
      startDate: {
        day: Number(this.employee.startDate.day),
        month: this.employee.startDate.month,
        year: Number(this.employee.startDate.year)
      },
      notes: this.employee.notes
    };

    this.employeeService.addEmployee(newEmployee);
    console.log('Employee Added:', newEmployee);
    this.resetForm();
    this.router.navigate(['/employees']); 
  }

  resetForm() {
    this.employee = {
      name: '',
      gender: '',
      department: {
        HR: false,
        Sales: false,
        Finance: false,
        Engineer: false,
        Others: false
      },
      salary: '',
      startDate: {
        day: '',
        month: '',
        year: ''
      },
      notes: ''
    };
  }

  cancelForm() {
    console.log('Form Cancelled');
  }
}
