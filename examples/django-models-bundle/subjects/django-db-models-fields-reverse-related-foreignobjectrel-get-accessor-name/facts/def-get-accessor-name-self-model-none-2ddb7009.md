# Fact 2ddb7009

Store id: 9f1bd8fa-2829-4ef0-ba46-916b205deb74

## Text

```text
def get_accessor_name(self, model=None)
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
- posted_at: `2026-11-09T22:39:45.3570710+00:00`

## Data

```json
{
  "end_line": 230,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 214,
  "symbol": "ForeignObjectRel.get_accessor_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":214,"selector":"L214-L230","symbol":"ForeignObjectRel.get_accessor_name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.get_accessor_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 230,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 214,
    "symbol": "ForeignObjectRel.get_accessor_name"
  },
  "id": "9f1bd8fa-2829-4ef0-ba46-916b205deb74",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3570710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 214,
        "selector": "L214-L230",
        "symbol": "ForeignObjectRel.get_accessor_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "6c0f1fab-dc9b-4a4d-90ff-5d1b84cc6659",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.get_accessor_name",
  "tags": [
    "entity:method"
  ],
  "text": "def get_accessor_name(self, model=None)"
}
```
