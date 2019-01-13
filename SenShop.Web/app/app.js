﻿/// <reference path="/Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('senshop',
        ['senshop.products',
         'senshop.product_categories',
         'senshop.common'])
        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();