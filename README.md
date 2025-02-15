# Interactive Story Book

[![GitHub License](https://img.shields.io/github/license/b3r8t3r/Interactive-Story-Book)](https://github.com/b3r8t3r/Interactive-Story-Book/blob/master/LICENSE)
[![GitHub Release](https://img.shields.io/github/v/release/b3r8t3r/Interactive-Story-Book?label=version)](https://github.com/b3r8t3r/Interactive-Story-Book/releases/latest)
[![(https://github.com/b3r8t3r/Interactive-Story-Book/blob/master/README.md)](https://img.shields.io/badge/readme-%F0%9F%87%B7%F0%9F%87%BA%20russian-green)](https://github.com/b3r8t3r/Interactive-Story-Book/blob/master/README.md)
[![(README_ENG)](https://img.shields.io/badge/readme-%F0%9F%87%AC%F0%9F%87%A7%20english-green)](https://github.com/b3r8t3r/Interactive-Story-Book/blob/master/README_ENG.md)
![Windows](https://img.shields.io/badge/Available%20on-Windows-blue)

## Описание

Этот программный комплекс предназначен для чтения, создания и редактирования интерактивных книг в формате *isb* (Interactive Story Book), ход событий которых напрямую зависит от выбора пользователя.

## Содержание

1. [Возможности](#возможности) \
1.1 [Interactive Book Reader](#interactive-book-reader) \
1.2 [Interactive Book Editor](#interactive-book-editor)
2. [Установка](#установка) \
2.1 [Windows](#windows) 
3. [Использование](#использование) \
3.1 [Чтение при помощи Interactive Book Reader](#чтение-при-помощи-interactive-book-reader) \
3.2 [Создание интерактивных книг при помощи Interactive Book Editor](#создание-интерактивных-книг-при-помощи-interactive-book-editor)
4. [Разработка](#разработка) \
4.1 [Требования](#требования) \
4.2 [Создание билда](#создание-билда)

## Возможности

### Interactive Book Reader

Модуль **Interactive Book Reader** позволяет открывать интерактивные книги, хранящиеся в файлах формата *isb*, и читать их.

### Interactive Book Editor

Модуль **Interactive Book Reader** позволяет создавать и редактировать интерактивные книги, хранящиеся в файлах формата *isb*.

Ниже представлены основные возможности модуля:

- Редактор основной информации о книге;
- Редактор ID глав;
- Редактор текста глав;
- Редактор развилок глав.

## Установка

### Windows

Перейдите в раздел [Releases](https://github.com/b3r8t3r/Interactive-Story-Book/releases), скачайте нужный вам модуль программы в виде архива и распакуйте архив.

## Использование

### Чтение при помощи Interactive Book Reader

Для того, чтобы открыть интерактивную книгу, необходимо нажать на раздел "Файл", во всплывающем меню нажать "Открыть книгу" и выбрать файл с расширением *isb*.

### Создание интерактивных книг при помощи Interactive Book Editor

Для того, чтобы создать интерактивную книгу, необходимо нажать на раздел "Файл", во всплывающем меню нажать "Создать новую книгу". Это загрузит шаблон для книги по-умолчанию (пароль от шаблона - `1111`), но так же сотрет текущие несохраненные изменения, если в какую-то книгу они были внесены.

Для изменения информации о книге необходимо перейти в раздел "Натройки книги", где можно изменить название книги, информацио об авторе и пароль от книги.

Для изменения количества вариантов развития событий в текущей главе необходмо перейти в раздел "Настройки главы".

Для изменения текста главы необходимо перейти в раздел "Редактор текста главы".

Для изменения вариантов исхода главы необходимо перейти в раздел "Редактор вариантов развития сюжета".

## Разработка

### Требования

- Visual Studio 2019 и более с установленным компонентом "Разработка классических приложений .NET".

### Создание билда

Откройте файл проекта `Interactive Story Book.sln` с помощью Visual Studio и воспользуйтесь комбинацией клавиш `Ctrl+Shift+B` - это позволит собрать решение.
