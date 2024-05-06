FROM selenium/standalone-chrome
USER root
RUN apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF && \
    echo deb https://download.mono-project.com/repo/ubuntu stable-focal main | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
RUN apt-get update && \
    apt-get install -y \
    gnupg \
    mono-devel \
    ca-certificates \
    apt-transport-https && \
    wget https://packages.microsoft.com/config/ubuntu/20.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb && \
    dpkg -i packages-microsoft-prod.deb
RUN apt-get update &&  \
    apt-get install -y dotnet-runtime-3.1 dotnet-sdk-3.1
