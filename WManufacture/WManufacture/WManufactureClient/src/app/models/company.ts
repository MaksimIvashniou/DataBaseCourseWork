import { Employee } from "./employees/employee";

export interface Company {

    id: number;

    name: string;

    employees: Employee[];
}