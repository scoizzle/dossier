# Fact 8335659d

Store id: fcba919b-2d29-40c9-95da-c816446b9fea

## Text

```text
def resolve_expression(self, query, *args, **kwargs)
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
- posted_at: `2026-11-09T23:44:58.7914550+00:00`

## Data

```json
{
  "end_line": 1287,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1259,
  "symbol": "Query.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1259,"selector":"L1259-L1287","symbol":"Query.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1287,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1259,
    "symbol": "Query.resolve_expression"
  },
  "id": "fcba919b-2d29-40c9-95da-c816446b9fea",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.7914550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1259,
        "selector": "L1259-L1287",
        "symbol": "Query.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "52bdc6c4-9a57-4259-a646-280ccbf75a55",
  "subject_name": "django/db/models/sql/query::Query.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, query, *args, **kwargs)"
}
```
