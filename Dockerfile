FROM 352631681906.dkr.ecr.us-east-1.amazonaws.com/siclo-automation-framework:latest
USER root
WORKDIR /code
RUN apt-get -y update && apt-get install -y git lftp openssh-client coreutils curl && curl -sSL https://get.docker.com/ | sh
ADD siclo_plus_api /code
RUN dotnet build siclo_plus_api.sln
#RUN dotnet test --logger:"console;verbosity=detailed" siclo_plus_api.sln