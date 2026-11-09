# Fact 183fdb43

Store id: 3c4cce19-b4b6-4ed2-afb6-1f719c33a93b

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
- posted_at: `2026-11-09T22:39:51.9133790+00:00`

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
  "id": "3c4cce19-b4b6-4ed2-afb6-1f719c33a93b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9133790+00:00"
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
  "subject_id": "38fb4c18-3a1d-4471-954a-60eb0d55911e",
  "subject_name": "django/db/models/sql/where::WhereNode.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
