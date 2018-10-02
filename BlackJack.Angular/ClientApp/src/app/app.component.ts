import { Component, OnInit, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Response, Headers } from '@angular/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styles: []
})
export class AppComponent implements OnInit {
  title = 'ClientApp';
  public Players: any[];

  constructor(private http: Http,
    @Inject('BASE_URL') private baseUrl: string) {
    this.Players = [];
  }

  ngOnInit(): void {
    this.createGame().subscribe(result => {
      console.log("Success!", result);
      let view = result.json();
      this.Players = view.Players;
    });
  }

  public createGame() {
    let obj = {
      PlayerName: "Dima",
      NumberOfBots: 3
    };
    const body = JSON.stringify(obj);
    let headers = new Headers({ 'Content-Type': 'application/json;charset=utf-8' });
    return this.http.post(`${this.baseUrl}/api/game/start`, body, { headers: headers });
  }
}
