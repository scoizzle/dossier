# Fact c7d64511

Store id: 5200e29a-0a4b-4203-9bbd-4563b5afde1e

## Text

```text
def _subquery_fields_len(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.3356160+00:00`

## Data

```json
{
  "end_line": 1257,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1251,
  "symbol": "Query._subquery_fields_len"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1251,"selector":"L1251-L1257","symbol":"Query._subquery_fields_len"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query._subquery_fields_len](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1257,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1251,
    "symbol": "Query._subquery_fields_len"
  },
  "id": "5200e29a-0a4b-4203-9bbd-4563b5afde1e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3356160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1251,
        "selector": "L1251-L1257",
        "symbol": "Query._subquery_fields_len"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c6a348eb-5828-47aa-bf60-eee656ac41b3",
  "subject_name": "django/db/models/sql/query::Query._subquery_fields_len",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def _subquery_fields_len(self)"
}
```
