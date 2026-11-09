# Fact 94d28358

Store id: febd2222-c668-4cfc-b89c-fd3b928fe280

## Text

```text
def get_db_converters(self, connection)
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
- posted_at: `2026-11-09T23:32:07.6936070+00:00`

## Data

```json
{
  "end_line": 311,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 310,
  "symbol": "WhereNode.get_db_converters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":310,"selector":"L310-L311","symbol":"WhereNode.get_db_converters"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.get_db_converters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 311,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 310,
    "symbol": "WhereNode.get_db_converters"
  },
  "id": "febd2222-c668-4cfc-b89c-fd3b928fe280",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.6936070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 310,
        "selector": "L310-L311",
        "symbol": "WhereNode.get_db_converters"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "02c796aa-2bac-41e4-8e8a-a26b797990fd",
  "subject_name": "django/db/models/sql/where::WhereNode.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
