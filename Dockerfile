# TODO: Is there a lighter image to use here
FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app
COPY . .

# TODO: Why does this take a weirdly long time
# Install dependencies
RUN ["dotnet", "restore"]

# Build the application
RUN ["dotnet", "build"]

# Boot the application
CMD ["dotnet", "run", "--launch-profile", "https"]

# TODO: Get this running on port 3000
EXPOSE 5040
