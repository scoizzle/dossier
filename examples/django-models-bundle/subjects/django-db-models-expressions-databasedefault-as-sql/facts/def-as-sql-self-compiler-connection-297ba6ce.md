# Fact 297ba6ce

Store id: a58feb5e-1f50-43cf-bbb9-15396768af60

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
- posted_at: `2026-11-09T23:31:55.8855440+00:00`

## Data

```json
{
  "end_line": 1348,
  "entity_kind": "method",
  "parent": "DatabaseDefault",
  "start_line": 1345,
  "symbol": "DatabaseDefault.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1345,"selector":"L1345-L1348","symbol":"DatabaseDefault.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DatabaseDefault.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1348,
    "entity_kind": "method",
    "parent": "DatabaseDefault",
    "start_line": 1345,
    "symbol": "DatabaseDefault.as_sql"
  },
  "id": "a58feb5e-1f50-43cf-bbb9-15396768af60",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8855440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1345,
        "selector": "L1345-L1348",
        "symbol": "DatabaseDefault.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3c9b53bd-19a6-4b4e-a5d0-7a743464e58f",
  "subject_name": "django/db/models/expressions::DatabaseDefault.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
