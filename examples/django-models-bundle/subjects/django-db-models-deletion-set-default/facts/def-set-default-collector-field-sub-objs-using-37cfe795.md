# Fact 37cfe795

Store id: 22c3006b-e0d1-4171-a4ab-d3a277f349ed

## Text

```text
def SET_DEFAULT(collector, field, sub_objs, using)
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
- posted_at: `2026-11-09T23:44:48.9026230+00:00`

## Data

```json
{
  "end_line": 77,
  "entity_kind": "function",
  "parent": "deletion",
  "start_line": 76,
  "symbol": "SET_DEFAULT"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":76,"selector":"L76-L77","symbol":"SET_DEFAULT"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::SET_DEFAULT](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 77,
    "entity_kind": "function",
    "parent": "deletion",
    "start_line": 76,
    "symbol": "SET_DEFAULT"
  },
  "id": "22c3006b-e0d1-4171-a4ab-d3a277f349ed",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9026230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 76,
        "selector": "L76-L77",
        "symbol": "SET_DEFAULT"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "f318a3d2-c0d4-497e-93e6-411396a293b8",
  "subject_name": "django/db/models/deletion::SET_DEFAULT",
  "tags": [
    "entity:function"
  ],
  "text": "def SET_DEFAULT(collector, field, sub_objs, using)"
}
```
