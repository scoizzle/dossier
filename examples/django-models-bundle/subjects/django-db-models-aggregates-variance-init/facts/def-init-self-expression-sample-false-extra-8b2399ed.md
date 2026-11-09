# Fact 8b2399ed

Store id: b5fbdb81-ffda-44bd-8508-3de08537c9fb

## Text

```text
def __init__(self, expression, sample=False, **extra)
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
- posted_at: `2026-11-09T22:39:40.0494540+00:00`

## Data

```json
{
  "end_line": 465,
  "entity_kind": "method",
  "parent": "Variance",
  "start_line": 463,
  "symbol": "Variance.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":463,"selector":"L463-L465","symbol":"Variance.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Variance.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 465,
    "entity_kind": "method",
    "parent": "Variance",
    "start_line": 463,
    "symbol": "Variance.__init__"
  },
  "id": "b5fbdb81-ffda-44bd-8508-3de08537c9fb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0494540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 463,
        "selector": "L463-L465",
        "symbol": "Variance.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "b06b238a-a08a-4afb-a9e0-4fd41e2c154a",
  "subject_name": "django/db/models/aggregates::Variance.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, sample=False, **extra)"
}
```
