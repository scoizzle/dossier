# Fact 64ffc014

Store id: daedd90e-3f3c-4c18-8daa-24eb1d699982

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:57.8677630+00:00`

## Data

```json
{
  "end_line": 165,
  "entity_kind": "method",
  "parent": "DataContains",
  "start_line": 157,
  "symbol": "DataContains.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":157,"selector":"L157-L165","symbol":"DataContains.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::DataContains.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 165,
    "entity_kind": "method",
    "parent": "DataContains",
    "start_line": 157,
    "symbol": "DataContains.as_sql"
  },
  "id": "daedd90e-3f3c-4c18-8daa-24eb1d699982",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8677630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 157,
        "selector": "L157-L165",
        "symbol": "DataContains.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "aa88012a-4256-4fc9-a76f-6c4c2dc420ac",
  "subject_name": "django/db/models/fields/json::DataContains.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
