FROM stefanscherer/node-windows:10.7-nanoserver

RUN powershell Invoke-Webrequest -Uri "https://github.com/sahat/hackathon-starter/archive/5.1.1.zip" -OutFile 5.1.1.zip
RUN powershell expand-archive 5.1.1.zip -Destination ./app 
WORKDIR  app/hackathon-starter-5.1.1/
RUN npm install
ADD init.ps1 ./
#CMD [ "powershell"]
RUN mkdir C:\live
# this bit of hackery thanks to a node.js bug on windows
# https://github.com/nodejs/node/issues/8897#issuecomment-298662512
RUN powershell Set-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Control\Session Manager\DOS Devices' -Name 'K:' -Value '\??\C:\live' -Type String
CMD [ "powershell", "./init.ps1"]

