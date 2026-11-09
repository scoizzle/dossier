# Fact df7b97c4

Store id: 46798ecd-9854-4b02-86a6-bccbf919489f

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:31:54.2737380+00:00`

## Data

```json
{
  "end_line": 544,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 518,
  "symbol": "UniqueConstraint.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":518,"selector":"L518-L544","symbol":"UniqueConstraint.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 544,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 518,
    "symbol": "UniqueConstraint.__repr__"
  },
  "id": "46798ecd-9854-4b02-86a6-bccbf919489f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.2737380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 518,
        "selector": "L518-L544",
        "symbol": "UniqueConstraint.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "5d2a28e3-cfbe-414a-8c87-82f2c1c466d0",
  "subject_name": "django/db/models/constraints::UniqueConstraint.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
