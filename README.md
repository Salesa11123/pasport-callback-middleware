# PaSPort Callback Middleware

Minimal ASP.NET Core Web API for testing the PaSPort asynchronous callback.

## Callback endpoint

`POST /api/si-workorders-callback`

Example request:

```json
{
  "callbackId": "11111111-1111-4111-8111-111111111111",
  "code": "1",
  "message": "Success"
}
```

Expected response:

`204 No Content`

The callback payload is written to the Visual Studio / console log.

## Run in Visual Studio

1. Open `PaSPortCallbackMiddleware.sln`.
2. Select the `https` profile.
3. Press F5.
4. Test:
   - `https://localhost:7080/api/si-workorders-callback`
   - or `http://localhost:5080/api/si-workorders-callback`

## First objective

For the first integration test this project intentionally does only:
- receive callback
- log callbackId/code/message
- return HTTP 204

SAP FSM update/correlation logic should be added only after the inbound callback is proven end-to-end.
