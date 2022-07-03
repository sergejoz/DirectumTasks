# Проф. задания для кандидатов на прикладную разработку (C#, Directum)

## Первое задание: Разработка на SQL
Из вариантов выбрал: **Написание запроса к базе данных**.

**Решение**: [SQLQuery.sql](https://github.com/sergejoz/DirectumTasks/blob/main/Task1/SQLQuery.sql).

**Задание**:
1.	Написать SQL-запрос, который возвращает объем продаж в количественном выражении в разрезе сотрудников за период с 01.10.2013 по 07.10.2013:
- Фамилия и имя сотрудника;
- Объем продаж сотрудника.

Данные отсортировать по фамилии и имени сотрудника.

2.	На основании созданного в первом задании запроса написать SQL-запрос, который возвращает процент объема продаж в разрезе сотрудников и продукции за период с 01.10.2013 по 07.10.2013:
-	Наименование продукции;
-	Фамилия и имя сотрудника;
-	Процент продаж сотрудником данного вида продукции (продажи сотрудника данной продукции/общее число продаж данной продукции).
В выборку должна попадать продукция, поступившая за период с 07.09.2013 по 07.10.2013.
Данные отсортировать по наименованию продукции, фамилии и имени сотрудника.

![image](https://user-images.githubusercontent.com/43649713/177024879-4560c3fc-49ce-4707-98cd-57b11587ff93.png)

## Второе задание: Разработка интерфейса

Из вариантов выбрал: **Разработка интерфейса карточки сотрудника**.

**Решение**: [Папка с скриншотами](https://github.com/sergejoz/DirectumTasks/tree/main/Task2).

## Третье задание: Разработка приложения

**Решение**: [Папка с решением](https://github.com/sergejoz/DirectumTasks/tree/main/Task3/MeetingApp), [План тестирования](https://github.com/sergejoz/DirectumTasks/blob/main/Task3/README.md)

**Задание**:
Разработать консольное приложение на C# .Net по описанию. 
Реализовывать долгосрочное хранение информации о встречах необязательно, достаточно хранить встречи в памяти.
Для приложения написать план тестирования.

**Исходные данные**:
Необходимо разработать приложение для управления личными встречами.
Встреча – событие, которое планируется заранее, для которой всегда известно время начала и примерное время окончания. 
Данные о встречах могут быть добавлены, изменены и удалены. Встречи всегда планируются только на будущее время. При этом встречи не должны пересекаться друг с другом. 
Также для встречи может быть настроено время, за которое нужно уведомить пользователя о предстоящей встрече. Время напоминания также может быть изменено после создания встречи. При наступлении времени напоминания приложение информирует пользователя о предстоящей встрече и времени ее начала.
Пользователь может посмотреть расписание своих встреч на любой день, в том числе и прошедший. 
Помимо просмотра он может с помощью приложения экспортировать расписание встреч за выбранный день в текстовый файл.



