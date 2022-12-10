using CurWork;
using CurWork.Controller;


EnterApp app = new(); // Создание необходимых обьектов для работы приложения 
var currentCustomer = app.MakeAChoice(); // Проверяем существует ли пользователь в баззе и записываем в переменную
MenuController menu = new();
menu.LogicsMenu(currentCustomer); 