# Fact d39bcd41

Store id: 82db8009-2f1c-4d4b-9fd6-ed51822cc3f3

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
- posted_at: `2026-11-09T23:44:50.7977900+00:00`

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
  "id": "82db8009-2f1c-4d4b-9fd6-ed51822cc3f3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.7977900+00:00"
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
  "subject_id": "4ee4a5f1-24cf-463f-8a47-009ed7e724bc",
  "subject_name": "django/db/models/fields/generated::GeneratedField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *, expression, output_field, db_persist, **kwargs)"
}
```
