FROM microsoft/dotnet:1.0.0-preview2-sdk

RUN mkdir -p /dotnetapp && \
    mkdir -p /data

WORKDIR /dotnetapp

#ENTRYPOINT ["dotnet", "run"]
CMD ["dotnet", "run"]

COPY . /dotnetapp
RUN dotnet restore && \
    dotnet build



