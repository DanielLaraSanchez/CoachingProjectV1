(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./src/$$_lazy_route_resource lazy recursive":
/*!**********************************************************!*\
  !*** ./src/$$_lazy_route_resource lazy namespace object ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./src/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./src/app/Components/login/login.component.css":
/*!******************************************************!*\
  !*** ./src/app/Components/login/login.component.css ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".main-container-wrapper {\r\n    height: 100vh;\r\n}\r\n\r\n.main-row{\r\n    height:100%;\r\n}\r\n\r\n.bg-col{\r\n    background-image: url('loginBG2.jpg');\r\n    max-height:100%;\r\n    min-height:100%;\r\n\r\n    background-repeat: no-repeat;\r\n\r\n}\r\n\r\n.login-col{\r\n    height:100vh;\r\n    width:100%;\r\n}\r\n\r\n.login-container {\r\n    height:100%;\r\n}\r\n\r\n.login-row{\r\n    height:100%;\r\n}\r\n\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvQ29tcG9uZW50cy9sb2dpbi9sb2dpbi5jb21wb25lbnQuY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUFBO0lBQ0ksYUFBYTtBQUNqQjs7QUFFQTtJQUNJLFdBQVc7QUFDZjs7QUFFQTtJQUNJLHFDQUFzRDtJQUN0RCxlQUFlO0lBQ2YsZUFBZTs7SUFFZiw0QkFBNEI7O0FBRWhDOztBQUdBO0lBQ0ksWUFBWTtJQUNaLFVBQVU7QUFDZDs7QUFFQTtJQUNJLFdBQVc7QUFDZjs7QUFFQTtJQUNJLFdBQVc7QUFDZiIsImZpbGUiOiJzcmMvYXBwL0NvbXBvbmVudHMvbG9naW4vbG9naW4uY29tcG9uZW50LmNzcyIsInNvdXJjZXNDb250ZW50IjpbIi5tYWluLWNvbnRhaW5lci13cmFwcGVyIHtcclxuICAgIGhlaWdodDogMTAwdmg7XHJcbn1cclxuXHJcbi5tYWluLXJvd3tcclxuICAgIGhlaWdodDoxMDAlO1xyXG59XHJcblxyXG4uYmctY29se1xyXG4gICAgYmFja2dyb3VuZC1pbWFnZTogdXJsKFwiLi4vLi4vLi4vYXNzZXRzL2xvZ2luQkcyLmpwZ1wiKSA7XHJcbiAgICBtYXgtaGVpZ2h0OjEwMCU7XHJcbiAgICBtaW4taGVpZ2h0OjEwMCU7XHJcblxyXG4gICAgYmFja2dyb3VuZC1yZXBlYXQ6IG5vLXJlcGVhdDtcclxuXHJcbn1cclxuXHJcblxyXG4ubG9naW4tY29se1xyXG4gICAgaGVpZ2h0OjEwMHZoO1xyXG4gICAgd2lkdGg6MTAwJTtcclxufVxyXG5cclxuLmxvZ2luLWNvbnRhaW5lciB7XHJcbiAgICBoZWlnaHQ6MTAwJTtcclxufVxyXG5cclxuLmxvZ2luLXJvd3tcclxuICAgIGhlaWdodDoxMDAlO1xyXG59XHJcbiJdfQ== */"

/***/ }),

/***/ "./src/app/Components/login/login.component.html":
/*!*******************************************************!*\
  !*** ./src/app/Components/login/login.component.html ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!-- <div class=\"container-fluid main-container-wrapper\">\r\n    <div class=\"row main-row\">\r\n      <div class=\"col-lg-8 bg-col\"></div>\r\n      <div class=\"col-lg-4 login-col\">\r\n        <div class=\"container-fluid login-container\">\r\n          <div class=\"row justify-content-center align-items-center login-row\">\r\n            <div class=\"col-lg-5 text-center\"> -->\r\n  \r\n              <form class=\"example-form\">\r\n                   <mat-form-field class=\"example-full-width\">\r\n                  <input matInput placeholder=\"Email\" [formControl]=\"emailFormControl\">\r\n                  <mat-error *ngIf=\"emailFormControl.hasError('email') && !emailFormControl.hasError('required')\">\r\n                    Please enter a valid email address\r\n                  </mat-error>\r\n                  <mat-error *ngIf=\"emailFormControl.hasError('required')\">\r\n                    Email is <strong>required</strong>\r\n                  </mat-error>\r\n                </mat-form-field>\r\n  \r\n                <mat-form-field class=\"example-full-width\">\r\n                  <input matInput type=\"password\" placeholder=\"Password\">\r\n                </mat-form-field>\r\n               \r\n                <br />\r\n                <br />\r\n  \r\n                <button mat-raised-button color=\"primary\">Primary</button>\r\n                <br />\r\n                <br />\r\n  \r\n  \r\n                <a href=\"#\" class=\"btn btn-link\">forgot Password?</a> \r\n                <a href=\"signup\" class=\"btn btn-link\">Signup</a>\r\n  \r\n                <br />\r\n  \r\n  \r\n              </form>\r\n  \r\n            <!-- </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n   -->"

/***/ }),

/***/ "./src/app/Components/login/login.component.ts":
/*!*****************************************************!*\
  !*** ./src/app/Components/login/login.component.ts ***!
  \*****************************************************/
/*! exports provided: LoginComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginComponent", function() { return LoginComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _route_animations__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../route-animations */ "./src/app/route-animations.ts");




var LoginComponent = /** @class */ (function () {
    function LoginComponent() {
        this.emailFormControl = new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', [
            _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required,
            _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].email,
        ]);
    }
    LoginComponent.prototype.ngOnInit = function () {
    };
    LoginComponent.prototype.prepareRoute = function (outlet) {
        return outlet && outlet.activatedRouteData && outlet.activatedRouteData['animation'];
    };
    LoginComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-login',
            template: __webpack_require__(/*! ./login.component.html */ "./src/app/Components/login/login.component.html"),
            animations: [
                _route_animations__WEBPACK_IMPORTED_MODULE_3__["fader"]
                // slider,
                // transformer,
            ],
            styles: [__webpack_require__(/*! ./login.component.css */ "./src/app/Components/login/login.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], LoginComponent);
    return LoginComponent;
}());



/***/ }),

/***/ "./src/app/Views/login-page/login-page.component.css":
/*!***********************************************************!*\
  !*** ./src/app/Views/login-page/login-page.component.css ***!
  \***********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".main-container-wrapper {\r\n    height: 100vh;\r\n}\r\n\r\n.main-row{\r\n    height:100%;\r\n}\r\n\r\n.bg-col{\r\n    background-image: url('loginBG2.jpg');\r\n    max-height:100%;\r\n    min-height:100%;\r\n\r\n    background-repeat: no-repeat;\r\n\r\n}\r\n\r\n.login-col{\r\n    height:100vh;\r\n    width:100%;\r\n}\r\n\r\n.login-container {\r\n    height:100%;\r\n}\r\n\r\n.login-row{\r\n    height:100%;\r\n}\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvVmlld3MvbG9naW4tcGFnZS9sb2dpbi1wYWdlLmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7SUFDSSxhQUFhO0FBQ2pCOztBQUVBO0lBQ0ksV0FBVztBQUNmOztBQUVBO0lBQ0kscUNBQXNEO0lBQ3RELGVBQWU7SUFDZixlQUFlOztJQUVmLDRCQUE0Qjs7QUFFaEM7O0FBR0E7SUFDSSxZQUFZO0lBQ1osVUFBVTtBQUNkOztBQUVBO0lBQ0ksV0FBVztBQUNmOztBQUVBO0lBQ0ksV0FBVztBQUNmIiwiZmlsZSI6InNyYy9hcHAvVmlld3MvbG9naW4tcGFnZS9sb2dpbi1wYWdlLmNvbXBvbmVudC5jc3MiLCJzb3VyY2VzQ29udGVudCI6WyIubWFpbi1jb250YWluZXItd3JhcHBlciB7XHJcbiAgICBoZWlnaHQ6IDEwMHZoO1xyXG59XHJcblxyXG4ubWFpbi1yb3d7XHJcbiAgICBoZWlnaHQ6MTAwJTtcclxufVxyXG5cclxuLmJnLWNvbHtcclxuICAgIGJhY2tncm91bmQtaW1hZ2U6IHVybChcIi4uLy4uLy4uL2Fzc2V0cy9sb2dpbkJHMi5qcGdcIikgO1xyXG4gICAgbWF4LWhlaWdodDoxMDAlO1xyXG4gICAgbWluLWhlaWdodDoxMDAlO1xyXG5cclxuICAgIGJhY2tncm91bmQtcmVwZWF0OiBuby1yZXBlYXQ7XHJcblxyXG59XHJcblxyXG5cclxuLmxvZ2luLWNvbHtcclxuICAgIGhlaWdodDoxMDB2aDtcclxuICAgIHdpZHRoOjEwMCU7XHJcbn1cclxuXHJcbi5sb2dpbi1jb250YWluZXIge1xyXG4gICAgaGVpZ2h0OjEwMCU7XHJcbn1cclxuXHJcbi5sb2dpbi1yb3d7XHJcbiAgICBoZWlnaHQ6MTAwJTtcclxufSJdfQ== */"

/***/ }),

/***/ "./src/app/Views/login-page/login-page.component.html":
/*!************************************************************!*\
  !*** ./src/app/Views/login-page/login-page.component.html ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"container-fluid main-container-wrapper\">\r\n    <div class=\"row main-row\">\r\n      <div class=\"col-lg-8 bg-col\"></div>\r\n      <div class=\"col-lg-4 login-col\">\r\n        <div class=\"container-fluid login-container\">\r\n          <div class=\"row justify-content-center align-items-center login-row\">\r\n            <div class=\"col-lg-5 text-center\" *ngIf=\"needsToRegister === false\">\r\n  \r\n                <form class=\"example-form\">\r\n                    <mat-form-field class=\"example-full-width\">\r\n                   <input matInput placeholder=\"Email\" [formControl]=\"emailFormControl\">\r\n                   <mat-error *ngIf=\"emailFormControl.hasError('email') && !emailFormControl.hasError('required')\">\r\n                     Please enter a valid email address\r\n                   </mat-error>\r\n                   <mat-error *ngIf=\"emailFormControl.hasError('required')\">\r\n                     Email is <strong>required</strong>\r\n                   </mat-error>\r\n                 </mat-form-field>\r\n   \r\n                 <mat-form-field class=\"example-full-width\">\r\n                   <input matInput type=\"password\" placeholder=\"Password\">\r\n                 </mat-form-field>\r\n                \r\n                 <br />\r\n                 <br />\r\n   \r\n                 <button mat-raised-button color=\"primary\">Login</button>\r\n                 <br />\r\n                 <br />\r\n   \r\n   \r\n                 <a href=\"#\" class=\"btn btn-link\">forgot Password?</a> \r\n                 <button (click)=\"switchOnSignup()\" class=\"btn btn-link\">Signup</button>\r\n   \r\n                 <br />\r\n   \r\n   \r\n               </form>\r\n   \r\n             </div>\r\n\r\n             <div class=\"col-lg-5 text-center\" *ngIf=\"needsToRegister === true\">\r\n  \r\n                <form class=\"example-form\">\r\n                    <mat-form-field class=\"example-full-width\">\r\n                   <input matInput placeholder=\"Email\" [formControl]=\"emailFormControl\">\r\n                   <mat-error *ngIf=\"emailFormControl.hasError('email') && !emailFormControl.hasError('required')\">\r\n                     Please enter a valid email address\r\n                   </mat-error>\r\n                   <mat-error *ngIf=\"emailFormControl.hasError('required')\">\r\n                     Email is <strong>required</strong>\r\n                   </mat-error>\r\n                 </mat-form-field>\r\n   \r\n                 <mat-form-field class=\"example-full-width\">\r\n                   <input matInput type=\"password\" placeholder=\"Password\">\r\n                 </mat-form-field>\r\n                \r\n                 <br />\r\n                 <br />\r\n   \r\n                 <button mat-raised-button color=\"primary\">Login</button>\r\n                 <br />\r\n                 <br />\r\n   \r\n   \r\n                 <a href=\"#\" class=\"btn btn-link\">forgot Password?</a> \r\n                 <a href=\"signup\" class=\"btn btn-link\">Signup</a>\r\n   \r\n                 <br />\r\n   \r\n   \r\n               </form>\r\n   \r\n             </div>\r\n\r\n           </div>\r\n         </div>\r\n       </div>\r\n     </div>\r\n   \r\n"

/***/ }),

/***/ "./src/app/Views/login-page/login-page.component.ts":
/*!**********************************************************!*\
  !*** ./src/app/Views/login-page/login-page.component.ts ***!
  \**********************************************************/
/*! exports provided: LoginPageComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LoginPageComponent", function() { return LoginPageComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");



var LoginPageComponent = /** @class */ (function () {
    function LoginPageComponent() {
        this.emailFormControl = new _angular_forms__WEBPACK_IMPORTED_MODULE_2__["FormControl"]('', [
            _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].required,
            _angular_forms__WEBPACK_IMPORTED_MODULE_2__["Validators"].email,
        ]);
        this.needsToRegister = false;
    }
    LoginPageComponent.prototype.ngOnInit = function () {
    };
    LoginPageComponent.prototype.switchOnSignup = function () {
        this.needsToRegister = true;
    };
    LoginPageComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-login-page',
            template: __webpack_require__(/*! ./login-page.component.html */ "./src/app/Views/login-page/login-page.component.html"),
            styles: [__webpack_require__(/*! ./login-page.component.css */ "./src/app/Views/login-page/login-page.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], LoginPageComponent);
    return LoginPageComponent;
}());



/***/ }),

/***/ "./src/app/Views/main-ranking/main-ranking.component.css":
/*!***************************************************************!*\
  !*** ./src/app/Views/main-ranking/main-ranking.component.css ***!
  \***************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL1ZpZXdzL21haW4tcmFua2luZy9tYWluLXJhbmtpbmcuY29tcG9uZW50LmNzcyJ9 */"

/***/ }),

/***/ "./src/app/Views/main-ranking/main-ranking.component.html":
/*!****************************************************************!*\
  !*** ./src/app/Views/main-ranking/main-ranking.component.html ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  main-ranking works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/Views/main-ranking/main-ranking.component.ts":
/*!**************************************************************!*\
  !*** ./src/app/Views/main-ranking/main-ranking.component.ts ***!
  \**************************************************************/
/*! exports provided: MainRankingComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MainRankingComponent", function() { return MainRankingComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var MainRankingComponent = /** @class */ (function () {
    function MainRankingComponent() {
    }
    MainRankingComponent.prototype.ngOnInit = function () {
    };
    MainRankingComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-main-ranking',
            template: __webpack_require__(/*! ./main-ranking.component.html */ "./src/app/Views/main-ranking/main-ranking.component.html"),
            styles: [__webpack_require__(/*! ./main-ranking.component.css */ "./src/app/Views/main-ranking/main-ranking.component.css")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], MainRankingComponent);
    return MainRankingComponent;
}());



/***/ }),

/***/ "./src/app/app-routing.module.ts":
/*!***************************************!*\
  !*** ./src/app/app-routing.module.ts ***!
  \***************************************/
/*! exports provided: AppRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _Views_main_ranking_main_ranking_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./Views/main-ranking/main-ranking.component */ "./src/app/Views/main-ranking/main-ranking.component.ts");
/* harmony import */ var _Views_login_page_login_page_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./Views/login-page/login-page.component */ "./src/app/Views/login-page/login-page.component.ts");






var routes = [
    { path: '', component: _Views_login_page_login_page_component__WEBPACK_IMPORTED_MODULE_5__["LoginPageComponent"] },
    { path: 'mainranking', component: _Views_main_ranking_main_ranking_component__WEBPACK_IMPORTED_MODULE_4__["MainRankingComponent"] }
    // { path: 'signup', component: SignupComponent, data: { animation: 'isRight' }}
];
var AppRoutingModule = /** @class */ (function () {
    function AppRoutingModule() {
    }
    AppRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            declarations: [],
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterModule"].forRoot(routes)
            ],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterModule"]]
        })
    ], AppRoutingModule);
    return AppRoutingModule;
}());



/***/ }),

/***/ "./src/app/app.component.css":
/*!***********************************!*\
  !*** ./src/app/app.component.css ***!
  \***********************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FwcC5jb21wb25lbnQuY3NzIn0= */"

/***/ }),

/***/ "./src/app/app.component.html":
/*!************************************!*\
  !*** ./src/app/app.component.html ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\r\n<main [@routeAnimations]=\"prepareRoute(outlet)\">\r\n        <router-outlet #outlet=\"outlet\"></router-outlet>\r\n\r\n</main>\r\n\r\n\r\n"

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _route_animations__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./route-animations */ "./src/app/route-animations.ts");



var AppComponent = /** @class */ (function () {
    function AppComponent() {
        this.title = 'PoolChampionUI';
    }
    AppComponent.prototype.prepareRoute = function (outlet) {
        return outlet && outlet.activatedRouteData && outlet.activatedRouteData['animation'];
    };
    AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-root',
            template: __webpack_require__(/*! ./app.component.html */ "./src/app/app.component.html"),
            animations: [
                _route_animations__WEBPACK_IMPORTED_MODULE_2__["fader"]
                // slider,
                // transformer,
            ],
            styles: [__webpack_require__(/*! ./app.component.css */ "./src/app/app.component.css")]
        })
    ], AppComponent);
    return AppComponent;
}());



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./app-routing.module */ "./src/app/app-routing.module.ts");
/* harmony import */ var _Views_main_ranking_main_ranking_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./Views/main-ranking/main-ranking.component */ "./src/app/Views/main-ranking/main-ranking.component.ts");
/* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm5/animations.js");
/* harmony import */ var _angular_material_input__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/material/input */ "./node_modules/@angular/material/esm5/input.es5.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_material_button__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @angular/material/button */ "./node_modules/@angular/material/esm5/button.es5.js");
/* harmony import */ var _Views_login_page_login_page_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./Views/login-page/login-page.component */ "./src/app/Views/login-page/login-page.component.ts");
/* harmony import */ var _Components_login_login_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./Components/login/login.component */ "./src/app/Components/login/login.component.ts");












var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
            declarations: [
                _app_component__WEBPACK_IMPORTED_MODULE_3__["AppComponent"],
                _Views_main_ranking_main_ranking_component__WEBPACK_IMPORTED_MODULE_5__["MainRankingComponent"],
                _Views_login_page_login_page_component__WEBPACK_IMPORTED_MODULE_10__["LoginPageComponent"],
                _Components_login_login_component__WEBPACK_IMPORTED_MODULE_11__["LoginComponent"]
            ],
            imports: [
                _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"],
                _app_routing_module__WEBPACK_IMPORTED_MODULE_4__["AppRoutingModule"],
                _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_6__["BrowserAnimationsModule"],
                //Material
                _angular_material_input__WEBPACK_IMPORTED_MODULE_7__["MatInputModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_8__["FormsModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_8__["ReactiveFormsModule"],
                _angular_material_button__WEBPACK_IMPORTED_MODULE_9__["MatButtonModule"]
            ],
            providers: [],
            bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_3__["AppComponent"]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./src/app/route-animations.ts":
/*!*************************************!*\
  !*** ./src/app/route-animations.ts ***!
  \*************************************/
/*! exports provided: fader */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "fader", function() { return fader; });
/* harmony import */ var _angular_animations__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/animations */ "./node_modules/@angular/animations/fesm5/animations.js");

var fader = Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["trigger"])('routeAnimations', [
    Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["transition"])('* <=> *', [
        // Set a default  style for enter and leave
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["query"])(':enter, :leave', [
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({
                position: 'absolute',
                left: 0,
                width: '100%',
                opacity: 0,
                transform: 'scale(0) translateY(100%)',
            }),
        ], { optional: true }),
        // Animate the new page in
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["query"])(':enter', [
            Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["animate"])('600ms ease', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ opacity: 1, transform: 'scale(1) translateY(0)' })),
        ], { optional: true })
    ]),
]);


/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
var environment = {
    production: false
};
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(function (err) { return console.error(err); });


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\CranewareRepositoriesALL\PersonalDevelopment\CoachingProjectV1\poolchampionUI\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map