# Fact 38baea1f

Store id: 734c8907-8a4c-419a-adaa-689a6b3c4fe5

## Text

```text
def _as_sql_parts(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:50.9626380+00:00`

## Data

```json
{
  "end_line": 214,
  "entity_kind": "method",
  "parent": "HasKeyLookup",
  "start_line": 190,
  "symbol": "HasKeyLookup._as_sql_parts"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":190,"selector":"L190-L214","symbol":"HasKeyLookup._as_sql_parts"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::HasKeyLookup._as_sql_parts](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 214,
    "entity_kind": "method",
    "parent": "HasKeyLookup",
    "start_line": 190,
    "symbol": "HasKeyLookup._as_sql_parts"
  },
  "id": "734c8907-8a4c-419a-adaa-689a6b3c4fe5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9626380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 190,
        "selector": "L190-L214",
        "symbol": "HasKeyLookup._as_sql_parts"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "a948266e-a05e-41c9-bf78-5ddc5bfb4c10",
  "subject_name": "django/db/models/fields/json::HasKeyLookup._as_sql_parts",
  "tags": [
    "entity:method"
  ],
  "text": "def _as_sql_parts(self, compiler, connection)"
}
```
