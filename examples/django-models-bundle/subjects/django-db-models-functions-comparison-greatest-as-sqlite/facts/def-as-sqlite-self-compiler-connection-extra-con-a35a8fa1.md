# Fact a35a8fa1

Store id: c8ba0428-f990-4350-bac5-d17a74ce8edb

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
- posted_at: `2026-11-09T22:39:45.9468910+00:00`

## Data

```json
{
  "end_line": 141,
  "entity_kind": "method",
  "parent": "Greatest",
  "start_line": 139,
  "symbol": "Greatest.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":139,"selector":"L139-L141","symbol":"Greatest.as_sqlite"}`

## Items

```json
[
  {
    "text": "Use the MAX function on SQLite.",
    "locator": {
      "line": 140
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Greatest.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 141,
    "entity_kind": "method",
    "parent": "Greatest",
    "start_line": 139,
    "symbol": "Greatest.as_sqlite"
  },
  "id": "c8ba0428-f990-4350-bac5-d17a74ce8edb",
  "items": [
    {
      "locator": {
        "line": 140
      },
      "text": "Use the MAX function on SQLite."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.9468910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 139,
        "selector": "L139-L141",
        "symbol": "Greatest.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "e4ce5d19-3f9f-42fa-99c6-044e31fccc9a",
  "subject_name": "django/db/models/functions/comparison::Greatest.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
