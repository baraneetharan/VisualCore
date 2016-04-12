var chakram = require('chakram'),
    expect = chakram.expect;
// 
// describe("Chakram", function() {
//     it("should provide a simple async testing framework", function () {
//         var response = chakram.get("http://httpbin.org/get");
//         expect(response).to.have.status(200);
//         expect(response).not.to.have.header('non-existing-header');
//         return chakram.wait();
//     });
// });

describe('EmployeeTest', function(){
	it('Create empdetails', function(){
		this.timeout(5000);
		return chakram.post("http://Localhost:5000/api/EmployeeMasters/",
			{
                "EmpName":"SueSmith","Designation":"Dev","Email":"soma@kgfsl.com","Phone":"898989898","Address":"CBE"            },
		 {
			headers: {
				'Content-Type': 'application/json'
			},
		})
		.then(function(response){
			//console.log(response.body);
			 expect(response).to.have.status(200);
			 expect(response).to.have.header('content-type', /json/);
		})
		return chakram.wait();
	})
});
//method 2
describe('EmployeeUpdateTest', function(){
	it('Updating employee details', function(){
		this.timeout(5000);
		return chakram.post("http://Localhost:5000/api/EmployeeMasters/",
			{
                "EmpID":"7","EmpName":"Somasundaram","Designation":"Dev","Email":"soma@kgfsl.com","Phone":"898989898","Address":"CBE"            },
		 {
			headers: {
				'Content-Type': 'application/json'
			},
			
			
		})
		.then(function(response){
			//console.log(response.body);
			 expect(response).to.have.status(200);
			 expect(response).to.have.header('content-type', /json/);
		})
		return chakram.wait();
	})
});
//method 3
describe('EmployeeUpdateTest', function(){
	it('delete employee details', function(){
		this.timeout(5000);
		return chakram.delete("http://Localhost:5000/api/EmployeeMasters?EmpID=7",
			
		 {
			headers: {
				'Content-Type': 'application/json'
			},
		})
		.then(function(response){
			//console.log(response.body);
	        expect(response).to.have.status(200);
			expect(response).to.have.header('content-type', /json/);
		})
		return chakram.wait();
	})
});
//get method
describe('EmployeeUpdateTest', function(){
	it('get all employees', function(){
		this.timeout(5000);
		return chakram.get("http://Localhost:5000/api/EmployeeMasters")
		.then(function(response){
			//console.log(response.body);
	        expect(response).to.have.status(200);
			expect(response).to.have.header('content-type', /json/);
		})
		return chakram.wait();
	})
});