dotnet build
dotnet pack
dotnet tool install --add-source ./nupkg razor_lit_demo --global | grep --invert-match warning --line-buffered
