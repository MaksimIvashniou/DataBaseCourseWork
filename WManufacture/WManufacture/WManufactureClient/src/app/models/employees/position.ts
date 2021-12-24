import { Employee } from "./employee";
import { PositionPermission } from "./positionPermission";

export interface Position {

    id: number;

    name: string;

    employees: Employee[];

    positionPermissions: PositionPermission[];
}