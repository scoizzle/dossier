# Fact 82239a4f

Store id: 952557e1-b831-4a02-9102-b4dbc2e68bc3

## Text

```text
class ReverseManyToOneDescriptor
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
- posted_at: `2026-11-09T23:44:51.8878380+00:00`

## Data

```json
{
  "end_line": 711,
  "entity_kind": "class",
  "parent": "related_descriptors",
  "start_line": 657,
  "symbol": "ReverseManyToOneDescriptor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":657,"selector":"L657-L711","symbol":"ReverseManyToOneDescriptor"}`

## Items

```json
[
  {
    "text": "Accessor to the related objects manager on the reverse side of a many-to-one relation.",
    "locator": {
      "line": 658
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 711,
    "entity_kind": "class",
    "parent": "related_descriptors",
    "start_line": 657,
    "symbol": "ReverseManyToOneDescriptor"
  },
  "id": "952557e1-b831-4a02-9102-b4dbc2e68bc3",
  "items": [
    {
      "locator": {
        "line": 658
      },
      "text": "Accessor to the related objects manager on the reverse side of a many-to-one relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8878380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 657,
        "selector": "L657-L711",
        "symbol": "ReverseManyToOneDescriptor"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "c9c6a087-a6bc-4ed6-b201-912442b4c332",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseManyToOneDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class ReverseManyToOneDescriptor"
}
```
