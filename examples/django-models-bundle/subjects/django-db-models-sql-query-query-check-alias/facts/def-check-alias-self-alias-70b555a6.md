# Fact 70b555a6

Store id: 66f46c53-bb3c-4a52-b28b-b842eb08269d

## Text

```text
def check_alias(self, alias)
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
- posted_at: `2026-11-09T22:39:51.3294750+00:00`

## Data

```json
{
  "end_line": 1237,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1221,
  "symbol": "Query.check_alias"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1221,"selector":"L1221-L1237","symbol":"Query.check_alias"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.check_alias](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1237,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1221,
    "symbol": "Query.check_alias"
  },
  "id": "66f46c53-bb3c-4a52-b28b-b842eb08269d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3294750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1221,
        "selector": "L1221-L1237",
        "symbol": "Query.check_alias"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "ed39a128-dd2b-4a1e-8035-a03c02fa1bd9",
  "subject_name": "django/db/models/sql/query::Query.check_alias",
  "tags": [
    "entity:method"
  ],
  "text": "def check_alias(self, alias)"
}
```
