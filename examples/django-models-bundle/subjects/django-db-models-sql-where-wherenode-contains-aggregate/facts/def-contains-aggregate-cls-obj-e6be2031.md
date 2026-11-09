# Fact e6be2031

Store id: eb2f5422-4cd7-4557-955f-bc1249458eb4

## Text

```text
def _contains_aggregate(cls, obj)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:59.7549090+00:00`

## Data

```json
{
  "end_line": 250,
  "entity_kind": "class_method",
  "parent": "WhereNode",
  "start_line": 246,
  "symbol": "WhereNode._contains_aggregate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":246,"selector":"L246-L250","symbol":"WhereNode._contains_aggregate"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode._contains_aggregate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 250,
    "entity_kind": "class_method",
    "parent": "WhereNode",
    "start_line": 246,
    "symbol": "WhereNode._contains_aggregate"
  },
  "id": "eb2f5422-4cd7-4557-955f-bc1249458eb4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.7549090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 246,
        "selector": "L246-L250",
        "symbol": "WhereNode._contains_aggregate"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "ec31846d-182b-4ae3-b4c3-85b2d21e6a8c",
  "subject_name": "django/db/models/sql/where::WhereNode._contains_aggregate",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _contains_aggregate(cls, obj)"
}
```
