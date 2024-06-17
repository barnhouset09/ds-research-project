# DACOS Dataset Introduction

DACOS is a dataset pulled from https://zenodo.org/records/7570428

The files of this dataset have been archived in the following folders of this repo:

- Code Files
  - The actual files of code that have been classified by various users.
    - [(link to folder: /CodeFiles)](CodeFiles)
- MySQL DB Creation Script Files
  - The DACOS project requires a MySQL database to create the metadata collected from the Code Files.
  - It can be created on a MySQL server of your choosing using the `DACOSMain.sql` file
  - Instructions for doing so can be found in [this README](MysqlDbScripts/README.md)
  - **I HAVE MIGRATED THIS DATA TO A DUCKDB INSTANCE TO REDUCE OVERHEAD**
    - Instructions on how to do so found in [this C# interactive notebook](../../Notebooks/1_Migrate_Csv_Data_To_DuckDb.dib).
    - **NOTE:** A compressed archive of the duckdb instance is provided in this repo [here](./DACOS_DuckDb.7z).
      - e.g. you will not need MySql to access the data, but if you want to reproduce the research you will.
    - **ADDITIONAL NOTE:** All data interacted with for this project has a relevant 7zip archive. 7zip provides much better compression over other compression suites.
      - In all cases of data retrieval and cleanup steps, you may unzip the archives available instead.
      - The notebooks found in [this folder](./../../Notebooks) will make mention of these files' locations should you decide to leverage them instead of repeating the data processing portions of this research.

The creation and other research information about the DACOS dataset can be found from this publication:
- https://arxiv.org/pdf/2303.08729
- A local version is saved in [this pdf](dacos_publication_nandani_saad_sharma.pdf)

## Dataset Contents

### `annotations`
**Metadata of each labeled code file. Includes columns:**
- `Id`
  - Primary key, int
- `iscm`
  - boolean
  - represents the `complex method` code smell and if it is present in the file
- `isim`
  - boolean
  - is not explained in any documentation
  - all values are false, so appears to be unused
- `islp`
  - boolean
  - represents the `long parameter list` code smell and if it is present in the file
- `isma`
  - boolean
  - represents the `multifaceted abstraction` code smell and if it is present in the file
- `is_smell`
  - boolean
  - is true when any code smells have been detected in the file
- `sample_id`
  - int
  - foreign key to the sample table, which contains a reference data to the file being assessed

### `class_metrics`
**Metrics collected of each code file and its contained classes**
- `id`
  - int, primary key
- `dit`
  - int
  - represents code metric `depth of inheritance tree`
- `fanin`
  - int
  - represents code metric `Fan-In`, or the number of other modules or callers of the code class
- `fanout`
  - int
  - represents code metric `Fan-Out`, or the measure of how many dependencies the code class has
- `lcom`
  - float
  - represents code metric `lack of cohesion in methods`, it is a measure of how closely the class's methods relate to one another
- `loc`
  - int
  - represents code metric `lines of code`
- `nc`
  - int
  - represents the code metric `number of classes`
- `nof`
  - int
  - represents the code metric `number of fields`
- `nom`
  - int
  - represents the code metric `number of methods`
- `nopf`
  - int
  - represents the code metric `number of public fields`
- `nopm`
  - int
  - represents the code metric `number of public methods`
- `wmc`
  - int
  - represents the code metric `weighted methods per class`, which is the sum of the complexities of all methods in a class
- `package_name`
  - string
  - the name of the java package the class is found in
- `project_name`
  - string
  - the name of the java project the class is found in
- `type_name`
  - string
  - the type / class name

### `method_metrics`
**Metrics collected of each method in each code file**
- `id`
  - int, primary key
- `cc`
  - int
  - represents the code metric `cyclomatic complexity`, or the relative complexity of the given method
- `loc`
  - int
  - represents the code metric `lines of code`
- `pc`
  - int
  - represents the code metric `path count`, or the number of possible execution paths of a method
- `method_name`
  - string
  - the name of the method
- `package_name`
  - string
  - the name of the package the method is found in
- `project_name`
  - string
  - the name of the project the method is found in
- `type_name`
  - string
  - the type of object/class that the method returns

### `sample`
**A reference to the files that are used in the dataset**
- `id`
  - int, primary key
- `designite_id`
  - int
  - is a foreign key to the `method_metrics` or `class_metrics` tables
    - the source is dependent on the column value `is_class`
- `has_smell`
  - boolean
  - is true when a code smell has been detected
- `is_class`
  - boolean
  - is true when the sample being referenced is a class, false when it is a method
  - denotes which table the `designite_id` is referencing
- `path_to_file`
  - string
  - the path to the file being referenced
- `project_name`
  - string
  - the name of the project the sample comes from
- `sample_constraints`
  - int
  - I am unsure what this value represents.
  - I've checked the publication and DACOS dataset pages
  - I've also checked to see if it is part of the designite software
  - Most of the values are less than 10, only 9 records exists above this out of 100k

### `smell`
**Appears to be an unused table. Neither the DACOSMain.sql nor the DACOSExtended.sql have any data in this table.**