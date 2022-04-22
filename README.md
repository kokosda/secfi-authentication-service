At Secfi we use a microservices architecture. Imagine we want to rebuild our authentication service,
and we ask you to do it. The assignment doesn’t have a hard time limit but we also don’t want to take
too much of your time, so try to spend a maximum of 4/5 hours on it.

## Users should have the following attributes: 
* username
* first name
* last name
* password.

## The API should allow the following operations:
* create
* login
* update
* remove (self-removal).

The proposed implementation scope doesn't require any privileged roles and operations (e.g.
removing other users), but you are welcome to define and add them.

## Requirements
* The microservice should be written in Python, TypeScript, Java, Kotlin or Scala.
* There should be tests.
* Passwords should be stored in encrypted format.
* Make sure to implement the necessary authorization controls (users can update/remove/etc
only themselves).
* Besides that you're free to choose any framework or library you need, although you should be
prepared to defend your choices.

## Evaluation
After you finish the assignment, we ask you to answer the following questions:
* How much time did you end up spending on it?
* What are some of the design decisions you made?
* What do you like about your implementation?
* What would you improve next time?
* What things are missing to make it production-ready?
