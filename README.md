# Описание задания

*Задача:* 

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

# Описание решения

1. Объявляем стринговый массив, который используется программой по умолчанию.

2. Предлагаем пользователю ввести массив с клавиатуры и объявляем переменную **input**, в которую сохраняем введенный пользователем массив.

3. Если пользователь выбрал массив по умолчанию, выводим его на экран с помощью метода **PrintArray**. Затем выполняем основной метод **GetNewArray**.

4. Если пользователь ввел свой массив, мы разбиваем текст на элементы массива через сепаратор и формируем массив. Выводим его на экран с помощью метода **PrintArray**. Затем выполняем основной метод **GetNewArray**.

5. Метод **PrintArray** сделан через **void**, он выводит в консоль каждый элемент массива построчно.

6. Метод **GetNewArray** проходит по заданному массиву и сохраняет в переменную **index** количество элементов массива с длиной менее 4. Если таких элементов нет, метод возвращает **Null**. Иначе - объявляет новый массив с количеством элементов **index**. Через **for** пробегается по заданному массиву и записывает в новый массив элементы с длиной менее 4. Возвращает новый массив.

7. Если **GetNewArray** вернул **Null**, сообщаем пользователю, что в заданном массиве нет элементов, удовлетворяющих условию задачи.

8. Если метод вернул массив - выводим в консоль новый массив.