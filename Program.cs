using CurWork;
using CurWork.Controller;
using CurWork.TypeOFValidations;

ValidationString valid = new();
Console.WriteLine("Вызарегистрированны на сайте");
EnterApp app = new(valid); // Создание необходимых обьектов для работы приложения 

var currentCustomer = app.MakeAChoice(); // Проверяем существует ли пользователь в баззе и записываем в переменную

MenuController menu = new(valid);

menu.LogicsMenu(currentCustomer);