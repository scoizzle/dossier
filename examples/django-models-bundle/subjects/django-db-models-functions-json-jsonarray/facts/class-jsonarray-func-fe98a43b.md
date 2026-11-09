# Fact fe98a43b

Store id: e03d061b-562b-4b20-9087-a24ba4728d79

## Text

```text
class JSONArray(Func)
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
- posted_at: `2026-11-09T23:32:01.4462190+00:00`

## Data

```json
{
  "end_line": 65,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 8,
  "symbol": "JSONArray"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":8,"selector":"L8-L65","symbol":"JSONArray"}`

## Referenced by

None.

## Subject

[django/db/models/functions/json::JSONArray](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 65,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 8,
    "symbol": "JSONArray"
  },
  "id": "e03d061b-562b-4b20-9087-a24ba4728d79",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.4462190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 8,
        "selector": "L8-L65",
        "symbol": "JSONArray"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/json.py"
    }
  ],
  "status": "live",
  "subject_id": "bb6fd098-b015-40b3-965d-347c4d120d3e",
  "subject_name": "django/db/models/functions/json::JSONArray",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONArray(Func)"
}
```
