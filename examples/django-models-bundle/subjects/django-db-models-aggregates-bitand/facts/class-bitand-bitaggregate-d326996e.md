# Fact d326996e

Store id: 9ff47e64-439d-48fa-958c-c020eebdc429

## Text

```text
class BitAnd(BitAggregate)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.5378100+00:00`

## Data

```json
{
  "end_line": 282,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 280,
  "symbol": "BitAnd"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":280,"selector":"L280-L282","symbol":"BitAnd"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::BitAnd](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 282,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 280,
    "symbol": "BitAnd"
  },
  "id": "9ff47e64-439d-48fa-958c-c020eebdc429",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5378100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 280,
        "selector": "L280-L282",
        "symbol": "BitAnd"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "59034b6b-e582-4e87-962b-95a20fb03f2f",
  "subject_name": "django/db/models/aggregates::BitAnd",
  "tags": [
    "entity:class"
  ],
  "text": "class BitAnd(BitAggregate)"
}
```
