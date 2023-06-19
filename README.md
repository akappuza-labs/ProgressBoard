# ProgressBoard
Enterprise organization system

==========================================English=============================================

Develop an enterprise organization system.

Business requirements:

1) Project management: the system should provide the ability to create and manage projects, including planning, task assignment, resource management, and progress tracking.
2) Task management: the system should provide the ability to create and manage tasks, including assigning responsible persons, setting deadlines, and tracking task status.
3) Document management: the system should provide the ability to manage documents, including uploading, storing, and searching for documents.
4) Reporting management: the system should provide the ability to create and manage reports, including project progress reports, budget reports, resource reports, and other reports necessary for decision-making in the enterprise.

The service should include three types of users:
1) Enterprise manager
	- ability to appoint department managers
	- ability to assign department tasks
	- ability to track the progress of the enterprise as a whole, the progress of each department in the assigned task, and the progress of each employee in the department
	- access to all possible reports and presentations
	- access to statistics for each employee
2) Department manager
	- ability to appoint department employees
	- ability to assign tasks to department employees
	- ability to track the progress of each department in the assigned task, and the progress of each employee in the department
	- access to reports and presentations of department employees
	- access to statistics for each employee in the department
3) Department employee
	- ability to mark their own progress in assigned tasks
	- ability to attach various documents to assigned tasks
	- access to their own statistics

Technical requirements:

 - Security: the system should provide data security and access to the system, including user authentication and authorization, and data encryption.
 - Scalability: the system should be scalable and ready to increase the number of users and data volume.
 - Reliability: the system should be reliable and ready to work 24/7.
 - Integration: the system should be ready for integration with other systems and services, such as email, calendar, and other applications.
 - User interface: the system should have a convenient and intuitive user interface that allows users to easily find the information they need and perform tasks.
 - Performance: the system should be fast and efficient, providing fast access to data and task execution.
 - Testing: the system should undergo thorough testing before release, including functional testing and performance testing.

Technology stack:

.NET v6 platform
Programming language: C# v10
Web application framework: ASP.NET Core 6
Frontend: React
Version control system: Git
Integration: RESTful API

==========================================Russian=============================================

Разработать систему организации предприятия.

Бизнес требования:

1) Управление проектами: система должна предоставлять возможность создания и управления проектами, включая планирование, назначение задач, управление ресурсами и отслеживание прогресса.
2) Управление задачами: система должна обеспечивать возможность создания и управления задачами, включая назначение ответственных лиц, установку сроков выполнения и отслеживание статуса задач. 
3) Управление документами: система должна предоставлять возможность управления документами, включая загрузку, хранение и поиск документов. 
4) Управление отчетностью: система должна предоставлять возможность создания и управления отчетами, включая отчеты о прогрессе проектов, отчеты о бюджете, отчеты о ресурсах и другие отчеты, необходимые для принятия решений на предприятии.

Сервис должен включать три типа пользователей: 
1) Руководитель предприятия 
	- возможность назначать Руководителей отделла 
	- возможность постановки задач отдела
	- возможность отслеживать прогресс предприятия в целом, прогресс каждого отдела в поставленной перед перед ним задачей, прогресс каждого сотрудника отдела
	- доступ ко всем возможным отчетам, докладам
	- доступ к статистике каждого сотрудника
2) Руководитель отдела
	- возможность назначать Сотрудников отдела
	- возможность постановки задач перед Сотрудниками отдела
	- возможность отслеживать прогресс каждого отдела в поставленной перед перед ним задачей, прогресс каждого сотрудника отдела
	- доступ к отчетам и докладам Сотрудников отдела
	- доступ к статистике каждого Сотрудника отдела
3) Сотрудник отдела
	- возможность отметки собственного прогресса в поставленных перед ним задачах
	- возможность прикрепления различных документов к поставленным перед ним задачам
	- доступ к собственной статистике

Технические требования:

  - Безопасность: система должна обеспечивать безопасность данных и доступа к системе, включая аутентификацию и авторизацию пользователей, шифрование данных.
  - Масштабируемость: система должна быть масштабируемой и готовой к увеличению количества пользователей и объема данных.
  - Надежность: система должна быть надежной и готовой к работе 24/7.
  - Интеграция: система должна быть готовой к интеграции с другими системами и сервисами, такими как электронная почта, календарь и другие приложения.
  - Пользовательский интерфейс: система должна иметь удобный и интуитивно понятный пользовательский интерфейс, который позволит пользователям легко находить нужную информацию и выполнять задачи.
  - Производительность: система должна быть быстрой и эффективной, чтобы обеспечивать быстрый доступ к данным и выполнение задач.
  - Тестирование: система должна проходить тщательное тестирование перед выпуском, включая функциональное тестирование, тестирование производительности.

Стек технологий:

Платформа .NET v6
Язык программирования: C# v10
Фреймворк для веб-приложений: ASP.NET Core 6
Фронтэнд React
Система контроля версий: Git
Интеграция: RESTful API
