# Data-Export-Pro
Данный проект представляет собой экспорт данных в БД из Excel и конвертируеться по средству полубайтов.
Программа написана для АРМ «Орион Про». Она оптимизирует внесение графика сотрудников, которые в свою очередь поляет доступ к объектам. 
Внесение изменений графика в АРМ «Орион Про» производиться в руную для каждого сотрудника отдельно, а не массово. 
Для работы с Data Export Pro используется только одна таблица «GTime». В «GTime» храниться график сотрудников. 
АРМ «Орион Про» записывает «id», «Name», «Comment», «Calendar», «TimeWin Type» и «WorkMode»

# Пример записи в базе данных
![image](https://user-images.githubusercontent.com/37382820/74772798-be0da900-52a1-11ea-82b9-55da4b708713.png)

# База данных АРМ «Орион Про»
![image](https://user-images.githubusercontent.com/37382820/74772990-0fb63380-52a2-11ea-8e69-eb04eff6f860.png)

# Logo
![gippro](https://user-images.githubusercontent.com/37382820/74772436-0b3d4b00-52a1-11ea-929f-9b465e3833aa.gif)

# Основная форма
![image](https://user-images.githubusercontent.com/37382820/74774464-d7642480-52a4-11ea-8384-6c68dc795ccf.png)

# Сторонние библиотеки классов

System.Data.SqlClient,
System.Threading,
AmRoMessageDialog,
MaterialSkin,
MySql.Data.MySqlClient,
ExcelDataReader,
