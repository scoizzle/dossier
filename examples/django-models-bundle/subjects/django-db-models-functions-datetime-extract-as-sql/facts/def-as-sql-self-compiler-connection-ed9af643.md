# Fact ed9af643

Store id: 6d8ad75d-3475-4959-a739-ad8bc012a0a6

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:46.1094540+00:00`

## Data

```json
{
  "end_line": 81,
  "entity_kind": "method",
  "parent": "Extract",
  "start_line": 51,
  "symbol": "Extract.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":51,"selector":"L51-L81","symbol":"Extract.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Extract.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 81,
    "entity_kind": "method",
    "parent": "Extract",
    "start_line": 51,
    "symbol": "Extract.as_sql"
  },
  "id": "6d8ad75d-3475-4959-a739-ad8bc012a0a6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1094540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 51,
        "selector": "L51-L81",
        "symbol": "Extract.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "44f94dc3-b0e9-4c94-9f68-3f249100d241",
  "subject_name": "django/db/models/functions/datetime::Extract.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
