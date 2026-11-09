# Fact 019836a6

Store id: 54ce1167-73fb-44d0-8a85-366212fca92e

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
- posted_at: `2026-11-09T23:44:53.3834210+00:00`

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
  "id": "54ce1167-73fb-44d0-8a85-366212fca92e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3834210+00:00"
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
  "subject_id": "4a0ad56b-acd5-4423-84ca-185f8edb7402",
  "subject_name": "django/db/models/functions/datetime::TruncBase.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
