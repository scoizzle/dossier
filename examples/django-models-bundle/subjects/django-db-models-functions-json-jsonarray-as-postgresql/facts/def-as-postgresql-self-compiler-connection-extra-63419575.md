# Fact 63419575

Store id: a7c61e7e-9b1d-48c6-9ec2-05a9ec62a2e3

## Text

```text
def as_postgresql(self, compiler, connection, **extra_context)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:46.3734020+00:00`

## Data

```json
{
  "end_line": 62,
  "entity_kind": "method",
  "parent": "JSONArray",
  "start_line": 35,
  "symbol": "JSONArray.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":35,"selector":"L35-L62","symbol":"JSONArray.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/json::JSONArray.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 62,
    "entity_kind": "method",
    "parent": "JSONArray",
    "start_line": 35,
    "symbol": "JSONArray.as_postgresql"
  },
  "id": "a7c61e7e-9b1d-48c6-9ec2-05a9ec62a2e3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.3734020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 35,
        "selector": "L35-L62",
        "symbol": "JSONArray.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/json.py"
    }
  ],
  "status": "live",
  "subject_id": "90e0dd41-2091-4b79-b9ec-211f3440c7da",
  "subject_name": "django/db/models/functions/json::JSONArray.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
