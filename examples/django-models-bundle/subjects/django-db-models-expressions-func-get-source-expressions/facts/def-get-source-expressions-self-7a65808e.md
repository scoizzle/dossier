# Fact 7a65808e

Store id: 85466cba-a7f7-423f-8f57-5a539dbbbf11

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
- posted_at: `2026-11-09T23:44:49.5115110+00:00`

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
  "id": "85466cba-a7f7-423f-8f57-5a539dbbbf11",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5115110+00:00"
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
  "subject_id": "25d1a0a6-b3fd-4e3b-a2f9-fc1c70a8c4ce",
  "subject_name": "django/db/models/expressions::Func.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
