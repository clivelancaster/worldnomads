
angular.module('formInput', [])
  .controller('HomeController', ['$scope', function ($scope) {
      angular.element(document).ready(function () {
          $scope.display = function (postData) {

              $.ajax({
                  type: "POST",
                  url: '/Home/GetCalculatedResult',
                  data: { number: angular.copy(postData).number },
                  success: function (data) { // on success..
                      $scope.master = data;
                      $scope.$apply();
                  },
                  error: function (ex) {
                      alert('Error: ' + ex.statusText);
                  }
              });

          };
      });
  }]);
