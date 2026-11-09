# Fact d39bcd41

Store id: 78fc5121-b308-4750-9af7-40dc798b7b98

## Text

```text
def __init__(self, *, expression, output_field, db_persist, **kwargs)
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
- posted_at: `2026-11-09T22:39:43.4252220+00:00`

## Data

```json
{
  "end_line": 33,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 18,
  "symbol": "GeneratedField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":18,"selector":"L18-L33","symbol":"GeneratedField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 33,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 18,
    "symbol": "GeneratedField.__init__"
  },
  "id": "78fc5121-b308-4750-9af7-40dc798b7b98",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.4252220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 18,
        "selector": "L18-L33",
        "symbol": "GeneratedField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "64ea503f-ed0a-43aa-bc91-f311f961e140",
  "subject_name": "django/db/models/fields/generated::GeneratedField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *, expression, output_field, db_persist, **kwargs)"
}
```
