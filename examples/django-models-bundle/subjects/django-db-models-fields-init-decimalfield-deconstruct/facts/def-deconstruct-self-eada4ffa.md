# Fact eada4ffa

Store id: b756c560-ef97-4d33-9faa-5d2ab4dc1d87

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
- posted_at: `2026-11-09T22:39:42.4576150+00:00`

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
  "id": "b756c560-ef97-4d33-9faa-5d2ab4dc1d87",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4576150+00:00"
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
  "subject_id": "5dd2848f-954c-4d58-82b1-6a24ef13ad5b",
  "subject_name": "django/db/models/fields/__init__::DecimalField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
