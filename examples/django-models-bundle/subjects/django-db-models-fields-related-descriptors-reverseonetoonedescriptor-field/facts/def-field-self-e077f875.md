# Fact e077f875

Store id: 024f28c7-ba83-4ccb-9150-2f6a6a107810

## Text

```text
def field(self)
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
- posted_at: `2026-11-09T22:39:44.7581830+00:00`

## Data

```json
{
  "end_line": 557,
  "entity_kind": "method",
  "parent": "ReverseOneToOneDescriptor",
  "start_line": 551,
  "symbol": "ReverseOneToOneDescriptor.field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":551,"selector":"L551-L557","symbol":"ReverseOneToOneDescriptor.field"}`

## Items

```json
[
  {
    "text": "Add compatibility with the fetcher protocol. While self.related is not a field but a OneToOneRel, it quacks enough like a field to work.",
    "locator": {
      "line": 553
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 557,
    "entity_kind": "method",
    "parent": "ReverseOneToOneDescriptor",
    "start_line": 551,
    "symbol": "ReverseOneToOneDescriptor.field"
  },
  "id": "024f28c7-ba83-4ccb-9150-2f6a6a107810",
  "items": [
    {
      "locator": {
        "line": 553
      },
      "text": "Add compatibility with the fetcher protocol. While self.related is not a field but a OneToOneRel, it quacks enough like a field to work."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7581830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 551,
        "selector": "L551-L557",
        "symbol": "ReverseOneToOneDescriptor.field"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "eaec2ab7-d5ef-4a99-8f2b-2c51cc1150f9",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def field(self)"
}
```
