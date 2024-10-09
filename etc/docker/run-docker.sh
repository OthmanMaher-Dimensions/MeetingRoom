#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 8b73d795-f475-4296-904b-337f16d2cae9 -t
    fi
    cd ../
fi

docker-compose up -d
