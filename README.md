# Dotnet Assignment

## Layers

1. API

    Contains Controllers

2. Business

    Contains Services

3. Data

    Contains Repositories for accessing Data

4. Core

    Contains Models

5. Root

    Contains DI

## APIs implemented

**Note:** Explore all APIs available at `/swagger`

1. `GET /v1/TypeAhead/locations`
2. `GET /v1/HomeDetails/home`
3. `POST /v1/User/create`
4. `GET /v1/User/profile`
5. `GET /v1/User/Bookmarks`
6. `POST /v1/User/createBookmark`
7. `POST /v1/User/updateBookmark`
8. `GET /v1/User/deleteBookmark`



Attempts to implement GraphQL at `/ui/playground`

Refer the Docs tab to find all the supported queries


1. Sample query
    
```
    query location(args: {partnerId: 9383, searchTerm: "New York"}){
        name,
        id
	}
```
