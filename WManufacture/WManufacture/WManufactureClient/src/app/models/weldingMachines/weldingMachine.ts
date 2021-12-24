import { BookingWorkObjectTask } from "../workObjects/bookingWorkObjectTask";

export interface WeldingMachine {

    id: number;

    name: string;

    certificationDate: Date;

    bookingWorkObjectTasks: BookingWorkObjectTask[];
}