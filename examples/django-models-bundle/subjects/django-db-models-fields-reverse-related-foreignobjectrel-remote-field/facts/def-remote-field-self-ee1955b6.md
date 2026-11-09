# Fact ee1955b6

Store id: 55760f42-3f8d-4d4a-ae3a-d02bebd447d6

## Text

```text
def remote_field(self)
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
- posted_at: `2026-11-09T23:32:00.2243470+00:00`

## Data

```json
{
  "end_line": 75,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 73,
  "symbol": "ForeignObjectRel.remote_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":73,"selector":"L73-L75","symbol":"ForeignObjectRel.remote_field"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.remote_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 75,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 73,
    "symbol": "ForeignObjectRel.remote_field"
  },
  "id": "55760f42-3f8d-4d4a-ae3a-d02bebd447d6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2243470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 73,
        "selector": "L73-L75",
        "symbol": "ForeignObjectRel.remote_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "68f4c990-d630-4536-8bb4-74b09bed8aae",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.remote_field",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def remote_field(self)"
}
```
