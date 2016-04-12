(function () {
    'use strict';

    angular
        .module('employeeapp')
        .controller('employeeController', employeeController);

    employeeController.$inject = ['$scope','Employees']; 

    function employeeController($scope, Employees) {
       
         $scope.Employees = Employees.query();
        
         
        $scope.result = "";
        $scope.saveEmployee = function() {
            alert(JSON.stringify($scope.Employee)+"<-----------Test");
             $scope.Employee.EmpID = 0;
             Employees.save($scope.Employee,function(success){
              alert(JSON.stringify(success));
              $scope.result = JSON.stringify(success);
              //return JSON.stringify(success);
             window.location.href = '#/';
             },function(error){
               
             });
             
        }
        
        $scope.updateEmployee = function(){
            alert(JSON.stringify($scope.Employee)+"<-----------Test");
           Employees.update($scope.Employee,function(success){
                alert(JSON.stringify(success));
                $scope.result = JSON.stringify(success);
                window.location.href = '#/'; 
            },function(error){
                
            });
        }
        
        $scope.deleteEmployee = function(){
            alert(JSON.stringify($scope.Employee)+"<-----------Test");
            Employees.delete($scope.Employee,function(success){
            alert(JSON.stringify(success));
            $scope.result = JSON.stringify(success);
                window.location.href = '#/';
            },function(error){
                
            });
        }
        
        // $scope.getByIdEmployee = function(){
        //   alert(JSON.stringify($scope.Employee)+"<-----------Test");
        //  
        //   Employees.getbyid($scope.Employee,function(success){
        //     alert(JSON.stringify(success));
        //     $scope.EmpById = JSON.stringify(success);
        //         
        //     },function(error){
        //         
        //     }); 
        //    
        // }
        
        
       
        
    }
 
})();
