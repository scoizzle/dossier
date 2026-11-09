# Fact 74ca84e2

Store id: 57092574-b15b-4ecf-8ae9-6d8be701ab3d

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
- posted_at: `2026-11-09T23:44:53.5476810+00:00`

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
  "id": "57092574-b15b-4ecf-8ae9-6d8be701ab3d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.5476810+00:00"
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
  "subject_id": "4d49c864-47d2-4f27-9ef7-754ea165c304",
  "subject_name": "django/db/models/functions/json::JSONObject",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONObject(Func)"
}
```
