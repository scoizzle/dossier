# Fact 431ab815

Store id: bbfccf1a-160d-4c7e-b7d8-cd3b4eb237e4

## Text

```text
def is_not_a_generic_relation(f)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.5294980+00:00`

## Data

```json
{
  "end_line": 553,
  "entity_kind": "function",
  "parent": "Options.fields",
  "start_line": 552,
  "symbol": "Options.fields.is_not_a_generic_relation"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":552,"selector":"L552-L553","symbol":"Options.fields.is_not_a_generic_relation"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.fields.is_not_a_generic_relation](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 553,
    "entity_kind": "function",
    "parent": "Options.fields",
    "start_line": 552,
    "symbol": "Options.fields.is_not_a_generic_relation"
  },
  "id": "bbfccf1a-160d-4c7e-b7d8-cd3b4eb237e4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5294980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 552,
        "selector": "L552-L553",
        "symbol": "Options.fields.is_not_a_generic_relation"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "9f38be58-7d6b-4804-9083-cb8d41cf71be",
  "subject_name": "django/db/models/options::Options.fields.is_not_a_generic_relation",
  "tags": [
    "entity:function"
  ],
  "text": "def is_not_a_generic_relation(f)"
}
```
