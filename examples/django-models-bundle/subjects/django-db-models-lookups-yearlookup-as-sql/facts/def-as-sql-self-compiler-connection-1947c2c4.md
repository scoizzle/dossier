# Fact 1947c2c4

Store id: 77fdcbba-e1bc-4ba4-a520-70fece62db0e

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
- posted_at: `2026-11-09T23:32:03.4170170+00:00`

## Data

```json
{
  "end_line": 742,
  "entity_kind": "method",
  "parent": "YearLookup",
  "start_line": 730,
  "symbol": "YearLookup.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":730,"selector":"L730-L742","symbol":"YearLookup.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::YearLookup.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 742,
    "entity_kind": "method",
    "parent": "YearLookup",
    "start_line": 730,
    "symbol": "YearLookup.as_sql"
  },
  "id": "77fdcbba-e1bc-4ba4-a520-70fece62db0e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.4170170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 730,
        "selector": "L730-L742",
        "symbol": "YearLookup.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "cccd9a50-8de9-4e56-8cb1-cb62af2761f9",
  "subject_name": "django/db/models/lookups::YearLookup.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
