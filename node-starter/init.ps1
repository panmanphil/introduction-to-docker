$ping = New-Object System.Net.NetworkInformation.Ping
$ip =  $ping.SendPingAsync("db").Result.Address.IpAddressToString

#this should work but returns the wrong ip address inside the container!!!
#$ips = Resolve-DnsName db
#$ip = $ips[0].IpAddress

$ENV:MONGODB_URI="mongodb://$($ip):27017/test"
Write-Host "db ip is: $ip connstr is: $($ENV:MONGODB_URI)"
k:
npm install
node app.js