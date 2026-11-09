# Fact 74ca84e2

Store id: 7fee0ed1-5c4f-42f9-96a2-951c5892b732

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
- posted_at: `2026-11-09T22:39:46.3782470+00:00`

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
  "id": "7fee0ed1-5c4f-42f9-96a2-951c5892b732",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.3782470+00:00"
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
  "subject_id": "9e827d32-8f1b-44a6-92c0-f21f7cd0bec2",
  "subject_name": "django/db/models/functions/json::JSONObject",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONObject(Func)"
}
```
