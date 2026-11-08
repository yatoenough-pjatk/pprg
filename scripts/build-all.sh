#!/usr/bin/env bash
set -euo pipefail

find . -name '*.csproj' -not -path '*/bin/*' -not -path '*/obj/*' -print0 |
    xargs -0 -r -n1 dotnet build
