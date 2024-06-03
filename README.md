# Разработка кода программного продукта на основе готовой спецификации на уровне модуля "Кондитерский завод"

### Название приложения: ConfectioneryFactory
### Описание приложения:
**Данное приложение - это удобный инструмент для подсчёт возможной продукции из ресурсов на складе и подсчета стоимоти логистики, так же в приложении представлен вход по логину и паролю, и на главном экране прописана должность и ФИО сотрудника.**

# В приложении имеются следующие страницы:
1. **Окно авторизации (MainWindow)** - на нем содержится два поля для ввода Логина и Пароля, а так же кнопка войти.
2. **Главное окно (Factory)** - в этом окне находится таблица DataGrid(количество ингридиентов на складе), должность и фио, и кнопки расчета продукции и логистики.
3. **Окно подсчета продукции (ProductCalcul)** - окно для подсчета возможной продукции из остатков на складе.
4. **Окно подсчета логистики (LogisticsCalcul)** - окно для подсчета стоимости доставки до магазина.

# Описание функций приложения:
1. **Авторизация** В приложении присутствует система входа для каждого сотрудника.
2. **Расчет логистики** для расчета логистики нужно знать расстояние до магазина и стоимость 1 км.
3. **Подсчет возможной продукции** Подсчет производиться из данных с БД, готовый результат измеряется в упаковках по 6 шт.

# Технологии, которые были использованы во время разработки приложения:
- **Язык программирования C#** - использован для создания всей логики приложения.
- **Фреймворк Windows Presentation Foundation (WPF)** - использован для создания интерфейса приложения.
- **База данных Sql Management Studio** - использована для хранения данных.

# Описание базы данных:
### База данных называется FactoryBD.db <br/>
База данных была подключена в проект через EntityFrameWork </br>
В базе данных имеется 2 таблица, в первой содержатся колонки с названием **idUser**, **Login**, **Pass**, **FIO**, **Department**. В этой таблице записаны данные о сотруднике. Во второй таблице содержатся колонки с названием **idStocks**, **Munka**, **Butter**, **Sugar**, **Cocoa**, **Water**. В этой таблице записано количество ингридиентов. <br/>
В дальнейшем, все записи отсюда выгружаются в приложение.

# Скриншоты приложения:
![Окно авторизации](https://github.com/qwerzxcvbn/ConfectioneryFactory/blob/main/Image/Screenshot_8.png) </br>
**Окно авторизации**
</br> </br> </br>
![Главное окно](https://github.com/qwerzxcvbn/ConfectioneryFactory/blob/main/Image/Screenshot_9.png) </br>
**Главное окно**
</br> </br> </br>
![Окно подсчета продукции](https://github.com/qwerzxcvbn/ConfectioneryFactory/blob/main/Image/Screenshot_10.png) </br>
**Окно подсчета продукции**
</br> </br> </br>
![Окно подсчета логистики](https://github.com/qwerzxcvbn/ConfectioneryFactory/blob/main/Image/Screenshot_6.png) </br>
**Окно подсчета логистики**
</br> </br> </br>
