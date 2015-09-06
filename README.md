# ExitTask

Построить веб-приложение, поддерживающую заданную функциональность:

	1.	На основе сущностей предметной области создать классы их описывающие, соблюдая принципы SOLID. (DI по желанию).
	2.	Классы и методы должны иметь отражающую их функциональность названия и должны быть грамотно структурированы в приложении (folders, namespaces).
	3.	Оформление кода должно соответствовать C# Code Conventions.
	4.	Информацию о предметной области хранить в БД, для доступа использовать Entity Framework. В качестве СУБД использовать MS SQL (не Compact).
	5.	Архитектура приложения должна соответствовать шаблону MVC.
	6.	Выполнить журналирование событий, то есть информацию о возникающих исключениях и событиях в системе обрабатывать средствами среды.
	7.	Код должен содержать комментарии (все классы верхнего уровня, нетривиальные методы и конструкторы).
	8.	Уровень доступа к данным должен быть вынесен в отдельный проект.
	9.	Реализовать разграничение прав доступа пользователей системы к компонентам приложения (минимум 3 роли).
	10.	Все поля ввода должны быть с валидацией данных.


Дополнительно, к требованиям изложенным выше, более чем желательно обеспечить выполнение следующих требований.
    
    1.	покрытие юнит-тестами бизнес-логики.
    2.	Использовать журналирование событий.
    3.	Обработка исключений.
    4.	Самостоятельное расширение постановки задачи по функциональности приветствуется.

Туристическое агентство

Турагенство имеет каталог Туров. Для каталога реализовать возможность выборки туров:
   
    по типу (отдых, экскурсия, шоппинг);
    по цене;
    по количеству человек;
    по типу гостиницы.

Заказчик регистрируется в системе, выбирает Тур и делает Заказ. После заказа тур имеет статус 'зарегистрирован'. Незарегистрированный пользователь не имеет возможности заказывать тур. Заказчик имеет личный кабинет, в котором содержится краткая информация о пользователе, а также список туров и их текущий статус (зарегистрирован, оплачен, отменен).

Менеджер определяет тур как 'горящий'. 'Горящие' туры всегда отображаются наверху перечня.

Менеджер переводит статус тура из 'зарегистрирован' в 'оплачен' или 'отменен'. На каждый заказанный тур определяется скидка с шагом, который определяет менеджер, но не больше процента, который так же определяет менеджер.

Администратор системы владеет правами такими же правами, как и менеджер, а также может:
добавить/удалить тур, изменить информацию о туре;
блокировать/разблокировать пользователя.

