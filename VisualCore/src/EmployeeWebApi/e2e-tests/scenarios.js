'use strict';

/* https://github.com/angular/protractor/blob/master/docs/toc.md */

describe('my app', function() {
it('should automatically redirect to index page when location hash/fragment is empty', function() {
    browser.get('index.html');
    expect(browser.getLocationAbsUrl()).toMatch("/");
  });
  
it('should automatically redirect to index page when location hash/fragment is empty', function() {
    browser.get('index.html#/create');
    expect(browser.getLocationAbsUrl()).toMatch("/create");
    element(by.model('Employee.EmpName')).sendKeys('Baraneetharan');
    element(by.model('Employee.Designation')).sendKeys('Developer');
    element(by.model('Employee.Email')).sendKeys('baraneetharan.ramasamy@kgfsl.com');
    element(by.model('Employee.Phone')).sendKeys(9790597065);
    element(by.model('Employee.Address')).sendKeys('Coimbatore');
    element(by.id('submit')).click();
    browser.switchTo().alert().accept();
    expect(browser.getCurrentUrl()).toEqual('http://localhost:8000/wwwroot/index.html#/create');
    //expect(browser.getCurrentUrl()).toEqual('http://localhost:8000/wwwroot/api/EmployeeMasters');
    //browser.pause();
  });  
});
