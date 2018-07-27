FROM microsoft/dotnet

ADD ./bin/debug/netcoreapp2.0/publish ./

RUN del *.txt

CMD ["dotnet", "tasty-app.dll"]


