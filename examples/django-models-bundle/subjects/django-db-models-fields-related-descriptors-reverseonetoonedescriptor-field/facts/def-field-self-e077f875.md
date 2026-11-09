# Fact e077f875

Store id: 27a1ad7a-c383-4c0b-840b-34808ad5b488

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
- posted_at: `2026-11-09T23:31:59.1981120+00:00`

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
  "id": "27a1ad7a-c383-4c0b-840b-34808ad5b488",
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
    "posted_at": "2026-11-09T23:31:59.1981120+00:00"
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
  "subject_id": "4cdc44f6-de8a-45c5-8947-62828081932f",
  "subject_name": "django/db/models/fields/related_descriptors::ReverseOneToOneDescriptor.field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def field(self)"
}
```
