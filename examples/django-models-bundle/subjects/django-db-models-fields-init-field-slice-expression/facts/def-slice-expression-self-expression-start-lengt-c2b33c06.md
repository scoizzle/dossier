# Fact c2b33c06

Store id: 7ae215e6-487d-4b56-9ac2-faeeb681ff46

## Text

```text
def slice_expression(self, expression, start, length)
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
- posted_at: `2026-11-09T22:39:42.3634610+00:00`

## Data

```json
{
  "end_line": 1197,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1195,
  "symbol": "Field.slice_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1195,"selector":"L1195-L1197","symbol":"Field.slice_expression"}`

## Items

```json
[
  {
    "text": "Return a slice of this field.",
    "locator": {
      "line": 1196
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.slice_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1197,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1195,
    "symbol": "Field.slice_expression"
  },
  "id": "7ae215e6-487d-4b56-9ac2-faeeb681ff46",
  "items": [
    {
      "locator": {
        "line": 1196
      },
      "text": "Return a slice of this field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3634610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1195,
        "selector": "L1195-L1197",
        "symbol": "Field.slice_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4f2e9493-5a38-422d-aaf1-fac83fc983b0",
  "subject_name": "django/db/models/fields/__init__::Field.slice_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def slice_expression(self, expression, start, length)"
}
```
