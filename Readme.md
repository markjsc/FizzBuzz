# FizzBuzz [![Build Status](https://travis-ci.org/markjsc/FizzBuzz.svg?branch=master)](https://travis-ci.org/markjsc/FizzBuzz)

## Purpose

This project was created as part of a technical interview. I can't disclose the company, but it was *Clear* that I had to provide a *Measure* of technical skill to be successful.

A big thanks to Kyle for being patient with me during the interview. Hopefully the outcome shows that I can deliver a well thought-out solution in a short amount of time.

## Getting Started

To run the Fizz Buzz Console app:

1. Open the FizzBuzz solution in Visual Studio (I used Visual Studio Community 2017 - 15.7.6)
1. Set FizzBuzz.App as the startup project.
1. Press F5 to run.
1. Select the desired option or press ESCAPE to exit.


To run the Unit Tests:

1. Open the FizzBuzz solution in Visual Studio (I used Visual Studio Community 2017 - 15.7.6)
1. Build the solution, which should trigger restoring NuGet packages (several are related to NUnit, the test engine used here).
3. Open the Test Explorer panel.
4. Click "Run All" to run all tests.

## CI Build

This uses [Travis-CI](https://travis-ci.org) for the CI build. It basically builds the solution and runs the tests. If I had plans to deploy this, I would also package it (NuGet pack) and push it (likely with Octo.exe).