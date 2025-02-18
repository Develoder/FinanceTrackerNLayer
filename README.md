# О проекте
Проект построен по принципам N-Layer архитектуры, где каждая часть системы отвечает за свою зону ответственности. Такой подход обеспечивает четкое разделение функциональности, упрощает масштабирование, сопровождение и тестирование приложения.

# Технологии
- .NET 8
- Windows Form App
- Entity Framework Core (PostgreSQL)
- XUnit
- Moq (Mock)
- ScottPlot WinForms (Отображение графиков)
- EF Core Power Tools (Маппер данных)

# Зависимости между проектами

![DBP UI](https://github.com/user-attachments/assets/ed56904e-5204-4b65-a780-091ef7a72e89)

# Описание проектов

FinanceTracker.DAL - слой работы с данными. Главным звеном является паттерн репозиторий, который создает интрефейс для работы с данными. Надстройкой для некоторых операция в одном контексте служит паттерн UnitOfWork. Он объеденяет репозитории для работы в одном контексте. Для работой с БД PostgreSQL используется ORM Entity Framework Core.

MyExtension - слой хранения классов расширений.

FinanceTracker.Domain - слой бизнес-логики. Хранит множество сервисов для работы с данными.

FinanceTracker.Test - слой XUnit тестов. Тестирование бизнес логики используется репозиторий для Mock, который позволяет не обращаться данным в БД, а работать с предустановленными значениями для этого теста. Автоматическое создание моков используется Fixture.

FinanceTracker.Service - слой сервисов для некоторой работы у клиента.

FinanceTracker.UI - слой представление. Ключевым подходом проектирования стал паттерн MVP, для выделения логики от преобразования данных для интерфейса. Подход к дизайну однооконного приложения помогало выделение в UserControl. Смена основного содержания формы MainForm отвечают WindowPanel, а после успешной авторизации работа происходит в главном меню, где по кнопкам навигации сменяется его контейнер на контролы-страницы.

# Структура БД

![Структура БД (Малый)](https://github.com/user-attachments/assets/6fe84a7f-eca5-4ec8-aa75-94ee7f2499d8)

# Finance Tracker - ваш личный учет финансов

Этот проект представляет собой приложение для учета личных финансов. Приложение позволяет пользователям вести учет своих доходов и расходов, анализировать свои финансовые данные и планировать бюджет.

## Основные возможности

- Регистрация новых пользователей и аутентификация
- Управление банковскими счетами и кредитными картами
- Добавление транзакций с указанием категории, суммы и даты
- Просмотр статистики и графиков по категориям расходов и доходов
- Поддержка различных методов оплаты и категорий транзакций

## Скриншоты

Вход

![Вход (Малый)](https://github.com/user-attachments/assets/b2231c29-de4a-42de-81b9-3a8ed0b57722)

Регистрация

![Регистрация (Малый)](https://github.com/user-attachments/assets/c2253020-7405-4982-be50-b6b782c10f51)

Счета

![Счета (Малый)](https://github.com/user-attachments/assets/a5cdf8e7-211f-41fd-8cb6-fa74cced2eb9)

Транзакции

![Транзакции (Малый)](https://github.com/user-attachments/assets/5a485659-654a-4e44-8e78-6716b0b3bc72)

Редактирование транзакций

![Редактирование транзакции (Малый)](https://github.com/user-attachments/assets/9678c114-a063-4d9e-b825-8c2ee92d2353)

Отчет транзакций за период

![Отчет транзакций (Малый)](https://github.com/user-attachments/assets/e9fad57a-fedb-499b-9789-3d5e9505e126)

Отчет расходов по категориям

![Отчет по категориям (Малый)](https://github.com/user-attachments/assets/c6784d45-720a-4f9e-8e3b-d2ddea9e2953)

## Авторы

- Develoder (Yuri Kaygorodtsev) - Разработчик
