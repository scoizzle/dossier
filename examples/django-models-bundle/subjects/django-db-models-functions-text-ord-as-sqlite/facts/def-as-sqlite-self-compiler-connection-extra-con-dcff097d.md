# Fact dcff097d

Store id: 55f71fa4-5cff-4d13-ac94-63c644413ced

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
- posted_at: `2026-11-09T22:39:47.1403310+00:00`

## Data

```json
{
  "end_line": 230,
  "entity_kind": "method",
  "parent": "Ord",
  "start_line": 229,
  "symbol": "Ord.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":229,"selector":"L229-L230","symbol":"Ord.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Ord.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 230,
    "entity_kind": "method",
    "parent": "Ord",
    "start_line": 229,
    "symbol": "Ord.as_sqlite"
  },
  "id": "55f71fa4-5cff-4d13-ac94-63c644413ced",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1403310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 229,
        "selector": "L229-L230",
        "symbol": "Ord.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "f7124c1b-6f75-409e-814d-deb4e063de33",
  "subject_name": "django/db/models/functions/text::Ord.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
