# Use the official .NET SDK as a base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /Blog

# Copy the project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the entire application
COPY . .

# Build the application
RUN dotnet publish -c Release -o out

# Use the official ASP.NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /Blog

# Copy the published output from the build image
COPY --from=build /Blog/out .

# Expose the port on which the application will run
EXPOSE 80

# Set the entry point for the application
ENTRYPOINT ["dotnet", "Blog.dll"]
