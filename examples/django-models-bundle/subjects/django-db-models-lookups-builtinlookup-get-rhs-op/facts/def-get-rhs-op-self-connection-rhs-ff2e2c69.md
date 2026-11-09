# Fact ff2e2c69

Store id: 01f0659c-b563-42f2-8ac3-9736f35e36c3

## Text

```text
def get_rhs_op(self, connection, rhs)
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
- posted_at: `2026-11-09T22:39:48.0698250+00:00`

## Data

```json
{
  "end_line": 251,
  "entity_kind": "method",
  "parent": "BuiltinLookup",
  "start_line": 250,
  "symbol": "BuiltinLookup.get_rhs_op"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":250,"selector":"L250-L251","symbol":"BuiltinLookup.get_rhs_op"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::BuiltinLookup.get_rhs_op](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 251,
    "entity_kind": "method",
    "parent": "BuiltinLookup",
    "start_line": 250,
    "symbol": "BuiltinLookup.get_rhs_op"
  },
  "id": "01f0659c-b563-42f2-8ac3-9736f35e36c3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0698250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 250,
        "selector": "L250-L251",
        "symbol": "BuiltinLookup.get_rhs_op"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "f03d5bae-5ee9-4910-81ec-0b78a262fd72",
  "subject_name": "django/db/models/lookups::BuiltinLookup.get_rhs_op",
  "tags": [
    "entity:method"
  ],
  "text": "def get_rhs_op(self, connection, rhs)"
}
```
