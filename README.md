# Обучение C# Backend

Учебный репозиторий для трехмесячного входа в backend-разработку на C#/.NET с полного нуля.

## Как Мы Учимся

Главное правило: брат не просто смотрит уроки, а каждую неделю делает маленькие работающие программы.

Рабочий цикл:

1. Получить задание в GitHub issue или в папке `assignments`.
2. Создать ветку под задание.
3. Сделать работу маленькими коммитами.
4. Открыть pull request.
5. Ответить на вопросы в PR.
6. Исправить замечания после ревью.
7. Обновить `PROGRESS.md` в конце недели.

## Git Workflow

Для каждого задания:

```powershell
git checkout main
git pull
git checkout -b hw/01-hello-profile
```

После изменений:

```powershell
git status
git add .
git commit -m "Create console project"
git push -u origin hw/01-hello-profile
```

Потом открыть pull request в GitHub.

## Структура

```text
README.md
ROADMAP.md
PROGRESS.md
REVIEW_GUIDE.md
assignments/
  README.md
  01-csharp-foundations/
    01-hello-profile/
      README.md
      ISSUE.md
    02-simple-calculator/
      README.md
      ISSUE.md
    03-number-guessing-game/
      README.md
      ISSUE.md
    04-contact-list/
      README.md
      ISSUE.md
  02-tools-and-debugging/
    README.md
  03-http-and-api/
    README.md
  04-sql-postgresql/
    README.md
  05-ef-core-postgresql/
    README.md
  06-tests-quality/
    README.md
  07-docker-production/
    README.md
projects/
  todo-api/
  study-planner-api/
```

`ROADMAP.md` описывает весь учебный путь. `assignments` повторяет модули из roadmap и хранит маленькие домашки. `projects` хранит большие проекты, которые могут расти через несколько модулей.

## Текущий Статус

Начать с задания:

```text
assignments/01-csharp-foundations/01-hello-profile
```

Следующее задание после принятия первого:

```text
assignments/01-csharp-foundations/02-simple-calculator
```

Ближайший буфер:

```text
assignments/01-csharp-foundations/03-number-guessing-game
assignments/01-csharp-foundations/04-contact-list
```
