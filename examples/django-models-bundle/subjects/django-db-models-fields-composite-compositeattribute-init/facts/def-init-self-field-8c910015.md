# Fact 8c910015

Store id: 6fa3d9bc-792d-45bc-ad52-109eb08e279d

## Text

```text
def __init__(self, field)
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
- posted_at: `2026-11-09T23:31:57.1083150+00:00`

## Data

```json
{
  "end_line": 25,
  "entity_kind": "method",
  "parent": "CompositeAttribute",
  "start_line": 24,
  "symbol": "CompositeAttribute.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":24,"selector":"L24-L25","symbol":"CompositeAttribute.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositeAttribute.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 25,
    "entity_kind": "method",
    "parent": "CompositeAttribute",
    "start_line": 24,
    "symbol": "CompositeAttribute.__init__"
  },
  "id": "6fa3d9bc-792d-45bc-ad52-109eb08e279d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1083150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 24,
        "selector": "L24-L25",
        "symbol": "CompositeAttribute.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "9197b744-6b83-43c3-97fa-71d8765607e9",
  "subject_name": "django/db/models/fields/composite::CompositeAttribute.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, field)"
}
```
