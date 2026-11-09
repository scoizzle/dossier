# Fact 142151e1

Store id: ee1c6bda-9c1b-40e0-9b7e-43028f6c2a91

## Text

```text
def SET_NULL(collector, field, sub_objs, using)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.0660060+00:00`

## Data

```json
{
  "end_line": 70,
  "entity_kind": "function",
  "parent": "deletion",
  "start_line": 69,
  "symbol": "SET_NULL"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":69,"selector":"L69-L70","symbol":"SET_NULL"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::SET_NULL](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 70,
    "entity_kind": "function",
    "parent": "deletion",
    "start_line": 69,
    "symbol": "SET_NULL"
  },
  "id": "ee1c6bda-9c1b-40e0-9b7e-43028f6c2a91",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0660060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 69,
        "selector": "L69-L70",
        "symbol": "SET_NULL"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "b9d74dea-5af7-488f-a989-62154420a23a",
  "subject_name": "django/db/models/deletion::SET_NULL",
  "tags": [
    "entity:function"
  ],
  "text": "def SET_NULL(collector, field, sub_objs, using)"
}
```
