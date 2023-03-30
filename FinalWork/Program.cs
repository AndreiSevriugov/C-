using System;

class Program {
  static void Main(string[] args) {
    // Ввод исходного массива
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine());
    string[] originalArray = new string[size];
    for (int i = 0; i < size; i++) {
      Console.Write($"Введите строку {i + 1}: ");
      originalArray[i] = Console.ReadLine();
    }

    // Формирование нового массива
    int newSize = 0;
    for (int i = 0; i < size; i++) {
      // Проверка длины строки
      if (originalArray[i].Length <= 3) {
        newSize++;
      }
    }

    // Создание нового массива
    string[] newArray = new string[newSize];
    int index = 0;
    for (int i = 0; i < size; i++) {
      // Проверка длины строки
      if (originalArray[i].Length <= 3) {
        // Добавление в новый массив
        newArray[index] = originalArray[i];
        index++;
      }
    }

    // Вывод нового массива
    Console.WriteLine("Новый массив:");
    for (int i = 0; i < newSize; i++) {
      Console.WriteLine(newArray[i]);
    }
  }
}
