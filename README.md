# _Отделочная_ компания
## Содержание  
 [Введение](#introduction)  
 [1. Описание предметной области](#domainDescription) 
 
 [1.1. Проблематика](#problematic) 
 
 [1.2. Цели и задачи](#goals) 
 
 [2. Сравнительный анализ существующих прогарммных решений](#existingSoftware)  

 [3. Разработка системы](#development)
 
 [3.1. Этап проектирования](#designing)
 
 
 <a name="introduction"/>

 ## Введение
 Данная практическая работа необходима для изучения студентами направлений информационных технологий. Она направлена на изучения пограммирования на языке С#. Он входит в самые популярные объектно-ориентированные языки программирования, имеет широкие возможности для создания различного рода приложений. В моей работе требуется разработать веб-приложение, связанное с информационной системой строительной организации. Его можно будет применять на практике для упрощения коммуникации между субъектами приобретающими и работающими над купленным проектом. Такие вопросы было принято решать через звонки или на оффлайн-встречах, но данное приложение значительно ускорит и упростит, а так же систематизирует работу организации.
 
 
 <a name="domainDescription"/>

 ## 1. Описание предметной области
 Выбранная предметная область - личный кабинет отделочной компании. Информационная система в данной предметной области включает в себя следующие разделы: «Прораб», «Заказчик», «Рабочий» и «Дизайнер». У каждого свои функции и задачи: 1) «Прораб» общается с заказчиком, предлагает ему проекты из базы данных «проекты» (разработанные дизайнером), если заказчик одобряет проект, то прораб начинает составлять план работы и заносит его в базу данных «план работы», далее он следит за качеством выполнения работы и, если она выполнена, то получает оплату проекта, которая заносится в базу «расчётный счёт», откуда затем выплачивается заработная плата. 2) «Рабочий» выполняет выданный ему из базы план работы и за это получает зарплату. 3) «Дизайнер» разрабатывает дизайн-проект, который заносится в соответствующую базу и передаётся прорабу, за эти проекты он получает зарплату из соответствующей базы данных. 4) «Заказчик» выбирает понравившийся из предложенных проектов, приобретает его и после завершения работы оплачивает её.  
 
 
 <a name="existingSoftware"/>
 
 ### 1.1. Проблематика 
На данный момент многие люди старшего поколения предпочли бы встречи в оффайн-формате, т.к. не доверяют технологиям. Так же большая часть рабочих может не иметь нужных устройств для пользования веб-приложениями. Необходим доступ в интернет, а значит, нужна постоянное стабильное соединение, которого в нужный момент может не оказаться. 
 
 <a name = "problematic"/>
 
 ### 1.2. Цели и задачи
 
 Целью данной работы является создание удобного приложения для упрощения организации работы отделочной компании.
Для этого необходимо реализовать следующие пункты:
1.	Создать удобную и простую в понимании среду работы.
2.	Привлечь молодых людей и расположить, донести до старшего поколения безопасность системы.
3.	Набрать штат квалифицированных сотрудников, имеющих необходимые устройства для пользования веб-приложением.  

 <a name="goals"/>

 ## 2. Сравнительный анализ существующих программных решений
Существуют многочисленные аналогичные личные кабинеты организаций, которыми пользуются уже годами. Но в нашем регионе таких компаний единицы. При поиске в интернете одним из первых высвечивается сайт 62otdelka.ru с довольно приятным интерфейсом и работающий с 2006 года. В подборке сайтов с таким назначением оценки пользователей в среднем не превышают 3,5 баллов из 5. Но основываясь на самых высоко оценённых, необходимо, чтобы в веб-приложении был простой интерфейс, гарантии качества, подсказки, видео и фото материалы. 

<a name="existingSoftware"/>

## 3. Разработка системы
Разработка системы состоит из двух этапов. Первый - это проектирование, в ходе которого определяются цели создания, требования и желаемый результат, также на нём определяют основные источники информации, их надежность и согласованность предоставляемых данных. Вторым этапом является реализация программной части, в ходе которой результаты проектирования превращаются в готовый продукт посредством написания программного обеспечения.

<a name="development"/>

### 3.1. Этап проектирования
Разработка начинается с проектирования диаграммы вариантов использования (use-case diagram)(см. рисунок 1), где отражаются главные действующие лица данной системы: прораб, дизайнер, рабочий и заказчик.
                ![Снимок экрана 2021-12-16 в 8 38 24](https://user-images.githubusercontent.com/91217659/146314488-fc0894bc-a2fb-485d-b971-546bc4182097.png)

                                                             Рисунок 1 - Use-case diagram

<a name="designing"/>
