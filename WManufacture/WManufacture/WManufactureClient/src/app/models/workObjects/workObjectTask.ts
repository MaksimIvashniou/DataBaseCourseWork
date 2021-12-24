import { BookingWorkObjectTask } from "./bookingWorkObjectTask";

export interface WorkObjectTask {

    id: number;

    name: string;

    description: string;

    bookingWorkObjectTasks: BookingWorkObjectTask[];
}