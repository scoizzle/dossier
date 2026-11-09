# Fact 15e0898d

Store id: 6bf2f9d7-08f0-4e16-8ecc-991d3e4a6990

## Text

```text
def get_compiler(self, using=None, connection=None, elide_empty=True)
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
- posted_at: `2026-11-09T23:32:06.7703120+00:00`

## Data

```json
{
  "end_line": 376,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 369,
  "symbol": "Query.get_compiler"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":369,"selector":"L369-L376","symbol":"Query.get_compiler"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.get_compiler](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 376,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 369,
    "symbol": "Query.get_compiler"
  },
  "id": "6bf2f9d7-08f0-4e16-8ecc-991d3e4a6990",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.7703120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 369,
        "selector": "L369-L376",
        "symbol": "Query.get_compiler"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "621ad298-6beb-47b0-8b73-1819c45f6964",
  "subject_name": "django/db/models/sql/query::Query.get_compiler",
  "tags": [
    "entity:method"
  ],
  "text": "def get_compiler(self, using=None, connection=None, elide_empty=True)"
}
```
