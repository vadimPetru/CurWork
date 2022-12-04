using CurWork;
using CurWork.Controller;
using CurWork.Menu;
using CurWork.Properties;

EnterApp app = new(); // Создание необходимых обьектов для работы приложения 
app.MakeAChoice(); // Проверяем существует ли пользователь в баззе 
MenuController menu = new();
menu.LogicsMenu();