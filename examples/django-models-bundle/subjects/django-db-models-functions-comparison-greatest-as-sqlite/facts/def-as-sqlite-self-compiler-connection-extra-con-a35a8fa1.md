# Fact a35a8fa1

Store id: 1d5718d0-94b6-407b-960b-e75b2e246e91

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
- posted_at: `2026-11-09T23:32:00.9986300+00:00`

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
  "id": "1d5718d0-94b6-407b-960b-e75b2e246e91",
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
    "posted_at": "2026-11-09T23:32:00.9986300+00:00"
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
  "subject_id": "e3e216fd-a550-47c7-b3a9-a1dc66a39553",
  "subject_name": "django/db/models/functions/comparison::Greatest.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
