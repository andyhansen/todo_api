# TODO: Is there a lighter image to use here
FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /app
COPY . .

# TODO: Why does this take a weirdly long time
RUN ["dotnet", "restore"]

RUN ["dotnet", "build"]

CMD ["dotnet", "run", "--launch-profile", "https"]

EXPOSE 5040
