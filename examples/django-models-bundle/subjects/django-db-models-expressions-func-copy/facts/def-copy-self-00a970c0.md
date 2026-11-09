# Fact 00a970c0

Store id: 5cd5a174-f7d8-4eb4-afaa-dc018620b66a

## Text

```text
def copy(self)
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
- posted_at: `2026-11-09T23:44:49.5137450+00:00`

## Data

```json
{
  "end_line": 1140,
  "entity_kind": "method",
  "parent": "Func",
  "start_line": 1136,
  "symbol": "Func.copy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1136,"selector":"L1136-L1140","symbol":"Func.copy"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Func.copy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1140,
    "entity_kind": "method",
    "parent": "Func",
    "start_line": 1136,
    "symbol": "Func.copy"
  },
  "id": "5cd5a174-f7d8-4eb4-afaa-dc018620b66a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5137450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1136,
        "selector": "L1136-L1140",
        "symbol": "Func.copy"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "6d7614ce-6a6b-4399-a6c3-e39694ea01ff",
  "subject_name": "django/db/models/expressions::Func.copy",
  "tags": [
    "entity:method"
  ],
  "text": "def copy(self)"
}
```
