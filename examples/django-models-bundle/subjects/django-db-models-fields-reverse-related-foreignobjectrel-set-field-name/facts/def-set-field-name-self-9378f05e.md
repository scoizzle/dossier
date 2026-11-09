# Fact 9378f05e

Store id: ec20dba3-2379-4fc3-8ee0-f4fc36389dca

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
- posted_at: `2026-11-09T23:32:00.2999200+00:00`

## Data

```json
{
  "end_line": 208,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 200,
  "symbol": "ForeignObjectRel.set_field_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":200,"selector":"L200-L208","symbol":"ForeignObjectRel.set_field_name"}`

## Items

```json
[
  {
    "text": "Set the related field's name, this is not available until later stages of app loading, so set_field_name is called from set_attributes_from_rel()",
    "locator": {
      "line": 201
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.set_field_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 208,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 200,
    "symbol": "ForeignObjectRel.set_field_name"
  },
  "id": "ec20dba3-2379-4fc3-8ee0-f4fc36389dca",
  "items": [
    {
      "locator": {
        "line": 201
      },
      "text": "Set the related field's name, this is not available until later stages of app loading, so set_field_name is called from set_attributes_from_rel()"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2999200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 200,
        "selector": "L200-L208",
        "symbol": "ForeignObjectRel.set_field_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "2cc8264f-2329-480b-a9e9-7613c2d49c11",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.set_field_name",
  "tags": [
    "entity:method"
  ],
  "text": "def set_field_name(self)"
}
```
