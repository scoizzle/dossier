# Fact ff2e2c69

Store id: 78d958f1-95a6-4fd8-b94d-65512f743a2d

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
- posted_at: `2026-11-09T23:32:03.2176850+00:00`

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
  "id": "78d958f1-95a6-4fd8-b94d-65512f743a2d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.2176850+00:00"
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
  "subject_id": "208b8850-0eed-43de-9162-8b127c60eb96",
  "subject_name": "django/db/models/lookups::BuiltinLookup.get_rhs_op",
  "tags": [
    "entity:method"
  ],
  "text": "def get_rhs_op(self, connection, rhs)"
}
```
