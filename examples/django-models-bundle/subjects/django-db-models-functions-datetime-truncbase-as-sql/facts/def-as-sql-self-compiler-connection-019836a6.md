# Fact 019836a6

Store id: 3930d1e2-f681-4c1d-a8e5-68d72828d765

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
- posted_at: `2026-11-09T22:39:46.1777180+00:00`

## Data

```json
{
  "end_line": 281,
  "entity_kind": "method",
  "parent": "TruncBase",
  "start_line": 258,
  "symbol": "TruncBase.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":258,"selector":"L258-L281","symbol":"TruncBase.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncBase.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 281,
    "entity_kind": "method",
    "parent": "TruncBase",
    "start_line": 258,
    "symbol": "TruncBase.as_sql"
  },
  "id": "3930d1e2-f681-4c1d-a8e5-68d72828d765",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1777180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 258,
        "selector": "L258-L281",
        "symbol": "TruncBase.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "e69cdb02-df95-4806-856d-f702a0fdfc1b",
  "subject_name": "django/db/models/functions/datetime::TruncBase.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
