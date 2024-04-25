# Итоговая контрольная работа #

**Задача:** 

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

__Примеры:__

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []


## Решение ##

*Описание:*

1. Просим ввести с клавиатуры длину массива
2. Далее просим ввести каждый элемент массива
3. Далле вводим переменную, которая будет считать длину массива с элементами, длинной меньше либо равным 3
4. Создаем новый массив с этой переменной
5. проверяем на длину каждый элемент первоначального массива и если он меньше или равен 3, добавляем в новый массив
6. Выводим новый массив на экран

**Файлы**
* README.MD - описание решения
* Program.cs - код решения задачи
* Диаграмма.png - алгоритм решения