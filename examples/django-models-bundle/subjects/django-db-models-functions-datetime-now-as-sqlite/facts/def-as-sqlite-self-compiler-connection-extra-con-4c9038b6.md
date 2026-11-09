# Fact 4c9038b6

Store id: 3711ea91-6f68-45e4-b409-da80984a2859

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
- posted_at: `2026-11-09T22:39:46.1677180+00:00`

## Data

```json
{
  "end_line": 236,
  "entity_kind": "method",
  "parent": "Now",
  "start_line": 230,
  "symbol": "Now.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":230,"selector":"L230-L236","symbol":"Now.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Now.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 236,
    "entity_kind": "method",
    "parent": "Now",
    "start_line": 230,
    "symbol": "Now.as_sqlite"
  },
  "id": "3711ea91-6f68-45e4-b409-da80984a2859",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1677180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 230,
        "selector": "L230-L236",
        "symbol": "Now.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "f21dd261-9810-41c7-974a-9ad10ae3498a",
  "subject_name": "django/db/models/functions/datetime::Now.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
