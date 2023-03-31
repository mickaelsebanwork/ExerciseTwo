# Exercise 2

In order to remove the IF condition and optimize the followed code block, 
I a applied a Strategy Pattern design pattern that enables selecting an algorithm at runtime.

## Original Code

```c#
if (@event is EventA)
{
   var eventA = @event as EventA;
   eventA?.MyCustomMethodOnA();
}
else if (@event is EventB)
{
   var eventB = @event as EventB;
   eventB?.MyCustomMethodOnB();
}
if (@event is EventC)
{
   var eventC = @event as EventC;
   eventC?.MyCustomMethodOnC();
}
```
