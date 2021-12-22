# _Отделочная компания_
## Содержание  
 [Введение](#introduction)  
 [1 Описание предметной области](#domainDescription) 
 
 [1.1 Проблематика](#problematic) 
 
 [1.2 Цели и задачи](#goals) 
 
 [2 Сравнительный анализ существующих прогарммных решений](#existingSoftware)  

 [3 Разработка системы](#development)
 
 [3.1 Этап проектирования](#designing)
 
 [3.2 Этап реализации](#realization)
 
 [4 Проверка и тестирование программы](#test)
 
 [Заключение](#conclusion)
 
 [Список использованных источников](#source)
 
 
 <a name="introduction"/>

 ## Введение
 Данная практическая работа необходима для изучения студентами направлений информационных технологий. Она направлена на изучения пограммирования на языке С#. Он входит в самые популярные объектно-ориентированные языки программирования, имеет широкие возможности для создания различного рода приложений. В моей работе требуется разработать веб-приложение, связанное с информационной системой строительной организации. Его можно будет применять на практике для упрощения коммуникации между субъектами приобретающими и работающими над купленным проектом. Такие вопросы было принято решать через звонки или на оффлайн-встречах, но данное приложение значительно ускорит и упростит, а так же систематизирует работу организации.
 
 
 <a name="domainDescription"/>

 ## 1 Описание предметной области
 Выбранная предметная область - личный кабинет отделочной компании. Информационная система в данной предметной области включает в себя следующие разделы: «Прораб», «Заказчик», «Рабочий» и «Дизайнер». У каждого свои функции и задачи: 1) «Прораб» общается с заказчиком, предлагает ему проекты из базы данных «проекты» (разработанные дизайнером), если заказчик одобряет проект, то прораб начинает составлять план работы и заносит его в базу данных «план работы», далее он следит за качеством выполнения работы и, если она выполнена, то получает оплату проекта, которая заносится в базу «расчётный счёт», откуда затем выплачивается заработная плата. 2) «Рабочий» выполняет выданный ему из базы план работы и за это получает зарплату. 3) «Дизайнер» разрабатывает дизайн-проект, который заносится в соответствующую базу и передаётся прорабу, за эти проекты он получает зарплату из соответствующей базы данных. 4) «Заказчик» выбирает понравившийся из предложенных проектов, приобретает его и после завершения работы оплачивает её.  
 
 
 <a name="existingSoftware"/>
 
 ### 1.1 Проблематика 
На данный момент многие люди старшего поколения предпочли бы встречи в оффайн-формате, т.к. не доверяют технологиям. Так же большая часть рабочих может не иметь нужных устройств для пользования веб-приложениями. Необходим доступ в интернет, а значит, нужна постоянное стабильное соединение, которого в нужный момент может не оказаться. 
 
 <a name = "problematic"/>
 
 ### 1.2 Цели и задачи
 
 Целью данной работы является создание удобного приложения для упрощения организации работы отделочной компании.
Для этого необходимо реализовать следующие пункты.
1.	Создать удобную и простую в понимании среду работы.
2.	Привлечь молодых людей и расположить, донести до старшего поколения безопасность системы.
3.	Набрать штат квалифицированных сотрудников, имеющих необходимые устройства для пользования веб-приложением.  

 <a name="goals"/>

 ## 2 Сравнительный анализ существующих программных решений
Существуют многочисленные аналогичные личные кабинеты организаций, которыми пользуются уже годами. Но в нашем регионе таких компаний единицы. При поиске в интернете одним из первых высвечивается сайт 62otdelka.ru[1] с довольно приятным интерфейсом и работающий с 2006 года. В подборке сайтов с таким назначением оценки пользователей в среднем не превышают 3,5 баллов из 5. Но основываясь на самых высоко оценённых, необходимо, чтобы в веб-приложении был простой интерфейс, гарантии качества, подсказки, видео и фото материалы. Если же рассмотривать всю Россию,по запросу самых качественных сайтов нашей тематики можно найти сочинское монтажное предприятие[2], сайт которого действительно впечатляющий, адаптивный и имеющий уникальный дизайн с фоновыми видео и всплывающими кнопками. Вся контактная информация на нём расположена на видном месте и кликабельна, всё максимально удобно и при этом быстро работает. Однако на всех этих сайтах нет личных кабинетов и возможности организации работы, лишь реклама и перечень услуг, поэтому наш проект довольно актуален. 

<a name="existingSoftware"/>

## 3 Разработка системы
Разработка системы состоит из двух этапов. Первый - это проектирование, в ходе которого определяются цели создания, требования и желаемый результат, также на нём определяют основные источники информации, их надежность и согласованность предоставляемых данных. Вторым этапом является реализация программной части, в ходе которой результаты проектирования превращаются в готовый продукт посредством написания программного обеспечения.

<a name="development"/>

### 3.1 Этап проектирования
Разработка начинается с проектирования диаграммы вариантов использования (use-case diagram)(см. рисунок 1), где отражаются главные действующие лица данной системы: прораб, дизайнер, рабочий и заказчик.
<p align="center">
<img src="https://user-images.githubusercontent.com/91217659/146314488-fc0894bc-a2fb-485d-b971-546bc4182097.png"></p>

<p align="center">Рисунок 1 - Use-case diagram

На основе use-case диаграммы происходит разработка диаграммы потока данных (Data Flow Diagram), на которой показаны потоки данных(см. рисунок 2 и рисунок 3).

![Снимок экрана 2021-12-16 в 8 44 05](https://user-images.githubusercontent.com/91217659/146315091-1237edaa-7f30-4998-9d5f-a40a014b9933.png)

<p align="center">Рисунок 2 - Data Flow Diagram

![Снимок экрана 2021-12-16 в 8 43 40](https://user-images.githubusercontent.com/91217659/146315147-1231d4f7-1c51-4035-9f42-4d91a617f029.png)

<p align="center">Рисунок 3 - Data Flow Diagram

Далее создаем диаграмму Сущность-Связь (Entity-Relationship diagram)(см. рисунок 4), где отображаются хранилища и связи между ними.

![Снимок экрана 2021-12-16 в 8 48 07](https://user-images.githubusercontent.com/91217659/146315497-ed14a804-26bd-4cbc-80c9-c74f00c0bd96.png)

<p align="center">Рисунок 4 - Entity-Relationship diagram

<a name="designing"/>

### 3.2 Этап реализации
На основании ER диаграммы создаем классы для каждой сущности. Ниже представлен листинг 1 - класс заказчик.

Листинг 1 - Класс "Заказчик"

        using System;

        namespace ZiminaLear.Domain
        {
            public class Customer
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Phone { get; set; }
                public string Address { get; set; }
                public DateTime BirthDate { get; set; }

                public Customer() {}

                public Customer(int custId,string name,string phone, string address, DateTime birthDate)
                {
                    Id = custId;
                    Name = name;
                    Phone = phone;
                    Address = address;
                    BirthDate = birthDate;
                }
            }
        }

Листинг 2 - Класс "Дизайнер"

     using System;

     namespace ZiminaLear.Domain
     {
         public class Designer
         {
             public int Id { get; set; }
             public string Name { get; set; }
             public string Phone { get; set; }
             public string Pay { get; set; }

             public Designer() {}

             public Designer(int desId, string name, string phone, string pay)
             {
                 Id = desId;
                 Name = name;
                 Phone = phone;
                 Pay = pay;
             }
         }
         }
Аналогичным образом создаём все классы (см.рисунок 5).

![image](https://user-images.githubusercontent.com/91217659/147104412-7556dfb1-effa-46c7-9d7c-005447622f35.png)

<p align="center">Рисунок 5 - Список созданных классов

Затем для каждой сущности создаём хранилище (см. рисунок 6).

![image](https://user-images.githubusercontent.com/91217659/147105783-0418a28b-3624-4764-8f2c-fe370aa789e0.png)

<p align="center">Рисунок 6 - Все хранилища

На примере рассмотрим хранилище класса "Дизайнер".

Листинг 3 - Хранилище класса "Дизайнер"

       using System;
       using System.Collections.Generic;
       using ZiminaLear.Domain;

       namespace ZiminaLear.Repository
       {
           public class DesignerStorage
           {
               private Dictionary<int, Designer> Designers = new();

               public Designer Create(Designer designer)
               {
                   Designers.Add(designer.Id, designer);
                   return Designers[designer.Id];
               }
               public Designer Read(int designerId)
               {
                   return Designers[designerId];
               }

               public Designer Update(int designerId, Designer newDesigner)
               {
                   Designers[designerId] = newDesigner;
                   return Designers[designerId];
               }


               public bool Delete(int designerId)
               {
                   return Designers.Remove(designerId);
               }

           }

       }


Следующим шагом создаём общее хранилище.

Листинг 4 - Общее хранилище

            namespace ZiminaLear.Repository
           {
             public static class Storage
             {
                 public static readonly CustomerStorage customerStorage = new();
                 public static readonly PayStorage payStorage = new();
                  public static readonly AcquiredProjectStorage acquiredProjectStorage = new();
                  public static readonly BilledaccountStorage billedaccountStorage = new();
                 public static readonly DesignerStorage designerStorage = new();
                 public static readonly WorkerStorage workerStorage = new();
                 public static readonly ProjectStorage projectStorage = new();
                 public static readonly ForemanStorage foremanStorage = new();
                 public static readonly PlanOfWorkStorage planOfWorkStorage = new();

             }
         }
         

Далее разрабатываются web-методы, включающие базовые операции CRUD[3] для каждой из сущностей, отображающих предметную область. Рассмотрим в качестве примера контроллер для класса Designer. 

Листинг 5 - Контроллер класса "Дизайнер"

     using System;
     using System.Collections.Generic;
     using System.Linq;
     using System.Threading.Tasks;
     using Microsoft.AspNetCore.Mvc;
     using Microsoft.Extensions.Logging;
     using ZiminaLear.Domain;
     using ZiminaLear.Repository;

     namespace ZiminaLear.Controllers
     {
         [ApiController]
         [Route("[controller]")]
         public class DesignerController : ControllerBase
         {    
             [HttpPut]
             public Designer Create(Designer designer)
             {
                 return Storage.designerStorage.Create(designer);
             }    
             [HttpGet]
             public Designer Read(int designerId)
             {
                 return Storage.designerStorage.Read(designerId);
             }

             [HttpPut]
             public Designer Update(int designerId, Designer newDesigner)
             {
                 return Storage.designerStorage.Update(designerId, newDesigner);
             }

             [HttpDelete]
             public bool Delete(int designerId)
             {
                 return Storage.designerStorage.Delete(designerId);
             }
         }
     }


Аналогичным образом создаем контроллеры для каждой из сущностей (см.рисунок 7).

![image](https://user-images.githubusercontent.com/91217659/147105372-2bb4d9b5-f8a0-4843-b306-d8a631ec9779.png)

<p align="center">Рисунок 7 - Список контроллеров для всех сущностей


<a name="realization"/>

### 4 Проверка и тестирование системы
 После запуска проекта автоматически открывается страница Swagger UI со списком сущностей и операций над ними (см.рисунок 8).
 
![image](https://user-images.githubusercontent.com/91217659/147130171-2206d838-fef0-4fdf-9007-576d8218f465.png)

<p align="center">Рисунок 8 - Список сущностей 

Рассмотрим работу методов CRUD на примере сущности "Дизайнер".

1. Create позволяет добавить новые строки (см.рисунок 9 и рисунок 10).

![image](https://user-images.githubusercontent.com/91217659/147130613-ada5e368-d7ba-4550-80f7-783f2a2b95b9.png)

<p align="center">Рисунок 9 - Заполнение полей в методе Create 

![image](https://user-images.githubusercontent.com/91217659/147130685-40701bcb-3048-4a2f-abe5-3536dc39ac58.png)

<p align="center">Рисунок 10 - Результат выполнения в методе Create 

2. Read - функция чтения, позволяющая извлекать и считывать значения записей (см. рисунок 11 и рисунок 12).

![image](https://user-images.githubusercontent.com/91217659/147131031-e641e78a-a76f-4021-b6cb-6797d8b36ec1.png)

<p align="center">Рисунок 11 - Окно метода Create

![image](https://user-images.githubusercontent.com/91217659/147131084-2041dd56-59bf-4f94-af91-6a3f51cb3a6f.png)

<p align="center">Рисунок 12 - Результат выполнения метода Read

3. Update - функция, нужная для изменения существующих записей (см. рисунок 13 и рисунок 14).

![image](https://user-images.githubusercontent.com/91217659/147131292-5fd0f597-8f21-4e3a-8b7c-ca6771f465e1.png)

<p align="center">Рисунок 13 - Окно метода Update

![image](https://user-images.githubusercontent.com/91217659/147131351-1eeb531f-49c5-408f-8e50-e69a60b48bf0.png)

<p align="center">Рисунок 14 - Результат выполнения метода Update

4. Delete - функция, необходимая для удаления записей. Если операция удаления сработает успешно, то ответ сервера будет "true", иначе "false" (см.рисунок 15 и рисунок 16).

![image](https://user-images.githubusercontent.com/91217659/147131581-15715cd4-c618-495f-9bde-637e1904581f.png)


<p align="center">Рисунок 15 - Окно метода Delete

![image](https://user-images.githubusercontent.com/91217659/147131617-672588b5-da41-4146-bcef-1c60268a9b1c.png)

<p align="center">Рисунок 16 - Результат выполнения метода Delete

Проверим с помощью функции Read информацию о меню. Программа выдает ошибку, что означает, что информации о дизайнере по его Id была удалена и ее невозможно найти (см.рисунок 17).

![image](https://user-images.githubusercontent.com/91217659/147131749-25643ffc-163d-4c00-aff0-410a2eaf0ccb.png)

<p align="center">Рисунок 17 - проверка удаления через метод Read 

<a name="test"/>


## Заключение
 В данной работе разработана информационная система для организации работы отделочной компании. Для её созданя были определены все сущности данной предметной области, связи между ними, процессы обмена информацией, требования и задачи к системе. Информационная система выполняет функции создания, чтения, обновления и удаления записей. 
 По итогу мы смогли разработать и успешно протестировать систему, в будущем будем развивать этот проект с помощью привязки к базам данных, добавления новых функций и методов, а так же расширения возможности системы.
 
 
<a name="conclusion"/>

## Список использованных источников
1) https://otdelka62.ru
2) https://smp-utm.ru
3) https://en.wikipedia.org/wiki/Create,_read,_update_and_delete

<a name="source"/>
