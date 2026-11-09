# Fact 183fdb43

Store id: 28043e33-724a-48e1-bf1d-88bb0df9a3ed

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T23:44:59.7165060+00:00`

## Data

```json
{
  "end_line": 197,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 196,
  "symbol": "WhereNode.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":196,"selector":"L196-L197","symbol":"WhereNode.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 197,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 196,
    "symbol": "WhereNode.get_source_expressions"
  },
  "id": "28043e33-724a-48e1-bf1d-88bb0df9a3ed",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.7165060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 196,
        "selector": "L196-L197",
        "symbol": "WhereNode.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "edc6a8c0-b5ec-4189-9d35-3f3ef14c8b09",
  "subject_name": "django/db/models/sql/where::WhereNode.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
