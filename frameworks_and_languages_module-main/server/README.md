Server
======

If port connection is blocked:

    Copy the link (should look like config.hosts << "url here") and paste into config/environment.rb, adding "Rails.application." at the beginning, similar to the other links found there

Useful commands:

Run server:
    bin/rails server

View items:
    curl http://localhost:3000/item

======

Requests:

GET:
    curl http://localhost:8000/item
    curl http://localhost:8000/item/id

POST:
    curl -d '{"user_id":"abc","keywords":"abc","description":"abc","lat":1,"lon":2}' -H 'Content-Type: application/json' http://localhost:8000/item
    (bad) curl -d '{"a":1,"b":2}' -H 'Content-Type: application/json' http://localhost:8000/item

DELETE
    curl -v --request DELETE http://localhost:8000/item/id

OPTIONS:
    curl -H "Origin: http://example.com" -H "Access-Control-Request-Method: POST" -H "Access-Control-Request-Headers: Content-Type" -X OPTIONS --verbose http://localhost:8000