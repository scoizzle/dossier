# Fact 019836a6

Store id: 1e9b291a-06d2-4fec-b260-5f56769ec514

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
- posted_at: `2026-11-09T23:32:01.2577100+00:00`

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
  "id": "1e9b291a-06d2-4fec-b260-5f56769ec514",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2577100+00:00"
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
  "subject_id": "79b69ccc-77c9-4780-be13-59302319ce25",
  "subject_name": "django/db/models/functions/datetime::TruncBase.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
