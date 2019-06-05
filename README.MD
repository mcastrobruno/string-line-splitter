[![Nuget](https://img.shields.io/nuget/v/string-splitter.svg)](https://www.nuget.org/packages/string-splitter/)

## String line splitter

#### Instalation
##### Package Manager
```
Install-Package string-splitter -Version 1.0.0
```
##### dotnet CLI
```
dotnet add package string-splitter --version 1.0.0
```

#### Usage

```
StringSplitter _splitter = new StringSplitter();
string result = _splitter.Split("This text will be splitted", 5);


//RESULT
This
text
will
be
splitted

