# CQRS_Kafka

#run docker - mongo
docker run -it -d --name mongo-container -p 37017:37017 --network mydockernetwork --restart always -v mongodb_data_container:/data/db mongo:latest --port 37017

#run docker - mssql
docker run -d --name sql-container --network mydockernetwork --restart always -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=$tr0ngS@P@ssw0rd02" -e "MSSQL_PID=Express" -p 1433:1433 mcr.microsoft.com/mssql/server:2017-latest-ubuntu 