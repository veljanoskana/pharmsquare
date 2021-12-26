#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat 

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["pharmsquare-prototype.csproj", "pharmsquare-prototypep/"]
RUN dotnet restore "pharmsquare-prototype/pharmsquare-prototype.csproj"
WORKDIR "/src/pharmsquare-prototype"
COPY . .
RUN dotnet build "pharmsquare-prototype.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "pharmsquare-prototype.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet pharmsquare-prototype.dll