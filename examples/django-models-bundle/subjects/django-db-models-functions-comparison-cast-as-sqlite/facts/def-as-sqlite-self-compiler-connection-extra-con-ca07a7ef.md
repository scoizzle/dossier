# Fact ca07a7ef

Store id: 3ceb29fb-2fb8-43ad-b3ad-4b838476a347

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
- posted_at: `2026-11-09T23:32:00.9547210+00:00`

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
  "id": "3ceb29fb-2fb8-43ad-b3ad-4b838476a347",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.9547210+00:00"
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
  "subject_id": "82465024-dc7f-4c63-8981-5d26d7a42916",
  "subject_name": "django/db/models/functions/comparison::Cast.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
