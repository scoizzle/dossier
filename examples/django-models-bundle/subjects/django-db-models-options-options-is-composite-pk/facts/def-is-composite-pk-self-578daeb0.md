# Fact 578daeb0

Store id: a290d0a6-3a8e-4822-b1dc-e28d55cd1c71

## Text

```text
def is_composite_pk(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.0436200+00:00`

## Data

```json
{
  "end_line": 998,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 996,
  "symbol": "Options.is_composite_pk"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":996,"selector":"L996-L998","symbol":"Options.is_composite_pk"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.is_composite_pk](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 998,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 996,
    "symbol": "Options.is_composite_pk"
  },
  "id": "a290d0a6-3a8e-4822-b1dc-e28d55cd1c71",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.0436200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 996,
        "selector": "L996-L998",
        "symbol": "Options.is_composite_pk"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "b4b68e4b-6ec4-44ba-b10a-305099daba37",
  "subject_name": "django/db/models/options::Options.is_composite_pk",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def is_composite_pk(self)"
}
```
