# Data-Export-Pro
Данный проект представляет собой экспорт данных в БД из Excel, при этом, конвертируя данные в полубайты.
Программа написана для АРМ «Орион Про» для автоматизации внесения/обновления рабочего графика сотрудников, который, в свою очередь, получает доступ к объектам. 
Внесение изменений графика в АРМ «Орион Про» производиться в руную для каждого сотрудника отдельно, а не массово. 
Для работы с Data Export Pro используется только одна таблица «GTime». В «GTime» храниться график сотрудников. 
АРМ «Орион Про» записывает «id», «Name», «Comment», «Calendar», «TimeWin Type» и «WorkMode».
______________________________________________________________________________________________________________________________________
This project is export of data to a database from Excel, while converting data into nibbles.
The program is written for AWP "Orion Pro" to automate the introduction of a work schedule for employees, who, in turn, gets access to the facilities.
Making changes to the schedule in AWP "Orion Pro" made in the rune for each employee separately, and not in large quantities.
Only one “GTime” table is used to work with Data Export Pro. GTime stores employee schedules.
AWP “Orion Pro” records “id”, “Name”, “Comment”, “Calendar”, “TimeWin Type” and “WorkMode”.

# Пример записи в базе данных
![image](https://user-images.githubusercontent.com/37382820/74772798-be0da900-52a1-11ea-82b9-55da4b708713.png)

# База данных АРМ «Орион Про»
![image](https://user-images.githubusercontent.com/37382820/74772990-0fb63380-52a2-11ea-8e69-eb04eff6f860.png)

# Logo
![gippro](https://user-images.githubusercontent.com/37382820/74772436-0b3d4b00-52a1-11ea-929f-9b465e3833aa.gif)

# Форма авторизации
![image](https://user-images.githubusercontent.com/37382820/74865527-4d7a9100-5362-11ea-9245-2510d1428b92.png)

# Основная форма
![image](https://user-images.githubusercontent.com/37382820/74774464-d7642480-52a4-11ea-8384-6c68dc795ccf.png)

# Сторонние библиотеки классов

System.Data.SqlClient,
System.Threading,
AmRoMessageDialog,
MaterialSkin,
MySql.Data.MySqlClient,
ExcelDataReader
