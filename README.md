# udacitycapstone

➜  MicroserviceDemo$ cd CustomerApi
➜  CustomerApi docker build -t customerapi .
➜  CustomerApi docker tag customerapi kursatarslan/customerapi       
➜  CustomerApi docker push kursatarslan/customerapi  

➜  MicroserviceDemo$ cd OrderApi
➜  OrderApi docker build -t orderapi .
➜  OrderApi docker tag orderapi kursatarslan/orderapi       
➜  OrderApi docker push kursatarslan/orderapi  


➜  MicroserviceDemo$ cd TokenManager
➜  TokenManager docker build -t jwtapi .
➜  TokenManager docker tag jwtapi kursatarslan/jwtapi       
➜  TokenManager docker push kursatarslan/jwtapi  

docker run --rm -dP -e RABBITMQ_DEFAULT_USER=user -e RABBITMQ_DEFAULT_PASS=password -p 4369:4369 -p 5672:5672  -p 15672:15672 -p 25672:25672 -p 35197:35197 --name rabbitmq rabbitmq:3-management

dotnet dev-certs https -ep ./Solution/CustomerApi/Infrastructure/Certificate/cert-aspnetcore.pfx -p SecretPassword  
dotnet dev-certs https --trust

docker run --rm -it -p 8000:80 -p 8001:443 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=8001 -e ASPNETCORE_Kestrel__Certificates__Default__Password=SecretPassword -e ASPNETCORE_Kestrel__Certificates__Default__Path=/app/Infrastructure/Certificate/cert-aspnetcore.pfx kursatarslan/customerapi 


docker run --rm -it -p 9000:80 -p 9001:443 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=8001 -e ASPNETCORE_Kestrel__Certificates__Default__Password=SecretPassword -e ASPNETCORE_Kestrel__Certificates__Default__Path=/app/Infrastructure/Certificate/cert-aspnetcore.pfx kursatarslan/orderapi 

