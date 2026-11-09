# Fact 8956bcea

Store id: 87ad2fa7-7a2a-46a8-acb6-8d1702dfed4c

## Text

```text
def __ror__(self, other)
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
- posted_at: `2026-11-09T22:39:41.4930690+00:00`

## Data

```json
{
  "end_line": 159,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 156,
  "symbol": "Combinable.__ror__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":156,"selector":"L156-L159","symbol":"Combinable.__ror__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__ror__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 159,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 156,
    "symbol": "Combinable.__ror__"
  },
  "id": "87ad2fa7-7a2a-46a8-acb6-8d1702dfed4c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4930690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 156,
        "selector": "L156-L159",
        "symbol": "Combinable.__ror__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3e167c6a-955d-4d5c-b22e-8074872d143e",
  "subject_name": "django/db/models/expressions::Combinable.__ror__",
  "tags": [
    "entity:method"
  ],
  "text": "def __ror__(self, other)"
}
```
