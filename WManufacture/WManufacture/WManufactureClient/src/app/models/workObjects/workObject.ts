import { WorkObjectTask } from "./workObjectTask";

export interface WorkObject {

    id: number;

    name: string;

    description: string;

    workObjectTasks: WorkObjectTask[];
}