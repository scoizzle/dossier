# Fact 52bb49b2

Store id: 19ea2a3e-46b3-4e58-a0ef-f0a5364c59e7

## Text

```text
def through(self)
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
- posted_at: `2026-11-09T22:39:44.8435020+00:00`

## Data

```json
{
  "end_line": 1055,
  "entity_kind": "method",
  "parent": "ManyToManyDescriptor",
  "start_line": 1050,
  "symbol": "ManyToManyDescriptor.through"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1050,"selector":"L1050-L1055","symbol":"ManyToManyDescriptor.through"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ManyToManyDescriptor.through](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1055,
    "entity_kind": "method",
    "parent": "ManyToManyDescriptor",
    "start_line": 1050,
    "symbol": "ManyToManyDescriptor.through"
  },
  "id": "19ea2a3e-46b3-4e58-a0ef-f0a5364c59e7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.8435020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1050,
        "selector": "L1050-L1055",
        "symbol": "ManyToManyDescriptor.through"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "92a38840-7668-4b81-b833-e5835fb2082b",
  "subject_name": "django/db/models/fields/related_descriptors::ManyToManyDescriptor.through",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def through(self)"
}
```
