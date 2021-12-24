import { PositionPermission } from "./positionPermission";

export interface Permission {

    id: number;

    name: string;

    positionPermissions: PositionPermission[];
}