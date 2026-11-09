# Fact 2a6d9b59

Store id: a3f6c91e-4bdf-45d9-8426-0d3fac45d845

## Text

```text
class ASin(NumericOutputFieldMixin, Transform)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:53.6900310+00:00`

## Data

```json
{
  "end_line": 25,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 23,
  "symbol": "ASin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":23,"selector":"L23-L25","symbol":"ASin"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::ASin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 25,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 23,
    "symbol": "ASin"
  },
  "id": "a3f6c91e-4bdf-45d9-8426-0d3fac45d845",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.6900310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 23,
        "selector": "L23-L25",
        "symbol": "ASin"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "8cdce2a8-606e-4b57-8653-7b8f58fbaf8e",
  "subject_name": "django/db/models/functions/math::ASin",
  "tags": [
    "entity:class"
  ],
  "text": "class ASin(NumericOutputFieldMixin, Transform)"
}
```
