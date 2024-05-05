#!/bin/bash

rm -rf ./release

mkdir -p ./release

dotnet publish -p:PublishProfile=ReleaseProfile

  
