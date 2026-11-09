# Fact 8fec1c8b

Store id: 4ee08cf5-5f0d-4de4-af55-260798eea96c

## Text

```text
def as_sql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:01.4841920+00:00`

## Data

```json
{
  "end_line": 83,
  "entity_kind": "method",
  "parent": "JSONObject",
  "start_line": 78,
  "symbol": "JSONObject.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":78,"selector":"L78-L83","symbol":"JSONObject.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/json::JSONObject.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 83,
    "entity_kind": "method",
    "parent": "JSONObject",
    "start_line": 78,
    "symbol": "JSONObject.as_sql"
  },
  "id": "4ee08cf5-5f0d-4de4-af55-260798eea96c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.4841920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 78,
        "selector": "L78-L83",
        "symbol": "JSONObject.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/json.py"
    }
  ],
  "status": "live",
  "subject_id": "dfdc977f-e978-426a-82a9-638020b821b1",
  "subject_name": "django/db/models/functions/json::JSONObject.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
