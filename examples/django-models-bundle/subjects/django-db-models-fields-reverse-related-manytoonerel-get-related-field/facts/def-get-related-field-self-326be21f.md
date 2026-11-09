# Fact 326be21f

Store id: e000c155-13e9-4a66-bdf1-c32a861a50bb

## Text

```text
def get_related_field(self)
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
- posted_at: `2026-11-09T23:32:00.3332750+00:00`

## Data

```json
{
  "end_line": 307,
  "entity_kind": "method",
  "parent": "ManyToOneRel",
  "start_line": 298,
  "symbol": "ManyToOneRel.get_related_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":298,"selector":"L298-L307","symbol":"ManyToOneRel.get_related_field"}`

## Items

```json
[
  {
    "text": "Return the Field in the 'to' object to which this relationship is tied.",
    "locator": {
      "line": 299
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ManyToOneRel.get_related_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 307,
    "entity_kind": "method",
    "parent": "ManyToOneRel",
    "start_line": 298,
    "symbol": "ManyToOneRel.get_related_field"
  },
  "id": "e000c155-13e9-4a66-bdf1-c32a861a50bb",
  "items": [
    {
      "locator": {
        "line": 299
      },
      "text": "Return the Field in the 'to' object to which this relationship is tied."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.3332750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 298,
        "selector": "L298-L307",
        "symbol": "ManyToOneRel.get_related_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "808fbf1b-5077-4d97-8841-924e627aea8c",
  "subject_name": "django/db/models/fields/reverse_related::ManyToOneRel.get_related_field",
  "tags": [
    "entity:method"
  ],
  "text": "def get_related_field(self)"
}
```
