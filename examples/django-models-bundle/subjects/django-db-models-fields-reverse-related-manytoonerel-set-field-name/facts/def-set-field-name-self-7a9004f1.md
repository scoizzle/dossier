# Fact 7a9004f1

Store id: cc5ba841-d539-4117-87db-89ace3cd9e7f

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
- posted_at: `2026-11-09T22:39:45.3790330+00:00`

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
  "id": "cc5ba841-d539-4117-87db-89ace3cd9e7f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3790330+00:00"
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
  "subject_id": "09a37bb4-7a8b-4932-b6a3-02d9f3ad168b",
  "subject_name": "django/db/models/fields/reverse_related::ManyToOneRel.set_field_name",
  "tags": [
    "entity:method"
  ],
  "text": "def set_field_name(self)"
}
```
