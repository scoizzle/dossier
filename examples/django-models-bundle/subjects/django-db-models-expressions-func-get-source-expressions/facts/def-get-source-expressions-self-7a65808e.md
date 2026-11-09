# Fact 7a65808e

Store id: 5690cd81-c9d0-4260-b039-0659d74946e8

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
- posted_at: `2026-11-09T23:31:55.8544800+00:00`

## Data

```json
{
  "end_line": 1092,
  "entity_kind": "method",
  "parent": "Func",
  "start_line": 1091,
  "symbol": "Func.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1091,"selector":"L1091-L1092","symbol":"Func.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Func.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1092,
    "entity_kind": "method",
    "parent": "Func",
    "start_line": 1091,
    "symbol": "Func.get_source_expressions"
  },
  "id": "5690cd81-c9d0-4260-b039-0659d74946e8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8544800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1091,
        "selector": "L1091-L1092",
        "symbol": "Func.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "db2b2c95-7732-4167-aa69-c4eb33fd2569",
  "subject_name": "django/db/models/expressions::Func.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
