# Fact 2387f19d

Store id: 6c0b1e3b-3355-4baa-81f7-5812cfe427c4

## Text

```text
def __pow__(self, other)
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
- posted_at: `2026-11-09T23:44:49.2452470+00:00`

## Data

```json
{
  "end_line": 95,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 94,
  "symbol": "Combinable.__pow__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":94,"selector":"L94-L95","symbol":"Combinable.__pow__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__pow__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 95,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 94,
    "symbol": "Combinable.__pow__"
  },
  "id": "6c0b1e3b-3355-4baa-81f7-5812cfe427c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2452470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 94,
        "selector": "L94-L95",
        "symbol": "Combinable.__pow__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "0133de2c-066b-4fac-98d6-a29210737926",
  "subject_name": "django/db/models/expressions::Combinable.__pow__",
  "tags": [
    "entity:method"
  ],
  "text": "def __pow__(self, other)"
}
```
