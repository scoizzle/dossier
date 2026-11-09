# Fact ca07a7ef

Store id: b5cff444-8c1c-475f-93aa-b13a260c8c93

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
- posted_at: `2026-11-09T23:44:53.1180290+00:00`

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
  "id": "b5cff444-8c1c-475f-93aa-b13a260c8c93",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.1180290+00:00"
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
  "subject_id": "b327617c-df59-43e9-b15d-6c076ddd022f",
  "subject_name": "django/db/models/functions/comparison::Cast.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
