##Задачи

1. Даны два целых знаковых четырех байтовых числа и две позиции битов i и j (i<j). Реализовать алгоритм InsertNumber вставки битов с j-ого по i-ый бит одного числа в другое так, чтобы биты второго числа занимали позиции с бита j по бит i (биты нумеруются справа налево). Разработать модульные тесты (NUnit и(!) MS Unit Test) для тестирования метода.<br/>
[Реализация](https://github.com/IlyaDvortsevoy/NET.S.2018.Dvortsevoy.02/blob/master/Algorithms/Algorithm.cs)
[Тесты - MS Test](https://github.com/IlyaDvortsevoy/NET.S.2018.Dvortsevoy.02/blob/master/Algorithms.Tests.MSTest/AlgorithmsTests.cs)
[Тесты - NUnit](https://github.com/IlyaDvortsevoy/NET.S.2018.Dvortsevoy.02/blob/master/Algorithms.Tests.NUnit/AlgorithmsTests.cs)

2. Реализовать метод FilterDigit который принимает массив целых чисел и фильтрует его таким образом, чтобы на выходе остались только числа, содержащие заданную цифру (LINQ-запросы не использовать!) Например, для цифры 7, FilterDigit (7,1,2,3,4,5,6,7,68,69,70, 15,17) -> {7, 7, 70, 17}. Разработать модульные тесты (NUnit и MS Unit Test (включая подход DDT)) для тестирования метода.<br/>
[Реализация](https://github.com/IlyaDvortsevoy/NET.S.2018.Dvortsevoy.02/blob/master/Algorithms/Algorithm.cs)
[Тесты](https://github.com/IlyaDvortsevoy/NET.S.2018.Dvortsevoy.02/blob/master/Algorithms.Tests.MSTest/AlgorithmsTests.cs)
