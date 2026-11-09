# Fact 971f51a4

Store id: 46434a57-0700-4714-b571-ed8dad8c743d

## Text

```text
def build_where(self, filter_expr)
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
- posted_at: `2026-11-09T22:39:51.3812490+00:00`

## Data

```json
{
  "end_line": 1686,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1685,
  "symbol": "Query.build_where"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1685,"selector":"L1685-L1686","symbol":"Query.build_where"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.build_where](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1686,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1685,
    "symbol": "Query.build_where"
  },
  "id": "46434a57-0700-4714-b571-ed8dad8c743d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3812490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1685,
        "selector": "L1685-L1686",
        "symbol": "Query.build_where"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "0b813a5a-8e57-4fe8-a92d-028bb1861f83",
  "subject_name": "django/db/models/sql/query::Query.build_where",
  "tags": [
    "entity:method"
  ],
  "text": "def build_where(self, filter_expr)"
}
```
