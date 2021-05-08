FROM mcr.microsoft.com/dotnet/sdk:5.0 AS builder
WORKDIR /app

COPY ./Twatch/*.csproj .
RUN dotnet restore

COPY ./Twatch .
RUN dotnet publish -c Release -o out

# ---

FROM mcr.microsoft.com/dotnet/runtime:5.0
WORKDIR /app
 
COPY --from=builder /app/appsettings.json .
COPY --from=builder /app/out .

ENTRYPOINT ["dotnet", "Twatch.dll"]
