(function () {
    'use strict';

    angular.module('employeeapp', [
        // Angular modules 
        'ngRoute','ngResource'

        // Custom modules 
        
        // 3rd Party Modules
        
    ]).config(['$routeProvider', function ($routeProvider) {
  $routeProvider
   
    .when("/", { templateUrl: "partial/details.html", controller: "employeeController" })
    .when("/create", { templateUrl: "partial/create.html", controller: "employeeController" })
    .when("/update", { templateUrl: "partial/Update.html", controller: "employeeController" })
    .when("/delete", { templateUrl: "partial/delete.html", controller: "employeeController" })
    .when("/getemployee", { templateUrl: "partial/getbyid.html", controller: "employeeController" })
    .otherwise("/404", {templateUrl: "partials/404.html"});
}]);
})();