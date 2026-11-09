# Fact 431ab815

Store id: c0b5723c-6027-4f07-a22b-b8d1a992d114

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
- posted_at: `2026-11-09T22:39:48.8428670+00:00`

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
  "id": "c0b5723c-6027-4f07-a22b-b8d1a992d114",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.8428670+00:00"
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
  "subject_id": "077369a2-9e65-4acd-ab27-5094c5a410be",
  "subject_name": "django/db/models/options::Options.fields.is_not_a_generic_relation",
  "tags": [
    "entity:function"
  ],
  "text": "def is_not_a_generic_relation(f)"
}
```
