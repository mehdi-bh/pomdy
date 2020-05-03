(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./$$_lazy_route_resource lazy recursive":
/*!******************************************************!*\
  !*** ./$$_lazy_route_resource lazy namespace object ***!
  \******************************************************/
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
webpackEmptyAsyncContext.id = "./$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Errors/PageNotFound/page-not-found/page-not-found.component.html":
/*!***************************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Errors/PageNotFound/page-not-found/page-not-found.component.html ***!
  \***************************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<p>page-not-found works!</p>\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Home/home-smart/home-smart.component.html":
/*!****************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Home/home-smart/home-smart.component.html ***!
  \****************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<app-home\n  (eventPostStudent)=\"postStudent($event)\"\n  (eventAuthenticate)=\"authenticate($event)\"\n  (eventVerifyNickName)=\"verifyNickName($event)\"\n  (eventVerifyMail)=\"verifyMail($event)\"\n  [isLoginOk]=\"isLoginOk\"\n  [isNickNameTaken]=\"isNickNameTaken\"\n  [isMailTaken]=\"isMailTaken\"\n></app-home>\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Home/home/home.component.html":
/*!****************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Home/home/home.component.html ***!
  \****************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"container-fluid\">\n\n  <div [className]=\"ROW_TITLE_CLASS\">\n    <h1 class=\"display-4 font-weight-bold\">POMDY</h1>\n  </div>\n\n  <div [className]=\"ROW_TITLE_CLASS\">\n    <h3 class=\"display-5 font-italic\">The first study tool</h3>\n  </div>\n\n  <!-- Button -->\n  <div [className]=\"ROW_TITLE_CLASS\" *ngIf=\"!isUserConnected(); else studentConnected\">\n    <button type=\"button\" class=\"btn btn-lg action-button shadow animate orange\" (click)=\"home()\" data-toggle=\"modal\" data-target=\"#modal\">\n      Start now\n    </button>\n  </div>\n\n  <ng-template #studentConnected>\n    <div [className]=\"ROW_TITLE_CLASS\">\n      <button type=\"button\" class=\"btn btn-lg action-button shadow animate orange\" [routerLink]=\"['/profile']\">\n        Start now\n      </button>\n    </div>\n  </ng-template>\n\n  <!--Cards -->\n  <div class=\"row pt-5\">\n\n    <!--Card 1 -->\n    <div [className]=\"COL_CARDS_CLASS\">\n      <div [className]=\"CARDS_CLASS\">\n        <div [className]=\"CARDS_HEADERS_CLASS\">Be productive</div>\n        <div [className]=\"CARD_IMG_CLASS\">\n          <fa-icon [icon]=\"faTasks\" [className]=\"ICON_SIZE_CLASS\"></fa-icon>\n        </div>\n      </div>\n    </div>\n\n    <!--Card 2 -->\n    <div [className]=\"COL_CARDS_CLASS\">\n      <div [className]=\"CARDS_CLASS\">\n        <div [className]=\"CARDS_HEADERS_CLASS\">Win points</div>\n        <div [className]=\"CARD_IMG_CLASS\">\n          <fa-icon [icon]=\"faTrophy\" [className]=\"ICON_SIZE_CLASS\"></fa-icon>\n        </div>\n      </div>\n    </div>\n\n    <!--Card 3 -->\n    <div [className]=\"COL_CARDS_CLASS\">\n      <div [className]=\"CARDS_CLASS\">\n        <div [className]=\"CARDS_HEADERS_CLASS\">Study with friends</div>\n        <div [className]=\"CARD_IMG_CLASS\">\n          <fa-icon [icon]=\"faUserFriends\" [className]=\"ICON_SIZE_CLASS\"></fa-icon>\n        </div>\n      </div>\n    </div>\n\n  </div>\n\n  <!-- Modal -->\n  <div class=\"modal fade\" id=\"modal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"modal\" aria-hidden=\"true\" data-backdrop=\"static\" data-keyboard=\"false\">\n\n\n    <!---------------------------- 1.Login ---------------------------->\n    <form [formGroup]=\"login\" (ngSubmit)=\"notifyAuthenticate()\">\n      <div *ngIf=\"step == 0\" class=\"modal-dialog\" role=\"document\">\n        <div class=\"modal-content\">\n\n          <!--Header-->\n          <div class=\"modal-header\">\n            <h5 class=\"modal-title\">Login</h5>\n            <button id=\"closeLogin\" type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\" (click)=\"resetLoginForm(); resetRegisterOneForm(); resetRegisterTwoForm()\">\n              <span aria-hidden=\"true\">&times;</span>\n            </button>\n          </div>\n\n          <!--Body-->\n          <div class=\"modal-body\">\n            <div class=\"container-fluid\">\n              <!-- Nickname -->\n              <div class=\"row pt-1\">\n                <div class=\"col-12 text-center\">\n                  <label>Nickname</label>\n                </div>\n              </div>\n\n              <div class=\"row justify-content-center p-1\">\n                <input type=\"text\" formControlName=\"nickname\" id=\"loginNickname\" minlength=\"1\" maxlength=\"20\" class=\"form-control w-50\"/>\n              </div>\n\n              <!-- Password -->\n              <div class=\"row pt-3\">\n                <div class=\"col-12 text-center\">\n                  <label>Password</label>\n                </div>\n              </div>\n              <div class=\"row justify-content-center p-1\">\n                <input type=\"password\" formControlName=\"password\" id=\"loginPassword\" minlength=\"1\" maxlength=\"25\" class=\"form-control w-50\"/>\n              </div>\n\n              <!-- Login Button -->\n              <div class=\"row justify-content-center pt-3 pb-2\">\n                <button type=\"submit\" class=\"btn action-button shadow animate orange w-50\" [disabled]=\"login.invalid\">\n                  Start\n                </button>\n              </div>\n\n              <!-- Error fields -->\n              <div class=\"row justify-content-center pt-3 pb-2\" *ngIf=\"!isLoginOk\">\n                <span class=\"h5 bg-danger p-1 rounded\">Incorrect nickname or password</span>\n              </div>\n\n              <!-- Footer buttons -->\n              <hr />\n              <div class=\"row justify-content-center\">\n                <button type=\"button\" class=\"btn action-button-small shadow animate yellow mr-1\" (click)=\"next(); resetLoginForm()\">\n                  Register now\n                </button>\n                <button type=\"button\" class=\"btn action-button-small shadow animate beige ml-1\" (click)=\"forgotPassword(); resetLoginForm()\">\n                  Forgot password ?\n                </button>\n              </div>\n            </div>\n          </div>\n        </div>\n      </div>\n    </form>\n\n    <!---------------------------- 1.RegisterOne ---------------------------->\n    <form [formGroup]=\"registerOne\" (ngSubmit)=\"next()\">\n      <div *ngIf=\"step == 1\" class=\"modal-dialog\" role=\"document\">\n        <div class=\"modal-content\">\n\n          <!-- Header -->\n          <div class=\"modal-header\">\n            <h5 class=\"modal-title\">Register (1/2)</h5>\n            <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\" (click)=\"resetLoginForm(); resetRegisterOneForm(); resetRegisterTwoForm()\">\n              <span aria-hidden=\"true\">&times;</span>\n            </button>\n          </div>\n\n          <!-- Body -->\n          <div class=\"modal-body\">\n            <div class=\"container-fluid\">\n\n              <!--Nickname-->\n              <div class=\"row pt-1\">\n                <div class=\"col-12 text-center\">\n                  <label>Nickname</label>\n                </div>\n              </div>\n\n              <div class=\"row justify-content-center p-1\">\n                <input type=\"text\" formControlName=\"nickname\" id=\"registerNickname\" class=\"form-control w-50\" minlength=\"3\" maxlength=\"20\" (keyup)=\"notifyVerifyNickName()\"/>\n              </div>\n\n              <!--Error fields-->\n              <div class=\"row justify-content-center pt-2\" *ngIf=\"isNickNameTaken\">\n                <span class=\"h5 bg-danger p-1 rounded\">Nickname already taken</span>\n              </div>\n\n              <!--Date of birth-->\n              <div class=\"row pt-3\">\n                <div class=\"col-12 text-center\">\n                  <label>Date of birth</label>\n                </div>\n              </div>\n\n              <div class=\"row justify-content-center p-1\">\n                <input type=\"date\" formControlName=\"birthdate\" id=\"registerBirthDate\" class=\"form-control w-50\" min=\"1920-01-01\" max=\"2020-01-01\"/>\n              </div>\n\n              <!--Next Button-->\n              <div class=\"row justify-content-center pt-3 pb-2\">\n                <button type=\"submit\" class=\"btn action-button shadow animate orange w-50\" [disabled]=\"registerOne.invalid || isNickNameTaken\">\n                  Next\n                </button>\n              </div>\n\n              <!--Footer buttons-->\n              <hr />\n              <div class=\"row justify-content-center\">\n                <button type=\"button\" class=\"btn action-button-small shadow animate yellow mr-1\"(click)=\"back(); resetRegisterOneForm()\">\n                  Back\n                </button>\n              </div>\n            </div>\n          </div>\n        </div>\n      </div>\n    </form>\n\n    <!---------------------------- 2.RegisterTwo ---------------------------->\n    <form [formGroup]=\"registerTwo\" (ngSubmit)=\"notifyPostStudent()\">\n      <div *ngIf=\"step == 2\" class=\"modal-dialog\" role=\"document\">\n        <div class=\"modal-content\">\n\n          <!--Header-->\n          <div class=\"modal-header\">\n            <h5 class=\"modal-title\">Register (2/2)</h5>\n            <button id=\"closeRegister\" type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\" (click)=\"resetLoginForm(); resetRegisterOneForm(); resetRegisterTwoForm()\">\n              <span aria-hidden=\"true\">&times;</span>\n            </button>\n          </div>\n\n          <!--Body-->\n          <div class=\"modal-body\">\n            <div class=\"container-fluid\">\n\n              <!--Mail-->\n              <div class=\"row pt-1\">\n                <div class=\"col-12 text-center\">\n                  <label>Mail</label>\n                </div>\n              </div>\n\n              <div class=\"row justify-content-center p-1\">\n                <input type=\"email\" formControlName=\"mail\" id=\"registerMail\" class=\"form-control w-50\" minlength=\"4\" maxlength=\"50\" (keyup)=\"notifyVerifyMail()\"/>\n              </div>\n\n              <!--Error fields-->\n              <div class=\"row justify-content-center pt-2\" *ngIf=\"isMailTaken\">\n                <span class=\"h5 bg-danger p-1 rounded\">Mail already taken</span>\n              </div>\n\n              <!--Password-->\n              <div class=\"row pt-3\">\n                <div class=\"col-12 text-center\">\n                  <label>\n                    Password\n                  </label>\n                </div>\n              </div>\n\n              <div class=\"row\">\n                <div class=\"col-12 text-center\">\n                  <span class=\"badge badge-danger\">At least 8 characters with uppercase, lowercase and number</span>\n                </div>\n              </div>\n\n              <div class=\"row justify-content-center p-1\">\n                <input type=\"password\" formControlName=\"password\" id=\"registerPassword\" class=\"form-control w-50\" minlength=\"8\" maxlength=\"25\" ngModel pattern=\"^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$\"/>\n              </div>\n\n              <!--Register Button-->\n              <div class=\"row justify-content-center pt-3 pb-2\">\n                <button type=\"submit\" class=\"btn action-button shadow animate orange w-50\" [disabled]=\"registerTwo.invalid || isMailTaken\">\n                  Get started !\n                </button>\n              </div>\n\n              <!--Footer buttons-->\n              <hr />\n              <div class=\"row justify-content-center\">\n                <button type=\"button\" class=\"btn action-button-small shadow animate yellow mr-1\" (click)=\"back(); resetRegisterTwoForm()\">\n                  Back\n                </button>\n              </div>\n            </div>\n          </div>\n        </div>\n      </div>\n    </form>\n\n\n    <!---------------------------- 3.ForgotPassword ---------------------------->\n    <div *ngIf=\"step == 3\" class=\"modal-dialog\" role=\"document\">\n      <div class=\"modal-content\">\n\n        <!--Header-->\n        <div class=\"modal-header\">\n          <h5 class=\"modal-title\">Forgot Password</h5>\n          <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\" (click)=\"resetLoginForm(); resetRegisterOneForm(); resetRegisterTwoForm()\">\n            <span aria-hidden=\"true\">&times;</span>\n          </button>\n        </div>\n\n        <!--Body-->\n        <div class=\"modal-body\">\n          <div class=\"container-fluid\">\n\n            <!--Mail-->\n            <div class=\"row pt-1\">\n              <div class=\"col-12 text-center\">\n                <label>Mail</label>\n              </div>\n            </div>\n\n            <div class=\"row justify-content-center p-1\">\n              <input type=\"email\" class=\"form-control w-50\" minlength=\"3\" maxlength=\"50\"/>\n            </div>\n\n            <!--Send mail button-->\n            <div class=\"row justify-content-center pt-3 pb-2\">\n              <button type=\"submit\" class=\"btn action-button shadow animate orange w-50\">\n                Send mail\n              </button>\n            </div>\n\n            <!--Footer buttons-->\n            <hr />\n            <div class=\"row justify-content-center\">\n              <button type=\"submit\" class=\"btn action-button-small shadow animate yellow mr-1\" (click)=\"home()\">\n                Back\n              </button>\n            </div>\n          </div>\n        </div>\n      </div>\n    </div>\n  </div>\n</div>\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Profile/profile-smart/profile-smart.component.html":
/*!*************************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Profile/profile-smart/profile-smart.component.html ***!
  \*************************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<app-profile [student]=\"student\"></app-profile>\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Profile/profile/profile.component.html":
/*!*************************************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Profile/profile/profile.component.html ***!
  \*************************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<div class=\"container-fluid\" *ngIf=\"student != undefined\">\n\n  <div class=\"row justify-content-center p-3\">\n    <div class=\"h3\">\n      My profile\n    </div>\n  </div>\n\n  <div class=\"row pb-2\">\n    <div class=\"col-12 col-md-4 p-2\">\n      <button class=\"btn action-button-small shadow animate blue w-100\" [routerLink]=\"['/home']\">\n        Go to dashboard\n        <fa-icon [icon]=\"faArrowRight\"></fa-icon>\n      </button>\n    </div>\n\n    <div class=\"col-12 col-md-4 p-2\">\n      <button class=\"btn action-button-small shadow animate green w-100\">\n        Save changes\n        <fa-icon [icon]=\"faSave\"></fa-icon>\n      </button>\n    </div>\n\n    <div class=\"col-12 col-md-4 p-2\">\n      <button class=\"btn action-button-small shadow animate red w-100\">\n        Log out\n        <fa-icon [icon]=\"faSignOutAlt\"></fa-icon>\n      </button>\n    </div>\n\n  </div>\n\n  <hr style=\"background-color: slategrey\">\n\n  <div class=\"row\">\n\n\n    <!-------------- 1st column -------------->\n    <div class=\"col-12 col-md-12 col-xl-2 bg-dark shadow\">\n\n      <div class=\"card bg-dark mx-auto mb-3\">\n        <div class=\"card-img-bottom\">\n          <img src=\"assets/images/image.png\" class=\"img-fluid float-right w-100 h-100\">\n        </div>\n      </div>\n\n      <!-- Nickname and ghost mode -->\n      <div class=\"p-2 pt-3\">\n\n        <div class=\"text-center\">\n          <label class=\"w-100\">Nickname</label>\n        </div>\n\n        <div>\n\n          <div>\n            <input type=\"text\" class=\"form-control w-100\" value=\"{{student.nickName}}\">\n          </div>\n\n          <div class=\"form-check w-100 p-3 text-center\">\n\n            <input type=\"checkbox\" class=\"form-check-input\" [checked]=\"student.isGhostMode\">\n            <label class=\"form-check-label\">Ghost mode</label>\n\n          </div>\n\n        </div>\n\n      </div>\n\n      <div class=\"p-2\">\n        <button class=\"btn action-button-small shadow animate red w-100\">\n          Disable account\n          <fa-icon [icon]=\"faSignOutAlt\"></fa-icon>\n        </button>\n      </div>\n\n    </div>\n\n\n    <!-------------- 2nd column -------------->\n    <div class=\"col-12 col-md-6 col-xl-5 bg-dark shadow\">\n      <!-- Firstname and lastname -->\n      <div class=\"p-4\">\n\n        <div class=\"text-center\">\n          <label class=\"w-50\">Firstname</label>\n          <label class=\"w-50\">Lastname</label>\n        </div>\n\n        <div class=\"form-inline\">\n          <input type=\"text\" class=\"form-control w-50\" value=\"{{student.firstName}}\">\n          <input type=\"text\" class=\"form-control w-50\" value=\"{{student.lastName}}\">\n        </div>\n\n      </div>\n\n      <!-- Birthdate -->\n      <div class=\"p-4\">\n\n        <div class=\"text-center\">\n          <label class=\"w-100\">Birthdate</label>\n        </div>\n\n        <!-- TODO Changer le datetime en date -->\n        <div>\n          <input type=\"datetime-local\" class=\"form-control w-100\" min=\"1920-01-01\" max=\"2020-01-01\" value=\"{{student.birthDate}}\"/>\n        </div>\n\n      </div>\n\n      <!-- School -->\n      <div class=\"p-4\">\n\n        <div class=\"text-center\">\n          <label class=\"w-100\">School</label>\n        </div>\n\n        <div>\n          <input type=\"text\" class=\"form-control\" value=\"{{student.school}}\"/>\n        </div>\n\n      </div>\n\n      <!-- Diploma name -->\n      <div class=\"p-4\">\n\n        <div class=\"text-center\">\n          <label class=\"w-100\">Diploma name</label>\n        </div>\n\n        <div>\n          <input type=\"text\" class=\"form-control\" value=\"{{student.diplomaName}}\"/>\n        </div>\n\n      </div>\n    </div>\n\n\n    <!-------------- 3rd column -------------->\n    <div class=\"col-12 col-md-6 col-xl-5 bg-dark shadow\">\n      <!-- Mail -->\n      <div class=\"p-4\">\n\n        <div class=\"text-center\">\n          <label class=\"w-100\">Mail</label>\n        </div>\n\n        <div>\n          <input type=\"text\" class=\"form-control w-100\" value=\"{{student.mail}}\"/>\n        </div>\n\n      </div>\n\n      <!-- Password -->\n      <div class=\"p-4\">\n\n        <div class=\"text-center\">\n          <label class=\"w-100\">Password</label>\n        </div>\n\n        <div>\n          <button class=\"btn action-button shadow animate darkBlue w-100 p-1 mb-5\" (click)=\"togglePasswordChange()\">Change</button>\n        </div>\n\n      </div>\n\n      <!-- Change Password -->\n      <div class=\"p-4\" *ngIf=\"!disabledPasswordChange\">\n\n        <div class=\"text-center\">\n          <label class=\"w-50\">New password</label>\n          <label class=\"w-50\">Confirm password</label>\n        </div>\n\n        <div class=\"form-inline\">\n          <input type=\"text\" class=\"form-control w-50\"/>\n          <input type=\"text\" class=\"form-control w-50\"/>\n        </div>\n\n      </div>\n\n      <div class=\"p-4 mt-4\" *ngIf=\"!passwordsMatch\">\n        <div class=\"h5 bg-danger p-1 mt-2 rounded text-center\">\n          Passwords don't match\n        </div>\n      </div>\n    </div>\n  </div>\n</div>\n");

/***/ }),

/***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html":
/*!**************************************************************************!*\
  !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html ***!
  \**************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("<router-outlet></router-outlet>\n");

/***/ }),

/***/ "./node_modules/tslib/tslib.es6.js":
/*!*****************************************!*\
  !*** ./node_modules/tslib/tslib.es6.js ***!
  \*****************************************/
/*! exports provided: __extends, __assign, __rest, __decorate, __param, __metadata, __awaiter, __generator, __exportStar, __values, __read, __spread, __spreadArrays, __await, __asyncGenerator, __asyncDelegator, __asyncValues, __makeTemplateObject, __importStar, __importDefault, __classPrivateFieldGet, __classPrivateFieldSet */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__extends", function() { return __extends; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__assign", function() { return __assign; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__rest", function() { return __rest; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__decorate", function() { return __decorate; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__param", function() { return __param; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__metadata", function() { return __metadata; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__awaiter", function() { return __awaiter; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__generator", function() { return __generator; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__exportStar", function() { return __exportStar; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__values", function() { return __values; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__read", function() { return __read; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__spread", function() { return __spread; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__spreadArrays", function() { return __spreadArrays; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__await", function() { return __await; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncGenerator", function() { return __asyncGenerator; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncDelegator", function() { return __asyncDelegator; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncValues", function() { return __asyncValues; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__makeTemplateObject", function() { return __makeTemplateObject; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__importStar", function() { return __importStar; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__importDefault", function() { return __importDefault; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__classPrivateFieldGet", function() { return __classPrivateFieldGet; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__classPrivateFieldSet", function() { return __classPrivateFieldSet; });
/*! *****************************************************************************
Copyright (c) Microsoft Corporation. All rights reserved.
Licensed under the Apache License, Version 2.0 (the "License"); you may not use
this file except in compliance with the License. You may obtain a copy of the
License at http://www.apache.org/licenses/LICENSE-2.0

THIS CODE IS PROVIDED ON AN *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
MERCHANTABLITY OR NON-INFRINGEMENT.

See the Apache Version 2.0 License for specific language governing permissions
and limitations under the License.
***************************************************************************** */
/* global Reflect, Promise */

var extendStatics = function(d, b) {
    extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return extendStatics(d, b);
};

function __extends(d, b) {
    extendStatics(d, b);
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
}

var __assign = function() {
    __assign = Object.assign || function __assign(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p)) t[p] = s[p];
        }
        return t;
    }
    return __assign.apply(this, arguments);
}

function __rest(s, e) {
    var t = {};
    for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p) && e.indexOf(p) < 0)
        t[p] = s[p];
    if (s != null && typeof Object.getOwnPropertySymbols === "function")
        for (var i = 0, p = Object.getOwnPropertySymbols(s); i < p.length; i++) {
            if (e.indexOf(p[i]) < 0 && Object.prototype.propertyIsEnumerable.call(s, p[i]))
                t[p[i]] = s[p[i]];
        }
    return t;
}

function __decorate(decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
}

function __param(paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
}

function __metadata(metadataKey, metadataValue) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(metadataKey, metadataValue);
}

function __awaiter(thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
}

function __generator(thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
}

function __exportStar(m, exports) {
    for (var p in m) if (!exports.hasOwnProperty(p)) exports[p] = m[p];
}

function __values(o) {
    var s = typeof Symbol === "function" && Symbol.iterator, m = s && o[s], i = 0;
    if (m) return m.call(o);
    if (o && typeof o.length === "number") return {
        next: function () {
            if (o && i >= o.length) o = void 0;
            return { value: o && o[i++], done: !o };
        }
    };
    throw new TypeError(s ? "Object is not iterable." : "Symbol.iterator is not defined.");
}

function __read(o, n) {
    var m = typeof Symbol === "function" && o[Symbol.iterator];
    if (!m) return o;
    var i = m.call(o), r, ar = [], e;
    try {
        while ((n === void 0 || n-- > 0) && !(r = i.next()).done) ar.push(r.value);
    }
    catch (error) { e = { error: error }; }
    finally {
        try {
            if (r && !r.done && (m = i["return"])) m.call(i);
        }
        finally { if (e) throw e.error; }
    }
    return ar;
}

function __spread() {
    for (var ar = [], i = 0; i < arguments.length; i++)
        ar = ar.concat(__read(arguments[i]));
    return ar;
}

function __spreadArrays() {
    for (var s = 0, i = 0, il = arguments.length; i < il; i++) s += arguments[i].length;
    for (var r = Array(s), k = 0, i = 0; i < il; i++)
        for (var a = arguments[i], j = 0, jl = a.length; j < jl; j++, k++)
            r[k] = a[j];
    return r;
};

function __await(v) {
    return this instanceof __await ? (this.v = v, this) : new __await(v);
}

function __asyncGenerator(thisArg, _arguments, generator) {
    if (!Symbol.asyncIterator) throw new TypeError("Symbol.asyncIterator is not defined.");
    var g = generator.apply(thisArg, _arguments || []), i, q = [];
    return i = {}, verb("next"), verb("throw"), verb("return"), i[Symbol.asyncIterator] = function () { return this; }, i;
    function verb(n) { if (g[n]) i[n] = function (v) { return new Promise(function (a, b) { q.push([n, v, a, b]) > 1 || resume(n, v); }); }; }
    function resume(n, v) { try { step(g[n](v)); } catch (e) { settle(q[0][3], e); } }
    function step(r) { r.value instanceof __await ? Promise.resolve(r.value.v).then(fulfill, reject) : settle(q[0][2], r); }
    function fulfill(value) { resume("next", value); }
    function reject(value) { resume("throw", value); }
    function settle(f, v) { if (f(v), q.shift(), q.length) resume(q[0][0], q[0][1]); }
}

function __asyncDelegator(o) {
    var i, p;
    return i = {}, verb("next"), verb("throw", function (e) { throw e; }), verb("return"), i[Symbol.iterator] = function () { return this; }, i;
    function verb(n, f) { i[n] = o[n] ? function (v) { return (p = !p) ? { value: __await(o[n](v)), done: n === "return" } : f ? f(v) : v; } : f; }
}

function __asyncValues(o) {
    if (!Symbol.asyncIterator) throw new TypeError("Symbol.asyncIterator is not defined.");
    var m = o[Symbol.asyncIterator], i;
    return m ? m.call(o) : (o = typeof __values === "function" ? __values(o) : o[Symbol.iterator](), i = {}, verb("next"), verb("throw"), verb("return"), i[Symbol.asyncIterator] = function () { return this; }, i);
    function verb(n) { i[n] = o[n] && function (v) { return new Promise(function (resolve, reject) { v = o[n](v), settle(resolve, reject, v.done, v.value); }); }; }
    function settle(resolve, reject, d, v) { Promise.resolve(v).then(function(v) { resolve({ value: v, done: d }); }, reject); }
}

function __makeTemplateObject(cooked, raw) {
    if (Object.defineProperty) { Object.defineProperty(cooked, "raw", { value: raw }); } else { cooked.raw = raw; }
    return cooked;
};

function __importStar(mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];
    result.default = mod;
    return result;
}

function __importDefault(mod) {
    return (mod && mod.__esModule) ? mod : { default: mod };
}

function __classPrivateFieldGet(receiver, privateMap) {
    if (!privateMap.has(receiver)) {
        throw new TypeError("attempted to get private field on non-instance");
    }
    return privateMap.get(receiver);
}

function __classPrivateFieldSet(receiver, privateMap, value) {
    if (!privateMap.has(receiver)) {
        throw new TypeError("attempted to set private field on non-instance");
    }
    privateMap.set(receiver, value);
    return value;
}


/***/ }),

/***/ "./src/app/Model/Classes/Student.ts":
/*!******************************************!*\
  !*** ./src/app/Model/Classes/Student.ts ***!
  \******************************************/
/*! exports provided: Student */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Student", function() { return Student; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

class Student {
    constructor() { }
    toStudentDTO() {
        return {
            id: this._id,
            isArchived: this._isArchived,
            isGhostMode: this._isGhostMode,
            nickName: this._nickName,
            password: this._password,
            mail: this._mail,
            firstName: this._firstName,
            lastName: this._lastName,
            description: this._description,
            birthDate: this._birthDate,
            diplomaName: this._diplomaName,
            school: this._school,
            photo: this._photo
        };
    }
    fromStudentDTO(studentDTO) {
        Object.assign(this, studentDTO);
        return this;
    }
    get id() {
        return this._id;
    }
    set id(value) {
        this._id = value;
    }
    get isArchived() {
        return this._isArchived;
    }
    set isArchived(value) {
        this._isArchived = value;
    }
    get isGhostMode() {
        return this._isGhostMode;
    }
    set isGhostMode(value) {
        this._isGhostMode = value;
    }
    get nickName() {
        return this._nickName;
    }
    set nickName(value) {
        this._nickName = value;
    }
    get password() {
        return this._password;
    }
    set password(value) {
        this._password = value;
    }
    get mail() {
        return this._mail;
    }
    set mail(value) {
        this._mail = value;
    }
    get token() {
        return this._token;
    }
    set token(value) {
        this._token = value;
    }
    get firstName() {
        return this._firstName;
    }
    set firstName(value) {
        this._firstName = value;
    }
    get lastName() {
        return this._lastName;
    }
    set lastName(value) {
        this._lastName = value;
    }
    get description() {
        return this._description;
    }
    set description(value) {
        this._description = value;
    }
    get birthDate() {
        return this._birthDate;
    }
    set birthDate(value) {
        this._birthDate = value;
    }
    get diplomaName() {
        return this._diplomaName;
    }
    set diplomaName(value) {
        this._diplomaName = value;
    }
    get school() {
        return this._school;
    }
    set school(value) {
        this._school = value;
    }
    get photo() {
        return this._photo;
    }
    set photo(value) {
        this._photo = value;
    }
}


/***/ }),

/***/ "./src/app/Services/Student/student.service.ts":
/*!*****************************************************!*\
  !*** ./src/app/Services/Student/student.service.ts ***!
  \*****************************************************/
/*! exports provided: StudentService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "StudentService", function() { return StudentService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");



let StudentService = class StudentService {
    constructor(httpClient) {
        this.httpClient = httpClient;
        this.API_URL = "/api/students";
    }
    authenticate(nickName, password) {
        return this.httpClient.get(`${this.API_URL}/${nickName}&${password}`);
    }
    post(student) {
        return this.httpClient.post(this.API_URL, student);
    }
    getByToken(token) {
        return this.httpClient.get(`${this.API_URL}/${token}`);
    }
    getByNickName(nickName) {
        return this.httpClient.get(`${this.API_URL}/nickname/${nickName}`);
    }
    getByMail(mail) {
        return this.httpClient.get(`${this.API_URL}/mail/${mail}`);
    }
};
StudentService.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"] }
];
StudentService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], StudentService);



/***/ }),

/***/ "./src/app/Services/Utility/LocalStorageManager.ts":
/*!*********************************************************!*\
  !*** ./src/app/Services/Utility/LocalStorageManager.ts ***!
  \*********************************************************/
/*! exports provided: LocalStorageManager */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LocalStorageManager", function() { return LocalStorageManager; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");

class LocalStorageManager {
    static getToken() {
        return localStorage.getItem(this.TOKEN_KEY);
    }
    static setToken(value) {
        localStorage.setItem(this.TOKEN_KEY, value);
        return value;
    }
    static resetToken() {
        localStorage.removeItem(this.TOKEN_KEY);
    }
}
LocalStorageManager.TOKEN_KEY = "PomdyToken";


/***/ }),

/***/ "./src/app/Services/Utility/authentication.service.ts":
/*!************************************************************!*\
  !*** ./src/app/Services/Utility/authentication.service.ts ***!
  \************************************************************/
/*! exports provided: AuthenticationService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthenticationService", function() { return AuthenticationService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let AuthenticationService = class AuthenticationService {
    constructor() { }
};
AuthenticationService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], AuthenticationService);



/***/ }),

/***/ "./src/app/Services/Utility/connected-guard.service.ts":
/*!*************************************************************!*\
  !*** ./src/app/Services/Utility/connected-guard.service.ts ***!
  \*************************************************************/
/*! exports provided: ConnectedGuardService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ConnectedGuardService", function() { return ConnectedGuardService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _LocalStorageManager__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./LocalStorageManager */ "./src/app/Services/Utility/LocalStorageManager.ts");




let ConnectedGuardService = class ConnectedGuardService {
    constructor(router) {
        this.router = router;
        this.subscriptions = [];
    }
    canActivate(route, state) {
        // TODO : Checker également si son token vaut quelque chose ou pas
        if (_LocalStorageManager__WEBPACK_IMPORTED_MODULE_3__["LocalStorageManager"].getToken() != null) {
            return true;
        }
        else {
            this.router.navigate(['home']);
        }
    }
};
ConnectedGuardService.ctorParameters = () => [
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"] }
];
ConnectedGuardService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
        providedIn: 'root'
    })
], ConnectedGuardService);



/***/ }),

/***/ "./src/app/UI/Errors/PageNotFound/page-not-found/page-not-found.component.css":
/*!************************************************************************************!*\
  !*** ./src/app/UI/Errors/PageNotFound/page-not-found/page-not-found.component.css ***!
  \************************************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiIuLi8uLi9VSS9FcnJvcnMvUGFnZU5vdEZvdW5kL3BhZ2Utbm90LWZvdW5kL3BhZ2Utbm90LWZvdW5kLmNvbXBvbmVudC5jc3MifQ== */");

/***/ }),

/***/ "./src/app/UI/Errors/PageNotFound/page-not-found/page-not-found.component.ts":
/*!***********************************************************************************!*\
  !*** ./src/app/UI/Errors/PageNotFound/page-not-found/page-not-found.component.ts ***!
  \***********************************************************************************/
/*! exports provided: PageNotFoundComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PageNotFoundComponent", function() { return PageNotFoundComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let PageNotFoundComponent = class PageNotFoundComponent {
    constructor() { }
    ngOnInit() {
    }
};
PageNotFoundComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-page-not-found',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./page-not-found.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Errors/PageNotFound/page-not-found/page-not-found.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./page-not-found.component.css */ "./src/app/UI/Errors/PageNotFound/page-not-found/page-not-found.component.css")).default]
    })
], PageNotFoundComponent);



/***/ }),

/***/ "./src/app/UI/Home/home-smart/home-smart.component.css":
/*!*************************************************************!*\
  !*** ./src/app/UI/Home/home-smart/home-smart.component.css ***!
  \*************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiIuLi8uLi9VSS9Ib21lL2hvbWUtc21hcnQvaG9tZS1zbWFydC5jb21wb25lbnQuY3NzIn0= */");

/***/ }),

/***/ "./src/app/UI/Home/home-smart/home-smart.component.ts":
/*!************************************************************!*\
  !*** ./src/app/UI/Home/home-smart/home-smart.component.ts ***!
  \************************************************************/
/*! exports provided: HomeSmartComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HomeSmartComponent", function() { return HomeSmartComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _Services_Student_student_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../Services/Student/student.service */ "./src/app/Services/Student/student.service.ts");
/* harmony import */ var _Services_Utility_LocalStorageManager__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../Services/Utility/LocalStorageManager */ "./src/app/Services/Utility/LocalStorageManager.ts");
/* harmony import */ var _Services_Utility_authentication_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../Services/Utility/authentication.service */ "./src/app/Services/Utility/authentication.service.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");






let HomeSmartComponent = class HomeSmartComponent {
    constructor(studentService, authenticationService, router) {
        this.studentService = studentService;
        this.authenticationService = authenticationService;
        this.router = router;
        this.subscriptions = [];
        this.isLoginOk = true;
        this.isNickNameTaken = false;
        this.isMailTaken = false;
    }
    ngOnInit() {
    }
    ngOnDestroy() {
        for (let i = this.subscriptions.length - 1; i >= 0; i--) {
            const subscription = this.subscriptions[i];
            subscription && subscription.unsubscribe();
            this.subscriptions.pop();
        }
    }
    closeLoginModal() {
        document.getElementById("closeLogin").click();
    }
    closeRegisterModal() {
        document.getElementById("closeRegister").click();
    }
    authenticate($event) {
        this.subscriptions.push(this.studentService.authenticate($event.nickName, $event.password).subscribe(answer => {
            if (answer == null)
                this.isLoginOk = false;
            else {
                this.isLoginOk = true;
                this.authenticationService.studentConnected = answer;
                _Services_Utility_LocalStorageManager__WEBPACK_IMPORTED_MODULE_3__["LocalStorageManager"].setToken(this.authenticationService.studentConnected.token);
                this.closeLoginModal();
                this.router.navigate([("/profile")]);
            }
        }));
    }
    postStudent($event) {
        this.subscriptions.push(this.studentService.post($event.toStudentDTO()).subscribe(answer => {
            this.authenticationService.studentConnected = answer;
            _Services_Utility_LocalStorageManager__WEBPACK_IMPORTED_MODULE_3__["LocalStorageManager"].setToken(this.authenticationService.studentConnected.token);
            this.closeRegisterModal();
            this.router.navigate([("/profile")]);
        }));
    }
    verifyNickName($event) {
        this.subscriptions.push(this.studentService.getByNickName($event.nickName).subscribe(answer => {
            this.isNickNameTaken = answer != null;
        }));
    }
    verifyMail($event) {
        this.subscriptions.push(this.studentService.getByMail($event.mail).subscribe(answer => {
            this.isMailTaken = answer != null;
        }));
    }
};
HomeSmartComponent.ctorParameters = () => [
    { type: _Services_Student_student_service__WEBPACK_IMPORTED_MODULE_2__["StudentService"] },
    { type: _Services_Utility_authentication_service__WEBPACK_IMPORTED_MODULE_4__["AuthenticationService"] },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_5__["Router"] }
];
HomeSmartComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-home-smart',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./home-smart.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Home/home-smart/home-smart.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./home-smart.component.css */ "./src/app/UI/Home/home-smart/home-smart.component.css")).default]
    })
], HomeSmartComponent);



/***/ }),

/***/ "./src/app/UI/Home/home/home.component.css":
/*!*************************************************!*\
  !*** ./src/app/UI/Home/home/home.component.css ***!
  \*************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiIuLi8uLi9VSS9Ib21lL2hvbWUvaG9tZS5jb21wb25lbnQuY3NzIn0= */");

/***/ }),

/***/ "./src/app/UI/Home/home/home.component.ts":
/*!************************************************!*\
  !*** ./src/app/UI/Home/home/home.component.ts ***!
  \************************************************/
/*! exports provided: HomeComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HomeComponent", function() { return HomeComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _fortawesome_free_solid_svg_icons__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @fortawesome/free-solid-svg-icons */ "./node_modules/@fortawesome/free-solid-svg-icons/index.es.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _Model_Classes_Student__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../Model/Classes/Student */ "./src/app/Model/Classes/Student.ts");
/* harmony import */ var _Services_Utility_LocalStorageManager__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../../../Services/Utility/LocalStorageManager */ "./src/app/Services/Utility/LocalStorageManager.ts");
/* harmony import */ var _Services_Student_student_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../../../Services/Student/student.service */ "./src/app/Services/Student/student.service.ts");









let HomeComponent = class HomeComponent {
    constructor(fb, studentService) {
        this.fb = fb;
        this.studentService = studentService;
        this.ROW_TITLE_CLASS = "row justify-content-center p-1 pt-3 pb-3";
        this.COL_CARDS_CLASS = "col-12 col-sm-4 text-center p-1";
        this.CARDS_CLASS = "card bg-dark mx-auto shadow";
        this.CARDS_HEADERS_CLASS = "card-header h5";
        this.CARD_IMG_CLASS = "card-img-bottom";
        this.ICON_SIZE_CLASS = "fa-5x";
        this.faTrophy = _fortawesome_free_solid_svg_icons__WEBPACK_IMPORTED_MODULE_2__["faTrophy"];
        this.faUserFriends = _fortawesome_free_solid_svg_icons__WEBPACK_IMPORTED_MODULE_2__["faUserFriends"];
        this.faTasks = _fortawesome_free_solid_svg_icons__WEBPACK_IMPORTED_MODULE_2__["faTasks"];
        this.eventPostStudent = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.eventAuthenticate = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.eventVerifyNickName = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.eventVerifyMail = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        /* Modal navigation */
        this.step = 0;
        /* 0.Login */
        this.login = this.fb.group({
            nickname: this.fb.control("", _angular_forms__WEBPACK_IMPORTED_MODULE_3__["Validators"].required),
            password: this.fb.control("", _angular_forms__WEBPACK_IMPORTED_MODULE_3__["Validators"].required)
        });
        /* 1/2.Register */
        this.registerOne = this.fb.group({
            nickname: this.fb.control("", _angular_forms__WEBPACK_IMPORTED_MODULE_3__["Validators"].required),
            birthdate: this.fb.control("", _angular_forms__WEBPACK_IMPORTED_MODULE_3__["Validators"].required),
        });
        this.registerTwo = this.fb.group({
            mail: this.fb.control("", _angular_forms__WEBPACK_IMPORTED_MODULE_3__["Validators"].required),
            password: this.fb.control("", _angular_forms__WEBPACK_IMPORTED_MODULE_3__["Validators"].required)
        });
    }
    ngOnInit() {
    }
    isUserConnected() {
        return _Services_Utility_LocalStorageManager__WEBPACK_IMPORTED_MODULE_5__["LocalStorageManager"].getToken() != null;
    }
    next() {
        this.step++;
    }
    back() {
        this.step--;
    }
    forgotPassword() {
        this.step = 3;
    }
    home() {
        this.step = 0;
    }
    resetLoginForm() {
        this.login.reset();
        this.isLoginOk = true;
    }
    printLogs() {
        if (this.login.valid) {
            console.log(this.login.get('nickname').value);
            console.log(this.login.get('password').value);
        }
    }
    buildAuthenticate() {
        let student = new _Model_Classes_Student__WEBPACK_IMPORTED_MODULE_4__["Student"]();
        student.nickName = this.login.get('nickname').value;
        student.password = this.login.get('password').value;
        return student;
    }
    notifyAuthenticate() {
        this.eventAuthenticate.next(this.buildAuthenticate());
    }
    resetRegisterOneForm() {
        this.registerOne.reset();
        this.isNickNameTaken = false;
    }
    resetRegisterTwoForm() {
        this.registerTwo.reset();
        this.isMailTaken = false;
    }
    printRegister() {
        console.log(this.registerOne.get('nickname').value);
        console.log(this.registerTwo.get('mail').value);
        console.log(this.registerTwo.get('password').value);
    }
    buildStudent() {
        let student = new _Model_Classes_Student__WEBPACK_IMPORTED_MODULE_4__["Student"]();
        student.isArchived = false;
        student.isGhostMode = false;
        student.nickName = this.registerOne.get('nickname').value;
        student.birthDate = this.registerOne.get('birthdate').value;
        student.mail = this.registerTwo.get('mail').value;
        student.password = this.registerTwo.get('password').value;
        return student;
    }
    buildForNickNameCheck() {
        let student = new _Model_Classes_Student__WEBPACK_IMPORTED_MODULE_4__["Student"]();
        student.nickName = this.registerOne.get('nickname').value;
        return student;
    }
    buildForMailCheck() {
        let student = new _Model_Classes_Student__WEBPACK_IMPORTED_MODULE_4__["Student"]();
        student.mail = this.registerTwo.get('mail').value;
        return student;
    }
    notifyPostStudent() {
        this.eventPostStudent.next(this.buildStudent());
    }
    notifyVerifyNickName() {
        let isNotEmpty = this.buildForNickNameCheck().nickName != "";
        if (isNotEmpty) {
            this.eventVerifyNickName.next(this.buildForNickNameCheck());
        }
    }
    notifyVerifyMail() {
        let isNotEmpty = this.buildForMailCheck().mail != "";
        if (isNotEmpty) {
            this.eventVerifyMail.next(this.buildForMailCheck());
        }
    }
};
HomeComponent.ctorParameters = () => [
    { type: _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormBuilder"] },
    { type: _Services_Student_student_service__WEBPACK_IMPORTED_MODULE_6__["StudentService"] }
];
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])()
], HomeComponent.prototype, "eventPostStudent", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])()
], HomeComponent.prototype, "eventAuthenticate", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])()
], HomeComponent.prototype, "eventVerifyNickName", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])()
], HomeComponent.prototype, "eventVerifyMail", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], HomeComponent.prototype, "isLoginOk", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], HomeComponent.prototype, "isNickNameTaken", void 0);
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], HomeComponent.prototype, "isMailTaken", void 0);
HomeComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-home',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./home.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Home/home/home.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./home.component.css */ "./src/app/UI/Home/home/home.component.css")).default]
    })
], HomeComponent);



/***/ }),

/***/ "./src/app/UI/Profile/profile-smart/profile-smart.component.css":
/*!**********************************************************************!*\
  !*** ./src/app/UI/Profile/profile-smart/profile-smart.component.css ***!
  \**********************************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiIuLi8uLi9VSS9Qcm9maWxlL3Byb2ZpbGUtc21hcnQvcHJvZmlsZS1zbWFydC5jb21wb25lbnQuY3NzIn0= */");

/***/ }),

/***/ "./src/app/UI/Profile/profile-smart/profile-smart.component.ts":
/*!*********************************************************************!*\
  !*** ./src/app/UI/Profile/profile-smart/profile-smart.component.ts ***!
  \*********************************************************************/
/*! exports provided: ProfileSmartComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProfileSmartComponent", function() { return ProfileSmartComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _Services_Student_student_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../../../Services/Student/student.service */ "./src/app/Services/Student/student.service.ts");
/* harmony import */ var _Services_Utility_LocalStorageManager__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../../Services/Utility/LocalStorageManager */ "./src/app/Services/Utility/LocalStorageManager.ts");
/* harmony import */ var _Model_Classes_Student__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../../Model/Classes/Student */ "./src/app/Model/Classes/Student.ts");





let ProfileSmartComponent = class ProfileSmartComponent {
    constructor(studentService) {
        this.studentService = studentService;
        this.subscriptions = [];
    }
    ngOnInit() {
        this.loadStudent();
    }
    ngOnDestroy() {
        for (let i = this.subscriptions.length - 1; i >= 0; i--) {
            const subscription = this.subscriptions[i];
            subscription && subscription.unsubscribe();
            this.subscriptions.pop();
        }
    }
    loadStudent() {
        const sub = this.studentService
            .getByToken(_Services_Utility_LocalStorageManager__WEBPACK_IMPORTED_MODULE_3__["LocalStorageManager"].getToken())
            .subscribe(student => {
            this.student = new _Model_Classes_Student__WEBPACK_IMPORTED_MODULE_4__["Student"]().fromStudentDTO(student);
        });
        this.subscriptions.push(sub);
    }
};
ProfileSmartComponent.ctorParameters = () => [
    { type: _Services_Student_student_service__WEBPACK_IMPORTED_MODULE_2__["StudentService"] }
];
ProfileSmartComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-profile-smart',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./profile-smart.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Profile/profile-smart/profile-smart.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./profile-smart.component.css */ "./src/app/UI/Profile/profile-smart/profile-smart.component.css")).default]
    })
], ProfileSmartComponent);



/***/ }),

/***/ "./src/app/UI/Profile/profile/profile.component.css":
/*!**********************************************************!*\
  !*** ./src/app/UI/Profile/profile/profile.component.css ***!
  \**********************************************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiIuLi8uLi9VSS9Qcm9maWxlL3Byb2ZpbGUvcHJvZmlsZS5jb21wb25lbnQuY3NzIn0= */");

/***/ }),

/***/ "./src/app/UI/Profile/profile/profile.component.ts":
/*!*********************************************************!*\
  !*** ./src/app/UI/Profile/profile/profile.component.ts ***!
  \*********************************************************/
/*! exports provided: ProfileComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProfileComponent", function() { return ProfileComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _fortawesome_free_solid_svg_icons__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @fortawesome/free-solid-svg-icons */ "./node_modules/@fortawesome/free-solid-svg-icons/index.es.js");





let ProfileComponent = class ProfileComponent {
    constructor() {
        this.faArrowRight = _fortawesome_free_solid_svg_icons__WEBPACK_IMPORTED_MODULE_2__["faArrowRight"];
        this.faSave = _fortawesome_free_solid_svg_icons__WEBPACK_IMPORTED_MODULE_2__["faSave"];
        this.faSignOutAlt = _fortawesome_free_solid_svg_icons__WEBPACK_IMPORTED_MODULE_2__["faSignOutAlt"];
        this.disabledPasswordChange = true;
        this.passwordsMatch = true;
    }
    ngOnInit() { }
    get student() {
        return this._student;
    }
    set student(value) {
        this._student = value;
    }
    togglePasswordChange() {
        this.disabledPasswordChange = !this.disabledPasswordChange;
    }
};
tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])()
], ProfileComponent.prototype, "student", null);
ProfileComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-profile',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./profile.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/UI/Profile/profile/profile.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./profile.component.css */ "./src/app/UI/Profile/profile/profile.component.css")).default]
    })
], ProfileComponent);



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
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");



const routes = [];
let AppRoutingModule = class AppRoutingModule {
};
AppRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
        imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forRoot(routes)],
        exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]]
    })
], AppRoutingModule);



/***/ }),

/***/ "./src/app/app.component.css":
/*!***********************************!*\
  !*** ./src/app/app.component.css ***!
  \***********************************/
/*! exports provided: default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony default export */ __webpack_exports__["default"] = ("\r\n\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiIuLi8uLi9hcHAuY29tcG9uZW50LmNzcyJ9 */");

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
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");


let AppComponent = class AppComponent {
};
AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
        selector: 'app-root',
        template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./app.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html")).default,
        styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./app.component.css */ "./src/app/app.component.css")).default]
    })
], AppComponent);



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
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm2015/platform-browser.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./app-routing.module */ "./src/app/app-routing.module.ts");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _UI_Errors_PageNotFound_page_not_found_page_not_found_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./UI/Errors/PageNotFound/page-not-found/page-not-found.component */ "./src/app/UI/Errors/PageNotFound/page-not-found/page-not-found.component.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
/* harmony import */ var _UI_Home_home_home_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./UI/Home/home/home.component */ "./src/app/UI/Home/home/home.component.ts");
/* harmony import */ var _UI_Home_home_smart_home_smart_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./UI/Home/home-smart/home-smart.component */ "./src/app/UI/Home/home-smart/home-smart.component.ts");
/* harmony import */ var _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! @fortawesome/angular-fontawesome */ "./node_modules/@fortawesome/angular-fontawesome/fesm2015/angular-fontawesome.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
/* harmony import */ var _UI_Profile_profile_profile_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./UI/Profile/profile/profile.component */ "./src/app/UI/Profile/profile/profile.component.ts");
/* harmony import */ var _UI_Profile_profile_smart_profile_smart_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./UI/Profile/profile-smart/profile-smart.component */ "./src/app/UI/Profile/profile-smart/profile-smart.component.ts");
/* harmony import */ var _Services_Utility_connected_guard_service__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./Services/Utility/connected-guard.service */ "./src/app/Services/Utility/connected-guard.service.ts");















const routes = [
    {
        path: 'home',
        component: _UI_Home_home_smart_home_smart_component__WEBPACK_IMPORTED_MODULE_9__["HomeSmartComponent"]
    },
    {
        path: 'profile',
        canActivate: [_Services_Utility_connected_guard_service__WEBPACK_IMPORTED_MODULE_14__["ConnectedGuardService"]],
        component: _UI_Profile_profile_smart_profile_smart_component__WEBPACK_IMPORTED_MODULE_13__["ProfileSmartComponent"]
    },
    // Other routes
    {
        path: 'not-found',
        component: _UI_Errors_PageNotFound_page_not_found_page_not_found_component__WEBPACK_IMPORTED_MODULE_5__["PageNotFoundComponent"]
    },
    {
        path: '',
        redirectTo: 'home',
        pathMatch: 'full'
    },
    {
        path: '**',
        redirectTo: '/not-found'
    }
];
let AppModule = class AppModule {
};
AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
        declarations: [
            _app_component__WEBPACK_IMPORTED_MODULE_4__["AppComponent"],
            _UI_Errors_PageNotFound_page_not_found_page_not_found_component__WEBPACK_IMPORTED_MODULE_5__["PageNotFoundComponent"],
            _UI_Home_home_home_component__WEBPACK_IMPORTED_MODULE_8__["HomeComponent"],
            _UI_Home_home_smart_home_smart_component__WEBPACK_IMPORTED_MODULE_9__["HomeSmartComponent"],
            _UI_Profile_profile_profile_component__WEBPACK_IMPORTED_MODULE_12__["ProfileComponent"],
            _UI_Profile_profile_smart_profile_smart_component__WEBPACK_IMPORTED_MODULE_13__["ProfileSmartComponent"]
        ],
        imports: [
            _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"],
            _app_routing_module__WEBPACK_IMPORTED_MODULE_3__["AppRoutingModule"],
            _angular_common_http__WEBPACK_IMPORTED_MODULE_7__["HttpClientModule"],
            _angular_router__WEBPACK_IMPORTED_MODULE_6__["RouterModule"].forRoot(routes),
            _fortawesome_angular_fontawesome__WEBPACK_IMPORTED_MODULE_10__["FontAwesomeModule"],
            _angular_forms__WEBPACK_IMPORTED_MODULE_11__["ReactiveFormsModule"]
        ],
        providers: [_Services_Utility_connected_guard_service__WEBPACK_IMPORTED_MODULE_14__["ConnectedGuardService"]],
        bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_4__["AppComponent"]]
    })
], AppModule);



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
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

const environment = {
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
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm2015/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");





if (_environments_environment__WEBPACK_IMPORTED_MODULE_4__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_2__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_3__["AppModule"])
    .catch(err => console.error(err));


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Users\mehdi\Desktop\Pomdy\pomdyFrontEnd\pomdyFrontend\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map