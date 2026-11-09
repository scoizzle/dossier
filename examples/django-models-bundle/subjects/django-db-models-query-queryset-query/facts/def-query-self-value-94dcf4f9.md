# Fact 94dcf4f9

Store id: 56610202-47d0-4a15-9a5a-58c4391e8600

## Text

```text
def query(self, value)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:query.setter`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.2943810+00:00`

## Data

```json
{
  "end_line": 397,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 393,
  "symbol": "QuerySet.query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":393,"selector":"L393-L397","symbol":"QuerySet.query"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 397,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 393,
    "symbol": "QuerySet.query"
  },
  "id": "56610202-47d0-4a15-9a5a-58c4391e8600",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.2943810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 393,
        "selector": "L393-L397",
        "symbol": "QuerySet.query"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c2c1e427-4d28-4d21-95f3-4bc57a14f5be",
  "subject_name": "django/db/models/query::QuerySet.query",
  "tags": [
    "entity:method",
    "decorator:query.setter"
  ],
  "text": "def query(self, value)"
}
```
