# Fact 3c9fda5e

Store id: fa90d234-2301-4f84-91a8-ef6d144f4a83

## Text

```text
def add_field(self, field, private=False)
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
- posted_at: `2026-11-09T23:32:03.9288470+00:00`

## Data

```json
{
  "end_line": 373,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 340,
  "symbol": "Options.add_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":340,"selector":"L340-L373","symbol":"Options.add_field"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.add_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 373,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 340,
    "symbol": "Options.add_field"
  },
  "id": "fa90d234-2301-4f84-91a8-ef6d144f4a83",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9288470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 340,
        "selector": "L340-L373",
        "symbol": "Options.add_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "f1a52439-8861-4455-acee-8f416d1fc7fa",
  "subject_name": "django/db/models/options::Options.add_field",
  "tags": [
    "entity:method"
  ],
  "text": "def add_field(self, field, private=False)"
}
```
