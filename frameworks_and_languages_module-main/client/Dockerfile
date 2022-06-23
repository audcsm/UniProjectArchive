FROM node:alpine

WORKDIR /vue_client

COPY ./vue_client/package.json ./

RUN npm install

COPY . .

EXPOSE 8001
CMD ["npm", "run", "serve", "--", "--port", "8001"]