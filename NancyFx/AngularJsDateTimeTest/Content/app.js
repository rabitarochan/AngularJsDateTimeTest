function testCtrl($scope, $http) {
    $scope.times = [];
    $scope.getTime = function() {
        $http({
            url: '/now',
            method: 'GET'
        }).success(function (data) {
            console.log(data.time);
            $scope.times.push(data);
        });
    };
}