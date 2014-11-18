//$( document ).ready(function() {
angular.module('formInput', [])
  .controller('HomeController', ['$scope', function ($scope) {
      
      angular.element(document).ready(function () {

          $scope.postData = { number: '0' };
          $scope.display = function (postData) {
              //$scope.master = angular.copy(postData);
              console.log(postData);
              $event.stopPropagation();

              $.ajax({
                  type: "POST",
                  url: '/Home/GetCalculatedResult',
                  data: { number: angular.copy(postData).number },
                  success: function (data) { // on success..
                      $scope.master = data;
                  },
                  error: function (ex) {
                      alert('Error: ' + ex.statusText);
                  }
              });

          };

          $scope.reset = function () {
              $scope.postData = angular.copy($scope.master);
          };

          $scope.reset();

      });
  }]);
//});