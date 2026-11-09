# Fact 00d2496a

Store id: 36549aef-dc77-4f72-acb3-f5f5bf75976a

## Text

```text
def closed(self)
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
- posted_at: `2026-11-09T23:44:50.6361400+00:00`

## Data

```json
{
  "end_line": 134,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 131,
  "symbol": "FieldFile.closed"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":131,"selector":"L131-L134","symbol":"FieldFile.closed"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.closed](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 134,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 131,
    "symbol": "FieldFile.closed"
  },
  "id": "36549aef-dc77-4f72-acb3-f5f5bf75976a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6361400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 131,
        "selector": "L131-L134",
        "symbol": "FieldFile.closed"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "bc8cd512-c64b-491d-a9b5-b02fb9bcaf4d",
  "subject_name": "django/db/models/fields/files::FieldFile.closed",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def closed(self)"
}
```
