# Fact ce0412a1

Store id: 43d88b1c-fa13-4db8-a816-20e5f693c604

## Text

```text
def as_postgresql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:53.1274600+00:00`

## Data

```json
{
  "end_line": 58,
  "entity_kind": "method",
  "parent": "Cast",
  "start_line": 49,
  "symbol": "Cast.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":49,"selector":"L49-L58","symbol":"Cast.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Cast.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 58,
    "entity_kind": "method",
    "parent": "Cast",
    "start_line": 49,
    "symbol": "Cast.as_postgresql"
  },
  "id": "43d88b1c-fa13-4db8-a816-20e5f693c604",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.1274600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 49,
        "selector": "L49-L58",
        "symbol": "Cast.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "0340c311-9fc9-443d-9857-f1f18d54cbbb",
  "subject_name": "django/db/models/functions/comparison::Cast.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
