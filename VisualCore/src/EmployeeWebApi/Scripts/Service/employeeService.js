//(function () {
//    'use strict';

//    angular
//        .module('employeeapp')
//        .factory('employeeService', employeeService);

//    employeeService.$inject = ['$http'];

//    function employeeService($http) {
//        var service = {
//            getData: getData
//        };

//        return service;

//        function getData() { }
//    }
//})();
//save:{method: 'POST',params:{}}

(function () {
    'use strict';
    var employeeService = angular.module('employeeapp');
    employeeService.factory('Employees', ['$resource',
    function ($resource) {
        
        return $resource('api/EmployeeMasters/:id', {id:'@id'},
         {
             save:{method:"POST"},
             update:{method:"POST"},
             delete:{method:"DELETE"}
            
        });
    }
    ]);
    
//    var employeeCreateService = angular.module('employeeapp');
//    employeeCreateService.factory('EmployeeCreate', ['$resource',
//     function ($resource) {
//         return $resource('api/EmployeeMasters/createEmployeeMaster', {}, {
//             save: { method: 'POST' }
//         
//         });
//     }
//     ]);

})();