# Fact ab51e9fa

Store id: 4dd86dc4-3342-4297-b6f2-0c01d4c881e7

## Text

```text
def _values(self, *fields, **expressions)
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
- posted_at: `2026-11-09T23:32:04.5162150+00:00`

## Data

```json
{
  "end_line": 1557,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1546,
  "symbol": "QuerySet._values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1546,"selector":"L1546-L1557","symbol":"QuerySet._values"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1557,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1546,
    "symbol": "QuerySet._values"
  },
  "id": "4dd86dc4-3342-4297-b6f2-0c01d4c881e7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5162150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1546,
        "selector": "L1546-L1557",
        "symbol": "QuerySet._values"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "9d70e2fc-87ef-40c5-bc3a-2a79c2362201",
  "subject_name": "django/db/models/query::QuerySet._values",
  "tags": [
    "entity:method"
  ],
  "text": "def _values(self, *fields, **expressions)"
}
```
