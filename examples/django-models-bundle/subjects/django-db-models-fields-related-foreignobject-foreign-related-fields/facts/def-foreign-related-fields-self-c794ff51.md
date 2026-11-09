# Fact c794ff51

Store id: 86760b33-fbae-4dbd-914c-b1f7c9d838e1

## Text

```text
def foreign_related_fields(self)
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
- posted_at: `2026-11-09T22:39:44.3319620+00:00`

## Data

```json
{
  "end_line": 822,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 818,
  "symbol": "ForeignObject.foreign_related_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":818,"selector":"L818-L822","symbol":"ForeignObject.foreign_related_fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.foreign_related_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 822,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 818,
    "symbol": "ForeignObject.foreign_related_fields"
  },
  "id": "86760b33-fbae-4dbd-914c-b1f7c9d838e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3319620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 818,
        "selector": "L818-L822",
        "symbol": "ForeignObject.foreign_related_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "a47e3c68-ea3b-4821-b843-f043e827cb9b",
  "subject_name": "django/db/models/fields/related::ForeignObject.foreign_related_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def foreign_related_fields(self)"
}
```
