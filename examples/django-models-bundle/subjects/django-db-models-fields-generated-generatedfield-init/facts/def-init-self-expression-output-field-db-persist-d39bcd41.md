# Fact d39bcd41

Store id: aca9c42e-60df-4d23-aaf0-3276fafd059b

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
- posted_at: `2026-11-09T23:31:57.6153860+00:00`

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
  "id": "aca9c42e-60df-4d23-aaf0-3276fafd059b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.6153860+00:00"
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
  "subject_id": "f727098d-01d7-4e49-9310-b1bf40d79569",
  "subject_name": "django/db/models/fields/generated::GeneratedField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *, expression, output_field, db_persist, **kwargs)"
}
```
