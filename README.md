# DataAnalyticsRepo
## Обо мне
Привет! Меня зовут Дмитрий Баландин, мне 19 лет. Я начинающий аналитик данных. В этом репозитории вы можете найти некоторые из моих проектов, выполненных во время обучения и практики, а также мои данные



### Контактная информация
* Электронная почта: example@mail.ru
* Телеграмм https://t.me/LEGENDA2457
#### Навыки и технологии
* Занимаюсь анализом данных с помощью Exel и SQL
* Создаю дашборды и отчеты
* Обеспечиваю точность и достоверность данных
* Работал с большими объемами данных


### Образование
#### ННГУ им. Лобачевского
* Факультет: Прикладная информатика
* Год окончания: 2025

### Технические навыки
* Инструменты анализа данных: SQL, Exel
* Языки программирования и библиотеки C++, math, STL
* Системы управления базами данных: MySQL, PostgreSQL
* Теория вероятностей и мат. статистика
#### Проэкты:
### Проект 1: Калькулятор юнит-экономики онлайн-школы
https://github.com/Dmitrii2457/DataAnalyticsRepo/blob/main/%D0%9F%D1%80%D0%BE%D0%B5%D0%BA%D1%82%201.xlsx


### Что нужно было сделать:

### Задача №1
Настроить в калькуляторе учет корректировок планов маркетинга.

### Ход выполнения задачи:

1. Добавил в список параметров калькулятора показатель "Поправочный коэф-т на привлечение"
2. Установил значение этого показателя по умолчанию как 100% и добавил возможность изменять этот показатель для расчётного периода 05.21-04.22
3. Настроил динамический расчёт количества новых студентов за период 05.21-04.22 с поправкой на этот коэффициент. Если для 05.21-04.22 он равен 120%, то в каждый месяц этого периода рассчётное значение количества новых студентов должно быть больше на 20%
4. Просчитал сценарий, при котором планы маркетинга будут увеличены на 12% 

### Итог:	обновленный лист с калькулятором + новое расчётное количество студентов на 04.2022								

### Задача №2.
Пересчитать план найма преподавателей.

### Ход выполнения задачи:

1. Добавил в калькулятор Найма преподавателей возможность изменять входных параметры: Пропускную способность П и Retention П - с помощью дополнительного столбца с процентными изменениями
2. Сделал поправку в расчёте общей пропускной способности - изменил формулу так, чтобы отразить, что новые преподаватели в первый месяц своей работы могут проводить только половину уроков от средней пропускной способности преподавателя, задаваемой параметром
3. Обновил прогнозное количество уроков, добавив новые значения
4. Просчитал сценарий, при котором Пропускная способность П увеличится на 15 процентов, а Retention П упадёт на 2 процента
5. С помощью Поиска решений составил новый план найма с ограничением: за месяц нельзя нанять более 70 преподавателей

### Итог:	Обновлённый план по найму - с количеством новых преподавателей по месяцам за период с 05.2021 по 04.2022






### Проект 2: Моделирование изменения балансов студентов
https://github.com/Dmitrii2457/DataAnalyticsRepo/blob/main/%D0%9F%D1%80%D0%BE%D0%B5%D0%BA%D1%82%202.xlsx


### Что нужно было сделать:

### Задача №1
Посмотрите на изменения балансов студентов (на примере топ-1000 строк), собранных из CTE. 
Какие данные вас смущают? Какие вопросы стоит задавать дата-инженерам и владельцам таблиц?


### Ход выполнения задачи:



1.Узнаем, когда была первая транзакция для каждого студента. 

2.Соберем таблицу с датами за каждый календарный день 2016 года.

3.Узнаем, за какие даты имеет смысл собирать баланс для каждого студента.

4.Найдем все изменения балансов, связанные с успешными транзакциями. 

5.Найдем баланс студентов, который сформирован только транзакциями.

6.Найдем изменения балансов из-за прохождения уроков. 

7.Создадим CTE для хранения кумулятивной суммы количества пройденных уроков. 

8.Создадим CTE с вычисленными балансами каждого студента. 

9.Посмотрим, как менялось общее количество уроков на балансах студентов.



### Задача №2
Создайте визуализацию (линейную диаграмму) итогового результата.
Какие выводы можно сделать из получившейся визуализации?
### Итог
Получившиеся данные были загружены в эксель, по ним была создана сводная таблица и наросован график.
Из данных удалось сделать вывод:
1. В итоговой таблице можно увидеть, что к концу 2016 года накопительный итог по урокам был: 4534, студентам было начислено больше уроков, чем было пройдено.
2. Если рассматривать прохождение уроков по месяцам, то можно увидеть, что в  начале 2016 года интенсивность была небольшой, по сравнению с концом года.  
    Можно сделать вывод, что к концу года ученики пытались нагнать оставания по урокам, поэтому интенсивность намного выше.
3. Исходя из выводов выше, можно сказать ,что студенты бросают обучение или медленно проходят уроки, провоцируя тем самым возниковение "хвостов", которые идут на следующий год. 





### Проэкт 3: База данных магазина бытовой техники
Задача:
* Создать базу данных для магазина
В магазине осуществляется продажа бытовой техники. Было решено 
автоматизировать учет представленной в магазине техники (наименование, 
производитель, дата выпуска, цена, число единиц на складе), а также учет всех продаж. 
Продажа осуществляется консультантами, работающими в разных отделах магазина. 
Кроме того, было решено также вести учет кадров, т.е. хранить данные обо всех 
консультантах: ФИО, номер телефона, номер паспорта и номер отдела, в котором 
консультант работает.

* Развитие постановки задачи:
в ходе работы выяснилось, что консультант за одну продажу может реализовать 
несколько единиц техники и сопутствующих товаров. Кроме того, магазин 
предоставляет скидки, в зависимости от суммы покупки, система скидок является 
гибкой и может меняться каждый месяц, поэтому необходимо иметь возможность 
просто переназначать сумму покупки и размер соответствующей ей скидки. 
* Запрос: Для каждого производителя вывести суммарное количество проданных товаров, сумму 
продажи (с учетом скидки и без нее), а также перечисление всех видов проданной 
продукции (через запятую) за каждый календарный месяц за последний год.


### Ход выполнения задачи:



1. Создал даталогическую модель для данного задания.(Техника, консультант, продажа, скидка и связующая таблица между скидкой и продажей)

2. Создание базы данных в MySQL

3. Создание таблиц и связей между ними

4. Заполнение таблиц данными

5. Реализация запроса, описанного в задании:

* Организовать данные по производителям.
* Создать отдельный объект для каждого производителя.
* Для каждого производителя: 
1. Получить данные о продажах товаров за последний год.
2. Сгруппировать данные по месяцам.
3. Рассчитать суммарное количество проданных товаров, сумму продажи с учетом скидки и без нее.
4. Получить список всех видов проданной продукции для каждого календарного месяца.
5. Заполнить объект данными о продажах, суммарном количестве проданной продукции, сумме продажи с учетом и без учета скидки, а также списком всех видов проданной продукции для каждого месяца.
* Вывести суммарное количество проданных товаров, сумму продажи с учетом скидки и без нее, а также список проданной продукции для каждого производителя.


### Итог 
Создал даталогическую модель базы данных для магазина бытовой техники, таблицы и связи между ними, заполненил таблицы данными и реализован запрос на получение данных о продажах для каждого производителя за последний год.




 ### Проэкт 4: Визуализация данных в Exel
 
 https://github.com/Dmitrii2457/DataAnalyticsRepo/blob/main/%D0%9F%D1%80%D0%BE%D0%B5%D0%BA%D1%82%204.xlsx
 
 ### Задача №1
Постройте график количества уроков: оформите и добавьте подписи.

### Ход выполнения задачи:
1. Воспользовался данными на листе "Свод"	
2. Построил обычный график количества уроков по месяцам	
3. Добавил на график подпись для последнего месяца	
4. Добавил на диаграмму Название	

### Итог: оформленный график количества уроков


### Задача №2
Визуализируйте расходы маркетинга и их эффективность в динамике.

1. построил диаграмму на данных с листа CAC's				
2. Воспользовался для этого Комбинированной диаграммой				
3. Объединил на диаграмме ряд с суммарными расходами маркетинга на основной оси и CAC - на вспомогательной				
4. Добавил на диаграмму средний CAC за весь исторический период				
5. Вынес на визуализацию подпись со средним CAC				


### Итог: наглядная визуализация, с помощью которой можно оценить динамику CAC и объёма маркетинговых расходов		




### Задача №3
Визуализируйте доли уроков с разной ценой в динамике.

1. построил диаграмму на данных с листа classes	
2. Воспользовалс типом диаграммы "Нормированная гистограмма с накоплением"	
3. Добавил подписи	
	
### Итог: наглядная визуализация, с помощью которой можно оценить доли уроков разных цен во времени





### Задача №4
Визуализируйте динамику привлечения новых студентов по каналам.

1. Воспользовался листом users настроил сводную диаграмму
2. Использовал тип диаграммы "С областями и накоплением"
3. Добавил подписи

### Итог:наглядная визуализация, полученная  из сырых данных с помощью сводной диаграммы







### Личные качества
* Аналитический склад ума
* Креативное мышление
* Ответственность за выполнение задач
* Коммуникабельность
* Стремление к обучению новому

### Хобби
* Программирование
* Спорт (Волейбол, шахматы)

>---------

