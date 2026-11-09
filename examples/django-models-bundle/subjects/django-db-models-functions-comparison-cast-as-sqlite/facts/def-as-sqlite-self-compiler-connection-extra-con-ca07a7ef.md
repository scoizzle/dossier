# Fact ca07a7ef

Store id: 9c9bd31e-e0e5-46ed-9e46-d072af827da1

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
- posted_at: `2026-11-09T22:39:45.9027200+00:00`

## Data

```json
{
  "end_line": 36,
  "entity_kind": "method",
  "parent": "Cast",
  "start_line": 20,
  "symbol": "Cast.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":20,"selector":"L20-L36","symbol":"Cast.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Cast.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 36,
    "entity_kind": "method",
    "parent": "Cast",
    "start_line": 20,
    "symbol": "Cast.as_sqlite"
  },
  "id": "9c9bd31e-e0e5-46ed-9e46-d072af827da1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.9027200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 20,
        "selector": "L20-L36",
        "symbol": "Cast.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "8e94e262-890d-4b7d-ad9f-c256ce2aa9fc",
  "subject_name": "django/db/models/functions/comparison::Cast.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
