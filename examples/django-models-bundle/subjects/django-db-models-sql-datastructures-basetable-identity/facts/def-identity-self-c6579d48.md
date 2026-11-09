# Fact c6579d48

Store id: 6349f670-4756-4c2c-9a2b-40ffee001ad0

## Text

```text
def identity(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.0239810+00:00`

## Data

```json
{
  "end_line": 214,
  "entity_kind": "method",
  "parent": "BaseTable",
  "start_line": 212,
  "symbol": "BaseTable.identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/datastructures.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":212,"selector":"L212-L214","symbol":"BaseTable.identity"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures::BaseTable.identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 214,
    "entity_kind": "method",
    "parent": "BaseTable",
    "start_line": 212,
    "symbol": "BaseTable.identity"
  },
  "id": "6349f670-4756-4c2c-9a2b-40ffee001ad0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.0239810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 212,
        "selector": "L212-L214",
        "symbol": "BaseTable.identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/datastructures.py"
    }
  ],
  "status": "live",
  "subject_id": "7ac6040b-aec9-43c7-8c42-19c2aa752704",
  "subject_name": "django/db/models/sql/datastructures::BaseTable.identity",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def identity(self)"
}
```
