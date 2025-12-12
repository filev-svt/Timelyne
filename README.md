# Timelyne
Timelyne is a lightweight and capable task management application. A pragmatic tool for the ones that are doing the work. 


# The main entities

## User
User can own many projects.
User can watch many projects via an invite.

## Project
Project has many tasks.
Project has many statuses - three pre-defined, "To do", "In progress", "Done".

Projects can have hourly rates, which can then be used for generating an Invoice from the Time entries of the Projects' Tasks.

## Task status
Task status belongs to a project.

Task statuses are pre-defined on project creation, but can be customized.

## Task status transitions
Task status transitions belong to a project

Task status transitions are pre-defined on project creation, but can be customized

## Task
A Task has many time entries.
A Task has many comments.
A Task has many subtasks.
 
A Task always belongs to a Project.

A Task can have a time estimate.
Tasks can be ordered.

The Task is the main unit of work. It can optionally be made out of a "todo list" of subtasks, but these are very simple, small units.

## Subtask
Subtask always belongs to a Task.

Subtask is more or less a "todo item" for a more complex task and is completely optional.

## Time entry
Time entries belong to a task. A timer component can trigger time entry tracking, and can then be submitted to create the Time entry. The Time entry can also be created manually via a form.

## Comment
Comments contain fruitful discussions about a task.

## Invoice

