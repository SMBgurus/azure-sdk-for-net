# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml
title: EventGridClient
require: https://github.com/Azure/azure-rest-api-specs/blob/bd75cbc7ae9c997f39362ac9d19d557219720bbd/specification/eventgrid/data-plane/readme.md

```

## Swagger workarounds

### Add nullable annotations

``` yaml
directive:
  from: swagger-document
  where: $.definitions.CloudEventEvent
  transform: >
    $.properties.data["x-nullable"] = true;
````

### Append `EventData` suffix to Resource Manager system event data models

``` yaml
directive:
- from: swagger-document
  where: $.definitions
  transform: >
    $.ResourceActionCancelData["x-ms-client-name"] = "ResourceActionCancelEventData";
    $.ResourceActionFailureData["x-ms-client-name"] = "ResourceActionFailureEventData";
    $.ResourceActionSuccessData["x-ms-client-name"] = "ResourceActionSuccessEventData";
    $.ResourceDeleteCancelData["x-ms-client-name"] = "ResourceDeleteCancelEventData";
    $.ResourceDeleteFailureData["x-ms-client-name"] = "ResourceDeleteFailureEventData";
    $.ResourceDeleteSuccessData["x-ms-client-name"] = "ResourceDeleteSuccessEventData";
    $.ResourceWriteCancelData["x-ms-client-name"] = "ResourceWriteCancelEventData";
    $.ResourceWriteFailureData["x-ms-client-name"] = "ResourceWriteFailureEventData";
    $.ResourceWriteSuccessData["x-ms-client-name"] = "ResourceWriteSuccessEventData";
```

### Apply converters and update namespace for system event data models
``` yaml
directive:
- from: swagger-document
  where: $.definitions
  transform: >
    const namespace = "Azure.Messaging.EventGrid.SystemEvents";
    for (var path in $)
    {
      if (!path.includes("CloudEvent") && !path.includes("EventGridEvent"))
      {
        $[path]["x-namespace"] = namespace;
      }
      if (path.endsWith("EventData") || 
          path.endsWith("SubscriptionValidationResponse") || 
          path.includes("EventGridEvent") || 
         ($[path]["x-ms-client-name"] && $[path]["x-ms-client-name"].endsWith("EventData")))
      {
        $[path]["x-csharp-usage"] = "model,output,converter";
      }
      $[path]["x-csharp-formats"] = "json";
      if (path.includes("WebAppServicePlanUpdatedEventData"))
      {
          $[path]["properties"]["sku"]["x-namespace"] = namespace;
          $[path]["properties"]["sku"]["x-csharp-formats"] = "json";
      }
      if (path.includes("DeviceTwinInfo"))
      {
          $[path]["properties"]["properties"]["x-namespace"] = namespace;
          $[path]["properties"]["properties"]["x-csharp-formats"] = "json";
          $[path]["properties"]["x509Thumbprint"]["x-namespace"] = namespace;
          $[path]["properties"]["x509Thumbprint"]["x-csharp-formats"] = "json";
      }
    }
```
