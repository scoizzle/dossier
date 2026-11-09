# Fact d1ca699b

Store id: 7f92f463-9ce9-4ba1-bcc2-f5caa55b815b

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T22:39:40.7304260+00:00`

## Data

```json
{
  "end_line": 576,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 562,
  "symbol": "UniqueConstraint.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":562,"selector":"L562-L576","symbol":"UniqueConstraint.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 576,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 562,
    "symbol": "UniqueConstraint.deconstruct"
  },
  "id": "7f92f463-9ce9-4ba1-bcc2-f5caa55b815b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7304260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 562,
        "selector": "L562-L576",
        "symbol": "UniqueConstraint.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "0f3639c5-ca45-4d98-b5bf-ddf960362dde",
  "subject_name": "django/db/models/constraints::UniqueConstraint.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
