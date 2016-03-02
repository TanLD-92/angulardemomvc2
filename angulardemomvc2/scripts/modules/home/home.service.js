(function () {
    'use strict';

    angular
        .module('home.module')
        .service('homeService', HomeService);

    HomeService.$inject = ['$http'];

    function HomeService($http) {
        var service = {
            getData: getDataListFriend
        };

        return service;

        function getDataListFriend() {
            return $http.get("http://api.gamma.youlook.net/paths/types?limit=8&page=2");
        }
    }
})();