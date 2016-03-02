(function () {
    'use strict';

    angular
        .module('home.module')
        .controller('HomeController', HomeController);

    HomeController.$inject = ['$location', '$scope','homeService'];

    function HomeController($location, $scope, homeService) {
        /* jshint validthis:true */

        var vm = this;
        vm.title = 'home';
        $scope.number = '123';
        //$scope.helloword = 'hello word';
        activate();

        function activate() {
            var getDataListFriend = homeService.getData();
            getDataListFriend.then(function (emp) {
                $scope.employees = emp.data.data.items;
            }, function () {
                alert('Data not found');
            });
        }

    }
})();
