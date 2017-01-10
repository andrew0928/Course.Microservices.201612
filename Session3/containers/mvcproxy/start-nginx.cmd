cd /d c:\nginx

:loop
ipconfig /flushdns
nginx.exe
powershell /c sleep 1
goto loop