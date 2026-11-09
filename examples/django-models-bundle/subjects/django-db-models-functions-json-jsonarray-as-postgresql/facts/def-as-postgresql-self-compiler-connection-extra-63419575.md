# Fact 63419575

Store id: f5c95835-a674-4ab3-8d50-b3c673bd094b

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
- posted_at: `2026-11-09T23:44:53.5433930+00:00`

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
  "id": "f5c95835-a674-4ab3-8d50-b3c673bd094b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.5433930+00:00"
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
  "subject_id": "33a6cfc5-519b-4720-83f4-4eac58a1fe28",
  "subject_name": "django/db/models/functions/json::JSONArray.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
