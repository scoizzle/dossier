# Fact eada4ffa

Store id: cc1218e7-fa47-4d75-b1cd-7853692a6bf4

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:31:56.6333600+00:00`

## Data

```json
{
  "end_line": 1888,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1882,
  "symbol": "DecimalField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1882,"selector":"L1882-L1888","symbol":"DecimalField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1888,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1882,
    "symbol": "DecimalField.deconstruct"
  },
  "id": "cc1218e7-fa47-4d75-b1cd-7853692a6bf4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6333600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1882,
        "selector": "L1882-L1888",
        "symbol": "DecimalField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "c449debb-7967-423c-b37e-1b3bc14b17eb",
  "subject_name": "django/db/models/fields/__init__::DecimalField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
