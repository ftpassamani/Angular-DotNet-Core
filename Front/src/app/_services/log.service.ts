import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class LogService {
    private url = 'http://localhost:49578/api/Log/GetLogsAcesso';

    constructor(private http: HttpClient) { }

}