# Fact ed9af643

Store id: e31cbbdb-9a48-49db-8629-93f32f16ce8a

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
- posted_at: `2026-11-09T23:32:01.1752580+00:00`

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
  "id": "e31cbbdb-9a48-49db-8629-93f32f16ce8a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.1752580+00:00"
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
  "subject_id": "1be3981e-f8cd-49a1-9e57-41e0944dc345",
  "subject_name": "django/db/models/functions/datetime::Extract.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
