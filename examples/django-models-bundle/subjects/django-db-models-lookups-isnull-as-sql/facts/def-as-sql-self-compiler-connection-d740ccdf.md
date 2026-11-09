# Fact d740ccdf

Store id: 9b29d38a-096c-4861-9753-a3566c6ceb07

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
- posted_at: `2026-11-09T23:32:03.3932410+00:00`

## Data

```json
{
  "end_line": 688,
  "entity_kind": "method",
  "parent": "IsNull",
  "start_line": 670,
  "symbol": "IsNull.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":670,"selector":"L670-L688","symbol":"IsNull.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IsNull.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 688,
    "entity_kind": "method",
    "parent": "IsNull",
    "start_line": 670,
    "symbol": "IsNull.as_sql"
  },
  "id": "9b29d38a-096c-4861-9753-a3566c6ceb07",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3932410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 670,
        "selector": "L670-L688",
        "symbol": "IsNull.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "fb739f61-0329-4763-ab46-8b83e24f5028",
  "subject_name": "django/db/models/lookups::IsNull.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
