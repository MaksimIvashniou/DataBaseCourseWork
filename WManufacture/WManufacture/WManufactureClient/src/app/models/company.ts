import { Employee } from "./employees/employee";
import { WeldingMachine } from "./weldingMachines/weldingMachine";
import { WorkObjects } from "./workObjects/workObject";

export interface Company {

    id: number;

    name: string;

    employees: Employee[];

    weldingMacines: WeldingMachine[];

    workObjects: WorkObjects[];
}