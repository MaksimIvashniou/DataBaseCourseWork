import { WorkObjectTask } from "./workObjectTask";

export interface WorkObjects {

    id: number;

    name: string;

    description: string;

    workObjectTasks: WorkObjectTask[];
}