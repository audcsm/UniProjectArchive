Client
======

Makefile and Dockerfile are not functional due to compilation errors.
To run the client:
    cd client
    cd vue_client
    npm install
    npm run serve -- --port 8001

To run alongside the Rails API, see /server/README.md for info on how to build the server.
Then, build the client and add ~ ?api=((full server 8000 URL)) ~ to the end of the 8001 URL.

======

Bugs:
    Axios uses a static URL to communicate with the Rails API. If requests do not function in your instance, go to the following locations and change the URL to that which matches your running instance of port 8000.
    - /client/vue_client/src/views/Home.vue, line 59
    - /client/vue_client/src/views/List.vue, line 37