# ProgressBoard
Enterprise organization system

==========================================English=============================================

Develop a project management system.

Business requirements:

1) Project management: the system should provide the ability to create and manage projects, including planning, task and subtask assignment, and progress tracking.
2) Task management: the system should provide the ability to create and manage tasks, including assigning responsible persons, setting deadlines, and tracking task status.
3) Document management: the system should provide the ability to manage documents, including uploading, storing, and searching for project-related documents.
4) The system should provide data security and access control, including user authentication and authorization.

The service should include three types of users:
1) Project manager
	- ability to assign managers
	- ability to assign project tasks
	- ability to track project progress overall, progress of each task and subtask
	- access to all possible forms of reporting
	- access to each employee's statistics
2) Manager
	- ability to assign task performers
	- ability to assign tasks to performers
	- ability to track each task relating to the manager and all subtasks
	- access to reports and presentations related to their tasks
	- access to each task performer's statistics
3) Task performer
	- ability to mark their own progress in assigned subtasks
	- ability to attach various documents to assigned subtasks
	- access to their own statistics

Technology stack:
	- .NET v6 platform
	- Programming language: C# v10
	- Framework for web applications: ASP.NET Core 6
	- Frontend: React

==========================================Russian=============================================

Разработать систему организации прооктов.

Бизнес требования:

1) Управление проектами: система должна предоставлять возможность создания и управления проектами, включая планирование, назначение задач и подзадач, отслеживание прогресса.
2) Управление задачами: система должна обеспечивать возможность создания и управления задачами, включая назначение ответственных лиц, установку сроков выполнения и отслеживание статуса задач. 
3) Управление документами: система должна предоставлять возможность управления документами, включая загрузку, хранение и поиск документов, относящихся к проекту.
4) Система должна обеспечивать безопасность данных и доступа к системе, включая аутентификацию и авторизацию пользователей.

Сервис должен включать три типа пользователей: 
1) Руководитель проекта
	- возможность назначать Менеджеров
	- возможность постановки задач проекта
	- возможность отслеживать прогресс проекта в целом, прогресс каждой задачи и подзадачи
	- доступ ко всем возможным формам отчетности
	- доступ к статистике каждого сотрудника
2) Менеджер
	- возможность назначать Исполнителя задач
	- возможность постановки задач перед исполнителями
	- возможность отслеживать каждой задачи, относящихся к менеджеру и всех подзадач
	- доступ к отчетам и докладам, относящихся к нему задч
	- доступ к статистике каждого Исполнителя задач
3) Исполнитель задач
	- возможность отметки собственного прогресса в поставленных перед ним подзадачах
	- возможность прикрепления различных документов к поставленным перед ним подзадачам
	- доступ к собственной статистике


Стек технологий:
	- Платформа .NET v6
	- Язык программирования: C# v10
	- Фреймворк для веб-приложений: ASP.NET Core 6
	- Фронтэнд React
