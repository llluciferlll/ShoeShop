-- База данных ООО «Обувь» (PostgreSQL). Создать пустую БД shoes и выполнить этот скрипт.

create table role (
    id serial primary key,
    name varchar(50) not null unique
);

create table users (
    id serial primary key,
    role_id int not null references role(id),
    full_name varchar(150) not null,
    login varchar(100) not null unique,
    password varchar(50) not null
);

create table category (
    id serial primary key,
    name varchar(100) not null unique
);

create table manufacturer (
    id serial primary key,
    name varchar(100) not null unique
);

create table supplier (
    id serial primary key,
    name varchar(100) not null unique
);

create table product (
    id serial primary key,
    article varchar(20) not null unique,
    name varchar(100) not null,
    unit varchar(20) not null,
    price numeric(10, 2) not null check (price >= 0),
    supplier_id int not null references supplier(id),
    manufacturer_id int not null references manufacturer(id),
    category_id int not null references category(id),
    discount int not null default 0 check (discount between 0 and 100),
    quantity int not null default 0 check (quantity >= 0),
    description text,
    photo varchar(255)
);

create table pickup_point (
    id serial primary key,
    address varchar(255) not null
);

create table orders (
    id serial primary key,
    order_date date not null,
    delivery_date date,
    point_id int not null references pickup_point(id),
    user_id int references users(id),
    code int,
    status varchar(30) not null
);

create table order_item (
    order_id int not null references orders(id),
    product_id int not null references product(id),
    quantity int not null check (quantity > 0),
    primary key (order_id, product_id)
);

insert into role (name) values ('Администратор'), ('Менеджер'), ('Авторизированный клиент');
insert into category (name) values ('Женская обувь'), ('Мужская обувь');
insert into manufacturer (name) values ('Kari'), ('Marco Tozzi'), ('Рос'), ('Rieker'), ('Alessio Nesca'), ('CROSBY');
insert into supplier (name) values ('Kari'), ('Обувь для вас');

insert into users (role_id, full_name, login, password) values
((select id from role where name = 'Администратор'), 'Никифорова Весения Николаевна', '94d5ous@gmail.com', 'uzWC67'),
((select id from role where name = 'Администратор'), 'Сазонов Руслан Германович', 'uth4iz@mail.com', '2L6KZG'),
((select id from role where name = 'Администратор'), 'Одинцов Серафим Артёмович', 'yzls62@outlook.com', 'JlFRCZ'),
((select id from role where name = 'Менеджер'), 'Степанов Михаил Артёмович', '1diph5e@tutanota.com', '8ntwUp'),
((select id from role where name = 'Менеджер'), 'Ворсин Петр Евгеньевич', 'tjde7c@yahoo.com', 'YOyhfR'),
((select id from role where name = 'Менеджер'), 'Старикова Елена Павловна', 'wpmrc3do@tutanota.com', 'RSbvHv'),
((select id from role where name = 'Авторизированный клиент'), 'Михайлюк Анна Вячеславовна', '5d4zbu@tutanota.com', 'rwVDh9'),
((select id from role where name = 'Авторизированный клиент'), 'Ситдикова Елена Анатольевна', 'ptec8ym@yahoo.com', 'LdNyos'),
((select id from role where name = 'Авторизированный клиент'), 'Ворсин Петр Евгеньевич', '1qz4kw@mail.com', 'gynQMT'),
((select id from role where name = 'Авторизированный клиент'), 'Старикова Елена Павловна', '4np6se@mail.com', 'AtnDjr');

insert into product (article, name, unit, price, supplier_id, manufacturer_id, category_id, discount, quantity, description, photo) values
('А112Т4', 'Ботинки', 'шт.', 4990, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Kari'), (select id from category where name = 'Женская обувь'), 3, 6, 'Женские Ботинки демисезонные kari', '1.jpg'),
('F635R4', 'Ботинки', 'шт.', 3244, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'Marco Tozzi'), (select id from category where name = 'Женская обувь'), 2, 13, 'Ботинки Marco Tozzi женские демисезонные, размер 39, цвет бежевый', '2.jpg'),
('H782T5', 'Туфли', 'шт.', 4499, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Kari'), (select id from category where name = 'Мужская обувь'), 4, 5, 'Туфли kari мужские классика MYZ21AW-450A, размер 43, цвет: черный', '3.jpg'),
('G783F5', 'Ботинки', 'шт.', 5900, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Рос'), (select id from category where name = 'Мужская обувь'), 2, 8, 'Мужские ботинки Рос-Обувь кожаные с натуральным мехом', '4.jpg'),
('J384T6', 'Ботинки', 'шт.', 3800, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'Rieker'), (select id from category where name = 'Мужская обувь'), 2, 16, 'B3430/14 Полуботинки мужские Rieker', '5.jpg'),
('D572U8', 'Кроссовки', 'шт.', 4100, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'Рос'), (select id from category where name = 'Мужская обувь'), 3, 6, '129615-4 Кроссовки мужские', '6.jpg'),
('F572H7', 'Туфли', 'шт.', 2700, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Marco Tozzi'), (select id from category where name = 'Женская обувь'), 2, 14, 'Туфли Marco Tozzi женские летние, размер 39, цвет черный', '7.jpg'),
('D329H3', 'Полуботинки', 'шт.', 1890, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'Alessio Nesca'), (select id from category where name = 'Женская обувь'), 4, 4, 'Полуботинки Alessio Nesca женские 3-30797-47, размер 37, цвет: бордовый', '8.jpg'),
('B320R5', 'Туфли', 'шт.', 4300, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Rieker'), (select id from category where name = 'Женская обувь'), 2, 6, 'Туфли Rieker женские демисезонные, размер 41, цвет коричневый', '9.jpg'),
('G432E4', 'Туфли', 'шт.', 2800, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Kari'), (select id from category where name = 'Женская обувь'), 3, 15, 'Туфли kari женские TR-YR-413017, размер 37, цвет: черный', '10.jpg'),
('S213E3', 'Полуботинки', 'шт.', 2156, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'CROSBY'), (select id from category where name = 'Мужская обувь'), 3, 6, '407700/01-01 Полуботинки мужские CROSBY', ''),
('E482R4', 'Полуботинки', 'шт.', 1800, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Kari'), (select id from category where name = 'Женская обувь'), 2, 14, 'Полуботинки kari женские MYZ20S-149, размер 41, цвет: черный', ''),
('S634B5', 'Кеды', 'шт.', 5500, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'CROSBY'), (select id from category where name = 'Мужская обувь'), 3, 0, 'Кеды Caprice мужские демисезонные, размер 42, цвет черный', ''),
('K345R4', 'Полуботинки', 'шт.', 2100, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'CROSBY'), (select id from category where name = 'Мужская обувь'), 2, 3, '407700/01-02 Полуботинки мужские CROSBY', ''),
('O754F4', 'Туфли', 'шт.', 5400, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'Rieker'), (select id from category where name = 'Женская обувь'), 4, 18, 'Туфли женские демисезонные Rieker артикул 55073-68/37', ''),
('G531F4', 'Ботинки', 'шт.', 6600, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Kari'), (select id from category where name = 'Женская обувь'), 12, 9, 'Ботинки женские зимние ROMER арт. 893167-01 Черный', ''),
('J542F5', 'Тапочки', 'шт.', 500, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Kari'), (select id from category where name = 'Мужская обувь'), 13, 0, 'Тапочки мужские Арт.70701-55-67син р.41', ''),
('B431R5', 'Ботинки', 'шт.', 2700, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'Rieker'), (select id from category where name = 'Мужская обувь'), 2, 5, 'Мужские кожаные ботинки/мужские ботинки', ''),
('P764G4', 'Туфли', 'шт.', 6800, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'CROSBY'), (select id from category where name = 'Женская обувь'), 15, 15, 'Туфли женские, ARGO, размер 38', ''),
('C436G5', 'Ботинки', 'шт.', 10200, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Alessio Nesca'), (select id from category where name = 'Женская обувь'), 15, 9, 'Ботинки женские, ARGO, размер 40', ''),
('F427R5', 'Ботинки', 'шт.', 11800, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'Rieker'), (select id from category where name = 'Женская обувь'), 15, 11, 'Ботинки на молнии с декоративной пряжкой FRAU', ''),
('N457T5', 'Полуботинки', 'шт.', 4600, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'CROSBY'), (select id from category where name = 'Женская обувь'), 3, 13, 'Полуботинки Ботинки черные зимние, мех', ''),
('D364R4', 'Туфли', 'шт.', 12400, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Kari'), (select id from category where name = 'Женская обувь'), 16, 5, 'Туфли Luiza Belly женские Kate-lazo черные из натуральной замши', ''),
('S326R5', 'Тапочки', 'шт.', 9900, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'CROSBY'), (select id from category where name = 'Мужская обувь'), 17, 15, 'Мужские кожаные тапочки "Профиль С.Дали"', ''),
('L754R4', 'Полуботинки', 'шт.', 1700, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Kari'), (select id from category where name = 'Женская обувь'), 2, 7, 'Полуботинки kari женские WB2020SS-26, размер 38, цвет: черный', ''),
('M542T5', 'Кроссовки', 'шт.', 2800, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'Rieker'), (select id from category where name = 'Мужская обувь'), 18, 3, 'Кроссовки мужские TOFA', ''),
('D268G5', 'Туфли', 'шт.', 4399, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'Rieker'), (select id from category where name = 'Женская обувь'), 3, 12, 'Туфли Rieker женские демисезонные, размер 36, цвет коричневый', ''),
('T324F5', 'Сапоги', 'шт.', 4699, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'CROSBY'), (select id from category where name = 'Женская обувь'), 2, 5, 'Сапоги замша Цвет: синий', ''),
('K358H6', 'Тапочки', 'шт.', 599, (select id from supplier where name = 'Kari'), (select id from manufacturer where name = 'Rieker'), (select id from category where name = 'Мужская обувь'), 20, 2, 'Тапочки мужские син р.41', ''),
('H535R5', 'Ботинки', 'шт.', 2300, (select id from supplier where name = 'Обувь для вас'), (select id from manufacturer where name = 'Rieker'), (select id from category where name = 'Женская обувь'), 2, 7, 'Женские Ботинки демисезонные', '');

insert into pickup_point (address) values
('420151, г. Лесной, ул. Вишневая, 32'),
('125061, г. Лесной, ул. Подгорная, 8'),
('630370, г. Лесной, ул. Шоссейная, 24'),
('400562, г. Лесной, ул. Зеленая, 32'),
('614510, г. Лесной, ул. Маяковского, 47'),
('410542, г. Лесной, ул. Светлая, 46'),
('620839, г. Лесной, ул. Цветочная, 8'),
('443890, г. Лесной, ул. Коммунистическая, 1'),
('603379, г. Лесной, ул. Спортивная, 46'),
('603721, г. Лесной, ул. Гоголя, 41'),
('410172, г. Лесной, ул. Северная, 13'),
('614611, г. Лесной, ул. Молодежная, 50'),
('454311, г.Лесной, ул. Новая, 19'),
('660007, г.Лесной, ул. Октябрьская, 19'),
('603036, г. Лесной, ул. Садовая, 4'),
('394060, г.Лесной, ул. Фрунзе, 43'),
('410661, г. Лесной, ул. Школьная, 50'),
('625590, г. Лесной, ул. Коммунистическая, 20'),
('625683, г. Лесной, ул. 8 Марта'),
('450983, г.Лесной, ул. Комсомольская, 26'),
('394782, г. Лесной, ул. Чехова, 3'),
('603002, г. Лесной, ул. Дзержинского, 28'),
('450558, г. Лесной, ул. Набережная, 30'),
('344288, г. Лесной, ул. Чехова, 1'),
('614164, г.Лесной,  ул. Степная, 30'),
('394242, г. Лесной, ул. Коммунистическая, 43'),
('660540, г. Лесной, ул. Солнечная, 25'),
('125837, г. Лесной, ул. Шоссейная, 40'),
('125703, г. Лесной, ул. Партизанская, 49'),
('625283, г. Лесной, ул. Победы, 46'),
('614753, г. Лесной, ул. Полевая, 35'),
('426030, г. Лесной, ул. Маяковского, 44'),
('450375, г. Лесной ул. Клубная, 44'),
('625560, г. Лесной, ул. Некрасова, 12'),
('630201, г. Лесной, ул. Комсомольская, 17'),
('190949, г. Лесной, ул. Мичурина, 26');

-- В Excel у заказа 7 указана несуществующая дата 30.02.2025, заменена на 28.02.2025
insert into orders (order_date, delivery_date, point_id, user_id, code, status) values
('2025-02-27', '2025-04-20', 1, (select min(id) from users where full_name = 'Степанов Михаил Артёмович'), 901, 'Завершен'),
('2022-09-28', '2025-04-21', 11, (select min(id) from users where full_name = 'Никифорова Весения Николаевна'), 902, 'Завершен'),
('2025-03-21', '2025-04-22', 2, (select min(id) from users where full_name = 'Сазонов Руслан Германович'), 903, 'Завершен'),
('2025-02-20', '2025-04-23', 11, (select min(id) from users where full_name = 'Одинцов Серафим Артёмович'), 904, 'Завершен'),
('2025-03-17', '2025-04-24', 2, (select min(id) from users where full_name = 'Степанов Михаил Артёмович'), 905, 'Завершен'),
('2025-03-01', '2025-04-25', 15, (select min(id) from users where full_name = 'Никифорова Весения Николаевна'), 906, 'Завершен'),
('2025-02-28', '2025-04-26', 3, (select min(id) from users where full_name = 'Сазонов Руслан Германович'), 907, 'Завершен'),
('2025-03-31', '2025-04-27', 19, (select min(id) from users where full_name = 'Одинцов Серафим Артёмович'), 908, 'Новый'),
('2025-04-02', '2025-04-28', 5, (select min(id) from users where full_name = 'Степанов Михаил Артёмович'), 909, 'Новый'),
('2025-04-03', '2025-04-29', 19, (select min(id) from users where full_name = 'Степанов Михаил Артёмович'), 910, 'Новый');

insert into order_item (order_id, product_id, quantity) values
(1, (select id from product where article = 'А112Т4'), 2),
(1, (select id from product where article = 'F635R4'), 2),
(2, (select id from product where article = 'H782T5'), 1),
(2, (select id from product where article = 'G783F5'), 1),
(3, (select id from product where article = 'J384T6'), 10),
(3, (select id from product where article = 'D572U8'), 10),
(4, (select id from product where article = 'F572H7'), 5),
(4, (select id from product where article = 'D329H3'), 4),
(5, (select id from product where article = 'А112Т4'), 2),
(5, (select id from product where article = 'F635R4'), 2),
(6, (select id from product where article = 'H782T5'), 1),
(6, (select id from product where article = 'G783F5'), 1),
(7, (select id from product where article = 'J384T6'), 10),
(7, (select id from product where article = 'D572U8'), 10),
(8, (select id from product where article = 'F572H7'), 5),
(8, (select id from product where article = 'D329H3'), 4),
(9, (select id from product where article = 'B320R5'), 5),
(9, (select id from product where article = 'G432E4'), 1),
(10, (select id from product where article = 'S213E3'), 5),
(10, (select id from product where article = 'E482R4'), 5);
