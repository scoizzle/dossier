# Fact 52bb49b2

Store id: ebf587db-6515-41fa-b168-8467450646c5

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
- posted_at: `2026-11-09T23:31:59.3167390+00:00`

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
  "id": "ebf587db-6515-41fa-b168-8467450646c5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.3167390+00:00"
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
  "subject_id": "60c57af0-c2a6-4714-9810-34d78038ea9d",
  "subject_name": "django/db/models/fields/related_descriptors::ManyToManyDescriptor.through",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def through(self)"
}
```
