# Fact d1ca699b

Store id: aaa18ef3-ea76-45da-b221-6e953a79453a

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
- posted_at: `2026-11-09T23:31:54.2977600+00:00`

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
  "id": "aaa18ef3-ea76-45da-b221-6e953a79453a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.2977600+00:00"
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
  "subject_id": "316db4a9-3098-4209-bfc7-00d0d45a48e4",
  "subject_name": "django/db/models/constraints::UniqueConstraint.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
