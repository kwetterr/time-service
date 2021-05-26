[![CodeQL](https://github.com/kwetterr/ui/actions/workflows/codeql-analysis.yml/badge.svg)](https://github.com/kwetterr/ui/actions/workflows/codeql-analysis.yml)
[![Build](https://github.com/kwetterr/ui/actions/workflows/build.yml/badge.svg)](https://github.com/kwetterr/ui/actions/workflows/build.yml)
[![Publish Docker image](https://github.com/kwetterr/ui/actions/workflows/docker-publish.yml/badge.svg)](https://github.com/kwetterr/ui/actions/workflows/docker-publish.yml)

# TimeService
Get formatted time with a Azure Function.

## Call service locally
POST: http://localhost:7071/api/time

Request
```zsh
{
    "Time": 1620029026
}
```

Response
```json
{
    "days": "23",
    "hours": "3",
    "minutes": "57"
}
```
