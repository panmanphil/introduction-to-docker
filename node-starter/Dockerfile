FROM mcr.microsoft.com/powershell:nanoserver as build

#originally the stefanscherer image had powershell, but no more
#so multi stage build

RUN pwsh /c Invoke-Webrequest -Uri "https://github.com/sahat/hackathon-starter/archive/5.1.1.zip" -OutFile 5.1.1.zip
RUN pwsh /c expand-archive 5.1.1.zip -Destination ./app 

FROM stefanscherer/node-windows:10.7-nanoserver
#paths with spaces!
ENV PROGFILES "/Program Files/" 
COPY --from=build "${PROGFILES}/Powershell/" ${PROGFILES}/Powershell
COPY --from=build /app ./app/
WORKDIR  app/hackathon-starter-5.1.1/
RUN npm install
ADD init.ps1 ./
#CMD [ "powershell"]
RUN mkdir C:\live

RUN setx /M PATH   "%PATH%;C:/Program Files/Powershell/"
RUN pwsh /c Write-Host 'yay'
# this bit of hackery thanks to a node.js bug on windows
# https://github.com/nodejs/node/issues/8897#issuecomment-298662512
RUN pwsh /c Set-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control\Session Manager\DOS Devices' -Name 'K:' -Value '\??\C:\live' -Type String
CMD [ "pwsh", "./init.ps1"]

