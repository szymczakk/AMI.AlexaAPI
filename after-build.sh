#!/bin/bash
if [ "$TRAVIS_BRANCH" == "master" ]; then
cd AMI.AlexaAPI/
docker login -u="$DOCKER_USERNAME" -p="$DOCKER_PASSWORD";
docker build -t rakaz/ami:latest .
docker push rakaz/ami:latest
fi
