# Fact 8d9095c3

Store id: 5acc3c48-629a-4996-bea0-3b518749e746

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
- posted_at: `2026-11-09T22:39:44.3443740+00:00`

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
  "id": "5acc3c48-629a-4996-bea0-3b518749e746",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3443740+00:00"
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
  "subject_id": "6bba0bc2-6767-4c41-8e2c-eb042b2f6505",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_reverse_joining_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_reverse_joining_fields(self)"
}
```
