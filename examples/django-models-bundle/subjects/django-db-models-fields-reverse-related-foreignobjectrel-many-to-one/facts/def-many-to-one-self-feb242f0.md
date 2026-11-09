# Fact feb242f0

Store id: 58951d6d-ded6-45e4-9f37-f160b54b63b1

## Text

```text
def many_to_one(self)
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
- posted_at: `2026-11-09T22:39:45.3017550+00:00`

## Data

```json
{
  "end_line": 105,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 103,
  "symbol": "ForeignObjectRel.many_to_one"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":103,"selector":"L103-L105","symbol":"ForeignObjectRel.many_to_one"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.many_to_one](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 105,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 103,
    "symbol": "ForeignObjectRel.many_to_one"
  },
  "id": "58951d6d-ded6-45e4-9f37-f160b54b63b1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3017550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 103,
        "selector": "L103-L105",
        "symbol": "ForeignObjectRel.many_to_one"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "36607cbe-6e2c-484a-a422-aac555536a6e",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.many_to_one",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def many_to_one(self)"
}
```
