# IdeaManagerDemo
A demo of a complete tiered application of a croud sourcing idea sharing app

# What is IdeaMan?
IdeaMan is a web based application where people can share business ideas, get sponsiorship, and investiment in a croud sourcing type of investiment

# Features
  - As an idea creator I can create my ideas to be voted by community
  - As a community user I can Vote in interesting ideas
  - As an idea creator I can have my idea being shortlisted to investiment
  - As an investor I can Propose to invest in an idea
  
# Architecture
## IdeaManWeb
Is a dotnet core 2.0 web application to manage ideas over the web
IdeaManWeb is containarized in a unix container exposing port 80

## IdeaManAPI
Is a dotnet core 2.0 web api application to service user interfaces that manage ideaMan functionalities
IdeaManAPI is a containarized in a unix container exposing port 80

## IdeaManDB
Is a SQLServer application containing all the persistence needed to store and manage ideas

# How to build
## Pre requisites (so far until a suitable docker image can be uploaded to dockerhub)
  - Latest dotnet 2.0 installed on your local machine
  - latest version of docker-compose
  - latest version of docker
  - Intenet connection

## Building
 - git clone this_repo_url
 - \$>cd <repo>; cd IdeaManager_FE; dotnet restore
 - \$>cd <repo>; cd IdeaManager_API; dotnet restore
 - \$>docker-compose up
 - Navigate to http://localhost
