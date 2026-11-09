# Fact 212d241b

Store id: 7811ec8c-7372-42b5-a997-f58b8ec04bd3

## Text

```text
def __radd__(self, other)
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
- posted_at: `2026-11-09T22:39:41.4834200+00:00`

## Data

```json
{
  "end_line": 134,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 133,
  "symbol": "Combinable.__radd__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":133,"selector":"L133-L134","symbol":"Combinable.__radd__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__radd__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 134,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 133,
    "symbol": "Combinable.__radd__"
  },
  "id": "7811ec8c-7372-42b5-a997-f58b8ec04bd3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4834200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 133,
        "selector": "L133-L134",
        "symbol": "Combinable.__radd__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "86037437-726b-480c-9aa7-59d51ce7acda",
  "subject_name": "django/db/models/expressions::Combinable.__radd__",
  "tags": [
    "entity:method"
  ],
  "text": "def __radd__(self, other)"
}
```
