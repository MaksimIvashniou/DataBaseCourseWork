import { Employee } from "./employees/employee";
import { WeldingMachine } from "./weldingMachines/weldingMachine";
import { WorkObject } from "./workObjects/workObject";

export interface Company {

    id: number;

    name: string;

    employees: Employee[];

    weldingMacines: WeldingMachine[];

    workObjects: WorkObject[];
}