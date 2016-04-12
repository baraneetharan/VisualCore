describe("employeeapp", function () {
    beforeEach(module("employeeapp"));
    describe('controller: employeeController', function () {
        var ctrl, Employees, $scope;
     

        beforeEach(inject(function ($rootScope, $controller) {
            $scope = $rootScope.$new();
            Employees = {
                query: function () { 
                  // $scope.Employees =  '[{"EmpID":1,"EmpName":"aravind","Designation":"dev","Email":"aravind.m@kgfsl.com","Phone":"8807548039","Address":"coimbatore"}]';
                },
                save:function () {
                    $scope.result = '{"result":true}';
                },
                 update:function () {
                    $scope.result = '{"result":true}';
                },
                delete:function () {
                     $scope.result = '{"result":true}';
                }
              
            };

            spyOn(Employees, 'query').and.returnValue('[{"EmpID":1,"EmpName":"aravind","Designation":"dev","Email":"aravind.m@kgfsl.com","Phone":"8807548039","Address":"coimbatore"}]'); // <----------- HERE
          //  spyOn(Employees, 'save').and.returnValue('{"result":true}');
          //  spyOn(Employees, 'delete').and.returnValue('{}');
           //  spyOn(Employees, 'save').and.returnValue('[]'); // <----------- HERE
          //  spyOn(Employees, 'update').and.returnValue('{}'); // <----------- HERE
         //   spyOn(Employees, 'delete').and.returnValue('{}'); // <----------- HERE
            
            
            

            ctrl = $controller('employeeController', { $scope: $scope, Employees: Employees });
        }));

        it('Should call get all()', function () {
            console.log($scope.Employees);     
            expect($scope.Employees).toBe('[{"EmpID":1,"EmpName":"aravind","Designation":"dev","Email":"aravind.m@kgfsl.com","Phone":"8807548039","Address":"coimbatore"}]');
        });
        
        it('Should call create', function () {
            $scope.Employee = {"EmpName":"reka","Designation":"Dev","Email":"reka.v@kgfsl.com","Phone":"577888","Address":"CBE"}
            console.log($scope.result);
            $scope.saveEmployee($scope.Employee);
            expect($scope.result).toBe('{"result":true}');
        });
        
        it('Should call update', function () {
            $scope.Employee = {"EmpID":1,"EmpName":"reka","Designation":"Dev","Email":"reka.v@kgfsl.com","Phone":"577888","Address":"CBE"};
            console.log($scope.result);
            $scope.updateEmployee($scope.Employee);
            expect($scope.result).toBe('{"result":true}');
        });
        
        it('Should call delete', function () {
            $scope.Employee = {"EmpID":1};
           $scope.deleteEmployee($scope.Employee);
            expect($scope.result).toBe('{"result":true}');
        });
               
    });
});

