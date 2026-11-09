# Fact 74ca84e2

Store id: 28f118e9-4a82-4469-9cf9-a66f9006e8d2

## Text

```text
class JSONObject(Func)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:01.4735780+00:00`

## Data

```json
{
  "end_line": 124,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 68,
  "symbol": "JSONObject"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":68,"selector":"L68-L124","symbol":"JSONObject"}`

## Referenced by

None.

## Subject

[django/db/models/functions/json::JSONObject](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 124,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 68,
    "symbol": "JSONObject"
  },
  "id": "28f118e9-4a82-4469-9cf9-a66f9006e8d2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.4735780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 68,
        "selector": "L68-L124",
        "symbol": "JSONObject"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/json.py"
    }
  ],
  "status": "live",
  "subject_id": "90c9df14-9393-42d7-b096-7043dd702440",
  "subject_name": "django/db/models/functions/json::JSONObject",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONObject(Func)"
}
```
