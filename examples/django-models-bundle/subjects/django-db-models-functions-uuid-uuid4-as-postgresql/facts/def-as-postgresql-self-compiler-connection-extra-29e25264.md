# Fact 29e25264

Store id: 744860f3-7eff-4bf0-9e69-8cfd9ca77da5

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
- posted_at: `2026-11-09T22:39:47.3678190+00:00`

## Data

```json
{
  "end_line": 21,
  "entity_kind": "method",
  "parent": "UUID4",
  "start_line": 16,
  "symbol": "UUID4.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/uuid.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":16,"selector":"L16-L21","symbol":"UUID4.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/uuid::UUID4.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 21,
    "entity_kind": "method",
    "parent": "UUID4",
    "start_line": 16,
    "symbol": "UUID4.as_postgresql"
  },
  "id": "744860f3-7eff-4bf0-9e69-8cfd9ca77da5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.3678190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 16,
        "selector": "L16-L21",
        "symbol": "UUID4.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/uuid.py"
    }
  ],
  "status": "live",
  "subject_id": "221006d0-173b-40e5-827a-e7c591ff5319",
  "subject_name": "django/db/models/functions/uuid::UUID4.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
