# Fact ff766a76

Store id: c6ec6542-b14e-4385-8319-ec5950f029e4

## Text

```text
def identity(self)
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
- posted_at: `2026-11-09T23:32:00.3526580+00:00`

## Data

```json
{
  "end_line": 392,
  "entity_kind": "method",
  "parent": "ManyToManyRel",
  "start_line": 385,
  "symbol": "ManyToManyRel.identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":385,"selector":"L385-L392","symbol":"ManyToManyRel.identity"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ManyToManyRel.identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 392,
    "entity_kind": "method",
    "parent": "ManyToManyRel",
    "start_line": 385,
    "symbol": "ManyToManyRel.identity"
  },
  "id": "c6ec6542-b14e-4385-8319-ec5950f029e4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.3526580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 385,
        "selector": "L385-L392",
        "symbol": "ManyToManyRel.identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "639be30d-ea52-4cce-9849-85cdbfa5ad71",
  "subject_name": "django/db/models/fields/reverse_related::ManyToManyRel.identity",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def identity(self)"
}
```
