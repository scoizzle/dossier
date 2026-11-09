# Fact fe98a43b

Store id: 99d2f245-ad4e-40ab-96c4-c75a01cdb598

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
- posted_at: `2026-11-09T23:44:53.5296880+00:00`

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
  "id": "99d2f245-ad4e-40ab-96c4-c75a01cdb598",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.5296880+00:00"
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
  "subject_id": "e969c87e-b451-434d-9ba3-482f2d73fc93",
  "subject_name": "django/db/models/functions/json::JSONArray",
  "tags": [
    "entity:class"
  ],
  "text": "class JSONArray(Func)"
}
```
