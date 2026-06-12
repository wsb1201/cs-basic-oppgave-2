# Greeting Console App

This program asks the user for their name and prints a time-aware greeting in Norwegian.

## Program Flowchart

![Diagram](./Diagram.svg)

## Pseudocode

```
userName = Console.ReadLine()

timeGreeting =
	if isWeekend: "God helg"
	elif Hour == 05..09: "God morgen"
	elif Hour == 09..12: "God formiddag"
	elif Hour == 12..18: "God ettermiddag"
	else: "God kveld"

if userName == null:
    Console.WriteLine(timeGreeting);
else:
    Console.WriteLine(timeGreeting, userName");

```
