# Fact 183fdb43

Store id: 643d1e73-fae1-4400-9aa8-0af744881fc2

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
- posted_at: `2026-11-09T23:32:07.6059540+00:00`

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
  "id": "643d1e73-fae1-4400-9aa8-0af744881fc2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.6059540+00:00"
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
  "subject_id": "f17385f3-1dea-4c4f-be8a-601350a4fa97",
  "subject_name": "django/db/models/sql/where::WhereNode.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
