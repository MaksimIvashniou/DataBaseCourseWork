import { Observable } from "rxjs";

export interface INavigationItem {

    name: string;

    link: string;
    
    hidden?: boolean | Observable<boolean>;
}