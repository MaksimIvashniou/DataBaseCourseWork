import { BookingWorkObjectTask } from "../workObjects/bookingWorkObjectTask";

export interface Employee {

    id: number;

    login: string;

    bookingWorkObjectTasks: BookingWorkObjectTask[];
}