import { WeldingMachine } from "./weldingMachine";

export interface ModelOfWeldingMachine {

    id: number;

    name: string;

    weldingMachines: WeldingMachine[];
}