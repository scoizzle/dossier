# Fact 17639bd1

Store id: f32d3412-154a-42ee-aeb4-3674f3af33a4

## Text

```text
def as_sqlite(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:45.9555610+00:00`

## Data

```json
{
  "end_line": 162,
  "entity_kind": "method",
  "parent": "Least",
  "start_line": 160,
  "symbol": "Least.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":160,"selector":"L160-L162","symbol":"Least.as_sqlite"}`

## Items

```json
[
  {
    "text": "Use the MIN function on SQLite.",
    "locator": {
      "line": 161
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Least.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 162,
    "entity_kind": "method",
    "parent": "Least",
    "start_line": 160,
    "symbol": "Least.as_sqlite"
  },
  "id": "f32d3412-154a-42ee-aeb4-3674f3af33a4",
  "items": [
    {
      "locator": {
        "line": 161
      },
      "text": "Use the MIN function on SQLite."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.9555610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 160,
        "selector": "L160-L162",
        "symbol": "Least.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "fcb35616-ad83-4e4e-9a63-e6cfe5f0610f",
  "subject_name": "django/db/models/functions/comparison::Least.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
