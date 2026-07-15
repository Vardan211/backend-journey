# HW10: File Notes App

## Goal

Build a console notes app that saves notes to `notes.txt` and can read them after restart.

## Acceptance Criteria

- [ ] Runs with `dotnet run`
- [ ] Shows the menu until the user chooses `0`
- [ ] Adds a note
- [ ] Saves notes to `notes.txt`
- [ ] Handles empty note
- [ ] Lists all notes
- [ ] Handles missing `notes.txt` without crashing
- [ ] Searches notes by word
- [ ] Shows a clear message when search finds nothing
- [ ] Handles unknown menu command
- [ ] Has at least 2 actions extracted into methods
- [ ] Has at least 3 small commits
- [ ] PR includes reflection answers

## Reflection Questions

1. Why do values in `List<T>` disappear after the program exits?
2. Why should you check `File.Exists` before reading a file?
3. Which methods did you extract and why?
4. What happens if the app starts before `notes.txt` exists?
5. Which file-related line is least clear?

## Branch

Use:

```text
hw/10-file-notes-app
```
