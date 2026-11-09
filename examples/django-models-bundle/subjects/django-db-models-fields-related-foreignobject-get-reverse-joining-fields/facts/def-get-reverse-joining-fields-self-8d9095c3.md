# Fact 8d9095c3

Store id: b696b0d9-9b6f-4b84-b977-22753881014d

## Text

```text
def get_reverse_joining_fields(self)
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
- posted_at: `2026-11-09T23:31:58.7067740+00:00`

## Data

```json
{
  "end_line": 860,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 859,
  "symbol": "ForeignObject.get_reverse_joining_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":859,"selector":"L859-L860","symbol":"ForeignObject.get_reverse_joining_fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_reverse_joining_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 860,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 859,
    "symbol": "ForeignObject.get_reverse_joining_fields"
  },
  "id": "b696b0d9-9b6f-4b84-b977-22753881014d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7067740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 859,
        "selector": "L859-L860",
        "symbol": "ForeignObject.get_reverse_joining_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "bc3df6a0-69c0-427a-a495-20114f742bb9",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_reverse_joining_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_reverse_joining_fields(self)"
}
```
