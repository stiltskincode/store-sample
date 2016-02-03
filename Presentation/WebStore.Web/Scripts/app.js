(function () {
    var app = angular.module('gemStore', ['ngRoute']);

    app.controller('CategoryController', ['$scope', '$http', function ($scope, $http){
        var store = this;
        $scope.category = {};

        store.addCategory = function (category) {
            $http.post("/api/category/post", { Category: category })
              .success(function (data, status, headers, config)
              {
                  $scope.category = {};
                  $scope.success = true;
              })
              .error(function (data, status, headers, config)
              {
                  $scope[resultVarName] = "SUBMIT ERROR";
              });
          };
    }]);

    app.controller('ProductController', ['$scope', '$http', function ($scope, $http) {
        var store = this;
        $scope.categories = {};
        $scope.product = {};

        $http.get("/api/category/get/").then(function (response) {
            $scope.categories = response.data;
        });

        store.addProduct = function (product) {
            $http.post("/api/product/post", { Product: product })
              .success(function (data, status, headers, config)
              {
                  $scope.product = {};
                  $scope.success = true;
              })
              .error(function (data, status, headers, config)
              {
                  $scope[resultVarName] = "SUBMIT ERROR";
              });
            };

    }]);

    app.controller('ProductsController', ['$scope', '$http', function ($scope, $http) {
        var store = this;
        $scope.products = {};


        $http.get("/api/product/get/").then(function (response) {
            $scope.products = response.data;
        });

    }]);
})();