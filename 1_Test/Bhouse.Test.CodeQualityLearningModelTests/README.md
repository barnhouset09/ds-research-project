# Code Quality Assessor Model

This project provides step-by-step instructions on how to pull various datasets and build various learning models from them with the goal of assessing code quality.

## Project Goals

This project builds three classifiers, one each for:
  1. Identifying code smells
  2. Identifying operational complexity
  3. Combining the above for identifying a code quality score

## Table of Contents

  1. [Requirements](#requirements)
     - [Software](#software)
       - [.NET 8.0 SDK](#net-80-sdk)
       - [7zip](#7zip)
       - [Docker](#docker)
       - [VSCode](#vscode)
       - [VS Code Extension: Polyglot Notebooks](#vs-code-extension-polyglot-notebooks)
        - [Datasets](#datasets)
          - [DACOS Dataset](#dacos-dataset)
          - [Project CodeNet Dataset](#project-codenet-dataset)
  2. [Project Guide](#project-guide)
     - [Working with the DACOS Data Set](#working-with-the-dacos-data-set)


## Requirements:
- .NET 8.0 SDK
  - https://dotnet.microsoft.com/en-us/download/dotnet/8.0
- 7zip
  - https://www.7-zip.org/
- Docker
  - https://www.docker.com/products/docker-desktop/
- VSCode
  - https://code.visualstudio.com/download
- VS Code Extension: 
  - **Polyglot Notebooks**
- DACOS Dataset:
  - https://zenodo.org/records/7570428
    - You need `DACOSMain.sql` to create the database
    - You need `files.zip` for the actual codefile data
      
    *both of these files are provided in this code solution as 7zip archives*
      - `DACOSMain.sql` (link: [Resources/DACOS/MysqlDbScripts](Resources/DACOS/MysqlDbScripts))
      - `files.zip` (link: [Resources/DACOS/CodeFiles](Resources/DACOS/CodeFiles))
- Project CodeNet Dataset
  - https://developer.ibm.com/exchanges/data/all/project-codenet/
  - It is a very large dataset and will take a couple of hours to extract.
  - There may be faster methods, but I used 7zip to decompress and extract the files.

## Project Guide

Below are the topics explored for this project.

### Working with the DACOS Data Set
The DACOS Dataset is used for classifying code smells.

See this [README.md](Resources/DACOS/README.md) for more information on how the data was utilized.

