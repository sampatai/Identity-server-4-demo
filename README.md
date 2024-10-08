# Identity server 4 demo

## Overview

OAuth2 and OpenID Connect are protocols that enable the development of more secure applications.

### OAuth2

- **Definition**: OAuth2 is the industry-standard protocol for authorization, allowing third-party applications to access user accounts by delegating user authentication to the service hosting the account.
- **Process**:
  1. The user provides credentials to the authorization server.
  2. The server responds with a token.
  3. The user uses this token to communicate with the API and retrieve data.
  4. The API validates the token to check user access to the requested endpoint.

### OpenID Connect

- **Definition**: OpenID Connect builds on OAuth2 by providing an authentication layer, enabling clients to verify user identity after authentication on the authorization server.

## Refresh Tokens

### Purpose

- **What are Refresh Tokens?**: Credentials used to acquire new access tokens when they expire, typically having a longer lifespan than access tokens.
- **Flow**:
  1. The application securely stores the refresh token.
  2. When the access token expires, the application uses the refresh token to request a new access token.
  3. If the refresh token is revoked, the user must re-authenticate.

## JSON Web Tokens (JWT)

### Definition

- **What is JWT?**: JSON Web Tokens (JWT) are a standard for user authentication and authorization in systems that communicate with each other.

### JWT Example Scenario

1. User sends a login request with credentials.
2. The Authentication Server validates the credentials and generates a token using a secret key.
3. The server returns the token to the user, which is stored in the user’s Token column in the database.
4. The user includes the JWT in the header of API calls, and the server verifies its validity.

### JWT Structure

JWT consists of three main parts encoded with Base64:

1. **Header**: Contains token type and signing algorithm.
2. **Payload**: Holds claims, providing unique data between the client and server.
3. **Signature**: Ensures data integrity by combining the header, payload, and secret key.

## OAuth2 Overview

- **Definition**: OAuth2 is an open authorization protocol for data communication between applications. It enables secure access to data resources.
- **Endpoints**:
  - **/authorize**: Obtains authorization from the resource owner.
  - **/token**: Exchanges an authorization grant for an access token.
  - **/revocation**: Enables token revocation.

## OpenID Connect Overview

- **Definition**: OpenID Connect 1.0 is a simple identity layer on top of OAuth2, allowing clients to verify user identity and obtain basic profile information.
- **Endpoints**:
  - **/userinfo**: Retrieves user profile information.
  - **/checksession**: Checks the current user's session.
  - **/endsession**: Ends the user's session.

## IdentityServer4

### Overview

- **Definition**: IdentityServer4 is a free, open-source OpenID Connect and OAuth2 framework for ASP.NET Core, centralizing authentication and access control across applications.

### Responsibilities

- Protect resources.
- Authenticate users using local accounts or external providers.
- Provide session management and single sign-on.
- Manage and authenticate clients.
- Issue identity and access tokens to clients.
- Validate tokens.

### Terminologies

#### Client Applications

- **Definition**: Applications that access secure data sources and must be registered with IdentityServer to request tokens.
- **Registration**: Involves providing necessary information such as name, redirect URI, client ID, and client secret.

#### Data Resources

- **Definition**: Specific data or information protected by IdentityServer (e.g., user profiles, sensitive documents).
- **Access Control**: Clients access resources by referencing their unique names.

## IdentityServer Functions

- **OpenID Connect Provider**: Implements OpenID Connect over OAuth2.
- **Data Protection**: Central authority for managing access to protected resources.
- **User Authentication**: Supports various authentication methods.
- **Single Sign-On**: Facilitates seamless access across applications.
- **Client Verification**: Authenticates and authorizes client applications.
- **Token Management**: Issues and verifies identity and access tokens.

### Identity and Access Tokens

#### Identity Token

- **Purpose**: Represents the result of the authentication process, containing user identifiers and authentication details.

#### Access Token

- **Purpose**: Grants access to APIs and data sources. It contains client and user information for authorization checks.

## Conclusion

Understanding OAuth2, OpenID Connect, JWT, and IdentityServer4 is crucial for developing secure applications that effectively manage user authentication and authorization across various platforms.
