# Fact 1e4bceb5

Store id: 95913105-647f-4653-86e4-6aab2c680632

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
- posted_at: `2026-11-09T23:44:51.4623650+00:00`

## Data

```json
{
  "end_line": 123,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 119,
  "symbol": "RelatedField.related_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":119,"selector":"L119-L123","symbol":"RelatedField.related_model"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.related_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 123,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 119,
    "symbol": "RelatedField.related_model"
  },
  "id": "95913105-647f-4653-86e4-6aab2c680632",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.4623650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 119,
        "selector": "L119-L123",
        "symbol": "RelatedField.related_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "dbf96c34-992a-4e64-90e8-9ca851c120b3",
  "subject_name": "django/db/models/fields/related::RelatedField.related_model",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def related_model(self)"
}
```
