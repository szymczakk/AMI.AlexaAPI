#!/bin/bash
if [ "$TRAVIS_BRANCH" == "master" ]; then
cd AMI.AlexaAPI/
docker login -u="$DOCKER_USERNAME" -p="$DOCKER_PASSWORD";
docker push rakaz/ami
fi
