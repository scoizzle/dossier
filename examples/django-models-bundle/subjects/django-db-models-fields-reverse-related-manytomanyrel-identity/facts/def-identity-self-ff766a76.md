# Fact ff766a76

Store id: e48faf16-22a5-4b12-9ee3-8ecf92700041

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
- posted_at: `2026-11-09T22:39:45.3919780+00:00`

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
  "id": "e48faf16-22a5-4b12-9ee3-8ecf92700041",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3919780+00:00"
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
  "subject_id": "d2ec4e4b-bb37-4c4b-b974-66cb8defdc13",
  "subject_name": "django/db/models/fields/reverse_related::ManyToManyRel.identity",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def identity(self)"
}
```
