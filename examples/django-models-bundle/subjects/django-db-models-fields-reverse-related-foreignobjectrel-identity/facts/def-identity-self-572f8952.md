# Fact 572f8952

Store id: 64472296-8492-4464-88ca-61f6fc236416

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
- posted_at: `2026-11-09T22:39:45.3340160+00:00`

## Data

```json
{
  "end_line": 150,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 138,
  "symbol": "ForeignObjectRel.identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":138,"selector":"L138-L150","symbol":"ForeignObjectRel.identity"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 150,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 138,
    "symbol": "ForeignObjectRel.identity"
  },
  "id": "64472296-8492-4464-88ca-61f6fc236416",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3340160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 138,
        "selector": "L138-L150",
        "symbol": "ForeignObjectRel.identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "008d10e6-c7b1-40ec-9dc2-9f0aaf5fe2c9",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.identity",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def identity(self)"
}
```
