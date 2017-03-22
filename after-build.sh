#!/bin/bash
if [ "$TRAVIS_BRANCH" == "master" ]; then
cd AMI.AlexaAPI/
docker login -u="$DOCKER_USERNAME" -p="$DOCKER_PASSWORD";
docker build -t rakaz/ami.alexaapi:dev .
docker push rakaz/ami.alexaapi:dev
fi
