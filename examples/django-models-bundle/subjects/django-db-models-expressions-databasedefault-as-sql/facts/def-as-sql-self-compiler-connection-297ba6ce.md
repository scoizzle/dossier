# Fact 297ba6ce

Store id: ce00718c-a07a-4912-9e6c-f75a9c43ae4d

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
- posted_at: `2026-11-09T22:39:41.6245490+00:00`

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
  "id": "ce00718c-a07a-4912-9e6c-f75a9c43ae4d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6245490+00:00"
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
  "subject_id": "81ec51e7-c1de-41eb-bb40-66f30c909ac8",
  "subject_name": "django/db/models/expressions::DatabaseDefault.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
