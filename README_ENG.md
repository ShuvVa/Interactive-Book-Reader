# Interactive Story Book

![GitHub License](https://img.shields.io/github/license/b3r8t3r/Interactive-Story-Book)
![GitHub Release](https://img.shields.io/github/v/release/b3r8t3r/Interactive-Story-Book?label=version)
![(https://github.com/b3r8t3r/Interactive-Story-Book/blob/master/README.md)](https://img.shields.io/badge/readme-%F0%9F%87%B7%F0%9F%87%BA%20russia-green)
![(https://github.com/b3r8t3r/Interactive-Story-Book/blob/master/README_ENG.md)](https://img.shields.io/badge/readme-%F0%9F%87%AC%F0%9F%87%A7%20english-green)
![Windows](https://img.shields.io/badge/Available%20on-Windows-blue)

## Description

This program complex is designed for reading, creating and editing interactive books in *isb* format (Interactive Story Book), the course of events of which directly depends on the user's choice.

## Contents

1. [Features](#features) \
1.1 [Interactive Book Reader](#interactive-book-reader) \
1.2 [Interactive Book Editor](#interactive-book-editor)
2. [Installation](#installation) \
2.1 [Windows](#windows)
3. [Usage](#usage) \
3.1 [Reading with Interactive Book Reader](#reading-with-interactive-book-reader)
3.2 [Creating Interactive Books with Interactive Book Editor](#creating-interactive-books-with-interactive-book-editor)
4. [Development](#development) \
4.1 [Requirements](#requirements) \
4.2 [Create a build](#create-a-build)

## Features

### Interactive Book Reader

The **Interactive Book Reader** module allows you to open and read interactive books stored in *isb* files.

### Interactive Book Editor

The **Interactive Book Reader** module allows you to create and edit interactive books stored in *isb* files.

Below are the main features of the module:

- Editor of basic information about the book;
- Editor of chapter IDs;
- Editor of chapter text;
- Editor of chapter endings.

## Installation

### Windows

Go to [Releases](https://github.com/b3r8t3r/Interactive-Story-Book/releases), download the desired program module as an archive and unpack the archive.

## Usage

### Reading with Interactive Book Reader

To open an interactive book, click on the “File” section, click on “Open Book” in the pop-up menu and select a file with *isb* extension.

### Creating Interactive Books with Interactive Book Editor

To create an interactive book, you need to click on the “File” section, click “Create New Book” from the pop-up menu. This will load the default template for the book (the password for the template is `1111`), but it will also erase any current unsaved changes if any changes have been made to any book.

To change the information about a book, go to the “Book Settings” section, where you can change the book title, author information, and book password.

To change the number of variants of development of events in the current chapter it is necessary to go to the section “Chapter settings”.

To change the text of the chapter it is necessary to go to the section “Chapter text editor”.

To change the variants of the outcome of the chapter you need to go to the section “Editor of plot development variants”.

## Development

### Requirements

- Visual Studio 2019 и более с установленным компонентом "Разработка классических приложений .NET".

### Create a build

Откройте файл проекта `Interactive Story Book.sln` с помощью Visual Studio и воспользуйтесь комбинацией клавиш `Ctrl+Shift+B` - это позволит собрать решение.
