# Fact deab228e

Store id: 4c2a60d2-6977-48c7-b08e-c0398cb4d241

## Text

```text
def as_sqlite(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:47.8238140+00:00`

## Data

```json
{
  "end_line": 391,
  "entity_kind": "method",
  "parent": "IndexExpression",
  "start_line": 389,
  "symbol": "IndexExpression.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":389,"selector":"L389-L391","symbol":"IndexExpression.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::IndexExpression.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 391,
    "entity_kind": "method",
    "parent": "IndexExpression",
    "start_line": 389,
    "symbol": "IndexExpression.as_sqlite"
  },
  "id": "4c2a60d2-6977-48c7-b08e-c0398cb4d241",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.8238140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 389,
        "selector": "L389-L391",
        "symbol": "IndexExpression.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "87a26037-b389-47f2-95bd-255596fd1a1c",
  "subject_name": "django/db/models/indexes::IndexExpression.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
