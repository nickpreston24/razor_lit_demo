# dotnet new razor

# globally installs, so we can use it on any project
dotnet tool install -g Microsoft.Web.LibraryManager.Cli


# locally installs to project, so any JS libs become part of the build output! :)
dotnet add package Microsoft.Web.LibraryManager.Build

libman init;
libman install htmx;
libman install alpinejs;
libman install lit -p jsdelivr;


