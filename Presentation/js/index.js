var app = angular.module('app', []);

function myCtrl($scope) {
	$scope.currIdx = 1;
	$scope.currPage = '1.html';
	
	setFocus();

	$scope.key = function($event){
		$scope.currIdx = getIdx($event.keyCode, $scope.currIdx);
		$scope.currPage = $scope.currIdx + '.html';
		setFocus();
	}
	
	function setFocus(){
		document.querySelector('body').focus();
	}

	function getIdx(keyCode, currIdx){
		if (keyCode == 37) //left arrow
			return currIdx -1;
		else if (keyCode == 38) //up arrow
			return currIdx -1;
		else if (keyCode == 39) //right arrow
			return currIdx +1;
		else if (keyCode == 40) //down arrow
			return currIdx +1;
		else
			return currIdx;
	}
}