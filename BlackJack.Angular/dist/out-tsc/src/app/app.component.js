var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var __param = (this && this.__param) || function (paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
};
import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Headers } from '@angular/http';
var AppComponent = /** @class */ (function () {
    function AppComponent(http, baseUrl) {
        this.http = http;
        this.baseUrl = baseUrl;
        this.title = 'ClientApp';
        this.Players = [];
    }
    AppComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.createGame().subscribe(function (result) {
            console.log("Success!", result);
            var view = result.json();
            _this.Players = view.Players;
        });
    };
    AppComponent.prototype.createGame = function () {
        var obj = {
            PlayerName: "Dima",
            NumberOfBots: 3
        };
        var body = JSON.stringify(obj);
        var headers = new Headers({ 'Content-Type': 'application/json;charset=utf-8' });
        return this.http.post(this.baseUrl + "/api/game/start", body, { headers: headers });
    };
    AppComponent = __decorate([
        Component({
            selector: 'app-root',
            templateUrl: './app.component.html',
            styles: []
        }),
        __param(1, Inject('BASE_URL')),
        __metadata("design:paramtypes", [Http, String])
    ], AppComponent);
    return AppComponent;
}());
export { AppComponent };
//# sourceMappingURL=app.component.js.map