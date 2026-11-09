# Fact c6579d48

Store id: 1190f250-3f58-4210-86e8-b2b060449677

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
- posted_at: `2026-11-09T23:32:06.4965330+00:00`

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
  "id": "1190f250-3f58-4210-86e8-b2b060449677",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.4965330+00:00"
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
  "subject_id": "b0bee04b-7756-4f31-9a64-9f511ef8f446",
  "subject_name": "django/db/models/sql/datastructures::BaseTable.identity",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def identity(self)"
}
```
