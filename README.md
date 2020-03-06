# _Find & Replace_

#### _A C# Console Application to replace words, March 2020_

#### By _**Jeremy Padot && K. Wicz**_


## Description

_A console application that takes a word and replaces it with another word._



## Behavior Driven Project Specifications

| Behavior | Input | Output |
|:---|:---:|:---:|
|User inputs three strings: phrase, word, replacement word| "hello world", "world", "Haru"| creates new instance of user input|
|If user fails to include word that is a part of the phrase, returns an error |"hello world", "wow", "Haru"|error, please enter a word to be replaced that a part of the phrase|
|User inputs three strings: phrase, word, replacement word| "hello world", "world", "Haru"| "hello Haru"|


## Setup/Installation Requirements

In your computer's terminal:

1. Navigate to where you want this application to be saved, i.e.:
```sh
cd desktop
```
2. Clone the file from GitHub with HTTPS
```sh
git clone 
```
3.  Enter into the new file directory
```sh
cd scrabble
```
4.  Start the program
```sh
dotnet run
```

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kwicz/scrabble/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Jeremy Padot && K.Wicz_**
