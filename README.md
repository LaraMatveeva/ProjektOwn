 
# Данная программа  формирует новый массив из строк из имеющегося массива строк, длина которых меньше, либо равна 3 символам. 
# Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
## При решении не рекомендуется пользоваться коллекциями,лучше обойтись исключительно массивами.

### Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → ["-2"]

[“Russia”, “Denmark”, “Kazan”] → []


## Решение задачи.
1. Для решения задачи используются методы.
Каждый метод отвечает за отдельную функцию.
Это функции ввода данных, обработки (нахождения строки с заданным значением), и вывода данных на экран.

2. Метод ввода данных. 

   **void ArrayEnter(string[] arr, int num)**

   Ввод массива строк предоставляется пользователю. Для этого предлагается ввести количество строк (слов), на основании которого будет формироваться первоначальный массив с помощью данного метода. В метод **ArrayEnter** передаются следующие параметры: пустой массив с количеством строк, которое ввел пользователь, а также количество строк.

3. Методы обработки данных. 
   
    3.1.  **CountArr(string[] array1, int num)**

   Метод подсчета строк, удовлетворяющих условию задачи (длина должна быть меньше либо равна 3 символам), определяет тем самым длину нового массива строк, преобразованного из исходного. Метод получает в качестве параметров введенный пользователем  массив, его длину, а возвращает количество строк в новом массиве, что и позволяет задать новый массив.

    3.2.  **ExtructArr(string[] array, int num, int sumStr)**
   
   Метод формирования нового массива строк из исходного присваивает каждому следующему элементу нового массива значение элемента исходного массива при условии, если длина строки исходного массива меньше либо равна 3 символам. Метод возвращает новый массив строк, а получает исходный массив, количество элементов в данном массиве, и количество элементов в новом массиве.

4. Метод **void PrintArray(string[] arr1, bool marker)**

   Метод вывода данных позволяет вывести как исходный массив на экран, так и вновь сформированный по условию задачи. Параметрами
   данного метода будут являться массив данных, а также маркер, который укажет, в какой именно последовательности выводить симоволы массива.