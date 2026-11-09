# Fact 907a4c2a

Store id: 602f9765-d7ee-4a8a-8e59-12fe9349a6cc

## Text

```text
def get_joining_fields(self)
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
- posted_at: `2026-11-09T23:32:00.2927510+00:00`

## Data

```json
{
  "end_line": 195,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 194,
  "symbol": "ForeignObjectRel.get_joining_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":194,"selector":"L194-L195","symbol":"ForeignObjectRel.get_joining_fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.get_joining_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 195,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 194,
    "symbol": "ForeignObjectRel.get_joining_fields"
  },
  "id": "602f9765-d7ee-4a8a-8e59-12fe9349a6cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2927510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 194,
        "selector": "L194-L195",
        "symbol": "ForeignObjectRel.get_joining_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "9dd12518-4c67-4252-b23a-75f9f4e55bdf",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.get_joining_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_joining_fields(self)"
}
```
