# Fact 2c40c71b

Store id: 927088d8-d021-40ae-92ea-e5f7b1bc6770

## Text

```text
class ContainedBy(FieldGetDbPrepValueMixin, PostgresOperatorLookup)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:57.8725260+00:00`

## Data

```json
{
  "end_line": 180,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 168,
  "symbol": "ContainedBy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":168,"selector":"L168-L180","symbol":"ContainedBy"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::ContainedBy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 180,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 168,
    "symbol": "ContainedBy"
  },
  "id": "927088d8-d021-40ae-92ea-e5f7b1bc6770",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8725260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 168,
        "selector": "L168-L180",
        "symbol": "ContainedBy"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "e75df377-f49b-4e18-8836-ac52772cc165",
  "subject_name": "django/db/models/fields/json::ContainedBy",
  "tags": [
    "entity:class"
  ],
  "text": "class ContainedBy(FieldGetDbPrepValueMixin, PostgresOperatorLookup)"
}
```
