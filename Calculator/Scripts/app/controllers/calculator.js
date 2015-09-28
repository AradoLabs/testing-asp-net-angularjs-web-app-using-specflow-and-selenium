app.controller("CalculatorCtrl", ["$scope",
    function CalculatorCtrl($scope) {
        var operationNameDivision = "/";
        var operationNameMultiply = "*";
        var operationNameAdd = "+";
        var operationNameReduce = "-";
        var operations = [
            { name: operationNameAdd, operation: function (input1, input2) { return input1 + input2; } },
            { name: operationNameReduce, operation: function (input1, input2) { return input1 - input2; } },
            { name: operationNameMultiply, operation: function (input1, input2) { return input1 * input2; } },
            { name: operationNameDivision, operation: function (input1, input2) { return input1 / input2; } }
        ];

        function isDivision(operation) {
            return operation.name == operationNameDivision;
        }

        function isDivisionByZero() {
            return isDivision($scope.selectedOperation) && ($scope.firstInput == 0 || $scope.secondInput == 0);
        }

        function isCalculationDisabled() {
            return isDivisionByZero();
        }

        function calculate() {
            $scope.result = $scope.selectedOperation.operation($scope.firstInput, $scope.secondInput);
        }

        $scope.operations = operations;
        $scope.selectedOperation = $scope.operations[0];
        $scope.calculate = calculate;
        $scope.isCalculationDisabled = isCalculationDisabled;
    }
]);