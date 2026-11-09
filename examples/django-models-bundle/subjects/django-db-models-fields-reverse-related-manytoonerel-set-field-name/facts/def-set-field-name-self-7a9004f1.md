# Fact 7a9004f1

Store id: deaa391c-44a8-4b52-ab47-7c6c2b6a6afb

## Text

```text
def set_field_name(self)
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
- posted_at: `2026-11-09T23:32:00.3373040+00:00`

## Data

```json
{
  "end_line": 310,
  "entity_kind": "method",
  "parent": "ManyToOneRel",
  "start_line": 309,
  "symbol": "ManyToOneRel.set_field_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":309,"selector":"L309-L310","symbol":"ManyToOneRel.set_field_name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ManyToOneRel.set_field_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 310,
    "entity_kind": "method",
    "parent": "ManyToOneRel",
    "start_line": 309,
    "symbol": "ManyToOneRel.set_field_name"
  },
  "id": "deaa391c-44a8-4b52-ab47-7c6c2b6a6afb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.3373040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 309,
        "selector": "L309-L310",
        "symbol": "ManyToOneRel.set_field_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "39d1a9df-2a63-4d83-a031-35d0f7e9d773",
  "subject_name": "django/db/models/fields/reverse_related::ManyToOneRel.set_field_name",
  "tags": [
    "entity:method"
  ],
  "text": "def set_field_name(self)"
}
```
