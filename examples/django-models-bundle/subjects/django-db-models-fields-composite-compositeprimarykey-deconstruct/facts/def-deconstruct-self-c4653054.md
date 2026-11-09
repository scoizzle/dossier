# Fact c4653054

Store id: 4896092a-f09d-4070-8595-3bc315886363

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
- posted_at: `2026-11-09T23:31:57.1221160+00:00`

## Data

```json
{
  "end_line": 81,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 78,
  "symbol": "CompositePrimaryKey.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":78,"selector":"L78-L81","symbol":"CompositePrimaryKey.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 81,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 78,
    "symbol": "CompositePrimaryKey.deconstruct"
  },
  "id": "4896092a-f09d-4070-8595-3bc315886363",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1221160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 78,
        "selector": "L78-L81",
        "symbol": "CompositePrimaryKey.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "501628f2-35db-4089-a070-80c611916097",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
