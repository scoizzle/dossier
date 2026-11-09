# Fact 27e607d1

Store id: a5c89b59-5ec5-4219-a378-1cf87cda2b6a

## Text

```text
def set_attributes_from_rel(self)
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
- posted_at: `2026-11-09T22:39:44.2780250+00:00`

## Data

```json
{
  "end_line": 475,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 467,
  "symbol": "RelatedField.set_attributes_from_rel"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":467,"selector":"L467-L475","symbol":"RelatedField.set_attributes_from_rel"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.set_attributes_from_rel](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 475,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 467,
    "symbol": "RelatedField.set_attributes_from_rel"
  },
  "id": "a5c89b59-5ec5-4219-a378-1cf87cda2b6a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2780250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 467,
        "selector": "L467-L475",
        "symbol": "RelatedField.set_attributes_from_rel"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "db5bbaf4-1526-4169-aa29-7600a8cb21f1",
  "subject_name": "django/db/models/fields/related::RelatedField.set_attributes_from_rel",
  "tags": [
    "entity:method"
  ],
  "text": "def set_attributes_from_rel(self)"
}
```
