# Fact 749bd1ba

Store id: 19de99bd-4b4d-4136-bd85-4f007e07b8b6

## Text

```text
def __sub__(self, other)
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
- posted_at: `2026-11-09T23:44:49.2420780+00:00`

## Data

```json
{
  "end_line": 83,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 82,
  "symbol": "Combinable.__sub__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":82,"selector":"L82-L83","symbol":"Combinable.__sub__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__sub__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 83,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 82,
    "symbol": "Combinable.__sub__"
  },
  "id": "19de99bd-4b4d-4136-bd85-4f007e07b8b6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2420780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 82,
        "selector": "L82-L83",
        "symbol": "Combinable.__sub__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c0b01363-318c-49a6-8b74-3e7b3662499b",
  "subject_name": "django/db/models/expressions::Combinable.__sub__",
  "tags": [
    "entity:method"
  ],
  "text": "def __sub__(self, other)"
}
```
