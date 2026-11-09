# Fact 52bb49b2

Store id: 6d89f464-8449-44f4-b9f7-fc9debbf6361

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
- posted_at: `2026-11-09T23:44:51.9531920+00:00`

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
  "id": "6d89f464-8449-44f4-b9f7-fc9debbf6361",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9531920+00:00"
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
  "subject_id": "85febc15-3b5b-4882-bf54-7a62d1a78c70",
  "subject_name": "django/db/models/fields/related_descriptors::ManyToManyDescriptor.through",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def through(self)"
}
```
