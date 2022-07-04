# Intro

This is a simple project to use along with a dotnet web api with postgresql integration tutorial.

https://lunawen.com/devops/20220410-luna-tech-add-postgresql-to-dotnetwebapi/

# Commands

For commands related to EF core, please check out the blog.

## Dev

```shell
cd dotnetwebapi
dotnet run
```

## Create a publish folder

Note: you can also use UI to create the folder.
Please don't use the single file approach, we need the dll to make this work.

```shell
dotnet publish --configuration Release -o published
```

## Create migration script

```shell
dotnet ef migrations script --output "migration.sql" --idempotent
```

## Run the publish

```shell
cd <publish-folder>
dotnet app-name.dll
```
