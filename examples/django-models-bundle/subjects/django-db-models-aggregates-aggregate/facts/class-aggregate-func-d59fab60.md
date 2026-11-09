# Fact d59fab60

Store id: ee1334e5-4667-449e-9f55-56ac8aa5b83d

## Text

```text
class Aggregate(Func)
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
- posted_at: `2026-11-09T23:44:48.3946740+00:00`

## Data

```json
{
  "end_line": 223,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 75,
  "symbol": "Aggregate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":75,"selector":"L75-L223","symbol":"Aggregate"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 223,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 75,
    "symbol": "Aggregate"
  },
  "id": "ee1334e5-4667-449e-9f55-56ac8aa5b83d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3946740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 75,
        "selector": "L75-L223",
        "symbol": "Aggregate"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "db2f9529-8cb4-4fb7-9a86-4f8a6fc61c3b",
  "subject_name": "django/db/models/aggregates::Aggregate",
  "tags": [
    "entity:class"
  ],
  "text": "class Aggregate(Func)"
}
```
