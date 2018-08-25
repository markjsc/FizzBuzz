# FizzBuzz [![Build Status](https://travis-ci.org/markjsc/FizzBuzz.svg?branch=master)](https://travis-ci.org/markjsc/FizzBuzz)

## Purpose

The classic [Fizz Buzz](https://en.wikipedia.org/wiki/Fizz_buzz) problem is described as:

>Fizz buzz is a group word game for children to teach them about division. Players take turns to count incrementally, replacing any number divisible by three with the word "fizz", and any number divisible by five with the word "buzz".

This project was created as part of a technical interview. I was asked to build a classic Fizz Buzz problem with a few twists.

Additionally, I was asked to create an extended example that allows the consume to pass in any desired words and count values instead of Fizz (3) and Buzz (5).

I added a Better Fizz Buzzer that uses Enumerable.Range() to avoid iterating with a `for` loop.

I created a console app as the host and added unit tests and a CI build.

## Architecture Note

I opted to use an extremely simple design - all static classes. This was an intentional choice due to the simplicity of the requirements, specifically not having the need to use state or to dispose of instances.

If the needs had been more complex then different design choices would have definitely been considered.

## Getting Started

To run the Fizz Buzz Console app:

1. Open the FizzBuzz solution in Visual Studio (I used Visual Studio Community 2017 - 15.7.6).
1. Set FizzBuzz.App as the startup project.
1. Press F5 to run.
1. Select the desired option or press ESCAPE to exit.


To run the Unit Tests:

1. Open the FizzBuzz solution in Visual Studio (I used Visual Studio Community 2017 - 15.7.6).
1. Build the solution, which should trigger restoring NuGet packages (several are related to NUnit, the test engine used here).
3. Open the Test Explorer panel.
4. Click "Run All" to run all tests.

## CI Build

This uses [Travis-CI](https://travis-ci.org) for the [CI build](https://travis-ci.org/markjsc/FizzBuzz). It basically builds the solution and runs the tests. If I had plans to deploy this, I would also package it (NuGet pack) and push it (likely with Octo.exe).
