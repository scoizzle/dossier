# Fact deab228e

Store id: 5d00e80e-bc73-44aa-b640-6ad6b87c0d38

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
- posted_at: `2026-11-09T23:32:02.9645770+00:00`

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
  "id": "5d00e80e-bc73-44aa-b640-6ad6b87c0d38",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.9645770+00:00"
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
  "subject_id": "3f3f05ae-63eb-4af0-945f-1512aba4c05c",
  "subject_name": "django/db/models/indexes::IndexExpression.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
