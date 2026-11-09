# Fact 80bbf892

Store id: 1047c62a-836c-4a6e-8d9e-b81e0ea40669

## Text

```text
class IntegerGreaterThan(IntegerFieldOverflow, GreaterThan)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:IntegerField.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.3036980+00:00`

## Data

```json
{
  "end_line": 482,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 480,
  "symbol": "IntegerGreaterThan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":480,"selector":"L480-L482","symbol":"IntegerGreaterThan"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerGreaterThan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 482,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 480,
    "symbol": "IntegerGreaterThan"
  },
  "id": "1047c62a-836c-4a6e-8d9e-b81e0ea40669",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3036980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 480,
        "selector": "L480-L482",
        "symbol": "IntegerGreaterThan"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "5e0f80d7-dc43-4723-9c99-2dcba9e5797d",
  "subject_name": "django/db/models/lookups::IntegerGreaterThan",
  "tags": [
    "entity:class",
    "decorator:IntegerField.register_lookup"
  ],
  "text": "class IntegerGreaterThan(IntegerFieldOverflow, GreaterThan)"
}
```
