FROM ubuntu:latest

MAINTAINER Philip Nelson <philip.nelson@omniresources.com>

RUN   \
  apt-get -y -qq install python wget

# Install Node
RUN   \
  cd /opt && \
  wget https://nodejs.org/dist/v4.2.6/node-v4.2.6-linux-x64.tar.gz && \
  tar -xzf node-v4.2.6-linux-x64.tar.gz && \
  mv node-v4.2.6-linux-x64 node && \
  cd /usr/local/bin && \
  ln -s /opt/node/bin/* . && \
  rm -f /opt/node-v4.2.6-linux-x64.tar.gz

ADD . /src 
# Set the working directory
WORKDIR   /src
RUN npm install node-sass
RUN node ./node_modules/node-sass-middleware/node_modules/node-sass/scripts/install.js
RUN /opt/node/bin/npm -g install express
CMD ["/usr/local/bin/node", "app.js"]

