# Fact 3f4fa109

Store id: f5ef7b54-27a8-4690-bfc0-7eb4916985f4

## Text

```text
def bitleftshift(self, other)
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
- posted_at: `2026-11-09T23:44:49.2473730+00:00`

## Data

```json
{
  "end_line": 108,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 107,
  "symbol": "Combinable.bitleftshift"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":107,"selector":"L107-L108","symbol":"Combinable.bitleftshift"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.bitleftshift](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 108,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 107,
    "symbol": "Combinable.bitleftshift"
  },
  "id": "f5ef7b54-27a8-4690-bfc0-7eb4916985f4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2473730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 107,
        "selector": "L107-L108",
        "symbol": "Combinable.bitleftshift"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "5b15acde-0c37-45e9-90b3-e8c224455b39",
  "subject_name": "django/db/models/expressions::Combinable.bitleftshift",
  "tags": [
    "entity:method"
  ],
  "text": "def bitleftshift(self, other)"
}
```
