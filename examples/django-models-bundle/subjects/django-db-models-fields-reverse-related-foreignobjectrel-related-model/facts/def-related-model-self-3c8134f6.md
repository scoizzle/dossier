# Fact 3c8134f6

Store id: 8072181b-c38e-43d2-a1b3-72a46d2d13a8

## Text

```text
def related_model(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:00.2296870+00:00`

## Data

```json
{
  "end_line": 97,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 90,
  "symbol": "ForeignObjectRel.related_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":90,"selector":"L90-L97","symbol":"ForeignObjectRel.related_model"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.related_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 97,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 90,
    "symbol": "ForeignObjectRel.related_model"
  },
  "id": "8072181b-c38e-43d2-a1b3-72a46d2d13a8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2296870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 90,
        "selector": "L90-L97",
        "symbol": "ForeignObjectRel.related_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "2a4e1b0a-235f-4140-8ae7-a8aab9c9699c",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.related_model",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def related_model(self)"
}
```
