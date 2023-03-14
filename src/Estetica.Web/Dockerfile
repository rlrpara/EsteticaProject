FROM node:18 as angular
WORKDIR /app
COPY ["package.json", "./"]

RUN yarn add @angular/cli@15
RUN yarn --silent
COPY . .
RUN yarn run build

FROM nginx:alpine
VOLUME /var/cache/nginx
COPY --from=angular /app/dist/estetica-ui usr/share/nginx/html
COPY ./src/config/nginx.conf /etc/nginx/conf.d/default.conf
