FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app
# Copy everything else and build
COPY . ./
RUN dotnet restore
RUN dotnet publish QuantumCircuitAPI/QuantumCircuitAPI.csproj -c Release -o out

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/QuantumCircuitAPI/out .
RUN apt-get update && apt-get -y install libgomp1
ENTRYPOINT ["dotnet", "QuantumCircuitAPI.dll"]